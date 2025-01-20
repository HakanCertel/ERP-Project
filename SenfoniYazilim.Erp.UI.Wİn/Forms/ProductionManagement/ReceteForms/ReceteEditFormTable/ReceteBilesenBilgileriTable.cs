using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting.Native;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.Bll.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.ReceteEditFormTable
{
    public partial class ReceteBilesenBilgileriTable : BaseTablo
    {
        private IEnumerable<ReceteOperasyonBilgileriL> _operasyonBilgileri;
        private BindingList<ReceteBilgileriL> _list;
        private List<Birim> _units;

        public ReceteBilesenBilgileriTable()
        {
            InitializeComponent();

            Bll = new ReceteBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            
            ShowItems = new BarItem[] { btnKartDuzenle };

            repositoryItemCombo.Items.AddRange(Enum.GetValues(typeof(Uretilebilir)).Cast<Uretilebilir>().Where(x => x != Uretilebilir.AnaKod).Select(x => x).ToList());

        }
        protected internal override void Yukle()
        {
            base.Yukle();
            _operasyonBilgileri= ((ReceteEditForm)OwnerForm).receteOperasyonBilgiTable.Tablo.DataController.ListSource.Cast<ReceteOperasyonBilgileriL>();
            repositoryItemLookUpOperasyon.DataSource =  _operasyonBilgileri;
            repositoryItemLookUpOperasyon.ValueMember = "OperasyonId";
            repositoryItemLookUpOperasyon.DisplayMember = "OperasyonAdi";
            repositoryItemLookUpBirim.DataSource = GetAnySingleOrListBll.ListUnitItems();
            repositoryItemLookUpBirim.ValueMember = "Id";
            repositoryItemLookUpBirim.DisplayMember = "BirimAdi";
        }

        protected internal override void Listele()
        {
            //BindingList<ReceteBilgileriL> list;
            //if (false/*((ReceteEditForm)OwnerForm)._durumKontrol*/) 
            //    _list= ReceteBilgisiOlustur().Where(x => x.Uretilebilir != Uretilebilir.AnaKod).ToList().toBindingList<ReceteBilgileriL>();
            //else
                _list= ((ReceteBilgileriBll)Bll).List(x => x.ReceteId == OwnerForm.Id && ((ReceteEditForm)OwnerForm).txtMalzemeKod.Id != x.StokId).toBindingList<ReceteBilgileriL>();
            Tablo.GridControl.DataSource = _list; //((ReceteBilgileriBll)Bll).List(x => x.ReceteId == OwnerForm.Id && ((ReceteEditForm)OwnerForm).txtKod.Id!=x.StokId).toBindingList<ReceteBilgileriL>();           
        }

        protected override void HareketEkle()
        {
            if(((ReceteEditForm)OwnerForm).txtMalzemeKod.Text=="")
            {
                Messages.HataMesaji("Bileşen Biligis Girilebilmesi için Reçete Kodu tanımlanmış olmalı.");
                return;
            }
            var operasyonList = ((ReceteEditForm)OwnerForm).receteOperasyonBilgiTable
                .Tablo.DataController
                .ListSource.Cast<ReceteOperasyonBilgileriL>();
            var varsayilanOperasyon = operasyonList
                ?.Where(x => x.OperasyonSirasi == operasyonList?.Max(y => y.OperasyonSirasi))
                .FirstOrDefault();
            var source = tablo.DataController.ListSource;
            
            ListeDisiTutulacakKayitlar = source.Cast<ReceteBilgileriL>().Where(x => !x.Delete).Select(x => x.StokId).ToList();

            ListeDisiTutulacakKayitlar.Add(((ReceteEditForm)OwnerForm).txtMalzemeKod.Id.Value);
            
            var entities = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<MaterialL>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new ReceteBilgileriL
                {
                    ReceteId = OwnerForm.Id,
                    StokId = entity.Id,
                    StokBirim = entity.UnitCode,
                    StokKodu = entity.Kod,
                    StokAdi = entity.StockName,
                    TuketimBirimId=entity.UnitId,
                    TuketimBirimAdi =entity.UnitCode,
                    Miktar = 0,
                    TuketimDepoId=entity.DepoId,
                    TuketimDepoAdi=entity.DepoAdi,
                    Uretilebilir=entity.Uretilebilir?Uretilebilir.Uretim:Uretilebilir.Tuketim,
                    OperasyonId=varsayilanOperasyon.OperasyonId,
                    Insert = true
                };               

                source.Add(row);
            }
            
            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colStokKodu;

            ButtonEnabledDurum(true);
        }

        protected internal override bool HatalıGiriş()
        {
            if (tablo.DataController.ListSource.Count <= 0)
            {
                Messages.HataMesaji("Reçete'ye eklenmiş bir kayıt olmadığı için Kayıt işlemi gerçekleştirilemez.");
            }
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors)
                tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<ReceteBilgileriL>(i);

                if (entitiy.Uretilebilir == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colUretilebilir;
                    tablo.SetColumnError(colUretilebilir, "Durum Alanına Geçerli Bir Değer Giriniz .");
                }
                else if (entitiy.Miktar == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colMiktar;
                    tablo.SetColumnError(colMiktar, "Miktar Alanına Geçerli Bir Değer Giriniz .");
                }
                else if (entitiy.TuketimDepoId <= 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colTuketimDepoAdi;
                    tablo.SetColumnError(colTuketimDepoAdi, "Depo Alanına Geçerli Bir Değer Giriniz .");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected override void OpenEntity()
        {
            var entity = tablo.GetRow<ReceteBilgileriL>();
            if (entity == null) return;

            ShowEditForms<StokEditForm>.ShowDialogForm(KartTuru.Stok, entity.StokId, null);
        }

        protected internal override bool TopluHareketSil()
        {
            var source = tablo.DataController.ListSource.Cast<ReceteBilgileriL>();

            if (source == null) return true;

            source.ForEach(x =>
            {
                if(!x.Insert)
                    x.Delete = true;
                if (x.Insert) x.Insert = false;
            });

            return Kaydet();
        }
        
        //protected internal bool TopluHareketSil()
        //{
        //    //if (Messages.SilMesaj("Recete Kartı") != System.Windows.Forms.DialogResult.Yes) return false;

        //    if (((ReceteEditForm)OwnerForm).BaseIslemTuru != IslemTuru.EntityInsert)
        //    {
        //        Tablo.GridControl.DataSource = ((ReceteBilgileriBll)Bll).List(x => x.ReceteId == OwnerForm.Id ).toBindingList<ReceteBilgileriL>();
        //        var source = tablo.DataController.ListSource.Cast<ReceteBilgileriL>();

        //        source.ForEach(x =>
        //        {
        //            if(!x.Insert)
        //                x.Delete = true;

        //            ButtonEnabledDurum(true);

        //        });

        //        tablo.RefreshDataSource();


        //        return Kaydet();
        //    }
        //    return false;
        //}

        protected override void LookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            var entity = Tablo.GetRow<ReceteBilgileriL>(false);
            if (((LookUpEdit)sender).Name == repositoryItemLookUpOperasyon.Name)
            {
                entity.OperasyonId= Convert.ToInt64(((LookUpEdit)sender).EditValue);
                entity.OperasyonBilgileriId = _operasyonBilgileri.Where(x => x.OperasyonId == entity.OperasyonId).FirstOrDefault().Id;
            }
            else if (((LookUpEdit)sender).Name == repositoryItemLookUpBirim.Name)
                entity.TuketimBirimId= Convert.ToInt32(((LookUpEdit)sender).EditValue);
            if (!entity.Insert)
                entity.Update=true;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            ButtonEnabledDurum(true);

        }
        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colTuketimDepoAdi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemTuketimDepo, colTuketimDepoId);
        }

        private List<ReceteBilgileriL> ReceteBilgisiOlustur()
        {
            List<ReceteBilgileriL> rblList = new List<ReceteBilgileriL>();

            if (((ReceteEditForm)OwnerForm)._mibListReceteBilesenleri == null) return null;

            foreach (var entity in ((ReceteEditForm)OwnerForm)._mibListReceteBilesenleri)
            {
                var row = new ReceteBilgileriL
                {
                    Id = entity.Id,
                    ReceteId = OwnerForm.Id,
                    StokId = entity.StokId,
                    StokBirim = entity.BirimAdi,
                    StokKodu = entity.StokKodu,
                    StokAdi = entity.StokAdi,
                    TuketimBirimAdi = entity.BirimAdi,
                    Miktar = entity.BirimIhtiyac,
                    TuketimDepoId = Convert.ToInt64(entity.DepoId),
                    TuketimDepoAdi = entity.DepoAdi,
                    Uretilebilir = entity.Uretim ? Uretilebilir.Uretim : Uretilebilir.Tuketim,
                };
                row.Uretilebilir = entity.Filter ? Uretilebilir.AnaKod : row.Uretilebilir;

                rblList.Add(row);
            }
            return rblList;
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!_isLoaded) return;
            var entity = Tablo.GetRow<ReceteBilgileriL>(false);
            if (entity == null) return;
            if (Tablo.FocusedColumn == colOperasyonId)
                entity.OperasyonBilgileriId = _operasyonBilgileri.Where(x => x.OperasyonId == (long)Tablo.FocusedValue).FirstOrDefault().Id;
            base.Tablo_CellValueChanged(sender, e);
        }
    }
}

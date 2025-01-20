using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting.Native;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.ReceteEditFormTable
{
    public partial class MReceteBilesenBilgileriTable : BaseTablo
    {
        protected internal IList<MalzemeIhtiyacBilgileriL> mibList;

        public MReceteBilesenBilgileriTable()
        {
            InitializeComponent();

            Bll = new ReceteBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new BarItem[] { btnKartDuzenle };
            repositoryItemCombo.Items.AddRange(Enum.GetValues(typeof(Uretilebilir)).Cast<Uretilebilir>().Where(x => x != Uretilebilir.AnaKod).Select(x => x).ToList());
            //repositoryItemDurum.Items.AddEnum<Uretilebilir>();
        }
        protected internal override void Listele()
        {
            var src=ReceteBilgisiOlustur();

            if (src != null)
                Tablo.GridControl.DataSource = src.Where(x => x.Uretilebilir != Uretilebilir.AnaKod).ToList();           
        }
        private List<ReceteBilgileriL> ReceteBilgisiOlustur()
        {
            List<ReceteBilgileriL> rblList=new List<ReceteBilgileriL>();

            if (mibList == null) return null;
            
            foreach (var entity in mibList)
            {
                var row = new ReceteBilgileriL
                {
                    Id=entity.Id,
                    ReceteId = OwnerForm.Id,
                    StokId = entity.StokId,
                    StokBirim = entity.BirimAdi,
                    StokKodu = entity.StokKodu,
                    StokAdi = entity.StokAdi,
                    TuketimBirimAdi = entity.BirimAdi,
                    Miktar = entity.BirimIhtiyac,
                    TuketimDepoId=Convert.ToInt64( entity.DepoId),
                    TuketimDepoAdi = entity.DepoAdi,
                    Uretilebilir = entity.Uretim ? Uretilebilir.Uretim : Uretilebilir.Tuketim,
                };
                row.Uretilebilir =entity.Filter ? Uretilebilir.AnaKod : row.Uretilebilir;

                rblList.Add(row);
            }
            return rblList;
        }
        protected override void HareketEkle()
        {
            if(((ReceteEditForm)OwnerForm).txtMalzemeKod.Text=="")
            {
                Messages.HataMesaji("Bileşen Biligis Girilebilmesi için Reçete Kodu tanımlanmış olmalı.");
                return;
            }
            var source = tablo.DataController.ListSource;

            ListeDisiTutulacakKayitlar = source.Cast<ReceteBilgileriL>().Where(x => !x.Delete).Select(x => x.StokId).ToList();

            ListeDisiTutulacakKayitlar.Add(((ReceteEditForm)OwnerForm).txtMalzemeKod.Id.Value);
            ListeDisiTutulacakKayitlar = null;//burada depolar arası transfer edit formda ihtiyaç duyulan,
            //durumu karşılama için liste dişi kayıtlar değil listelenecek kayıtlara ihtiyacımız olduğu için 
            //bu parametreyi şimdilik iptal etmiş oluduk.
            var entities = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, ListeDisiTutulacakKayitlar, true,false).EntityListConvert<MaterialL>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new ReceteBilgileriL
                {
                    Id=0,
                    ReceteId = OwnerForm.Id,
                    StokId = entity.Id,
                    StokBirim = entity.UnitCode,
                    StokKodu = entity.Kod,
                    StokAdi = entity.StockName,
                    TuketimBirimAdi = "",
                    Miktar = 0,
                    TuketimDepoAdi="",
                    Uretilebilir=Uretilebilir.Tuketim,
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
          /*  if (tablo.HasColumnErrors)*/ tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<ReceteBilgileriL>(i);

                if (entitiy.Uretilebilir == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colUretilebilir;
                    tablo.SetColumnError(colUretilebilir, "Durum Alanına Geçerli Bir Değer Giriniz .");
                }
                if (entitiy.Miktar == 0)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colMiktar;
                    tablo.SetColumnError(colMiktar, "Miktar Alanına Geçerli Bir Değer Giriniz .");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colTuketimDepoAdi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemTuketimDepo, colTuketimDepoId);
        }
    }
}

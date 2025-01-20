using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using System.Linq;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms;
using DevExpress.XtraPrinting.Native;
using System;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IstasyonForms;
using DevExpress.XtraGrid.Views.Base;
using System.Collections.Generic;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.ReceteEditFormTable
{
    public partial class ReceteOperasyonMakinaBilgileriTable : BaseTablo
    {
        private IEnumerable<ReceteOperasyonBilgileriL> _operasyonBilgileri;

        public ReceteOperasyonMakinaBilgileriTable()
        {
            InitializeComponent();
            Bll = new ReceteOperasyonMakinaBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new BarItem[] { btnKartDuzenle };
            panelButtons.Visible = true;
            //repositoryItemLookUpOperasyonMakine.DataSource=
            //((ReceteEditForm)OwnerForm).receteOperasyonBilgileriTable.Tablo.DataController.ListSource.Cast<ReceteOperasyonBilgileriL>().Select(x=>x.OperasyonAdi).ToList());
        }
        protected internal override void Yukle()
        {
            base.Yukle();
            _operasyonBilgileri = ((ReceteEditForm)OwnerForm).receteOperasyonBilgiTable.Tablo.DataController.ListSource.Cast<ReceteOperasyonBilgileriL>();
            repositoryItemLookUpOperasyonMakine.DataSource = _operasyonBilgileri;
            repositoryItemLookUpOperasyonMakine.ValueMember = "OperasyonId";
            repositoryItemLookUpOperasyonMakine.DisplayMember = "OperasyonAdi";
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((ReceteOperasyonMakinaBilgileriBll)Bll)
                .List(x => x.ReceteId == OwnerForm.Id).toBindingList< ReceteOperasyonMakinaBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = Tablo.DataController.ListSource;

            var entitiesIstasyon= ShowListForms<IstasyonListForm>.ShowDialogListForm(KartTuru.Istasyon, true).EntityListConvert<IstasyonL>();

            if (entitiesIstasyon == null) return;

            foreach (var entityIst in entitiesIstasyon)
            {
                var formCaption = entityIst.IstasyonAdi;

                var entitiesMakinaOperasyon = ShowListForms<IstasyonOperasyonBilgileriListForm>.ShowDialogListForm(KartTuru.Makina,  true, entityIst.Id,formCaption).EntityListConvert<IstasyonOperasyonBilgileriBaseEntityL>();

                if (entitiesMakinaOperasyon == null) continue;

                foreach (var entityMkOp in entitiesMakinaOperasyon)
                {
                    var row = new ReceteOperasyonMakinaBilgileriL
                    {
                        ReceteId = OwnerForm.Id,
                        IstasyonId = entityIst.Id,
                        IstasyonAdi=entityIst.IstasyonAdi,
                        OperasyonId = entityMkOp.OperasyonId,
                        OperasyonAdi = entityMkOp.OperasyonAdi,
                        MakinaId = entityMkOp.MakinaId,
                        MakinaKodu = entityMkOp.MakinaKodu,
                        MakinaAdi = entityMkOp.MakinaAdi,
                        Insert = true
                    };
                    source.Add(row);
                    if (source.Count == 0)
                        row.VarsayilanMakina = true;
                }
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colIstasyonAdi;

            ButtonEnabledDurum(true);
        }

        protected internal override bool TopluHareketSil()
        {
            var source = tablo.DataController.ListSource.Cast<ReceteOperasyonMakinaBilgileriL>();

            if (source == null) return true;

            source.ForEach(x =>
            {
                if (!x.Insert)
                    x.Delete = true;
                if (x.Insert) x.Insert = false;
            });

            return Kaydet();
        }

        protected internal override bool HatalıGiriş()
        {
            if (!TableValueChanged) return false;

            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<ReceteOperasyonMakinaBilgileriL>(i);

                if (!(entity.OperasyonSuresi > 0))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colOperasyonSuresi;
                    tablo.SetColumnError(colOperasyonSuresi, "Operasyon Süresinin Girilmesi Zorunludur .");
                }
                if (entity.MakinaKodu == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colMakinaAdi;
                    tablo.SetColumnError(colMakinaAdi, "Makina Adı Girilmesi Zorunludur");
                }
                
                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{ tablo.ViewCaption} Tablosu");
                return true;
            }
            var source = Tablo.DataController.ListSource.Cast<ReceteOperasyonMakinaBilgileriL>();
            if (!source.Any(x => x.VarsayilanMakina))
            {
                Messages.HataMesaji("En Az Bir Makinenin Varsayılan Olarak Seçilmesi Zorunludur");
                return true;
            }
            return false;
        }

        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var source = Tablo.DataController.ListSource.Cast<ReceteOperasyonMakinaBilgileriL>().ToList();
            var selectedRow = Tablo.GetRow<ReceteOperasyonMakinaBilgileriL>();
            if (selectedRow == null) return;
            if (!selectedRow.VarsayilanMakina)
            {
                var row = source.Where(x => x.VarsayilanMakina)?.FirstOrDefault();
                if (row != null)
                {
                    row.Update = row.Insert ? false : true;
                    row.VarsayilanMakina = false;
                }
            }
            if (!selectedRow.Insert)
                selectedRow.Update = true;
            ButtonEnabledDurum(true);
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        }

       
        ////protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        ////{
        ////    base.Tablo_FocusedColumnChanged(sender, e);
        ////    //var tabloReceteBilgileri = ((ReceteEditForm)OwnerForm).receteBilesenBilgileriTable.Tablo;
        ////    var rowHandle = tablo.FocusedRowHandle;
        ////    var entity = Tablo.GetRow<ReceteOperasyonMakinaBilgileriL>(false);

        ////    //if (e.FocusedColumn == colTuketimKalemiSec)
        ////    //    e.FocusedColumn.Sec(tabloReceteBilgileri, entity.Id, repositoryItemButtonTuketimKalemleri, tabloReceteBilgileri.Columns["OperasyonBilgileriId"]);
            
        //}
    }
}

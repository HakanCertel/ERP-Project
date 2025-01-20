using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.OperasyonForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraGrid.Views.Base;
using SenfoniYazilim.Erp.Common.Message;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ProductionManagement.ReceteForms.ReceteEditFormTable
{
    public partial class ReceteOperasyonBilgiTable :BaseTablo
    {
        public ReceteOperasyonBilgiTable()
        {
            InitializeComponent();
            Bll = new ReceteOperasyonBilgileriBll();
            Tablo = tablo;
            EventsLoad();

            panelButtons.Visible = true;
        }
        protected internal override void Yukle()
        {
            base.Yukle();

            if (((ReceteEditForm)OwnerForm).BaseIslemTuru != IslemTuru.EntityInsert) return;

            btnAsagiTasi.Enabled = false;
            btnYukariTasi.Enabled = false;
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((ReceteOperasyonBilgileriBll)Bll).List(x => x.ReceteId == OwnerForm.Id).toBindingList<ReceteOperasyonBilgileriL>();
        }

        protected override void HareketEkle()
        {
            if (((ReceteEditForm)OwnerForm).txtMalzemeKod == null)
            {
                Messages.BilgiMesaji("Lütfen Malzeme Seçiniz!");
                ((ReceteEditForm)OwnerForm).txtMalzemeKod.Focus();
                return;
            }
            var source = Tablo.DataController.ListSource;

            var entitiesOperasyon = ShowListForms<OperasyonListForm>.ShowDialogListForm(KartTuru.Operasyon, true).EntityListConvert<Operasyon>();
            if (entitiesOperasyon == null) return;

            foreach (var entityOp in entitiesOperasyon)
            {
                var row = new ReceteOperasyonBilgileriL
                {
                    ReceteId = OwnerForm.Id,
                    OperasyonId = entityOp.Id,
                    OperasyonKodu = entityOp.Kod,
                    OperasyonAdi = entityOp.OperasyonAdi,
                    OperasyonSirasi = source.Count + 1,
                    Insert = true,
                };
                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colOperasyonKodu;

            ButtonEnabledDurum(true);
        }

        protected internal override bool TopluHareketSil()
        {
            var source = tablo.DataController.ListSource.Cast<ReceteOperasyonBilgileriL>();

            if (source == null) return true;

            source.ForEach(x =>
            {
                if (!x.Insert)
                    x.Delete = true;
                if (x.Insert) x.Insert = false;
            });

            return Kaydet();
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colOperasyonKodu)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemOperasyon, colOperasyonId,colOperasyonAdi);

            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        }

        protected override void YukariTasi()
        {
            var rowHandle = Tablo.FocusedRowHandle;
            if (rowHandle == 0 || Tablo.DataRowCount == 0) return;

            var asagiTasinacakEntity = Tablo.GetRow<ReceteOperasyonBilgileriL>(rowHandle - 1);
            asagiTasinacakEntity.OperasyonSirasi = asagiTasinacakEntity.OperasyonSirasi + 1;
            if (!asagiTasinacakEntity.Insert)
                asagiTasinacakEntity.Update = true;

            var yukariTasinacakEntity = Tablo.GetRow<ReceteOperasyonBilgileriL>(rowHandle);
            yukariTasinacakEntity.OperasyonSirasi = yukariTasinacakEntity.OperasyonSirasi - 1;
            if (!yukariTasinacakEntity.Insert)
                yukariTasinacakEntity.Update = true;

            Kaydet();
            Listele();
            Tablo.FocusedRowHandle = rowHandle - 1;

        }
        protected override void AsagiTasi()
        {
            var rowHandle = Tablo.FocusedRowHandle;

            if (Tablo.DataRowCount == 0 || rowHandle == Tablo.DataController.ListSource.Count - 1) return;

            var asagiTasinacakEntity = Tablo.GetRow<ReceteOperasyonBilgileriL>(rowHandle);
            asagiTasinacakEntity.OperasyonSirasi = asagiTasinacakEntity.OperasyonSirasi + 1;
            if (!asagiTasinacakEntity.Insert)
                asagiTasinacakEntity.Update = true;

            var yukariTasinacakEntity = Tablo.GetRow<ReceteOperasyonBilgileriL>(rowHandle + 1);
            yukariTasinacakEntity.OperasyonSirasi = yukariTasinacakEntity.OperasyonSirasi - 1;
            if (!yukariTasinacakEntity.Insert)
                yukariTasinacakEntity.Update = true;

            Kaydet();
            Listele();
            Tablo.FocusedRowHandle = rowHandle + 1;
        }
    }
}

using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.FaturaForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.FaturaEditFormTable
{
    public partial class FaturaPlaniTable : BaseTablo
    {
        public FaturaPlaniTable()
        {
            InitializeComponent();

            Bll = new FaturaBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((FaturaBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).toBindingList<FaturaPlaniL>();
        }

        protected override void HareketEkle()
        {
            var alinanHizmetlerSource =((FaturaPlaniEditForm)OwnerForm).tablo.DataController.ListSource.Cast<FaturaAlinanHizmetlerL>();
            //var faturaPlaniSource = tablo.DataController.ListSource.Cast<FaturaPlaniL>().ToList();
            var faturaPlaniSource = tablo.DataController.ListSource;
            if (!ShowEditForms<TopluFaturaPlaniEditForm>.ShowDialogForm(KartTuru.Fatura,alinanHizmetlerSource,faturaPlaniSource)) return;

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colAciklama;

            ButtonEnabledDurum(true);
        }

        protected override void HareketSil()
        {
            var entity = tablo.GetRow<FaturaPlaniL>();
            if (entity == null) return;

            if (!colPlanTarihi.OptionsColumn.AllowEdit)
            {
                Messages.HataMesaji("Hareket Görmüş Fatura Planları Silinemez. ");
                return;
            }

            base.HareketSil();
        }

        protected override void RowCellAllowEdit()
        {
            var entity = tablo.GetRow<FaturaPlaniL>();
            if (entity == null) return;

            colAciklama.OptionsColumn.AllowEdit = entity.TahakkukTarih == null;
            colPlanTarihi.OptionsColumn.AllowEdit = entity.TahakkukTarih == null;
            colPlanTutar.OptionsColumn.AllowEdit = entity.TahakkukTarih == null;
            colPlanIndirim.OptionsColumn.AllowEdit = entity.TahakkukTarih == null;
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var entity = tablo.GetRow<FaturaPlaniL>();
            if (entity == null) return;

            if (e.Column == colPlanTutar || e.Column == colPlanIndirim)
                entity.PlanNetTutar = entity.PlanTutar - entity.PlanIndirimTutar;

            entity.Update = true;
            ButtonEnabledDurum(true);
        }

        protected override void Tablo_RowCountChanged(object sender, EventArgs e)
        {
            OwnerForm.btnSil.Enabled = tablo.DataController.ListSource.Cast<FaturaPlaniL>().Where(x => !x.Delete).ToList().Any();
        }
    }
}

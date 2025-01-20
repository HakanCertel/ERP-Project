using System;
using System.Linq;
using DevExpress.XtraGrid.Views.Base;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.MrpForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.MrpEditFormTable
{
    public partial class MrpMakinaBilgileriTable : BaseTablo
    {
        public MrpMakinaBilgileriTable()
        {
            InitializeComponent();

            Bll = new IstasyonOperasyonBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            //insUpNavigator.Visible = false;
            insUpNavigator.Navigator.Buttons.Append.Visible = false;
            insUpNavigator.Navigator.Buttons.Remove.Visible = false;

        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((IstasyonOperasyonBilgileriBll)Bll).CrpMakinaList(null).toBindingList<MrpMakinaBilgileriL>();

            //KapasiteHesapla();
        }
        protected override void Tablo_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            if (!_isLoaded) return;

           // base.Tablo_FocusedRowObjectChanged(sender, e);

            var entity = Tablo.GetRow<MrpMakinaBilgileriL>(false);
            if (entity == null) return;

            if (((MalzemeIhtiyacPlanlamaEditForm)OwnerForm).planlanmisMalzemeKalemleriTable.OwnerForm == null) return;

            OwnerForm.Id = entity.MakinaId;

            var vardiyaId = Erp.Bll.Functions.GetAnySingleOrListBll.SingleIstasyon(x=>x.Id==entity.IstasyonId).VardiyaId;

            OwnerForm.VardiyaBilgileri = Erp.Bll.Functions.GetAnySingleOrListBll
                    .SingleVardiya(x=>x.Id==vardiyaId)?.VardiyaBilgileriLastVersion.ToList();
                    //.VardiyaBilgileriLastVersion.Where(x => x.Gun == "Cuma".GetEnum<DaysOfWeek>())
                    //.FirstOrDefault();

            ((MalzemeIhtiyacPlanlamaEditForm)OwnerForm).planlanmisMalzemeKalemleriTable.Tablo.ViewCaption = $"{entity.MakinaAdi} Makinesinde Planlanan ";
            ((MalzemeIhtiyacPlanlamaEditForm)OwnerForm).planlanmisMalzemeKalemleriTable.Listele();
        }

        //protected override void Tablo_DoubleClick(object sender, EventArgs e)
        //{
        //    var entity = Tablo.GetRow<MrpMakinaBilgileriL>();
        //    OwnerForm.Id = entity.MakinaId;
        //    //((MalzemeIhtiyacPlanlamaEditForm)OwnerForm).mrpMalzemeIhtiyacBilgileriTable.Tablo.ViewCaption = $"- {entity.MakinaAdi} Planlanacak Malzeme Bilgileri -";
        //    ((MalzemeIhtiyacPlanlamaEditForm)OwnerForm).planlanmisMalzemeKalemleriTable.Tablo.ViewCaption = $"- {entity.MakinaAdi} Planlanan Malzeme Bilgileri -"; 

        //    //((MalzemeIhtiyacPlanlamaEditForm)OwnerForm).mrpMalzemeIhtiyacBilgileriTable.Listele();
        //    ((MalzemeIhtiyacPlanlamaEditForm)OwnerForm).planlanmisMalzemeKalemleriTable.Listele();
        //}

        protected override void Tablo_SablonChanged(object sender, EventArgs e)
        {
            TabloSablonKaydedilecek = true;
        }
        protected override void FiltreTemizle()
        {
            OwnerForm.Id = 0;
            //((MalzemeIhtiyacPlanlamaEditForm)OwnerForm).mrpMalzemeIhtiyacBilgileriTable.Listele();
        }
        protected internal void KapasiteHesapla()
        {
            var baslamaTarihi = ((MalzemeIhtiyacPlanlamaEditForm)OwnerForm).txtDonemBaslangicTarihi.DateTime;
            var bitisTarihi = ((MalzemeIhtiyacPlanlamaEditForm)OwnerForm).txtDonemBitisTarihi.DateTime;
            var source = tablo.DataController.ListSource.Cast<MrpMakinaBilgileriL>();

            if (source == null) return;

            foreach (var item in source)
            {
                var istasyon = GeneralFunctions.SingleIstasyon(item.IstasyonId);

                item.KapasiteIhtiyaci = GeneralFunctions.KapasiteHesaplaDakika(baslamaTarihi, bitisTarihi, istasyon.VardiyaId);
            }

            tablo.RefreshData();
        }

        protected override void HareketSil()
        {
            //base.HareketSil();
        }
    }
}

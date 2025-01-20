using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using System.Collections.Generic;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.Linq;
using SenfoniYazilim.Erp.Bll.General.PurchaseBll;
using System.Linq.Expressions;
using System;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.PurchaseDemandForms
{
    public partial class PurchaseDemandListForm : BaseListForm
    {
        private Expression<Func<SatinalmaTalep, bool>> _filter;

        public PurchaseDemandListForm()
        {
            InitializeComponent();

            Bll = new PurchaseDemandBll();

            if (AnaForm.KullaniciYetkisi == KullaniciYetkisi.Yonetici)
                _filter = x => x.Durum == AktifKartlariGoster;
            else
                _filter = x => x.Durum == AktifKartlariGoster && x.CreatorId == AnaForm.KullaniciId;
        }
        public PurchaseDemandListForm(params object[] prm):this()
        {

        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.SatinalmaTalep;
            Navigator = longNavigator.Navigator;
            FormShow = new ShowEditForms<PurchaseDemanEditForm>();
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((PurchaseDemandBll)Bll).List(_filter);
        }
        protected override void EntityDelete()
        {
            var entity = Tablo.GetRow<SatinalmaTalep>();
            if (entity == null) return;

            using (var bll= new PurchaseDemandItemsFormBll())
            {
                IList<BaseHareketEntity> satinalmaKalemleri ;
                satinalmaKalemleri = bll.List(x => x.OwnerFormId == entity.Id).Cast<BaseHareketEntity>().ToList();
                if (satinalmaKalemleri != null) 
                    bll.Delete(satinalmaKalemleri);
            }
            base.EntityDelete();
        }
        protected override bool SelectedEntityActiveOrPasive()
        {
            var entitiy = Tablo.GetRow<SatinalmaTalep>();
            if (entitiy == null) return false;
            var result=base.SelectedEntityActiveOrPasive();
            if (!result) return false;
            using (var bll=new PurchaseDemandItemsFormBll())
            {
                var list=bll.List(x => x.OwnerFormId == entitiy.Id).ToList();
                list.ForEach(x => 
                {
                    x.IsActive = !x.IsActive;
                });
                bll.Update(list);
            }
            return true;
        }
    }
}
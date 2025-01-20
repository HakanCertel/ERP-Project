using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General.WarehouseBll;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Model.Entities.WareHouseEntities;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using System.Linq.Expressions;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Dto.WareHousesDto;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.TransferBetweenWarehousesForms
{
    public partial class TransferDemandBetweenWarehousesListFrom : BaseListForm
    {
        private Expression<Func<TransferBetweenWarehouse, bool>> _filter;

        public TransferDemandBetweenWarehousesListFrom()
        {
            InitializeComponent();

            Bll = new TransferDemandWarehouseBll();

        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            BaseKartTuru = KartTuru.TransferDemandBetweenWarehouses;
            FormShow = new ShowEditForms<TransferDemandBetweenWarehousesEditForm>();
        }
        protected override void Listele()
        {
            if (AnaForm.KullaniciYetkisi == KullaniciYetkisi.Yonetici)
                _filter = x => x.Durum == AktifKartlariGoster;
            else
                _filter = x => x.Durum == AktifKartlariGoster&&x.CreatorUserId==AnaForm.KullaniciId;

            Tablo.GridControl.DataSource = ((TransferDemandWarehouseBll)Bll).List(_filter);
        }
        protected override void EntityDelete()
        {
            var entity = Tablo.GetRow<TransferDemandWarehouseL>();
            if (entity == null) return;
            var list=GetAnySingleOrListBll.ListTarnsferItemsBetweenWareHouses(x => x.OwnerFormId == entity.Id);
            var result = InstanceBaseHareketEntityBll<TransferItemsBetweenWareHouses, TarnsferItemsBetweenWareHousesBll>
                .DeleteEntites(list.Cast<BaseHareketEntity>().ToList());
            if(result)
                base.EntityDelete();
        }
    }
}
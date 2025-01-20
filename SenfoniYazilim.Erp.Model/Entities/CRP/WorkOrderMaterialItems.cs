using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Model.Entities.CRP
{
    public class WorkOrderMaterialItems:BaseHareketEntity
    {
        public int OwnerFormId { get; set; }
        public int MrpBilgileriId { get; set; }
        public int MalzemeIhtiyacBilgileriId { get; set; }
        public long BagliOlduguReceteId { get; set; }
        public long MaterialId { get; set; }
        public long UnitId { get; set; }
        public long WarehouseId { get; set; }
        public decimal UnitQty { get; set; }
        public decimal WastageQty { get; set; }

        public WorkOrders OwnerForm { get; set; }
        public WareHouse Warehouse { get; set; }
        public Recete BagliOlduguRecete { get; set; }
        public Material Material { get; set; }
        public Birim Unit { get; set; }
    }
}

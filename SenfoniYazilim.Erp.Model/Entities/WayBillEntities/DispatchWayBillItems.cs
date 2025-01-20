using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Model.Entities.WayBillEntities
{
    public class DispatchWayBillItems : BaseHareketEntity
    {
        public long WayBillId { get; set; }
        public long CompanyId { get; set; }
        public long? DeliveryCompanyId { get; set; }
        public int? SaleItemId { get; set; }
        public decimal Quantity { get; set; }
        public string WayBillItemDescription { get; set; }

        public long MaterialId { get; set; }
        public long CurrencyId { get; set; }
        public long TaxRateId { get; set; }
        public long MaterialUnitOfProccessId { get; set; }
        public decimal DefaultUnitPrice { get; set; }

        public decimal UnitPrice { get; set; }
        public decimal DiscountRate { get; set; }
        public DateTime? DemandedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public WayBillCreatingMethod WayBillCreatingMethod { get; set; }
        public byte[] OrderItemFile { get; set; }

        public DovizBilgileri Currency { get; set; }
        public Kdv TaxRate { get; set; }
        public Cari Company { get; set; }
        public Cari DeliveryCompany { get; set; }
        public Birim MaterialUnitOfProccess { get; set; }
        public Material Material { get; set; }
    }
}


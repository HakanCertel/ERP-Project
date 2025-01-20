using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;   

namespace SenfoniYazilim.Erp.Model.Entities.Company.CompanySetting
{
    public class CompanyRelatedMaterials:BaseHareketEntity
    {
        public long CompanyId { get; set; }
        public long MaterialId { get; set; }
        public long CompanyMaterialUnitId { get; set; }
        public int PackagingId { get; set; }
        public decimal MinOrderQty { get; set; }
        public decimal MaxOrderQty { get; set; }
        public long? ContractId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountRate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string BarcodeNumber { get; set; }
        public string CompanyMaterialCode { get; set; }
        public string CompanyMaterialName { get; set; }
        public bool IsActive { get; set; }

        public Cari Company { get; set; }
        public Material Material { get; set; }
        public Birim CompanyMaterialUnit { get; set; }
        public Packaging Packaging { get; set; }
    }
}

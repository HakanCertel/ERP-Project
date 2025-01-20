using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Company;
using SenfoniYazilim.Erp.Model.Entities.Company.CompanySetting;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class Cari:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Cari Adı", "txtCariAdi")]
        public string CariAdi { get; set; }

        [StringLength(14)]
        public string TcKimlikNo { get; set; }

        [StringLength(17)]
        public string Telefon1 { get; set; }

        [StringLength(17)]
        public string Telefon2 { get; set; }

        [StringLength(17)]
        public string Telefon3 { get; set; }

        [StringLength(17)]
        public string Telefon4 { get; set; }

        [StringLength(17)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Web { get; set; }

        [StringLength(50)]
        public string EMail { get; set; }

        [StringLength(50)]
        public string VergiDairesi { get; set; }

        [StringLength(20)]
        public string VergiNo { get; set; }

        [StringLength(155)]
        public string Adres { get; set; }

        public long? OzelKod1Id { get; set; }

        public long? OzelKod2Id { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public LegalEntity LegalEntity { get; set; } = LegalEntity.LegalEntity;

        public CustomerOrSuplier CustomerOrSuplier { get; set; } = CustomerOrSuplier.Customer;

        public Location Location { get; set; } = Location.Local;

        public CompanyState CompanyState { get; set; } = CompanyState.Active;

        public long? DefaultCurrencyId { get; set; }

        public OzelKod OzelKod1 { get; set; }

        public OzelKod OzelKod2 { get; set; }

        public DovizBilgileri DefaultCurrency { get; set; }

        public ICollection<CompanyContact> CompanyContactItems { get; set; }
        public ICollection<CompanyRelatedMaterials> CompanyRelatedMaterials { get; set; }
        public ICollection<CompanyPriceList> CompanyPriceList { get; set; }
        public ICollection<AddressItems> AddressItems { get; set; }
    }
}

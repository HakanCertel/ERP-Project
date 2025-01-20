using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class Material:BaseEntityFeatures
    {
        [StringLength(150), Required, ZorunluAlan("Stok Adı", "txtStokAdi")]
        public string StockName { get; set; }
        [Required, ZorunluAlan("Birim", "txtUnit")]
        public long? UnitId { get; set; }
        public string UnitC { get; set; }
        public bool Uretilebilir { get; set; }
        [Required, ZorunluAlan("Depo", "txtDepom")]
        public long DepoId { get; set; }
        public UrunCinsi UrunCinsi { get; set; } = UrunCinsi.Mamul;
        public decimal MinStockQty { get; set; }
        public decimal MaxStockQty { get; set; }
        public int? Feture1Id { get; set; }
        public int? Feture2Id { get; set; }
        public int? Feture3Id { get; set; }
        public int? Feture4Id { get; set; }
        public int? Feture5Id { get; set; }
        public int? Feture6Id { get; set; }
        public int? Feture7Id { get; set; }
        public int? Feture8Id { get; set; }
        public int? Feture9Id { get; set; }
        public int? Feture10Id { get; set; }
        public int? Feture11Id { get; set; }
        public int? Feture12Id { get; set; }
        public int? Feture13Id { get; set; }
        public int? Feture14Id { get; set; }
        public int? Feture15Id { get; set; }
        public int? Feture16Id { get; set; }
        public int? Feture17Id { get; set; }
        public int? Feture18Id { get; set; }
        public int? Feture19Id { get; set; }
        public int? Feture20Id { get; set; }

        public WareHouse Depo { get; set; }
        public Birim Unit { get; set; }

        public Features Feature1 { get; set; }
        public Features Feature2 { get; set; }
        public Features Feature3 { get; set; }
        public Features Feature4 { get; set; }
        public Features Feature5 { get; set; }
        public Features Feature6 { get; set; }
        public Features Feature7 { get; set; }
        public Features Feature8 { get; set; }
        public Features Feature9 { get; set; }
        public Features Feature10 { get; set; }
        public Features Feature11 { get; set; }
        public Features Feature12 { get; set; }
        public Features Feature13 { get; set; }
        public Features Feature14 { get; set; }
        public Features Feature15 { get; set; }
        public Features Feature16 { get; set; }
        public Features Feature17 { get; set; }
        public Features Feature18 { get; set; }
        public Features Feature19 { get; set; }
        public Features Feature20 { get; set; }

        public ICollection<WareHouseStocks> WareHouseStocks { get; set; }
        public ICollection<RezervasyonBilgileri> RezervasyonBilgileri { get; set; }
    }
}

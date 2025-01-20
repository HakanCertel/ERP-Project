using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.ProductionManagmentEntites.MrpEntites
{
    public class MrpBilgileri:BaseHareketEntity
    {
        public long ReceteId { get; set; }
        public long? StokId { get; set; }
        public long MrpId { get; set; }
        public long? DemandId { get; set; }
        public int? DemanItemId { get; set; }
        public string DemandCode { get; set; }
        public DemandStatus DemandStatu { get; set; }
        public long DemandInformationId { get; set; }
        public long? CurrentId { get; set; }
        public long UserId { get; set; }
        public long? PersonelId { get; set; }
        public decimal Miktar { get; set; }
        //[Column(TypeName = "date")]
        public DateTime BaslangicTarihi { get; set; }
        //[Column(TypeName = "date")]
        public DateTime BitisTarihi { get; set; }
        public string Cinsi { get; set; }
        public bool IsTakenToProcess { get; set; }
        public MrpCreatingMethod MrpCreatingMethod { get; set; }

        public Recete Recete { get; set; }
        public Material Stok { get; set; }
        public Mrp Mrp { get; set; }
        public Cari Current { get; set; }
        public Kullanici User { get; set; }
        public Personel Personel { get; set; }

        [InverseProperty("MrpBilgileri")]
        public ICollection<MalzemeIhtiyacBilgileri> MalzemeIhtiyacBilgileri { get; set; }
    }
}

using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.ProductionManagmentEntites.MrpEntites
{
    public class Mrp:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true), Kod("MRP Kod", "txtMrpKod"), ZorunluAlan("Mrp Kod", "txtMrpKod")]
        public override string Kod { get ; set ; }
        //[Column(TypeName = "date")]
        public DateTime EvrakTarihi { get; set; }
        public MrpCreatingMethod MrpCreatingMethod { get; set; } = MrpCreatingMethod.ChooseMaterial;
        public bool IsRun { get; set; }

        public string Aciklama { get; set; }

        [InverseProperty("Mrp")]
        public ICollection<MrpBilgileri> MrpBilgileri { get; set; }

    }
}

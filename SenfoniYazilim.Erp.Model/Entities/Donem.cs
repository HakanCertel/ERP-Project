﻿using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class Donem:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Dönem Adı", "txtDonemAdi")]
        public String DonemAdi { get; set; }

        [StringLength(500)]
        public String Aciklama { get; set; }
    }
}

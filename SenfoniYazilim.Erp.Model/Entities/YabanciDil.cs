﻿using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class YabanciDil:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Dil Adı", "txtDilAdi")]
        public string DilAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}

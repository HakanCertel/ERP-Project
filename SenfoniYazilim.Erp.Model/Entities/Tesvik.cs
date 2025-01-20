using SenfoniYazilim.Erp.Model.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Model.Entities.Base
{
    public class Tesvik:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Teşvik Adı", "txtTesvikAdi")]
        public string TesvikAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}

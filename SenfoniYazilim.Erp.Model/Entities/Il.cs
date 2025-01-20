using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities
{
    //[Table("Il1")] bu atribute Il olarak kaydedilecek tablomuzu Il1 olarak kaydedecektir...
    public class Il:BaseEntityDurum
    {
        [Index("IX_Kod",IsUnique =true)]
        public override string Kod { get ; set ; }

        public long CountryId { get; set; }

        [Required,StringLength(50),ZorunluAlan("İl Adı","txtIlAdi")]
        public String IlAdi { get; set; }
        [StringLength(500)]
        public String Aciklama { get; set; }

        public Country Country { get; set; }
        [InverseProperty("Il")]
        public ICollection<Ilce> Ilce { get; set; }
    }
}

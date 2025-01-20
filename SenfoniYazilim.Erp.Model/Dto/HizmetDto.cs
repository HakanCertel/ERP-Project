using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class HizmetS:Hizmet
    {
        public string HizmetTuruAdi { get; set; }
    }

    public class HizmetL : BaseEntity
    {
        public string HizmetAdi { get; set; }

        public DateTime BaslamaTarihi{ get; set; }

        public DateTime BitisTarihi { get; set; }

        public decimal Ucret { get; set; }

        public string Aciklama { get; set; }

        public string HizmetTuruAdi { get; set; }

        public long HizmetTuruId { get; set; }

        public HizmetTipi HizmetTipi{ get; set; }
    }
}

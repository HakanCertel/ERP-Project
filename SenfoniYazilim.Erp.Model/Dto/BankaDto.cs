﻿using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class BankaS:Banka
    {
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }

    public class BankaL : BaseEntity
    {
        public string BankaAdi { get; set; }

        public string OzelKod1Adi { get; set; }

        public string OzelKod2Adi { get; set; }

        public string Aciklama { get; set; }
    }
}

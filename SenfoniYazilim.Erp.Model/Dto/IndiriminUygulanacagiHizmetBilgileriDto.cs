﻿using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class IndiriminUygulanacagiHizmetBilgileriL : IndiriminUygulanacagiHizmetBilgileri , IBaseHareketEntity
    {
        public string HizmetAdi { get; set; }

        public bool Insert { get; set; }

        public bool Update { get; set; }

        public bool Delete { get; set; }
    }
}

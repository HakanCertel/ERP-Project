﻿using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class KullaniciS:Kullanici
    {
        public string RolAdi { get; set; }
        public KullaniciYetkisi KullaniciYetkisi { get; set; }
    }
    public class KullaniciL : BaseEntity
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string RolAdi { get; set; }
        public string Aciklama { get; set; }
    }
}

﻿using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class BankaHesap:BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Hesap Adı", "txtHesapAdi")]
        public string HesapAdi { get; set; }

        public BankaHesapTuru HesapTuru { get; set; } = BankaHesapTuru.VadesizMevduatHesabi;

        [ZorunluAlan("Banka Adı", "txtBankaAdi")]
        public long BankaId { get; set; }

        [ZorunluAlan("Banka Şube Adı", "txtBankaSube")]
        public long BankaSubeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime HesapAcilisTarihi { get; set; } = DateTime.Now.Date;

        [Required, StringLength(30), ZorunluAlan("Hesap No", "txtHesapNo")]
        public string HesapNo { get; set; }

        [Required, StringLength(32), ZorunluAlan("IBAN Adı", "txtIbanNo")]
        public string IbanNo { get; set; }
       
        public byte BlokeGunSayisi { get; set; }

        [StringLength(30)]
        public string IsyeriNo { get; set; }

        [StringLength(30)]
        public string TerminalNo { get; set; }

        public long? OzelKod1Id { get; set; }

        public long? OzelKod2Id { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public long SubeId { get; set; }

        public Banka Banka { get; set; }

        public BankaSube BankaSube { get; set; }

        public OzelKod OzelKod1 { get; set; }

        public OzelKod OzelKod2 { get; set; }

        public Sube Sube { get; set; }
    }
}

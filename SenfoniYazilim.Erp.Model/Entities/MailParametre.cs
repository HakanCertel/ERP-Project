using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class MailParametre : BaseEntity
    {
        [Required, StringLength(50), ZorunluAlan("EMail", "txtEMail")]
        public string EMail { get; set; }

        [Required, StringLength(50), ZorunluAlan("Şifre", "txtSifre")]
        public string Sifre { get; set; }

        [ ZorunluAlan("Port No", "txtPortNo")]
        public int PortNo { get; set; }

        [Required, StringLength(50), ZorunluAlan("Host", "txtHost")]
        public string Host { get; set; }

        public EvetHayir SslKullan { get; set; } = EvetHayir.Evet;

    }
}


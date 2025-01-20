using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Model.Entities.Satis
{
    public class Satis:BaseEntity
    {
        public long? EvrakTuruId { get; set; }
        public long? FirmaId { get; set; }
        public long? ProjeId { get; set; }
        public long? PlasiyerId { get; set; }
        public long? OdemeSekliId { get; set; }
        public long? DovizId { get; set; }
        public long? TevkifatId { get; set; }
        public long? OvfId { get; set; }
        public long? BankaId { get; set; }
        public long? TeslimCariId { get; set; }
        public long? KisiId { get; set; }
        public long? UlkeId { get; set; }
        public int Vade { get; set; }
        public IskontoTuru IskontoTuru { get; set; }
        public int Iskonto1 { get; set; }
        public int Iskonto2 { get; set; }
        public DateTime EvrakTarihi { get; set; }
        public DateTime GecerlilikTarihi { get; set; }
        public DateTime TerminTarihi { get; set; }
        public string TeslimAdresi { get; set; }
        public string Aciklama { get; set; }
        public string TeklifAciklama { get; set; }
        public string Not { get; set; }

    }
}

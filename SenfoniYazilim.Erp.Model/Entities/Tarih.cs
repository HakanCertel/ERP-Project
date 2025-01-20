using SenfoniYazilim.Erp.Model.Entities.Base;
using System;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class Tarih:BaseHareketEntity
    {
        public DateTime TamTarih { get; set; }
        public byte Gun { get; set; }
        public byte Hafta { get; set; }
        public byte Ay { get; set; }
        public bool Tatil { get; set; }
    }
}

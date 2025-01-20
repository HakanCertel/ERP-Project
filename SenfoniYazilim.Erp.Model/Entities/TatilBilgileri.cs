using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class TatilBilgileri:BaseHareketEntity
    {
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public SliceOfDay ZamanDilimi { get; set; }
    }
}

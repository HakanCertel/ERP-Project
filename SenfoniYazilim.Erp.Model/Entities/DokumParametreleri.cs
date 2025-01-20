using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;

namespace SenfoniYazilim.Erp.Model.Entities
{
    public class DokumParametreleri:IBaseEntity
    {
        public string RaporBaslik { get; set; }

        public EvetHayir BaslikEkle { get; set; }

        public RaporuKagidaSigdirma RaporuKagidaSigdir { get; set; }

        public YazdirmaYonu YazdirmaYonu { get; set; }

        public EvetHayir YatayCizgileriGoster { get; set; }

        public EvetHayir DİkeyCizgileriGoster { get; set; }

        public EvetHayir SutunBaslikleriniGoster { get; set; }

        public string YaziciAdi { get; set; }

        public int YazdirilacakAdet { get; set; }

        public DokumSekli DokumSekli { get; set; }
    }
}

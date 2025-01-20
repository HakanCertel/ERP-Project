using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity
{
    public class Language:BaseHareketEntity
    {
        public string LanguageCode { get; set; }
        public string LanguageDescription { get; set; }
        public string LocalEquivalent { get; set; }
        public bool DefaultLanguage { get; set; }
    }
}

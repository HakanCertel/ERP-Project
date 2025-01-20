using SenfoniYazilim.Erp.Model.Entities.Base;

namespace SenfoniYazilim.Erp.Model.Entities.Company
{
    public class CompanyContact:BaseHareketEntity
    {
        public long CompanyId { get; set; }
        public string ContactFullName { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string ContactPhoneNumber2 { get; set; }
        public string ContactEMail { get; set; }
        public bool IsDefault { get; set; }

        public Cari Company { get; set; }
    }
}

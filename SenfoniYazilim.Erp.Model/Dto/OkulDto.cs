using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    //biz entity lerimizi tanımlarken, örneğin Okul Entity si, OkulAdi,Ilid,IlceId,Aciklama ve bu sınıfın
    //inherit ettiği sınıfdan gelen Kod ve Id property leri vardı. Fakat biz aynı zamanda IlAdi ve IlceAdi
    //da getirmek istediğimizde işte bu Dto ları kullanacağız...

    //Attribute-----buraya gelecek olan Attribute Okul tablosunda değişiklikleri kaydederken IlAdi ve
    //IlceAdi nıda kaydedecektir. bu durumu engellemekiçin bu Attribute Kullanılacak...
    [NotMapped]
    public class OkulS:Okul
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
    }

    //bu metot ile kullanıcıya gösterilecek listeli veri tablosunda gösterilecek alanları belirleyeceğiz
    //IlId ve IlceId bu listede görünsün istenmediği için aşğıda bu işlemi yapacak işlemler yapılacak

    public class OkulL : BaseEntity
    {
        //OkuL sınıfı BaseEntity den inherite olduğu için sadece Kod ve Id alanları gelecektir.
        //görüntülemek istediğimiz diğer alanları ekleyelim...

        public string OkulAdi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string Aciklama { get; set; }
    }
}

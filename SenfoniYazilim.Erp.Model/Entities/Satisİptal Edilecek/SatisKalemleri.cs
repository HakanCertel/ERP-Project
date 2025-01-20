using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Model.Entities.Satis
{
    public class SatisKalemleri:BaseHareketEntity
    {
        public long SiparisId { get; set; }
        public long StokId { get; set; }//stok adı, birim,üretici kodu,Ambalaj Şekli,Hacim,NetAğırlık,BrütAğırlık,Barkod
        public long? DepoId { get; set; }//DepoAdı
        public long? TedarikciId { get; set; }//tedarikci bedeli, tedarikci döviz cinsi
        public long? TeklifBilgileriId { get; set; }//Teklif Kalem Numarası
        public long? KdvId { get; set; }//KdvOrani
        public int Miktar { get; set; }
        public long? FiyatListesiId { get; set; }
        public DateTime? TerminTarihi { get; set; }
        public string Aciklama { get; set; }
        //Net Fiyat, 

    }
}

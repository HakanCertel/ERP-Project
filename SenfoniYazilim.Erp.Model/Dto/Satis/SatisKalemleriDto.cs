using SenfoniYazilim.Erp.Model.Entities.Satis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Model.Dto.Satis
{
    public class SatisKalemleriL:SatisKalemleri
    {
        public string StokAdi { get; set; }
        public string Birim { get; set; }//->Stok
        public string ÜreticiKodu { get; set; }//->Stok
        public string AmbalajSekli { get; set; }//->Stok
        public string Hacim { get; set; }//->Stok
        public string NetAgirlik { get; set; }//->Stok
        public string BrutAgirlik { get; set; }//->Stok
        public string Barkod { get; set; }//->Stok
        public decimal TedarikciBedeli { get; set; }//->Tedarikci/Cari
        
    }
}

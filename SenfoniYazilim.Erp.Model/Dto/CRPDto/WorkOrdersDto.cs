using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.CRP;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Model.Dto.CRPDto
{
    [NotMapped]
    public class WorkOrdersL:WorkOrders,IBaseHareketEntity
    {
        public int MrpBilgileriId { get; set; }
        public long? DemandId { get; set; }
        public string DemandCode { get; set; }
        public long? CurrentId { get; set; }
        public string CurrentName { get; set; }
        public string UserName { get; set; }
        public string PersonelName { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string DepoKodu { get; set; }
        public string DepoAdi { get; set; }
        public string IstasyonKodu { get; set; }
        public string IstasyonAdi { get; set; }
        public string OperasyonKodu { get; set; }
        public string OperasyonAdi { get; set; }
        public string MakinaKodu { get; set; }
        public string MakinaAdi { get; set; }
        public string MakinaElemaniKodu { get; set; }
        public string MakinaElemaniAdi { get; set; }
        public string BirimAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

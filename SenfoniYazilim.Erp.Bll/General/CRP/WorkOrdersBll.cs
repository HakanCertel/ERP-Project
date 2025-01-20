using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.CRPDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.CRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Bll.General.CRP
{
    public class WorkOrdersBll : BaseHareketBll<WorkOrders, SenfoniErpContext>, IBaseHareketSelectBll<WorkOrders>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<WorkOrders, bool>> filter)
        {
            return List(filter, x =>  new WorkOrdersL
            {
                Id = x.Id,
                Kod=x.Kod,
                MrpBilgileriId = x.MalzemeIhtiyacBilgi.MrpBilgileriId,
                MalzemeIhtiyacBilgiId = x.MalzemeIhtiyacBilgiId,
                ReceteId = x.ReceteId,
                BagliOlduguUstReceteId = x.BagliOlduguUstReceteId,
                BagliOlduguAnaReceteId = x.MalzemeIhtiyacBilgi.BagliOlduguAnaReceteId,
                StokId = x.StokId,
                StokKodu = x.Stok.Kod,
                StokAdi = x.Stok.StockName,
                DepoId = x.DepoId,
                DepoKodu = x.Depo.Kod,
                DepoAdi = x.Depo.WarehouseName,
                IstasyonId = x.IstasyonId,
                IstasyonKodu = x.Istasyon.Kod,
                IstasyonAdi = x.Istasyon.IstasyonAdi,
                OperasyonId = x.OperasyonId,
                OperasyonKodu = x.Operasyon.Kod,
                OperasyonAdi = x.Operasyon.OperasyonAdi,
                MakinaId = x.MakinaId,
                MakinaKodu = x.Makina.Kod,
                MakinaAdi = x.Makina.MakinaAdi,
                MakinaElemaniId = x.MakinaElemaniId,
                MakinaElemaniKodu = x.MakinaElemani.Kod,
                MakinaElemaniAdi = x.MakinaElemani.StockName,
                BirimId = x.BirimId,
                BirimAdi = x.Birim.BirimAdi,
                IsEmriMiktari=x.IsEmriMiktari,
                UretilenMiktar = x.UretilenMiktar,
                Kalan = x.IsEmriMiktari - x.UretilenMiktar < 0 ? 0 : x.IsEmriMiktari - x.UretilenMiktar,
                IhtiyacTarihi = x.IhtiyacTarihi,
                PlanlandigiTarih = x.PlanlandigiTarih,
                DemandId = x.MalzemeIhtiyacBilgi.MrpBilgileri.DemandId,
                DemandCode = x.MalzemeIhtiyacBilgi.MrpBilgileri.DemandCode,
                CurrentId = x.MalzemeIhtiyacBilgi.MrpBilgileri.CurrentId,
                CurrentName = x.MalzemeIhtiyacBilgi.MrpBilgileri.Current.CariAdi,
                UserId = x.UserId,
                UserName = x.User.Adi+" "+x.User.Soyadi,
            }).ToList();

        }
    }
}


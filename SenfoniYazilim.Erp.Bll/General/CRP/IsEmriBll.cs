using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto.CRPDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.CRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General.CRP
{
    public class IsEmriBll : BaseHareketBll<CalismaEmri, SenfoniErpContext>, IBaseHareketSelectBll<CalismaEmri>
    {

        public  IEnumerable<BaseHareketEntity> List(Expression<Func<CalismaEmri, bool>> filter)
        {
            return List(filter, x => new
            {
                mib = x,
            }).Select(x => new IsEmriL
            {
                Id = x.mib.Id,
                Kod=x.mib.Kod,
                MalzemeIhtiyacBilgiId=x.mib.MalzemeIhtiyacBilgiId,
                MrpBilgileriId=x.mib.MalzemeIhtiyacBilgi.MrpBilgileriId,
                ReceteId = x.mib.ReceteId,
                BagliOlduguUstReceteId = x.mib.BagliOlduguUstReceteId,
                BagliOlduguAnaReceteId = x.mib.MalzemeIhtiyacBilgi.BagliOlduguAnaReceteId,
                StokId = x.mib.StokId,
                StokKodu = x.mib.Stok.Kod,
                StokAdi = x.mib.Stok.StockName,
                DepoId = x.mib.DepoId,
                DepoKodu = x.mib.Depo.Kod,
                DepoAdi = x.mib.Depo.WarehouseName,
                IstasyonId = x.mib.IstasyonId,
                IstasyonKodu = x.mib.Istasyon.Kod,
                IstasyonAdi = x.mib.Istasyon.IstasyonAdi,
                OperasyonId = x.mib.OperasyonId,
                OperasyonKodu = x.mib.Operasyon.Kod,
                OperasyonAdi = x.mib.Operasyon.OperasyonAdi,
                MakinaId = x.mib.MakinaId,
                MakinaKodu = x.mib.Makina.Kod,
                MakinaAdi = x.mib.Makina.MakinaAdi,
                MakinaElemaniId = x.mib.MakinaElemaniId,
                MakinaElemaniKodu = x.mib.MakinaElemani.Kod,
                MakinaElemaniAdi = x.mib.MakinaElemani.StockName,
                BirimId = x.mib.BirimId,
                BirimAdi = x.mib.Birim.BirimAdi,
                UretilenMiktar = x.mib.UretilenMiktar,
                IsEmriMiktari = x.mib.IsEmriMiktari,
                Kalan = x.mib.IsEmriMiktari - x.mib.UretilenMiktar < 0 ? 0 : x.mib.IsEmriMiktari - x.mib.UretilenMiktar,
                IhtiyacTarihi = x.mib.IhtiyacTarihi,
                PlanlandigiTarih = x.mib.PlanlandigiTarih,
                DemandId = x.mib.MalzemeIhtiyacBilgi.MrpBilgileri.DemandId,
                DemandCode = x.mib.MalzemeIhtiyacBilgi.MrpBilgileri.DemandCode,
                CurrentId = x.mib.MalzemeIhtiyacBilgi.MrpBilgileri.CurrentId,
                CurrentName = x.mib.MalzemeIhtiyacBilgi.MrpBilgileri.Current.CariAdi,
                UserId = x.mib.UserId,
                UserName = x.mib.User.Adi+" "+x.mib.User.Soyadi,
            }).ToList();

        }
    }
}

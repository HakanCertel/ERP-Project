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

namespace SenfoniYazilim.Erp.Bll.General.CRP
{
    public class PlanlanmisMalzemeKalemleriBll : BaseHareketBll<PlanlanmisMalzemeKalemleri, SenfoniErpContext>, IBaseHareketSelectBll<PlanlanmisMalzemeKalemleri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<PlanlanmisMalzemeKalemleri, bool>> filter)
        {
            var sonuc= List(filter, x => new
            {
                pmk = x,
                ihtiyacMiktari=(x.PlanlananMiktar-x.UretilenMiktar)>0?x.PlanlananMiktar-x.UretilenMiktar:0,
                operasyonSuresi=x.OperasyonSuresi
            }).Select(x=> new PlanlanmisMalzemeKalemleriL
            {
                Id = x.pmk.Id,
                MrpBilgileriId = x.pmk.MrpBilgileriId,
                MalzemeIhtiyacBilgiId=x.pmk.MalzemeIhtiyacBilgiId,
                KapasiteIhtiyacKalemId=x.pmk.KapasiteIhtiyacKalemId,
                IsEmriId=x.pmk.IsEmriId,
                IsEmriKod=x.pmk.IsEmriKodu,
                AnaReceteKodu = x.pmk.MrpBilgileri.Recete.Stok.Kod,
                ReceteId = x.pmk.ReceteId,
                BagliOlduguUstReceteId = x.pmk.BagliOlduguUstReceteId,
                BagliOlduguAnaReceteId = x.pmk.MrpBilgileri.Recete.Id,
                StokId = x.pmk.StokId,
                StokKodu = x.pmk.Stok.Kod,
                StokAdi = x.pmk.Stok.StockName,
                DepoId = x.pmk.DepoId,
                DepoKodu = x.pmk.Depo.Kod,
                DepoAdi = x.pmk.Depo.WarehouseName,
                IstasyonId = x.pmk.IstasyonId,
                IstasyonKodu = x.pmk.Istasyon.Kod,
                IstasyonAdi = x.pmk.Istasyon.IstasyonAdi,
                OperasyonId = x.pmk.OperasyonId,
                OperasyonKodu = x.pmk.Operasyon.Kod,
                OperasyonAdi = x.pmk.Operasyon.OperasyonAdi,
                MakinaId = x.pmk.MakinaId,
                MakinaKodu = x.pmk.Makina.Kod,
                MakinaAdi = x.pmk.Makina.MakinaAdi,
                MakinaElemaniId = x.pmk.MakinaElemaniId,
                MakinaElemaniKodu = x.pmk.MakinaElemani.Kod,
                MakinaElemaniAdi = x.pmk.MakinaElemani.StockName,
                BirimId = x.pmk.BirimId,
                BirimAdi = x.pmk.Birim.BirimAdi,
                UretilenMiktar = x.pmk.UretilenMiktar,
                PlanlananMiktar = x.pmk.PlanlananMiktar,
                Kalan = x.pmk.PlanlananMiktar - x.pmk.UretilenMiktar < 0 ? 0 : x.pmk.PlanlananMiktar - x.pmk.UretilenMiktar,
                IhtiyacTarihi = x.pmk.IhtiyacTarihi,
                PlanTarihi = x.pmk.PlanTarihi,
                TamamlanmaTarihi=x.pmk.TamamlanmaTarihi,
                ReceteSeviyesi = x.pmk.ReceteSeviyesi,
                OperasyonSeviyesi = x.pmk.OperasyonSeviyesi,
                ToplamUretimSuresi = x.pmk.KapasiteIhtiyaci,
                OperasyonSuresi = x.pmk.OperasyonSuresi,
                IsEmriKodu = x.pmk.IsEmriKodu,
                KapasiteIhtiyaci = x.ihtiyacMiktari*x.operasyonSuresi,
                DemandId = x.pmk.MrpBilgileri.DemandId,
                DemandItemId=x.pmk.MrpBilgileri.DemanItemId,
                DemandCode = x.pmk.MrpBilgileri.DemandCode,
                CurrentId = x.pmk.MrpBilgileri.CurrentId,
                CurrentName = x.pmk.MrpBilgileri.Current.CariAdi,
                UserId = x.pmk.MrpBilgileri.UserId,
                UserName = x.pmk.MrpBilgileri.User.Adi,
                PersonelId = x.pmk.MrpBilgileri.PersonelId,
                PersonelName = x.pmk.MrpBilgileri.Personel.Adi,
                PlanKesinlesti=x.pmk.PlanKesinlesti,
                IsEmriDurumu=x.pmk.IsEmriDurumu,
                Sira=x.pmk.Sira,
            }).OrderBy(x=>x.Sira).ToList();
            return sonuc;
        }
    }
}

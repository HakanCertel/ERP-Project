using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.Bll.General.CRP
{
    public class KapasiteIhtiyacBilgileriBll : BaseHareketBll<KapasiteIhtiyacBilgileri, SenfoniErpContext>, IBaseHareketSelectBll<KapasiteIhtiyacBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<KapasiteIhtiyacBilgileri, bool>> filter)
        {
            var list = List(filter, x => new
            {
                mib = x,
                StokMiktari = x.Stok.WareHouseStocks.Where(y => y.MaterialId == x.StokId && y.WareHouseId == x.DepoId).Select(y => y.Quantity).FirstOrDefault(),
            });

            var sonuc = list.Select(x => new KapasiteIhtiyacBilgileriL
            {
                Id = x.mib.Id,
                MrpBilgileriId = x.mib.MrpBilgileriId,//MrpBilgileriId,
                MalzemeIhtiyacBilgiId=x.mib.MalzemeIhtiyacBilgiId,
                MrpId = x.mib.MrpBilgileri.MrpId,//MrpBilgileri.MrpId,
                MrpKod = x.mib.MrpBilgileri.Mrp.Kod,
                AnaReceteKodu = x.mib.MrpBilgileri.Recete.Stok.Kod,
                ReceteId = x.mib.ReceteId,
                BagliOlduguUstReceteId = x.mib.BagliOlduguUstReceteId,
                BagliOlduguAnaReceteId = x.mib.BagliOlduguAnaReceteId,
                //BagliOlduguUstReceteStokKodu = x.mib.BagliOlduguUstRecete.Kod,
                //BagliOlduguUstReceteStokAdi = x.mib.BagliOlduguUstRecete.Stok.StockName,
                StokId = x.mib.StokId,//StokId,
                StokKodu = x.mib.Stok.Kod,//Stok.Kod,
                StokAdi = x.mib.Stok.StockName,//Stok.StockName,
                DepoId = x.mib.DepoId,
                DepoKodu = x.mib.Depo.Kod,
                DepoAdi = x.mib.Depo.WarehouseName,
                IstasyonId = x.mib.IstasyonId,
                IstasyonKodu = x.mib.Istasyon.Kod,
                IstasyonAdi=x.mib.Istasyon.IstasyonAdi,
                OperasyonId = x.mib.OperasyonId,
                OperasyonKodu = x.mib.Operasyon.Kod,
                OperasyonAdi=x.mib.Operasyon.OperasyonAdi,
                MakinaId = x.mib.MakinaId,
                MakinaKodu = x.mib.Makina.Kod,
                MakinaAdi = x.mib.Makina.MakinaAdi,
                MakinaElemaniId = x.mib.MakinaElemaniId,
                //MakinaElemaniKodu = x.mib.MakinaElemani.Kod,
                //MakinaElemaniAdi = x.mib.MakinaElemani.StockName,
                BirimId = x.mib.BirimId,
                BirimAdi=x.mib.Birim.BirimAdi,
                BirimIhtiyac = x.mib.BirimIhtiyac,
                NetIhtiyac = x.mib.MalzemeIhtiyacBilgi.NetIhtiyac,
                PlanlananMiktar = x.mib.PlanlananMiktar,
                Kalan = x.mib.NetIhtiyac - x.mib.PlanlananMiktar < 0 ? 0 : x.mib.NetIhtiyac - x.mib.PlanlananMiktar,
                ToplamStokMiktari = x.StokMiktari,
                TavsiyeEdilenUretimBaslamaTarihi = x.mib.TavsiyeEdilenUretimBaslamaTarihi,
                IhtiyacTarihi = x.mib.IhtiyacTarihi,
                //ReceteSeviyesi = x.mib.MalzemeIhtiyacBilgi.ReceteSeviyesi,
                OperasyonSeviyesi = x.mib.OperasyonSeviyesi,
                ToplamUretimSuresi = x.mib.KapasiteIhtiyaci,
                OperasyonSuresi = x.mib.OperasyonSuresi,
                KapasiteIhtiyaci = x.mib.KapasiteIhtiyaci,
                Planlandi = x.mib.Planlandi,
                //Bolunen = x.mib.Bolunen,
                //IsEmriKodu = x.mib.IsEmriKodu,
                DemandId = x.mib.MrpBilgileri.DemandId,
                DemandItemId=x.mib.MrpBilgileri.DemanItemId,
                DemandCode = x.mib.MrpBilgileri.DemandCode,
                CurrentId = x.mib.MrpBilgileri.CurrentId,
                CurrentName = x.mib.MrpBilgileri.Current.CariAdi,
                UserId = x.mib.MrpBilgileri.UserId,
                UserName = x.mib.MrpBilgileri.User.Adi,
                PersonelId = x.mib.MrpBilgileri.PersonelId,
                PersonelName = x.mib.MrpBilgileri.Personel.Adi,
                IsActive=x.mib.IsActive,
                IsClosed=x.mib.IsClosed,
            }).ToList();//.OrderBy(x => x.MrpBilgileriId).ThenBy(x=>x.ReceteSeviyesi).ToList();

            return sonuc;
        }

      

    }
}

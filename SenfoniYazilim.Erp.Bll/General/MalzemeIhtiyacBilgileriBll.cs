using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class MalzemeIhtiyacBilgileriBll : BaseHareketBll<MalzemeIhtiyacBilgileri, SenfoniErpContext>, IBaseHareketSelectBll<MalzemeIhtiyacBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<MalzemeIhtiyacBilgileri, bool>> filter)
        {
            var list = List(filter, x => new
            {
                mib = x,
                StokMiktari = x.Stok.WareHouseStocks.Where(y => y.MaterialId == x.StokId && y.WareHouseId == x.DepoId).Select(y => y.Quantity).FirstOrDefault(),
                toplamRezerveMiktari = x.Stok.RezervasyonBilgileri.Where(y => y.MaterialId == x.StokId&&y.WarehouseId==x.DepoId).Select(y => y.RezervedQty).Sum(),
                RezerveMiktari = x.Stok.RezervasyonBilgileri.Where(y => y.MaterialId == x.StokId && x.Id == y.OwnerFormId).Select(y => y.RezervedQty).FirstOrDefault(),
                Rezerv=x.Stok.RezervasyonBilgileri.Where(y=>y.OwnerFormItemId==x.Id).FirstOrDefault(),
            });

            var sonuc = list.Select(x => new MalzemeIhtiyacBilgileriL
            {
                Id = x.mib.Id,
                MrpBilgileriId = x.mib.MrpBilgileriId,
                MrpId = x.mib.MrpBilgileri.MrpId,
                MrpKod = x.mib.MrpBilgileri.Mrp.Kod,
                MrpCreatingMethod=x.mib.MrpBilgileri.MrpCreatingMethod,
                AnaReceteKodu = x.mib.MrpBilgileri.Recete.Stok.Kod,
                ReceteId = x.mib.ReceteId,
                BagliOlduguUstReceteId = x.mib.BagliOlduguUstReceteId,
                BagliOlduguAnaReceteId = x.mib.ReceteId,//MrpBilgileri.Recete.Id,
                BagliOlduguUstReceteStokKodu = x.mib.BagliOlduguUstRecete.Kod,
                BagliOlduguUstReceteStokAdi = x.mib.BagliOlduguUstRecete.ReceteAdi,//.Stok.StockName,
                StokId = x.mib.StokId,
                StokKodu = x.mib.Stok.Kod,
                StokAdi = x.mib.Stok.StockName,
                DepoId = x.mib.DepoId,
                DepoKodu = x.mib.Depo.Kod,
                DepoAdi = x.mib.Depo.WarehouseName,
                IstasyonId = x.mib.IstasyonId,
                IstasyonKodu = x.mib.Istasyon.Kod,
                OperasyonId = x.mib.OperasyonId,
                OperasyonKodu = x.mib.Operasyon.Kod,
                MakinaId = x.mib.MakinaId,
                //MakinaKodu = x.mib.Makina.Kod,
                //MakinaAdi = x.mib.Makina.MakinaAdi,
                MakinaElemaniId = x.mib.MakinaElemaniId,
                //MakinaElemaniKodu = x.mib.MakinaElemani.Kod,
                //MakinaElemaniAdi = x.mib.MakinaElemani.StockName,
                BirimId=x.mib.BirimId,
                BirimAdi = x.mib.Birim.BirimAdi,
                BirimIhtiyac = x.mib.BirimIhtiyac,
                FireMiktarı=x.mib.FireMiktarı,
                ToplamIhtiyac = x.mib.ToplamIhtiyac,
                RezerveMiktar = x.Rezerv == null ? 0 : x.Rezerv.RezervedQty,
                BrutIhtiyac = x.mib.BrutIhtiyac,
                Uretilebilir=x.mib.Uretilebilir,
                NetIhtiyac = x.mib.NetIhtiyac,
                PlanlananMiktar = x.mib.PlanlananMiktar,
                Kalan = x.mib.NetIhtiyac - x.mib.PlanlananMiktar < 0 ? 0 : x.mib.NetIhtiyac - x.mib.PlanlananMiktar,
                ToplamStokMiktari = x.StokMiktari,
                ToplamRezerveMiktar = x.toplamRezerveMiktari,
                AcikMiktar = x.StokMiktari - x.toplamRezerveMiktari,
                TavsiyeEdilenBaslamaTarihi = x.mib.TavsiyeEdilenBaslamaTarihi,
                TalepTarihi = x.mib.TalepTarihi,
                ReceteSeviyesi = x.mib.ReceteSeviyesi,
                OperasyonSeviyesi = x.mib.OperasyonSeviyesi,
                Uretim = x.mib.Uretim,
                Kapandi = x.mib.Kapandi,
                ToplamUretimSuresi = x.mib.KapasiteIhtiyaci,
                OperasyonSuresi = x.mib.OperasyonSuresi,
                Filter = false,
                Planlandi = x.mib.Planlandi,
                Bolunen = x.mib.Bolunen,
                IsEmriKodu = x.mib.IsEmriKodu,
                KapasiteIhtiyaci = x.mib.KapasiteIhtiyaci,
                DemandId = x.mib.MrpBilgileri.DemandId,
                DemandCode = x.mib.MrpBilgileri.DemandCode,
                DemandStatu = x.mib.MrpBilgileri.DemandStatu,
                CurrentId = x.mib.MrpBilgileri.CurrentId,
                CurrentName = x.mib.MrpBilgileri.Current.CariAdi,
                UserId = x.mib.MrpBilgileri.UserId,
                UserName = x.mib.MrpBilgileri.User.Adi,
                PersonelId = x.mib.MrpBilgileri.PersonelId,
                PersonelName = x.mib.MrpBilgileri.Personel.Adi,
                MrpProccessStatus=x.mib.MrpProccessStatus,
                PurchaseDemandItemId=x.mib.PurchaseDemandItemId,

            }).OrderBy(x => x.MrpBilgileriId).ThenBy(x=>x.ReceteSeviyesi).ToList();

            return sonuc;
        }

        public IEnumerable<BaseHareketEntity> MrpMalzemeIhtiyacList(Expression<Func<MalzemeIhtiyacBilgileri, bool>> filter)
        {
            return List(filter, x => new
            {
                mib = x,
                StokMiktari = x.Stok.WareHouseStocks.Where(y => y.MaterialId == x.MrpBilgileri.Recete.ReceteBilgileri.Where(z => z.StokId == y.MaterialId).Select(z => z.StokId).FirstOrDefault()).Select(y => y.Quantity).FirstOrDefault(),
                ToplamRezerveMiktari = x.Stok.RezervasyonBilgileri.Where(y => y.MaterialId == x.StokId).Select(y => y.RezervedQty).Sum(),

            }).Select(x => new MrpMalzemeIhtiyacBilgileriL
            {
                Id = x.mib.Id,
                MrpBilgileriId = x.mib.MrpBilgileriId,
                MrpKodu = x.mib.MrpBilgileri.Mrp.Kod,
                BagliOlduguUstReceteKodu = x.mib.BagliOlduguUstRecete.Kod,
                MakinaId = x.mib.MakinaId,
                StokId = x.mib.StokId,
                StokKodu = x.mib.Stok.Kod,
                StokAdi = x.mib.Stok.StockName,
                DepoId = x.mib.DepoId,
                DepoKodu = x.mib.Depo.Kod,
                DepoAdi = x.mib.Depo.WarehouseName,
                NetIhtiyac = x.mib.NetIhtiyac,
                BirimAdi = x.mib.Stok.Unit.Kod,
                TavsiyeEdilenBaslamaTarihi = x.mib.TavsiyeEdilenBaslamaTarihi,
                TalepTarihi = x.mib.TalepTarihi,
                ReceteSeviyesi = x.mib.ReceteSeviyesi,
                KapasiteIhtiyaci = x.mib.KapasiteIhtiyaci,
                OperasyonSuresi = x.mib.OperasyonSuresi,
                
            }).OrderBy(x=>x.MrpBilgileriId).ThenBy(x=>x.ReceteSeviyesi).ToList();
        }
        public IEnumerable<BaseEntity> BirlestirList(Expression<Func<MalzemeIhtiyacBilgileri, bool>> filter)
        {
            return List(filter, x => new
            {
                mib = x,
                StokMiktari = x.Stok.WareHouseStocks.Where(y => y.MaterialId == x.StokId && y.WareHouseId == x.DepoId).Select(y => y.Quantity).FirstOrDefault(),
                toplamRezerveMiktari = x.Stok.RezervasyonBilgileri.Where(y => y.MaterialId == x.StokId).Select(y => y.RezervedQty).Sum(),
                RezerveMiktari = x.Stok.RezervasyonBilgileri.Where(y => y.MaterialId == x.StokId && x.Id == y.OwnerFormId).Select(y => y.RezervedQty).FirstOrDefault(),
                Rezerv = x.Stok.RezervasyonBilgileri.Where(y => y.OwnerFormId == x.Id).FirstOrDefault(),
            }).Select(x => new MrpMalzemeIhtiyacBilgileriBirlestirL
            {
                Id = x.mib.Id,
                MrpBilgileriId = x.mib.MrpBilgileriId,
                MrpId = x.mib.MrpBilgileri.MrpId,
                MrpKod = x.mib.MrpBilgileri.Mrp.Kod,
                AnaReceteKodu = x.mib.MrpBilgileri.Recete.Stok.Kod,
                ReceteId = x.mib.ReceteId,
                BagliOlduguUstReceteId = x.mib.BagliOlduguUstReceteId,
                BagliOlduguAnaReceteId = x.mib.MrpBilgileri.Recete.Id,
                BagliOlduguUstReceteStokKodu = x.mib.BagliOlduguUstRecete.Kod,
                BagliOlduguUstReceteStokAdi = x.mib.BagliOlduguUstRecete.Stok.StockName,
                StokId = x.mib.StokId,
                StokKodu = x.mib.Stok.Kod,
                StokAdi = x.mib.Stok.StockName,
                DepoId = x.mib.DepoId,
                DepoKodu = x.mib.Depo.Kod,
                DepoAdi = x.mib.Depo.WarehouseName,
                //Id=x.mib.MrpBilgileri.MrpId,
                IstasyonId = x.mib.IstasyonId,
                IstasyonKodu = x.mib.Istasyon.Kod,
                OperasyonId = x.mib.OperasyonId,
                OperasyonKodu = x.mib.Operasyon.Kod,
                MakinaId = x.mib.MakinaId,
               // MakinaKodu = x.mib.Makina.Kod,
                //MakinaAdi = x.mib.Makina.MakinaAdi,
                MakinaElemaniId = x.mib.MakinaElemaniId,
                //MakinaElemaniKodu = x.mib.MakinaElemani.Kod,
                //MakinaElemaniAdi = x.mib.MakinaElemani.StockName,
                Birim = x.mib.Birim.BirimAdi,
                BirimIhtiyac = x.mib.BirimIhtiyac,
                ToplamIhtiyac = x.mib.ToplamIhtiyac,
                RezerveMiktar = x.Rezerv == null ? 0 : x.Rezerv.RezervedQty,
                BrutIhtiyac = x.mib.BrutIhtiyac == 0 ? x.mib.ToplamIhtiyac : x.mib.BrutIhtiyac,
                NetIhtiyac = x.mib.NetIhtiyac,
                ToplamStokMiktari = x.StokMiktari,
                ToplamRezerveMiktar = x.toplamRezerveMiktari,
                AcikMiktar = x.StokMiktari - x.toplamRezerveMiktari,
                TavsiyeEdilenUretimBaslamaTarihi = x.mib.TavsiyeEdilenBaslamaTarihi,
                IhtiyacTarihi = x.mib.TalepTarihi,
                ReceteSeviyesi = x.mib.ReceteSeviyesi,
                OperasyonSeviyesi = x.mib.OperasyonSeviyesi,
                Bolunen=x.mib.Bolunen,
                Planlandi=x.mib.Planlandi,
                Uretim = x.mib.Uretim,
                IsEmriKodu=x.mib.IsEmriKodu,
                Kapandi= x.mib.Kapandi,
                ToplamUretimSuresi = x.mib.KapasiteIhtiyaci,
                OperasyonSuresi = x.mib.OperasyonSuresi,
                Filter = false,
            }).OrderBy(x => x.MrpBilgileriId).ThenBy(x => x.ReceteSeviyesi).ToList();
        }

    }
}

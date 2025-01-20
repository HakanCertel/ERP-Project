using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto.ProductionManagmentDto.UretimSonuKayitDto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.ProductionManagmentEntities.UretimSonuKayitEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General.ProductionManangmentBll.UretimSonuKayitSurecBll
{
    public class UretimSonuKayitBll : BaseGenelBll<UretimSonuKayit>, IBaseGenelBll, IBaseCommonBll
    {
        public UretimSonuKayitBll() : base(KartTuru.UretimSonuKayit) { }

        public UretimSonuKayitBll(Control ctrl) : base(ctrl, KartTuru.UretimSonuKayit) { }

        public override BaseEntity Single(Expression<Func<UretimSonuKayit, bool>> filter)
        {
            var entity= BaseSingle(filter, x => new UretimSonuKayitS
            {
                Id = x.Id,
                Kod = x.Kod,
                IsEmriId=x.IsEmriId,
                IsEmriKodu=x.IsEmri.Kod,
                IsEmriMiktari=x.IsEmri.IsEmriMiktari,
                UretilenMiktar=x.IsEmri.UretilenMiktar,
                FireMiktari=x.FireMiktari,
                CurrentName=x.IsEmri.MalzemeIhtiyacBilgi.MrpBilgileri.Current.CariAdi,
                UserName=x.User.Adi+" "+x.User.Soyadi,
                StokId=x.StokId,
                StokKodu=x.Stok.Kod,
                StokAdi=x.Stok.StockName,
                UnitId=x.UnitId,
                UnitCode=x.Unit.Kod,
                UnitName=x.Unit.BirimAdi,
                DepoId=x.DepoId,
                DepoKodu=x.Depo.Kod,
                DepoAdi=x.Depo.WarehouseName,
                IstasyonKodu=x.IsEmri.Istasyon.Kod,
                IstasyonAdi=x.IsEmri.Istasyon.IstasyonAdi,
                OperasyonKodu=x.IsEmri.Operasyon.Kod,
                OperasyonAdi=x.IsEmri.Operasyon.OperasyonAdi,
                MakinaKodu=x.IsEmri.Makina.Kod,
                MakinaAdi=x.IsEmri.Makina.MakinaAdi,
                BirimAdi=x.IsEmri.Birim.BirimAdi,
                IslemTarihi=x.IslemTarihi,
                EvrakTarihi=x.EvrakTarihi,
                GuncellemeTarihi=x.GuncellemeTarihi,
                BaslamaZamani=x.BaslamaZamani,
                BitisZamani=x.BitisZamani,
                UserId=x.UserId,
                UpdatingUserId=x.UpdatingUserId
            });
            entity.IslemMiktari = entity.IsEmriMiktari - entity.UretilenMiktar;

            return entity;
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<UretimSonuKayit, bool>> filter)
        {
            return BaseList(filter, x => new UretimSonuKayitL
            {
                Id = x.Id,
                Kod = x.Kod,
                IsEmriId = x.IsEmriId,
                IsEmriKodu=x.IsEmri.Kod,
                CurrentName = x.IsEmri.MalzemeIhtiyacBilgi.MrpBilgileri.Current.CariAdi,
                UserName = x.User.Adi + " " + x.User.Soyadi,
                StokId = x.StokId,
                StokKodu = x.Stok.Kod,
                StokAdi = x.Stok.StockName,
                DepoId = x.DepoId,
                DepoKodu = x.Depo.Kod,
                DepoAdi = x.Depo.WarehouseName,
                IstasyonKodu = x.IsEmri.Istasyon.Kod,
                IstasyonAdi = x.IsEmri.Istasyon.IstasyonAdi,
                OperasyonKodu = x.IsEmri.Operasyon.Kod,
                OperasyonAdi = x.IsEmri.Operasyon.OperasyonAdi,
                MakinaKodu = x.IsEmri.Makina.Kod,
                MakinaAdi = x.IsEmri.Makina.MakinaAdi,
                BirimAdi = x.IsEmri.Birim.BirimAdi,
                IslemMiktari = x.IslemMiktari,
                IslemTarihi = x.IslemTarihi,
                EvrakTarihi = x.EvrakTarihi,
                GuncellemeTarihi = x.GuncellemeTarihi,
                BaslamaZamani = x.BaslamaZamani,
                BitisZamani = x.BitisZamani,
                UserId = x.UserId,
            });
        }
    }
}

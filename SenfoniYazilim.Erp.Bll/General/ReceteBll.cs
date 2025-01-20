using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.Bll.General
{
    public class ReceteBll : BaseGenelBll<Recete>, IBaseGenelBll, IBaseCommonBll
    {
        public ReceteBll() : base(KartTuru.Recete) { }

        public ReceteBll(Control ctrl) : base(ctrl, KartTuru.Recete) { }

        public override BaseEntity Single(Expression<Func<Recete, bool>> filter)
        {
            return BaseSingle(filter,x=> new ReceteS
            {
                Id=x.Id,
                Kod=x.Kod,
                ReceteAdi=x.ReceteAdi,
                StokId=x.StokId,
                StokAdi=x.Stok.StockName,
                MalzemeBirimId=x.Stok.UnitId,
                MalzemeBirimAdi=x.Stok.Unit.Kod,
                MalzemeDepoId=x.Stok.DepoId,
                MalzemeDepoKodu=x.Stok.Depo.Kod,
                MalzemeDepoAdi=x.Stok.Depo.WarehouseName,
                DepoId=x.DepoId,
                ReceteDepoKodu=x.Depo.Kod,
                ReceteDepoAdi=x.Depo.WarehouseName,
                ReceteBirimId=x.ReceteBirimId,
                ReceteOperasyonBilgileri=x.ReceteOperasyonBilgileri,
                ReceteOperasyonMakinaBilgileri=x.ReceteOperasyonMakinaBilgileri,
                ReceteMakinaElemaniBilgileri=x.ReceteMakinaElemaniBilgileri,
                //ReceteBirimKodu=x.ReceteBirim.Kod,
                //ReceteBirimAdi=x.ReceteBirim.BirimAdi,
                UrunCinsi=x.Stok.UrunCinsi,
                Miktar=x.Miktar,
                Durum=x.Stok.Durum,
                Varsayılan=x.Varsayılan,
                ReceteBilgileri=x.ReceteBilgileri,
            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Recete, bool>> filter)
        {
            return BaseList(filter,x=> new ReceteL
            {
                Id=x.Id,
                Kod=x.Kod,
                ReceteAdi=x.ReceteAdi,
                StokId=x.StokId,
                StokKodu=x.Stok.Kod,
                StokAdi=x.Stok.StockName,
                MalzemeBirimAdi=x.Stok.Unit.BirimAdi,
                UrunCinsi=x.Stok.UrunCinsi,
                ReceteDepoId=x.DepoId,
                ReceteDepoAdi=x.Depo.WarehouseName,
                ReceteBirimId=x.ReceteBirimId,
                //ReceteBirimAdi=x.ReceteBirim.BirimAdi,
                Miktar=x.Miktar,
                Durum=x.Durum,
                Varsayılan=x.Varsayılan,
            }).ToList();
        }
    }
}

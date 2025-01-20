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
    public class MaterialBll : BaseGenelBll<Material>,IBaseGenelBll, IBaseCommonBll
    {
        public MaterialBll() : base(KartTuru.Stok) { }

        public MaterialBll(Control ctrl) : base(ctrl, KartTuru.Stok) { }

        public override BaseEntity Single(Expression<Func<Material, bool>> filter)
        {
            return BaseSingle(filter, x => new MaterialS
            {
                Id = x.Id,
                Kod = x.Kod,
                StockCode=x.Kod,
                StockName=x.StockName,
                DepoId=x.DepoId,
                DepoKodu=x.Depo.Kod,
                DepoAdi=x.Depo.WarehouseName,
                UnitId=x.UnitId,
                UnitCode=x.Unit.Kod,
                UnitName=x.Unit.BirimAdi,
                UrunCinsi=x.UrunCinsi,
                Uretilebilir=x.Uretilebilir,
                MaxStockQty=x.MaxStockQty,
                MinStockQty=x.MinStockQty,

                Durum = x.Durum,

                Feature1Id = x.Feature1Id,
                Feature2Id = x.Feature2Id,
                Feature3Id = x.Feature3Id,
                Feature4Id = x.Feature4Id,
                Feature5Id = x.Feature5Id,
                Feature6Id = x.Feature6Id,
                Feature7Id = x.Feature7Id,
                Feature8Id = x.Feature8Id,
                Feature9Id = x.Feature9Id,
                Feature10Id = x.Feature10Id,
                Feature11Id = x.Feature11Id,
                Feature12Id = x.Feature12Id,
                Feature13Id = x.Feature13Id,
                Feature14Id = x.Feature14Id,
                Feature15Id = x.Feature15Id,
                Feature16Id = x.Feature16Id,
                Feature17Id = x.Feature17Id,
                Feature18Id = x.Feature18Id,
                Feature19Id = x.Feature19Id,
                Feature20Id = x.Feature20Id,
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Material, bool>> filter)
        {
            return BaseList(filter, x => new MaterialL
            {
                Id = x.Id,
                Kod = x.Kod,
                StockCode=x.Kod,
                StockName = x.StockName,
                DepoId=x.DepoId,
                DepoKodu = x.Depo.Kod,
                DepoAdi = x.Depo.WarehouseName,
                UnitId=x.UnitId,
                UnitCode = x.Unit.Kod,
                UnitName=x.Unit.BirimAdi,
                UrunCinsi = x.UrunCinsi,
                Uretilebilir = x.Uretilebilir,
                MaxStockQty=x.MaxStockQty,
                MinStockQty=x.MinStockQty,
                Feature1Id=x.Feature1Id,
                Feature2Id=x.Feature2Id,
                Feature3Id = x.Feature3Id,
                Feature4Id = x.Feature4Id,
                Feature5Id = x.Feature5Id,
                Feature6Id = x.Feature6Id,
                Feature7Id = x.Feature7Id,
                Feature8Id = x.Feature8Id,
                Feature9Id = x.Feature9Id,
                Feature10Id = x.Feature10Id,
                Feature11Id = x.Feature11Id,
                Feature12Id = x.Feature12Id,
                Feature13Id = x.Feature13Id,
                Feature14Id = x.Feature14Id,
                Feature15Id = x.Feature15Id,
                Feature16Id = x.Feature16Id,
                Feature17Id = x.Feature17Id,
                Feature18Id = x.Feature18Id,
                Feature19Id = x.Feature19Id,
                Feature20Id = x.Feature20Id,

                FeatureDescription1 =x.Feature1.Description,
                FeatureDescription2=x.Feature2.Description,
                FeatureDescription3 = x.Feature3.Description,
                FeatureDescription4 = x.Feature4.Description,
                FeatureDescription5 = x.Feature5.Description,
                FeatureDescription6 = x.Feature6.Description,
                FeatureDescription7 = x.Feature7.Description,
                FeatureDescription8 = x.Feature8.Description,
                FeatureDescription9 = x.Feature9.Description,
                FeatureDescription10 = x.Feature10.Description,
                FeatureDescription11 = x.Feature11.Description,
                FeatureDescription12 = x.Feature12.Description,
                FeatureDescription13 = x.Feature13.Description,
                FeatureDescription14 = x.Feature14.Description,
                FeatureDescription15 = x.Feature15.Description,
                FeatureDescription16 = x.Feature16.Description,
                FeatureDescription17 = x.Feature17.Description,
                FeatureDescription18 = x.Feature18.Description,
                FeatureDescription19 = x.Feature19.Description,
                FeatureDescription20 = x.Feature20.Description,

            }).OrderBy(x => x.Kod).ToList();
        }

    }    
}

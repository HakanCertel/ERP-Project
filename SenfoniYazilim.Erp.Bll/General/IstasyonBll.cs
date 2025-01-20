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
    public class IstasyonBll : BaseGenelBll<Istasyon>, IBaseGenelBll, IBaseCommonBll
    {
        public IstasyonBll( ) : base(KartTuru.Istasyon) {}

        public IstasyonBll(Control ctrl) : base(ctrl, KartTuru.Istasyon){}

        public override BaseEntity Single(Expression<Func<Istasyon, bool>> filter)
        {
            return BaseSingle(filter,x=> new IstasyonS
            {
                Id=x.Id,
                Kod=x.Kod,
                IstasyonAdi=x.IstasyonAdi,
                Aciklama=x.Aciklama,
                VardiyaId=x.Vardiya.Id,
                VardiyaSistemAdi=x.Vardiya.VardiyaAdi,
                Durum=x.Durum
            });
        }
        public override IEnumerable<BaseEntity> List(Expression<Func<Istasyon, bool>> filter)
        {
            return BaseList(filter, x => new IstasyonL
            {
                Id=x.Id,
                Kod=x.Kod,
                VardiyaId=x.VardiyaId,
                IstasyonAdi =x.IstasyonAdi,
                VardiyaSistemAdi=x.Vardiya.VardiyaAdi,
                VardiyaSayisi=x.Vardiya.VardiyaSayisi,
                //Kapasiteyi Tanımla...
            }).ToList();
        }
    }

}

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
    public class Istasyon_Makina_Personel_BilgileriBll:BaseHareketBll<Istasyon_Makina_Personel_Bilgileri,SenfoniErpContext>, IBaseHareketSelectBll<Istasyon_Makina_Personel_Bilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<Istasyon_Makina_Personel_Bilgileri, bool>> filter)
        {
            return List(filter, x => new Istasyon_Makina_Personel_BilgileriL
            {
                Id = x.Id,
                IstasyonId=x.IstasyonId,
                OperasyonId=x.OperasyonId,
                OperasyonAdi=x.Operasyon.OperasyonAdi,
                MakinaId=x.MakinaId,
                MakinaKodu=x.Makina.Kod,
                MakinaAdi=x.Makina.MakinaAdi,
                PersonelId=x.PersonelId,
                PersonelAdiSoyadi=x.Personel.Adi+" "+x.Personel.Soyadi,
                //KapasiteBagi=x.Makina.IsCapacityBasedWorker,
                Aciklama=x.Aciklama
            }).ToList();
        }
    }
}
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
    public class IstasyonOperasyonBilgileriBll: BaseHareketBll<IstasyonOperasyonBilgileri, SenfoniErpContext>, IBaseHareketSelectBll<IstasyonOperasyonBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<IstasyonOperasyonBilgileri, bool>> filter)
        {
            return List(filter, x => new IstasyonOperasyonBilgileriL
            {
                Id = x.Id,
                IstasyonId=x.IstasyonId,
                OperasyonId=x.OperasyonId,
                OperasyonKodu=x.Operasyon.Kod,
                OperasyonAdi=x.Operasyon.OperasyonAdi,
                MakinaId=x.MakinaId,
                MakinaKodu=x.Makina.Kod,
                MakinaAdi=x.Makina.MakinaAdi,
                Aciklama=x.Aciklama
            }).ToList();
        }
        public IEnumerable<BaseEntity> ReceteList(Expression<Func<IstasyonOperasyonBilgileri, bool>> filter)
        {
            return List(filter, x => new ReceteMakinaIstasyonBilgileriL
            {
                Id = x.Id,
                OperasyonId=x.OperasyonId,
                OperasyonAdi=x.Operasyon.OperasyonAdi,
                IstasyonId = x.IstasyonId,
                IstasyonKodu=x.Istasyon.Kod,
                IstasyonAdi=x.Istasyon.IstasyonAdi,
                MakinaId = x.MakinaId,
                MakinaKodu = x.Makina.Kod,
                MakinaAdi = x.Makina.MakinaAdi,
                Makina_MakinaElemenlari_Bilgileri=x.Istasyon.Makina_MakinaElemenlari_Bilgileri
            }).ToList();
        }
        public IEnumerable<BaseHareketEntity> CrpMakinaList(Expression<Func<IstasyonOperasyonBilgileri, bool>> filter)
        {
            var sonuc= List(filter, x => new MrpMakinaBilgileriL
            {
                IstasyonId = x.IstasyonId,
                IstasyonKodu = x.Istasyon.Kod,
                IstasyonAdi = x.Istasyon.IstasyonAdi,
                OperasyonId=x.OperasyonId,
                OperasyonAdi=x.Operasyon.OperasyonAdi,
                MakinaId = x.MakinaId,
                MakinaKodu = x.Makina.Kod,
                MakinaAdi = x.Makina.MakinaAdi,
                KapasiteIhtiyaci=0,
                DonemselKapasite=0
            })./*OrderBy(x => x.MakinaId).*/Distinct().ToList();
            return sonuc;
        }
        public IEnumerable<BaseEntity> OperasyonMakinaList(Expression<Func<IstasyonOperasyonBilgileri, bool>> filter)
        {
            return List(filter, x => new IstasyonOperasyonBilgileriBaseEntityL
            {
                Id = 0,
                OperasyonId = x.OperasyonId,
                OperasyonAdi = x.Operasyon.OperasyonAdi,
                IstasyonId = x.IstasyonId,
                IstasyonKodu = x.Istasyon.Kod,
                IstasyonAdi = x.Istasyon.IstasyonAdi,
                MakinaId = x.MakinaId,
                MakinaKodu = x.Makina.Kod,
                MakinaAdi = x.Makina.MakinaAdi,
                Makina_MakinaElemenlari_Bilgileri = x.Istasyon.Makina_MakinaElemenlari_Bilgileri,
            }).ToList();
        }

    }
}

using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
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
    public class MakinaKapasiteKullanımBilgileriBll : BaseHareketBll<MakinaKapasiteKullanımBilgileri, SenfoniErpContext>, IBaseHareketSelectBll<MakinaKapasiteKullanımBilgileri>
    {
        public  IEnumerable<BaseHareketEntity> List(Expression<Func<MakinaKapasiteKullanımBilgileri, bool>> filter)
        {
            return List(filter,x=> new 
            {
                makinaKapasiteKullanim=x,
                talepBilgi= TalepBilgi(x.TalepId),

            }).Select(x=> new MakinaKapasiteKullanımBilgileriL
            {
                Id=x.makinaKapasiteKullanim.Id,
                MakinaId=x.makinaKapasiteKullanim.MakinaId,
                PlanSira=x.makinaKapasiteKullanim.PlanSira,
                MrpBilgileriId=x.makinaKapasiteKullanim.MrpBilgileriId,
                MalzemeIhtiyacBilgiId=x.makinaKapasiteKullanim.MalzemeIhtiyacBilgiId,
                TalepId=x.makinaKapasiteKullanim.TalepId,
                TalepKodu=x.makinaKapasiteKullanim.TalepKodu,
                TalepStatusu=x.makinaKapasiteKullanim.TalepStatusu,
                StokId=x.makinaKapasiteKullanim.StokId,
                StokKodu=x.makinaKapasiteKullanim.Stok.Kod,
                StokAdi=x.makinaKapasiteKullanim.Stok.StockName,
                IsEmriKodu=x.makinaKapasiteKullanim.IsEmriKodu,
                IhtiyacTarihi=x.makinaKapasiteKullanim.IhtiyacTarihi,
                PlanlandigiTarihi=x.makinaKapasiteKullanim.PlanlandigiTarihi,
                PlanlananMiktar=x.makinaKapasiteKullanim.PlanlananMiktar,
                ToplamUretilenMiktar=x.makinaKapasiteKullanim.ToplamUretilenMiktar,
                KalanMiktar=x.makinaKapasiteKullanim.KalanMiktar,
                PlanlananBaslamaTarih=x.makinaKapasiteKullanim.PlanlananBaslamaTarih,
                PlanlananBitisTarihi=x.makinaKapasiteKullanim.PlanlananBitisTarihi,
                Kapandi=x.makinaKapasiteKullanim.Kapandi,
                CariId=x.talepBilgi.CurrentId,
                CariAdi=x.talepBilgi.CurrentName,
                KullaniciId=x.talepBilgi.UserId,
                KullaniciAdi=x.talepBilgi.UserName,
                PlasiyerId=x.talepBilgi.PlasiyerId,
                PlasiyerAdi=x.talepBilgi.PlasiyerName,
            }).OrderBy(x=>x.PlanSira);
        }
        private DemandInformationsMultiL TalepBilgi(long TalepId)
        {
            using (var bll = new ProductionDemandInformationsBll())
            {
                return bll.DemandInformationsList(x => x.DemandId == TalepId).SingleOrDefault().EntityCovert<DemandInformationsMultiL>();
            }
        }
    }
}

using SenfoniYazilim.Erp.Bll;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Bll.General.Company;
using SenfoniYazilim.Erp.Bll.General.PurchaseBll;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Dto.Company;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SenfoniYazilim.Erp.UI.Wİn.Functions
{
    public static class GetEntityOrListOfAnyTableFunction
    {
        public static RezervasyonBilgileriL RezervasyonBilgisi(long stokId, long? depoId)
        {
            using (var bll = new RezervasyonBilgileriBll())
            {
                return (RezervasyonBilgileriL)bll.Single(x => x.MaterialId == stokId && x.WarehouseId == depoId);
            }
        }
        public static MaterialS SingleStock(this long stokId)
        {
            using (var bll = new MaterialBll())
            {
                return (MaterialS)bll.Single(x => x.Id == stokId);
            }
        }
        public static WareHouseStockL SingleDepoStok(long stokId, long? depoId)
        {
            using (var bll = new WarehouseStockBll())
            {
                var entity = (WareHouseStockL)bll.Single(y => y.WareHouseId == depoId && y.MaterialId == stokId);

                if (entity == null)
                    return null;
                return entity;

            }
        }
        public static decimal? GetDefaultMaterialUnitPrice(long companyId, long materialId)
        {
            using (var bll = new CompanyPriceListBll())
            {
                var entity = bll.List(y => y.CompanyId == companyId && y.IsDefault).EntityListConvert<CompanyPriceListL>().FirstOrDefault();
                if (entity == null) return null;
                var defaultPrice = entity.PriceListItems.Where(x => x.MaterialId == materialId)?.FirstOrDefault().ItemPrice;

                return defaultPrice;
            }
        }
        public static CompanyRelatedMaterialsL GetCompanyRelatedMaterial(long companyId, long materialId)
        {
            using (var bll = new CompanyRelatedMaterialsBll())
            {
                return bll.List(y => y.CompanyId == companyId && y.MaterialId==materialId)?.EntityListConvert<CompanyRelatedMaterialsL>().FirstOrDefault();
            }
        }
        
        public static CariS GetCompany(long companyId)
        {
            using (var bll = new CariBll())
            {
                return (CariS)bll.Single(y => y.Id == companyId );
            }
        }
        public static IstasyonS SingleIstasyon(long istasyonId)
        {
            using (var bll = new IstasyonBll())
            {
                return bll.Single(x => x.Id == istasyonId).EntityCovert<IstasyonS>();
            }
        }
        public static Vardiya SingleVardiya(long vardiyaId)
        {
            using (var bll = new VardiyaBll())
            {
                return bll.Single(x => x.Id == vardiyaId).EntityCovert<Vardiya>();
            }
        }
        public static TatilBilgileri SingleTatilBilgileri(DateTime tarih)
        {
            using (var bll = new TatilBilgileriBll())
            {
                return bll.BaseSingle<TatilBilgileri>(x => x.Tarih == tarih, x => x);
            }
        }
        public static Kdv AnyTaxRateS ()
        {
            using (var bll = new KdvBll())
            {
                return bll.List(x => x.Durum).EntityListConvert<Kdv>().FirstOrDefault();
            }
        }
        public static DovizBilgileri AnyCurrencyS()
        {
            using (var bll = new DovizBilgileriBll())
            {
                return bll.List(x => x.Durum).EntityListConvert<DovizBilgileri>().FirstOrDefault();
            }
        }
        public static Language AnyLanguageS(Expression<Func<Language,bool>> filter=null)
        {
            using (var bll = new LanguageBll())
            {
                return bll.List(filter,x=>x).EntityListConvert<Language>().FirstOrDefault();
            }
        }
        public static PaymentMethodItems AnyPaymentMethodS(Expression<Func<PaymentMethodItems, bool>> filter = null)
        {
            using (var bll = new PaymentMethodItemsBll())
            {
                return bll.List(filter, x => x)?.FirstOrDefault();
            }
        }
        public static DemandInformationsMultiL TalepBilgi(long TalepId)
        {
            using (var bll = new ProductionDemandInformationsBll())
            {
                return bll.DemandInformationsList(x => x.DemandId == TalepId).SingleOrDefault().EntityCovert<DemandInformationsMultiL>();
            }
        }
        public static IEnumerable<WareHouseStocks> ListDepoStok(Expression<Func<WareHouseStocks, bool>> filter=null)
        {
            return InstanceBaseHareketEntityBll<WareHouseStocks,WarehouseStockBll>.ListBaseHareketEntity<WareHouseStocks>(filter,x=>x);
        }
        public static List<VardiyaBilgileriLastVersionL> ListVardiyaBilgileri(long vardiyaId)
        {
            using (var bll = new VardiyaBilgileriLastVersionBll())
            {
                return bll.List(x => x.VardiyaId == vardiyaId)?.Cast<VardiyaBilgileriLastVersionL>().ToList();
            }
        }
        public static List<Kdv> ListTaxRate(Expression<Func<Kdv, bool>> filter)
        {
            return InstanceBaseEntityBll<Kdv>.ListBaseEntity<KdvBll>(null).Select(x => x).ToList();

            //using (var bll = new KdvBll())
            //{
            //    return bll.List(filter).ToList();
            //}
        }
        public static List<DovizBilgileri> ListCurrencyItems(Expression<Func<DovizBilgileri, bool>> filter=null)
        {
            return InstanceBaseEntityBll<DovizBilgileri>.ListBaseEntity<DovizBilgileriBll>(filter).Select(x => x).ToList();
        }
        public static IEnumerable<Language> ListLanguages(Expression<Func<Language, bool>> filter = null)
        {
            //return InstanceBaseHareketEntityBll<Language, LanguageBll>.ListBaseHareketEntity<Language>(filter, x => x);
            using (var bll = new LanguageBll())
            {
                return bll.List(filter,x=>x).ToList();
            }
        }
        public static List<Birim> ListUnitItems(Expression<Func<Birim, bool>> filter=null)
        {
            return InstanceBaseEntityBll<Birim>.ListBaseEntity<BirimBll>(filter).Select(x => x).ToList();
        }
        public static IEnumerable<CompanyContactL> ListCompanyContactItems(long companyId)
        {
            using (var bll = new CompanyContactBll())
            {
                return bll.List(y => y.CompanyId == companyId,x=>x )?.EntityListConvert<CompanyContactL>();
            }
        }
        public static IEnumerable<PurchaseDemandItems> ListPurchaseDemanItems(Expression<Func<PurchaseDemandItems, bool>> filter = null)
        {
            using (var bll = new PurchaseDemandItemsTableBll())
            {
                return bll.List(filter, x => x)?.EntityListConvert<PurchaseDemandItems>();
            }
        }
       
        public static IEnumerable<EvrakTurleriL> ListDocumentTypeItems(Expression<Func<EvrakTurleri, bool>> filter = null)
        {
            using (var bll = new EvrakTurleriBll())
            {
                return bll.List(filter, x => x).EntityListConvert<EvrakTurleriL>();
            }
        }
        public static IEnumerable<PaymentMethodItemsL> ListPaymentMethodItems(Expression<Func<PaymentMethodItems, bool>> filter = null)
        {
            using (var bll = new PaymentMethodItemsBll())
            {
                return bll.List(filter, x => x).EntityListConvert<PaymentMethodItemsL>();
            }
        }
        
        public static List<Packaging> ListPackagingItems(Expression<Func<Packaging, bool>> filter = null)
        {
            using (var bll = new PackagingBll())
            {
                return bll.List(filter, x => x).ToList();
            }
        }

    }
}

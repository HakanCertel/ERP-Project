using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Bll.General.Company;
using SenfoniYazilim.Erp.Bll.General.CRP;
using SenfoniYazilim.Erp.Bll.General.PurchaseBll;
using SenfoniYazilim.Erp.Bll.General.SalesBll;
using SenfoniYazilim.Erp.Bll.General.WarehouseBll;
using SenfoniYazilim.Erp.Bll.General.WayBillBll;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Dto.Company;
using SenfoniYazilim.Erp.Model.Dto.CRPDto;
using SenfoniYazilim.Erp.Model.Dto.WayBillDto;
using SenfoniYazilim.Erp.Model.Dto.SalesDto;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Company;
using SenfoniYazilim.Erp.Model.Entities.Company.CompanySetting;
using SenfoniYazilim.Erp.Model.Entities.CRP;
using SenfoniYazilim.Erp.Model.Entities.WayBillEntities;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using SenfoniYazilim.Erp.Model.Entities.Satınalma.PurchaseSettingsEntites;
using SenfoniYazilim.Erp.Model.Entities.WareHouseEntities;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SenfoniYazilim.Erp.Model.Dto.PriceListDto;
using SenfoniYazilim.Erp.Model.Entities.PriceListEntities;
using SenfoniYazilim.Erp.Bll.General.PriceListBll;

namespace SenfoniYazilim.Erp.Bll.Functions
{
    public static class GetAnySingleOrListBll
    {
        #region Purchase
            public static PurchaseDemandItems GetPurchaseDemandItem(Expression<Func<PurchaseDemandItems, bool>> filter = null)
            {
                using (var bll = new PurchaseDemandItemsFormBll())
                {
                    return bll.BaseSingle(filter, x => x);
                }
            }
        public static IEnumerable<PurchaseDemandItemsL> ListPurchaseDemandItem(Expression<Func<PurchaseDemandItems, bool>> filter = null)
        {
            using (var bll = new PurchaseDemandItemsFormBll())
            {
                return bll.List(filter).EntityListConvert<PurchaseDemandItemsL>();
            }
        }
        public static PurchaseOfferItems GetPurchaseOfferItem(Expression<Func<PurchaseOfferItems, bool>> filter = null)
        {
            using (var bll = new PurchaseOfferItemsBll())
            {
                return bll.BaseSingle(filter,x=>x);
            }
        }
        public static IEnumerable<PurchaseOfferItemL> ListPurchaseOfferItem(Expression<Func<PurchaseOfferItems, bool>> filter = null)
        {
            using (var bll = new PurchaseOfferItemsBll())
            {
                return bll.List(filter).EntityListConvert<PurchaseOfferItemL>();
            }
        }
        public static IEnumerable<PurchaseOrderItemsL> ListPurchaseOrderItems(Expression<Func<PurchaseOrderItems, bool>> filter = null)
            {
                using (var bll=new PurchaseOrderItemsBll())
                {
                    return bll.List(filter).EntityListConvert<PurchaseOrderItemsL>();
                }
            }
            public static PurchaseOrderItems GetPurchaseOrderItem(Expression<Func<PurchaseOrderItems, bool>> filter = null)
            {
                using (var bll = new PurchaseOrderItemsBll())
                {
                    return bll.BaseSingle(filter, x => x);
                }
            }
            public static IEnumerable<PurchaseWayBillItemsL> ListPurchaseWayBillItems(Expression<Func<PurchaseWayBillItems, bool>> filter = null)
            {
                using (var bll = new PurchaseWayBillItemsBll())
                {
                    return bll.List(filter).EntityListConvert<PurchaseWayBillItemsL>();
                }
            }
        #endregion

        #region Sales
        public static IEnumerable<DispatchWayBillItemsL> ListDispatchWayBillItems(Expression<Func<DispatchWayBillItems, bool>> filter = null)
        {
            using (var bll = new DispatchWayBillItemsBll())
            {
                return bll.List(filter).EntityListConvert<DispatchWayBillItemsL>();
            }
        }
        public static SalesOfferS GetSaleOffer(Expression<Func<SalesOffer, bool>> filter = null)
        {
            using (var bll=new SalesOfferBll())
            {
                return (SalesOfferS)bll.Single(filter);
            }
        }
            public static List<BaseHareketEntity> ListSalesOfferItems(Expression<Func<SalesOfferItems, bool>> filter = null)
        {
            using (var bll = new SalesOfferItemsBll())
            {
                return bll.List(filter).ToList();
            }
        }
            public static List<BaseHareketEntity> ListSalesItems(Expression<Func<SalesItems, bool>> filter = null)
        {
            using (var bll = new SalesItemsBll())
            {
                return bll.List(filter).ToList();
            }
        }
        public static SalesItems GetSaleItemL(Expression<Func<SalesItems, bool>> filter = null)
        {
            using (var bll = new SalesItemsBll())
            {
                return bll.BaseSingle(filter,x=>x).EntityCovert<SalesItems>();
            }
        }
        #endregion
        public static RezervasyonBilgileriL RezervasyonBilgisi(Expression<Func<RezervasyonBilgileri, bool>> filter = null)
        {
            using (var bll = new RezervasyonBilgileriBll())
            {
                return bll.BaseSingle(filter,x=>x).EntityCovert<RezervasyonBilgileriL>();
            }
        }
        public static IEnumerable<RezervasyonBilgileriL> ListRezervasyonBilgisi(Expression<Func<RezervasyonBilgileri, bool>> filter=null)
        {
            using (var bll = new RezervasyonBilgileriBll())
            {
                return bll.List(filter).EntityListConvert<RezervasyonBilgileriL>();
            }
        }
        public static MaterialS GetMaterial(Expression<Func<Material, bool>> filter)
        {
            return InstanceBaseEntityBll<Material>
                .SingleBaseEntity<Material, MaterialBll>(filter, x => x).EntityCovert<MaterialS>();
        }

        public static MaterialS SingleStock(this long stokId)
        {
            using (var bll = new MaterialBll())
            {
                return (MaterialS)bll.Single(x => x.Id == stokId);
            }
        }

        public static WareHouseStockL SingleWarehouseStock(long stokId, long? depoId)
        {
            using (var bll = new WarehouseStockBll())
            {
                return  (WareHouseStockL)bll.Single(y => y.WareHouseId == depoId && y.MaterialId == stokId);
            }
        }

        public static bool UpdateWarehouseStock(List<WareHouseStockL> whmList)
        {
            if (whmList == null) return false;

            using (var bll = new WarehouseStockBll())
            {
                var warehouseItems = new List<WareHouseStockL>();

                whmList.ForEach(x =>
                {
                    var item = SingleWarehouseStock(x.MaterialId, x.WareHouseId);
                    if (item != null)
                    {
                        item.Update = true;
                        item.Quantity = item.Quantity+x.Quantity;
                        warehouseItems.Add(item);
                    }
                    else
                    {
                        var warehouseItem = new WareHouseStockL
                        {
                            MaterialId = x.MaterialId,
                            WareHouseId = x.WareHouseId,
                            UnitId=x.UnitId,
                            Quantity = x.Quantity,
                            Insert = true
                        };
                        warehouseItems.Add(warehouseItem);
                    }
                });
                return bll.Update(warehouseItems.Where(x=>x.Update).Cast<BaseHareketEntity>().ToList())
                    && bll.Insert(warehouseItems.Where(x => x.Insert).Cast<BaseHareketEntity>().ToList());
            }
        }

        public static WarehouseSettings GetWarehouseSetting(Expression<Func<WarehouseSettings, bool>> filter=null)
        {
            using (var bll=new WarehouseSettingsBll())
            {
                return bll.BaseSingle(filter, x => x);
            }
        }

        public static IEnumerable<TarnsferItemsBetweenWareHousesL> ListTarnsferItemsBetweenWareHouses(Expression<Func<TransferItemsBetweenWareHouses, bool>> filter = null)
        {
            using (var bll=new TarnsferItemsBetweenWareHousesBll())
            {
                return bll.List(filter).EntityListConvert<TarnsferItemsBetweenWareHousesL>();
            }
        }

        public static bool InsertStokHareketleri(List<BaseHareketEntity> hareketList)
        {
            using (var bll = new StokHareketleriBll())
            {
                return bll.Insert(hareketList);
            }
        }

        public static List<CompanyPriceListL> ListCompanyPriceList(Expression<Func<CompanyPriceList,bool>> filter)
        {
            using (var bll=new CompanyPriceListBll())
            {
                return bll.List(filter)?.EntityListConvert<CompanyPriceListL>()?.ToList();
            }
        }
        public static IEnumerable<PriceListItemsL> ListPriceListItems(Expression<Func<PriceListItems, bool>> filter)
        {
            using (var bll = new PriceListItemsBll())
            {
                return bll.List(filter).EntityListConvert<PriceListItemsL>();
            }
        }
        public static decimal? GetDefaultMaterialUnitPrice(long companyId, long materialId)
        {
            using (var bll = new CompanyPriceListBll())
            {
                var entity = bll.List(y => y.CompanyId == companyId && y.IsDefault).EntityListConvert<CompanyPriceListL>().FirstOrDefault();
                if (entity == null) return null;
                var defaultPrice = entity.PriceListItems.Where(x => x.MaterialId == materialId)?.FirstOrDefault()?.ItemPrice;

                return defaultPrice;
            }
        }

        public static CompanyContactL GetCompanyContactItem(Expression<Func<CompanyContact,bool>> filter)
        {
            using (var bll = new CompanyContactBll())
            {
                return bll.BaseSingle(filter, x => x)?.EntityCovert<CompanyContactL>();
            }
        }
        public static AddressItemsL GetCompanyAddressItem(Expression<Func<AddressItems, bool>> filter)
        {
            using (var bll = new AddressItemsBll())
            {
                return bll.BaseSingle(filter, x => x)?.EntityCovert<AddressItemsL>();
            }
        }
        public static CompanyRelatedMaterialsL GetMaterialRelatedCompany(Expression<Func<CompanyRelatedMaterials, bool>> filter)
        {
            using (var bll = new CompanyRelatedMaterialsBll())
            {
                return bll.List(filter)?.EntityListConvert<CompanyRelatedMaterialsL>().FirstOrDefault();
            }
        }

        public static PurchaseSettings GetPurchaseSettings(Expression<Func<PurchaseSettings, bool>> filter)
        {
            using (var bll = new PurchaseSettingsBll())
            {
                return (PurchaseSettings)bll.Single(filter);
            }
        }
        public static CariS GetCompany(long companyId)
        {
            using (var bll = new CariBll())
            {
                return (CariS)bll.Single(y => y.Id == companyId);
            }
        }
        public static IstasyonS SingleIstasyon(Expression<Func<Istasyon, bool>> filter = null)
        {
            using (var bll = new IstasyonBll())
            {
                return bll.Single(filter).EntityCovert<IstasyonS>();
            }
        }

        public static Vardiya SingleVardiya(Expression<Func<Vardiya, bool>> filter = null)
        {
            using (var bll = new VardiyaBll())
            {
                return bll.Single(filter).EntityCovert<Vardiya>();
            }
        }

        public static TatilBilgileri SingleTatilBilgileri(DateTime tarih)
        {
            using (var bll = new TatilBilgileriBll())
            {
                return bll.BaseSingle<TatilBilgileri>(x => x.Tarih == tarih, x => x);
            }
        }

        public static Kdv AnyTaxRateS()
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

        public static Language AnyLanguageS(Expression<Func<Language, bool>> filter = null)
        {
            using (var bll = new LanguageBll())
            {
                return bll.List(filter, x => x).EntityListConvert<Language>().FirstOrDefault();
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
        
        #region ProductionManagment

        public static ReceteS GetRecete(Expression<Func<Recete, bool>> filter = null)
        {
            using (var bll=new ReceteBll())
            {
                return bll.Single(filter).EntityCovert<ReceteS>();
            }
            //return InstanceBaseEntityBll<Recete>
            //    .SingleBaseEntity<Recete, ReceteBll>(filter, x => x)
            //    ?.EntityCovert<ReceteS>();
        }

        public static IEnumerable<ReceteL> ListRecete(Expression<Func<Recete, bool>> filter = null)
        {
            return InstanceBaseEntityBll<Recete>
                .ListBaseEntity<ReceteBll>(filter)
                ?.EntityListConvert<ReceteL>();
        }

        public static ReceteOperasyonBilgileriL GetReceteOperasyonBilgi(Expression<Func<ReceteOperasyonBilgileri, bool>> filter = null)
        {
            return InstanceBaseHareketEntityBll<ReceteOperasyonBilgileri, ReceteOperasyonBilgileriBll>
                .SingleBaseHareketEntity<ReceteOperasyonBilgileri>(filter, x => x)
                .EntityCovert<ReceteOperasyonBilgileriL>();
        }

        public static IEnumerable<ReceteOperasyonBilgileri> ListReceteOperasyonBilgileri(Expression<Func<ReceteOperasyonBilgileri, bool>> filter = null)
        {
            return InstanceBaseHareketEntityBll<ReceteOperasyonBilgileri, ReceteOperasyonBilgileriBll>
                .ListBaseHareketEntity<ReceteOperasyonBilgileri>(filter, x => x);

        }

        public static List<ReceteOperasyonMakinaBilgileri> ListReceteMakineBilgileri(Expression<Func<ReceteOperasyonMakinaBilgileri, bool>> filter = null)
        {
            return InstanceBaseHareketEntityBll<ReceteOperasyonMakinaBilgileri, ReceteOperasyonMakinaBilgileriBll>
                .ListBaseHareketEntity(filter, x => x).ToList();

        }

        public static IEnumerable<ReceteBilgileri> ListBOM(Expression<Func<ReceteBilgileri, bool>> filter = null)
        {
            return InstanceBaseHareketEntityBll<ReceteBilgileri, ReceteBilgileriBll>
                .ListBaseHareketEntity<ReceteBilgileri>(filter, x => x);
        }

        public static MalzemeIhtiyacBilgileriL GetMalzemeIhtiyacBilgileri(Expression<Func<MalzemeIhtiyacBilgileri, bool>> filter = null)
        {
            using (var bll = new MalzemeIhtiyacBilgileriBll())
            {
                return bll.BaseSingle(filter,x=>x).EntityCovert<MalzemeIhtiyacBilgileriL>();
            }
        }

        public static IEnumerable<MalzemeIhtiyacBilgileriL> ListMalzemeIhtiyacBilgileri(Expression<Func<MalzemeIhtiyacBilgileri, bool>> filter = null)
        {
            using (var bll=new MalzemeIhtiyacBilgileriBll())
            {
                return bll.List(filter).EntityListConvert<MalzemeIhtiyacBilgileriL>();
            }
        }

        public static IEnumerable< Istasyon_Makina_Personel_BilgileriL> ListIstasyonMakinePersonel(Expression<Func<Istasyon_Makina_Personel_Bilgileri, bool>> filter = null)
        {
            using (var bll = new Istasyon_Makina_Personel_BilgileriBll())
            {
                return bll.List(filter).EntityListConvert<Istasyon_Makina_Personel_BilgileriL>();
            }
        }

        public static KapasiteIhtiyacBilgileriL GetKapasiteIhtiyacBilgileri(Expression<Func<KapasiteIhtiyacBilgileri, bool>> filter = null)
        {
            using (var bll = new KapasiteIhtiyacBilgileriBll())
            {
                return bll.BaseSingle(filter, x => x).EntityCovert<KapasiteIhtiyacBilgileriL>();
            }
        }
        public static PlanlanmisMalzemeKalemleriL GetPlanlanmisMalzemeKalemleri(Expression<Func<PlanlanmisMalzemeKalemleri, bool>> filter = null)
        {
            using (var bll = new PlanlanmisMalzemeKalemleriBll())
            {
                return bll.BaseSingle(filter, x => x).EntityCovert<PlanlanmisMalzemeKalemleriL>();
            }
        }
        public static IEnumerable< PlanlanmisMalzemeKalemleriL> ListPlanlanmisMalzemeKalemleri(Expression<Func<PlanlanmisMalzemeKalemleri, bool>> filter = null)
        {
            using (var bll = new PlanlanmisMalzemeKalemleriBll())
            {
                return bll.List(filter).EntityListConvert<PlanlanmisMalzemeKalemleriL>();
            }
        }

        public static WorkOrdersL GetWorkOrder(Expression<Func<WorkOrders, bool>> filter = null)
        {
            using (var bll=new WorkOrdersBll())
            {
                return bll.BaseSingle(filter, x => x).EntityCovert<WorkOrdersL>();
            }
        }

        public static IEnumerable<WorkOrderMaterialItemsL> ListWorkOrderMaterialItems(Expression<Func<WorkOrderMaterialItems, bool>> filter = null)
        {
            using (var bll = new WorkOrderMaterialItemsBll())
            {
                return bll.List(filter).EntityListConvert<WorkOrderMaterialItemsL>();
            }
        }

        #endregion
        public static IEnumerable<WareHouseStocks> ListDepoStok(Expression<Func<WareHouseStocks, bool>> filter = null)
        {
            return InstanceBaseHareketEntityBll<WareHouseStocks, WarehouseStockBll>.ListBaseHareketEntity<WareHouseStocks>(filter, x => x);
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
        public static List<WareHouse> ListWarehouses(Expression<Func<WareHouse, bool>> filter = null)
        {
            return InstanceBaseEntityBll<WareHouse>.ListBaseEntity<WareHouseBll>(filter).Select(x => x).ToList();
        }
        public static List<DovizBilgileri> ListCurrencyItems(Expression<Func<DovizBilgileri, bool>> filter = null)
        {
            return InstanceBaseEntityBll<DovizBilgileri>.ListBaseEntity<DovizBilgileriBll>(filter).Select(x => x).ToList();
        }
        public static IEnumerable<Language> ListLanguages(Expression<Func<Language, bool>> filter = null)
        {
            //return InstanceBaseHareketEntityBll<Language, LanguageBll>.ListBaseHareketEntity<Language>(filter, x => x);
            using (var bll = new LanguageBll())
            {
                return bll.List(filter, x => x).ToList();
            }
        }
        public static List<Birim> ListUnitItems(Expression<Func<Birim, bool>> filter = null)
        {
            return InstanceBaseEntityBll<Birim>.ListBaseEntity<BirimBll>(filter).Select(x => x).ToList();
        }
        public static IEnumerable<DefinationItems> ListDefinations(Expression<Func<Definations, bool>> filter = null)
        {
            using (var bll = new DefinationsBll())
            {
                 var list=bll.List(filter, x => x).EntityListConvert<DefinationItems>();
                return list;
            }
        }
        public static IEnumerable<FeatureL> ListFeatures(Expression<Func<Features, bool>> filter = null)
        {
            using (var bll = new FeaturesBll())
            {
                var list = bll.List(filter, x => x).EntityListConvert<FeatureL>();
                return list;
            }
        }
        public static FeatureL GetFeatures(Expression<Func<Features, bool>> filter = null)
        {
            using (var bll = new FeaturesBll())
            {
                var entity = bll.BaseSingle(filter, x => x).EntityCovert<FeatureL>();
                return entity;
            }
        }
        public static IEnumerable<CompanyContact> ListCompanyContactItems(Expression<Func<CompanyContact, bool>> filter)
        {
            using (var bll = new CompanyContactBll())
            {
                return bll.List(filter, x => x)?.EntityListConvert<CompanyContact>();
            }
        }
        public static IEnumerable<EvrakTurleriL> ListDocumentTypeItems(Expression<Func<EvrakTurleri, bool>> filter = null)
        {
            using (var bll = new EvrakTurleriBll())
            {
                return bll.List(filter, x => x).EntityListConvert<EvrakTurleriL>();
            }
        }
        public static IEnumerable<CompanyRelatedMaterialsL> ListMaterialRelatedCompany(Expression<Func<CompanyRelatedMaterials, bool>> filter)
        {
            using (var bll = new CompanyRelatedMaterialsBll())
            {
                return bll.List(filter)?.EntityListConvert<CompanyRelatedMaterialsL>();
            }
        }
        public static IEnumerable<AddressItems>  ListCompanyAddressItem(Expression<Func<AddressItems, bool>> filter)
        {
            using (var bll = new AddressItemsBll())
            {
                return bll.List(filter, x => x).EntityListConvert<AddressItems>();
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
        public static bool DeleteSalesOfferItems(List<BaseHareketEntity> items)
        {
            return InstanceBaseHareketEntityBll<SalesOfferItems, SalesOfferItemsBll>.DeleteEntites(items);
        }

    }
}

using System;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Satınalma;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using System.Linq;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using SenfoniYazilim.Erp.Bll.General.SalesBll;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using System.Collections.Generic;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.PurchaseDemandForms
{
    public partial class PurchaseDemanEditForm : BaseEditForm
    {
        public PurchaseDemanEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new PurchaseDemandBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.SatinalmaTalep;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new SatinalmaTalep() : ((PurchaseDemandBll)Bll).Single(FilterFunctions.Filter<SatinalmaTalep>(Id));

            NesneyiKontrollereBagla();

            if (BaseIslemTuru == IslemTuru.EntityInsert)
            {
                Id = BaseIslemTuru.IdOlustur(OldEntity);
                txtKod.Text = ((PurchaseDemandBll)Bll).YeniKodVer("STT");
                txtEvrakTarihi.EditValue=DateTime.Now;
            }

            TabloYukle();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SatinalmaTalep)OldEntity;

            txtKod.Text = entity.Kod;
            txtEvrakTarihi.EditValue = entity.DocumentDate;
            txtAciklama.Text = entity.DemandDescription;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
           // DateTime? guncelTarih = null;

            CurrentEntity = new SatinalmaTalep
            {
                Id = Id,
                Kod = txtKod.Text,
                DocumentDate = txtEvrakTarihi.DateTime,
                DemandDescription = txtAciklama.Text,
                RecordDate=IslemTuru.EntityInsert==BaseIslemTuru?DateTime.Now:((SatinalmaTalep)OldEntity).RecordDate,
                CreatorId= IslemTuru.EntityInsert == BaseIslemTuru?AnaForm.KullaniciId: ((SatinalmaTalep)OldEntity).CreatorId,
                UpdatingId= AnaForm.KullaniciId,
                UpdatingDate=((SatinalmaTalep)OldEntity).UpdatingDate,
                Durum= tglDurum.IsOn,
            };

            ButonEnabledDurumu();
        }

        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;
           Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity ,satinalmaTalepEditFormTable.TableValueChanged);
        }
        protected override void TabloYukle()
        {
            satinalmaTalepEditFormTable.OwnerForm = this;
            satinalmaTalepEditFormTable.Yukle();
        }
        protected override bool EntityInsert()
        {
            var veri = satinalmaTalepEditFormTable.Tablo.DataController.ListSource;

            if (satinalmaTalepEditFormTable.HatalıGiriş()) return false;

            ((SatinalmaTalep)CurrentEntity).UpdatingDate = DateTime.Now;

            var result = ((PurchaseDemandBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod) && satinalmaTalepEditFormTable.Kaydet();
            
            #region OtherProccess
            if (result && SelectedEntities != null)
            {
                if (DataSourceCardType == KartTuru.SalesItems)
                {
                    var demandList = GetAnySingleOrListBll.ListPurchaseDemandItem(x => x.OwnerFormId == Id);
                    var datasourceItemIds = demandList.Select(x => x.DataSourceItemId);
                    var saleItems = SelectedEntities.Cast<SalesItems>()
                        .Where(x=>datasourceItemIds.Contains(x.Id)).ToList();

                    saleItems.ForEach(x =>
                    {
                        x.SaleProccessStatus = SaleProccessStatus.CreatedPurchaseDemand;
                        x.PurchaseDemanItemId = demandList.Where(y => y.DataSourceItemId == x.Id).FirstOrDefault().Id;
                    });

                    InstanceBaseHareketEntityBll<SalesItems, SalesItemsBll>.UpdateEntities(saleItems.Cast<BaseHareketEntity>().ToList());
                }
                else if (DataSourceCardType == KartTuru.MaterialRequirmentPlaning)
                {
                    var demandList = GetAnySingleOrListBll.ListPurchaseDemandItem(x => x.OwnerFormId == Id);
                    var datasourceItemIds = demandList.Select(x => x.DataSourceItemId);
                    var mrpItems = SelectedEntities.Cast<MalzemeIhtiyacBilgileriL>()
                        .Where(x => datasourceItemIds.Contains(x.Id)).ToList();

                    mrpItems.ForEach(x =>
                    {
                        x.MrpProccessStatus = MrpProccessStatus.CreatedPurchaseDemand;
                        x.PurchaseDemandItemId = demandList.Where(y => y.DataSourceItemId == x.Id).FirstOrDefault().Id;
                    });

                    InstanceBaseHareketEntityBll<MalzemeIhtiyacBilgileri, MalzemeIhtiyacBilgileriBll>.UpdateEntities(mrpItems.Cast<BaseHareketEntity>().ToList());
                }
            }
            #endregion


            return result;
        }
        protected override bool EntityUpdate()
        {
            if (satinalmaTalepEditFormTable.HatalıGiriş()) return false;

            var result = ((PurchaseDemandBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod) && satinalmaTalepEditFormTable.Kaydet();

            return result;
        }

        protected override void EntityDelete()
        {
            var result=satinalmaTalepEditFormTable.Tablo.DataController.ListSource.Cast<PurchaseDemandItemsL>()
                .Any(x => x.IsComfirmed && x.IsCreatedOrder && x.IsTopDemandExisted);

            if (result)
            {
                Messages.UyariMesaji("Hareket Görmüş Kalemler Var. Kayıt Silinemez.");
                return;
            }

            satinalmaTalepEditFormTable.TopluHareketSil();

            if (!satinalmaTalepEditFormTable.Kaydet()) return;

            base.EntityDelete();

            var source = satinalmaTalepEditFormTable.Tablo.DataController.ListSource
                .Cast<PurchaseDemandItemsL>().Where(x => !x.Insert).ToList();
            if (source.Count != 0 && source.Any(x => x.DataSourceCardType == KartTuru.MaterialRequirmentPlaning))
            {
                var mibL = new List<MalzemeIhtiyacBilgileriL>();
                source.ForEach(x =>
                {
                    var mib = GetAnySingleOrListBll.GetMalzemeIhtiyacBilgileri(y => y.PurchaseDemandItemId == x.Id);
                    if (mib != null)
                    {
                        mib.PurchaseDemandItemId = null;
                        mib.MrpProccessStatus = MrpProccessStatus.NoProccess;
                        mibL.Add(mib);
                    }
                });
                InstanceBaseHareketEntityBll<MalzemeIhtiyacBilgileri, MalzemeIhtiyacBilgileriBll>.UpdateEntities(mibL.Cast<BaseHareketEntity>().ToList());

            }
        }

        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
                if (sender is MyToogleSwitch)
                {
                    satinalmaTalepEditFormTable.Tablo.DataController
                        .ListSource?.Cast<PurchaseDemandItemsL>()
                        .ToList().ForEach(x => { x.IsActive = !x.IsActive; x.Update = true; });
                }
            base.Control_EditValueChanged(sender, e);
        }

    }
}
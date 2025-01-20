using System;
using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using DevExpress.XtraPrinting.Native;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UrunTalepForms
{
    public partial class ProductionDemandEditForm : BaseEditForm
    {
        public ProductionDemandEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new ProductionDemandBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.ProductionDemand;
            EventsLoad();

            KayitSonrasiFormuKapat = false;
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new ProductionDemandS() : ((ProductionDemandBll)Bll).Single(FilterFunctions.Filter<ProductionDemand>(Id));

            if (IslemTuru.EntityInsert == BaseIslemTuru && (productionDemandTable.Tablo.GridControl.DataSource != null))
            {
                Id = BaseIslemTuru.IdOlustur(OldEntity);
                txtKod.Text = ((ProductionDemandBll)Bll).YeniKodVer("PRD");
                TabloYukle();
                TarihAyarla();
                return;
            }

            NesneyiKontrollereBagla();

            BagliTabloYukle();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ProductionDemandBll)Bll).YeniKodVer("PRD");
            txtKod.Focus();
            TarihAyarla();

            void TarihAyarla()
            {
                txtIslemTarihi.DateTime = DateTime.Now.Date;
                txtIslemTarihi.Properties.MinValue = DateTime.Now.Date;
                txtTeslimTarihi.DateTime = DateTime.Now.Date;
                txtTeslimTarihi.Properties.MinValue = DateTime.Now.Date;
            }
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (ProductionDemandS)OldEntity;

            txtKod.Text = entity.Kod;
            txtIslemTarihi.DateTime = entity.OperationDate;
            txtTeslimTarihi.DateTime = entity.DeliveryDate;
            txtAciklama.Text = entity.Description;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new ProductionDemand
            {
                Id = Id,
                Kod = txtKod.Text,
                UserId = AnaForm.KullaniciId,
                OperationDate = txtIslemTarihi.DateTime,
                DeliveryDate = txtTeslimTarihi.DateTime,
                Description = txtAciklama.Text,
            };

            ButonEnabledDurumu();
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (productionDemandTable != null && productionDemandTable.TableValueChanged) return true;
                return false;
            }

            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial, OldEntity, CurrentEntity, TableValueChanged());
        }
        protected override bool EntityInsert()
        {
            GuncelNesneOlustur();
            if (productionDemandTable.HatalıGiriş()) return false;

            var result = ((ProductionDemandBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod) && productionDemandTable.Kaydet();

            if (result && !KayitSonrasiFormuKapat)
                productionDemandTable.Yukle();

            return result;
        }
        protected override bool EntityUpdate()
        {
            GuncelNesneOlustur();

            if (productionDemandTable.HatalıGiriş()) return false;

            var result = ((ProductionDemandBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod) && productionDemandTable.Kaydet();

            if (result && !KayitSonrasiFormuKapat)
                productionDemandTable.Yukle();

            return result;
        }
        protected override void EntityDelete()
        {
            if (!productionDemandTable.TopluHareketSil()) return;

            base.EntityDelete();
        }
        protected override void TabloYukle()
        {
            if (productionDemandTable.Tablo.DataRowCount > 0)
            {
                var source = productionDemandTable.Tablo.DataController.ListSource.Cast<ProductionDemandInformationsL>();
                source.ForEach(x =>
                {
                    x.UserId = AnaForm.KullaniciId;
                    x.Insert = true;
                    x.Update = false;
                    x.Delete = false;
                    x.DemandId = Id;
                    x.DemandCode = txtKod.Text;
                    x.DemandStatu = DemandStatus.ProductionDemand;
                });
            }
        }
        protected override void BagliTabloYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Insert || x.Update || x.Delete);
            }

            if (productionDemandTable.OwnerForm == null || !TableValueChanged(productionDemandTable))
            {
                productionDemandTable.OwnerForm = this;
                productionDemandTable.Yukle();
            }
            if (TableValueChanged(productionDemandTable))
            {
                var rowHandle = productionDemandTable.Tablo.FocusedRowHandle;
                productionDemandTable.Yukle();
                productionDemandTable.Tablo.FocusedRowHandle = rowHandle;
            }
        }
    }
}
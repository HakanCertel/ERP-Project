using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General.CRP;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Dto.CRPDto;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.General.ProductionManangmentBll.UretimSonuKayitSurecBll;
using SenfoniYazilim.Erp.Model.Dto.ProductionManagmentDto.UretimSonuKayitDto;
using SenfoniYazilim.Erp.Model.Entities.ProductionManagmentEntities.UretimSonuKayitEntities;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Common.Message;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ProductionManagement.CRPForms.IsEmriForms
{
    public partial class UretimSonuKayitEditForm : BaseEditForm
    {
        private WorkOrdersL _isEmriL;
        private List<WorkOrderMaterialItemsL> _womi;

        public UretimSonuKayitEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new UretimSonuKayitBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Cari;
            EventsLoad();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnSil };
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new UretimSonuKayitS() : ((UretimSonuKayitBll)Bll).Single(FilterFunctions.Filter<UretimSonuKayit>(Id));

            NesneyiKontrollereBagla();

            TabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            ((UretimSonuKayitS)OldEntity).Kod = ((UretimSonuKayitBll)Bll).YeniKodVer("PER");
            ((UretimSonuKayit)OldEntity).UserId = AnaForm.KullaniciId;
            ((UretimSonuKayit)OldEntity).UpdatingUserId = AnaForm.KullaniciId;
            ((UretimSonuKayit)OldEntity).EvrakTarihi = DateTime.Now.Date;
            ((UretimSonuKayit)OldEntity).GuncellemeTarihi = DateTime.Now.Date;
            txtIslemTarihi.EditValue = DateTime.Now;
            var timeSpan = new TimeSpan(8, 30, 0);
            txtBaslamaZamani.EditValue = timeSpan;
            txtBitisZamani.EditValue = timeSpan;

        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (UretimSonuKayitS)OldEntity;

            txtKod.Text = entity.StokKodu;
            txtKod.Id = entity.StokId;
            txtStokAdi.Text = entity.StokAdi;
            txtUnit.Id = entity.UnitId;
            txtUnit.Text = entity.UnitName;
            txtIsEmriKodu.Text = entity.IsEmriKodu;
            txtIsEmriKodu.Id =entity.IsEmriId;
            txtDepoKodu.Text = entity.DepoKodu;
            txtDepoKodu.Id = entity.DepoId;
            txtDepoAdi.Text = entity.DepoAdi;
            txtToplamIsEmriMiktari.EditValue = entity.IsEmriMiktari;
            txtUretilenMiktar.EditValue = entity.UretilenMiktar;
            txtKalanMiktar.EditValue = entity.IslemMiktari;
            txtFireMiktari.EditValue = entity.FireMiktari;
            txtBaslamaZamani.EditValue = entity.BaslamaZamani;
            txtBitisZamani.EditValue = entity.BitisZamani;
            txtIslemTarihi.EditValue = entity.IslemTarihi;
        }
        protected override void GuncelNesneOlustur()
        {
            // base.GuncelNesneOlustur();
            CurrentEntity = new UretimSonuKayit
            {
                Id = Id,
                Kod = OldEntity.Kod,
                IsEmriId = Convert.ToInt32(txtIsEmriKodu.Id),
                DepoId = Convert.ToInt64(txtDepoKodu.Id),
                StokId = txtKod.Id,
                UnitId = txtUnit.Id,
                IslemMiktari=(decimal)txtKalanMiktar.EditValue,
                FireMiktari=(decimal)txtFireMiktari.EditValue,
                BaslamaZamani=(TimeSpan)txtBaslamaZamani.EditValue,
                BitisZamani=(TimeSpan)txtBitisZamani.EditValue,
                IslemTarihi=(DateTime)txtIslemTarihi.EditValue,
                UserId=((UretimSonuKayitS)OldEntity).UserId,
                UpdatingUserId=((UretimSonuKayitS)OldEntity).UpdatingUserId,
                EvrakTarihi=((UretimSonuKayitS)OldEntity).EvrakTarihi,
                GuncellemeTarihi=((UretimSonuKayitS)OldEntity).GuncellemeTarihi,
                ReceteId=((UretimSonuKayit)OldEntity).ReceteId,
            };

            ButonEnabledDurumu();
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (uretimSonuKayitTable != null && uretimSonuKayitTable.TableValueChanged) return true;
                return false;
            }

            Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial, OldEntity, CurrentEntity, TableValueChanged());
        }
        protected override void TabloYukle()
        {
            uretimSonuKayitTable.OwnerForm = this;
            uretimSonuKayitTable.Yukle();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is MyButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtIsEmriKodu)
                {
                    var isEmriL = new IsEmriL();

                    _isEmriL = (WorkOrdersL)sec.Sec(txtIsEmriKodu, isEmriL);

                    if (_isEmriL == null) return;

                    _womi = GetAnySingleOrListBll.ListWorkOrderMaterialItems(x=>x.OwnerFormId==_isEmriL.Id).ToList();

                    uretimSonuKayitTable.CreateUSB(_womi);

                    txtIsEmriKodu.Text = _isEmriL.Kod;
                    txtIsEmriKodu.Id =Convert.ToInt64( _isEmriL.Id);
                    txtKod.Text = _isEmriL.StokKodu;
                    txtKod.Id = _isEmriL.StokId;
                    txtStokAdi.Text = _isEmriL.StokAdi;
                    txtUnit.Id = _isEmriL.BirimId;
                    txtUnit.Text = _isEmriL.BirimAdi;
                    txtDepoKodu.Text = _isEmriL.DepoKodu;
                    txtDepoKodu.Id = _isEmriL.DepoId;
                    txtDepoAdi.Text = _isEmriL.DepoAdi;
                    txtToplamIsEmriMiktari.EditValue = _isEmriL.IsEmriMiktari;
                    txtUretilenMiktar.EditValue = _isEmriL.UretilenMiktar;
                    txtKalanMiktar.EditValue = _isEmriL.IsEmriMiktari - _isEmriL.UretilenMiktar;

                    if (BaseIslemTuru == IslemTuru.EntityInsert)
                        ((UretimSonuKayit)CurrentEntity).ReceteId = _isEmriL.BagliOlduguUstReceteId;
                }
                else if (sender == txtDepoKodu)
                {
                    sec.Sec(txtDepoKodu, txtDepoAdi);
                }
            }
           
        }

        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;

            if (sender == txtKalanMiktar||sender==txtFireMiktari)
            {
                var entities = uretimSonuKayitTable.Tablo.DataController.ListSource.Cast<UretimSonuKayitBilgileriL>().ToList();
                var quantity = txtKalanMiktar.Value + txtFireMiktari.Value;
                entities.ForEach(x =>
                {
                    x.KayitMiktari = quantity * x.BirimIhtiyac;
                });
                uretimSonuKayitTable.Tablo.RefreshData();
            }
            
            base.Control_EditValueChanged(sender, e);
        }

        protected override bool EntityInsert()
        {
            if (uretimSonuKayitTable.HatalıGiriş()) return false;
            ((UretimSonuKayit)CurrentEntity).UpdatingUserId = AnaForm.KullaniciId;
            ((UretimSonuKayit)CurrentEntity).GuncellemeTarihi = DateTime.Now;

            var result = ((UretimSonuKayitBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod)&& uretimSonuKayitTable.Kaydet();
            if (result)
            {
                uretimSonuKayitTable.Listele();
                var whmList = uretimSonuKayitTable.TranferItem().Cast<WareHouseStockL>().ToList(); 

                var insert = GetAnySingleOrListBll.UpdateWarehouseStock(whmList);

                if (insert)
                    uretimSonuKayitTable.InsertStockMoving();
            }
            return result;

        }

        protected override bool EntityUpdate()
        {
            return base.EntityUpdate();
        }

    }
}
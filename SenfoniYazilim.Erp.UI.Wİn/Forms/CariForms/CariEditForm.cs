using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.Linq;
using DevExpress.XtraBars.Navigation;
using SenfoniYazilim.Erp.UI.Wİn.Forms.CariForms.CompanyTables;
using SenfoniYazilim.Erp.Common.Functions;
using System;
using SenfoniYazilim.Erp.Bll.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.CariForms
{
    public partial class CariEditForm : BaseEditForm
    {
        private BaseTablo _companyPriceListTable;
        private BaseTablo _addressItemsTable;
        private BaseTablo _companyRelatedMaterialsTable;

        public CariEditForm()
        {
            InitializeComponent();

            DataLayoutControls = new[] { myDataLayoutControl, myDataLayoutControl3 };
            Bll = new CariBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Cari;
            EventsLoad();
            KayitSonrasiFormuKapat = false;
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new CariS() : ((CariBll)Bll).Single(FilterFunctions.Filter<Cari>(Id));
            NesneyiKontrollereBagla();
            BagliTabloYukle();

            txtCompanyState.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<CompanyState>());
            txtCustomerOrSuplier.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<CustomerOrSuplier>());
            txtLocation.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<Location>());
            txtLegalEntity.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<LegalEntity>());
            txtCurrency.Properties.Items.AddRange(GetAnySingleOrListBll.ListCurrencyItems().Select(x=>x.DovizAdi).ToList());

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((CariBll)Bll).YeniKodVer();
            txtCompanyName.Focus();
            txtCurrency.Text = GetAnySingleOrListBll.ListCurrencyItems().Select(x => x.DovizAdi).FirstOrDefault();
        }

        //üsteki metodla alınan veriyi kontrollere bağlamak için aşağıdaki metod oluşturulacaktır..
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (CariS)OldEntity;

            txtKod.Text = entity.Kod;
            txtCompanyName.Text = entity.CariAdi;
            txtIdentityNumber.Text = entity.TcKimlikNo;
            txtPhone1.Text = entity.Telefon1;
            txtPhone2.Text = entity.Telefon2;
            txtFax.Text = entity.Fax;
            txtWeb.Text = entity.Web;
            txtEMail.Text = entity.EMail;
            txtTaxOffice.Text = entity.VergiDairesi;
            txtTaxNumber.Text = entity.VergiNo;
            txtAddress.Text = entity.Adres;
            txtSpecialCode.Id = entity.OzelKod1Id;
            txtSpecialCode.Text = entity.OzelKod1Adi;
            txtSpecialCode1.Id = entity.OzelKod2Id;
            txtSpecialCode1.Text = entity.OzelKod2Adi;
            txtDescription.Text = entity.Aciklama;
            tglIsActice.IsOn = entity.Durum;
            txtLegalEntity.Text = entity.LegalEntity.toName();
            txtCustomerOrSuplier.Text = entity.CustomerOrSuplier.toName();
            txtLocation.Text = entity.Location.toName();
            txtCompanyState.Text = entity.CompanyState.toName();
            txtCurrency.Text = entity.CurrencyName;
        }

        protected override void GuncelNesneOlustur()
        {
            long currencyId =Convert.ToInt64( GetAnySingleOrListBll.ListCurrencyItems().Where(x => x.DovizAdi == txtCurrency.Text).FirstOrDefault()?.Id);

            CurrentEntity = new Cari
            {
                Id = Id,
                Kod = txtKod.Text,
                CariAdi = txtCompanyName.Text,
                TcKimlikNo = txtIdentityNumber.Text,
                Telefon1 = txtPhone1.Text,
                Telefon2 = txtPhone2.Text,
                Fax = txtFax.Text,
                Web = txtWeb.Text,
                EMail = txtEMail.Text,
                VergiDairesi = txtTaxOffice.Text,
                VergiNo = txtTaxNumber.Text,
                Adres = txtAddress.Text,
                OzelKod1Id = txtSpecialCode.Id,
                OzelKod2Id = txtSpecialCode1.Id,
                Aciklama = txtDescription.Text,
                Durum = tglIsActice.IsOn,
                CompanyState = txtCompanyState.Text.GetEnum<CompanyState>(),
                CustomerOrSuplier=txtCustomerOrSuplier.Text.GetEnum<CustomerOrSuplier>(),
                Location=txtLocation.Text.GetEnum<Location>(),
                LegalEntity=txtLegalEntity.Text.GetEnum<LegalEntity>(),
                DefaultCurrencyId=currencyId
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            if (BagliTabloHataliGirisKontrol()) return false;

            var result = ((CariBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod) && BagliTabloKaydet();

            if (result && !KayitSonrasiFormuKapat)
                BagliTabloYukle();

            return result;
        }

        protected override bool EntityUpdate()
        {
            if (BagliTabloHataliGirisKontrol()) return false;

            var result = ((CariBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod) && BagliTabloKaydet();

            if (result && !KayitSonrasiFormuKapat)
                BagliTabloYukle();

            return result;
        }

        protected override void BagliTabloYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Insert || x.Update || x.Delete);
            }

            #region Comment
                //    _kardesBilgilerTable.Yukle();
                //if (_aileBilgileriTable != null && TableValueChanged(_aileBilgileriTable))
                //if (_kardesBilgilerTable != null && TableValueChanged(_kardesBilgilerTable))
                //    _aileBilgileriTable.Yukle();
                //if (hizmetBilgileriTable.OwnerForm == null)
                //{
                //    hizmetBilgileriTable.OwnerForm = this;
                //    hizmetBilgileriTable.Yukle();
                //}
                //if (indirimBilgileriTable.OwnerForm == null)
                //{
                //    indirimBilgileriTable.OwnerForm = this;
                //    indirimBilgileriTable.Yukle();
                //}


            #endregion

            if (companyContactTable.OwnerForm == null)
            {
                companyContactTable.OwnerForm = this;
                companyContactTable.Yukle();
            }
            if (addressItemsTable.OwnerForm==null)
            {
                addressItemsTable.OwnerForm = this;
                addressItemsTable.Yukle();
            }
            if (_companyRelatedMaterialsTable != null && TableValueChanged(_companyRelatedMaterialsTable))
                _companyRelatedMaterialsTable.Yukle();
            if (_companyPriceListTable != null && TableValueChanged(_companyPriceListTable))
                _companyPriceListTable.Yukle();
            if (TableValueChanged(companyContactTable))
            {
                var rowHandle = companyContactTable.Tablo.FocusedRowHandle;
                companyContactTable.Yukle();
                companyContactTable.Tablo.FocusedRowHandle = rowHandle;
            }
            if (TableValueChanged(companyContactTable))
            {
                var rowHandle = companyContactTable.Tablo.FocusedRowHandle;
                companyContactTable.Yukle();
                companyContactTable.Tablo.FocusedRowHandle = rowHandle;
            }

        }

        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (addressItemsTable.TableValueChanged) return true;
                if (_companyRelatedMaterialsTable != null && _companyRelatedMaterialsTable.TableValueChanged) return true;
                if (_companyPriceListTable != null && _companyPriceListTable.TableValueChanged) return true;
                
                if (companyContactTable.TableValueChanged) return true;

                return false;
            }

            Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial, OldEntity, CurrentEntity, TableValueChanged());

        }

        protected override bool BagliTabloKaydet()
        {
            #region Comment
            //if (_kardesBilgilerTable != null && !_kardesBilgilerTable.Kaydet()) return false;
            //if (_aileBilgileriTable != null && !_aileBilgileriTable.Kaydet()) return false;
            //if (_sinavBilgileriTable != null && !_sinavBilgileriTable.Kaydet()) return false;
            //if (_evrakBilgileriTable != null && !_evrakBilgileriTable.Kaydet()) return false;
            //if (_promosyonBilgileriTable != null && !_promosyonBilgileriTable.Kaydet()) return false;
            //if (_iletisimBilgileriTable != null && !_iletisimBilgileriTable.Kaydet()) return false;
            //if (_ePosBilgileriTable != null && !_ePosBilgileriTable.Kaydet()) return false;
            //if (_bilgiNotlariTable != null && !_bilgiNotlariTable.Kaydet()) return false;
            //if (!hizmetBilgileriTable.Kaydet()) return false;
            //if (!indirimBilgileriTable.Kaydet()) return false;
            //if (!odemeBilgileriTable.Kaydet()) return false;
            //if (!geriOdemeBilgileriTable.Kaydet()) return false;
            #endregion

            if (!companyContactTable.Kaydet()) return false;

            if (!addressItemsTable.Kaydet()) return false;

            if (_companyRelatedMaterialsTable != null && !_companyRelatedMaterialsTable.Kaydet()) return false;

            if (_companyPriceListTable != null && !_companyPriceListTable.Kaydet()) return false;
            
            return true;
        }

        protected override bool BagliTabloHataliGirisKontrol()
        {

            #region Comment
            //if (_sinavBilgileriTable != null && _sinavBilgileriTable.HatalıGiriş())
            //{
            //    tabUst.SelectedPage = pageAileSinavBilgileri;
            //    _sinavBilgileriTable.Tablo.GridControl.Focus();
            //    return true;
            //}
            //if (_iletisimBilgileriTable != null && _iletisimBilgileriTable.HatalıGiriş())
            //{
            //    tabUst.SelectedPage = pageIletisimBilgileri;
            //    _iletisimBilgileriTable.Tablo.GridControl.Focus();
            //    return true;
            //}
            //if (_ePosBilgileriTable != null && _ePosBilgileriTable.HatalıGiriş())
            //{
            //    tabUst.SelectedPage = PageEPosBilgileri;
            //    _ePosBilgileriTable.Tablo.GridControl.Focus();
            //    return true;
            //}
            //if (_bilgiNotlariTable != null && _bilgiNotlariTable.HatalıGiriş())
            //{
            //    tabUst.SelectedPage = pageNotlar;
            //    _bilgiNotlariTable.Tablo.GridControl.Focus();
            //    return true;
            //}
            //if (hizmetBilgileriTable.HatalıGiriş())
            //{
            //    tabAlt.SelectedPage = pageHizmetBilgileri;
            //    hizmetBilgileriTable.Tablo.GridControl.Focus();
            //    return true;
            //}
            //if (hizmetBilgileriTable.HatalıGiriş())
            //{
            //    tabAlt.SelectedPage = pageOdemeBilgileri;
            //    odemeBilgileriTable.Tablo.GridControl.Focus();
            //    return true;
            //}

            //if (geriOdemeBilgileriTable.HatalıGiriş())
            //{
            //    tabAlt.SelectedPage = pageGeriOdemeBilgileri;
            //    geriOdemeBilgileriTable.Tablo.GridControl.Focus();
            //    return true;
            //}
            #endregion

            if (companyContactTable.HatalıGiriş())
            {
                tabPaneDetail.SelectedPage = pageCompanyContact;
                companyContactTable.Tablo.GridControl.Focus();
                return true;
            }
            if (addressItemsTable.HatalıGiriş())
            {
                tabPaneDetail.SelectedPage = pageAddressItems;
                addressItemsTable.Tablo.GridControl.Focus();
                return true;
            }
            return false;
        }

        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page == pageGenelBilgiler)
                txtCompanyName.Focus();
            else if (e.Page == pageCompanyContact)
                companyContactTable.Tablo.GridControl.Focus();

            else if (e.Page == pageAddressItems)
                addressItemsTable.Tablo.GridControl.Focus();
            else if (e.Page == pagePriceListItems)
            {
                if (pagePriceListItems.Controls.Count == 0)
                {
                    _companyPriceListTable = new CompanyPriceListTable().AddTable(this);
                    pagePriceListItems.Controls.Add(_companyPriceListTable);
                    _companyPriceListTable.Yukle();
                }

                _companyPriceListTable.Tablo.GridControl.Focus();
            }
            
            else if (e.Page == pageCompanyRelatedMaterials)
            {
                if (pageCompanyRelatedMaterials.Controls.Count == 0)
                {
                    _companyRelatedMaterialsTable = new CompanyRelatedMaterialTable().AddTable(this);
                    pageCompanyRelatedMaterials.Controls.Add(_companyRelatedMaterialsTable);
                    _companyRelatedMaterialsTable.Yukle();
                }

                _companyRelatedMaterialsTable.Tablo.GridControl.Focus();
            }

            #region Comment
            //if (e.Page == pageGenelBilgiler)
            //{
            //    txtOkulNo.Focus();
            //    txtOkulNo.SelectAll();
            //}

            //else if (e.Page == pageKardesBilgileri)
            //{
            //    if (pageKardesBilgileri.Controls.Count == 0)
            //    {
            //        _kardesBilgilerTable = new KardesBilgileriTable().AddTable(this);
            //        pageKardesBilgileri.Controls.Add(_kardesBilgilerTable);
            //        _kardesBilgilerTable.Yukle();
            //    }

            //    _kardesBilgilerTable.Tablo.GridControl.Focus();
            //    //pageKardesBilgileri.Controls[0].Focus();
            //}
            //else if (e.Page == pageEvrakPromosyonBilgileri)
            //{
            //    if (layoutControlEvrakPromosyonBilgileri.Count == 0)
            //    {
            //        _evrakBilgileriTable = new EvrakBilgileriTable().AddTable(this);
            //        //pageAileSinavBilgileri.Controls.Add(_aileBilgileriTable);
            //        layoutControlEvrakPromosyonBilgileri.LayoutControlInsert(_evrakBilgileriTable, 0, 0, 0, 0);
            //        _evrakBilgileriTable.Yukle();

            //        _promosyonBilgileriTable = new PromosyonBilgileriTable().AddTable(this);
            //        layoutControlEvrakPromosyonBilgileri.LayoutControlInsert(_promosyonBilgileriTable, 1, 0, 0, 0);
            //        _promosyonBilgileriTable.Yukle();
            //    }

            //    _evrakBilgileriTable.Tablo.GridControl.Focus();
            //}

            //else if (e.Page == pageIletisimBilgileri)
            //{
            //    if (pageIletisimBilgileri.Controls.Count == 0)
            //    {
            //        _iletisimBilgileriTable = new IletisimBilgileriTable().AddTable(this);
            //        pageIletisimBilgileri.Controls.Add(_iletisimBilgileriTable);
            //        _iletisimBilgileriTable.Yukle();
            //    }

            //    _iletisimBilgileriTable.Tablo.GridControl.Focus();
            //}
            //else if (e.Page == PageEPosBilgileri)
            //{
            //    if (PageEPosBilgileri.Controls.Count == 0)
            //    {
            //        _ePosBilgileriTable = new EPosBilgileriTable().AddTable(this);
            //        PageEPosBilgileri.Controls.Add(_ePosBilgileriTable);
            //        _ePosBilgileriTable.Yukle();
            //    }

            //    _ePosBilgileriTable.Tablo.GridControl.Focus();
            //}

            //else if (e.Page == pageNotlar)
            //{
            //    if (pageNotlar.Controls.Count == 0)
            //    {
            //        _bilgiNotlariTable = new BilgiNotlariTable().AddTable(this);
            //        pageNotlar.Controls.Add(_bilgiNotlariTable);
            //        _bilgiNotlariTable.Yukle();
            //    }

            //    _bilgiNotlariTable.Tablo.GridControl.Focus();
            //}
            //else if (e.Page == pageHizmetBilgileri)
            //    hizmetBilgileriTable.Tablo.GridControl.Focus();

            //else if (e.Page == pageIndirimBilgileri)
            //    indirimBilgileriTable.Tablo.GridControl.Focus();

            //else if (e.Page == pageOdemeBilgileri)
            //    odemeBilgileriTable.Tablo.GridControl.Focus();

            //else if (e.Page == pageGeriOdemeBilgileri)
            //    geriOdemeBilgileriTable.Tablo.GridControl.Focus();
            #endregion

        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtSpecialCode)
                    sec.Sec(txtSpecialCode, KartTuru.Cari);
                else if (sender == txtSpecialCode1)
                    sec.Sec(txtSpecialCode1, KartTuru.Cari);
        }
    }
}
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.UI.Wİn.Forms.AvukatForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BankaForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BankaHesapForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BankaSubeForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.CariForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.GorevForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.HizmetTuruForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IlceForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IlForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IndirimTuruForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IsyeriForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.KasaForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.KullaniciForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.MeslekForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.OgrenciForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.OperasyonForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.OzelKodForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SubeForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Forms.VardiyaForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.WarehouseForms;
using SenfoniYazilim.Erp.Model.Dto.CRPDto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ProductionManagement.CRPForms.IsEmriForms;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;

namespace SenfoniYazilim.Erp.UI.Wİn.Functions
{
    public class SelectFunctions : IDisposable
    {
        private object _entity;
        private static MyTextEdit _txtEdit;
        private MyTextEdit _txtKodEdit;
        private MyButtonEdit _btnEdit;
        private MyButtonEdit _prmEdit;
        private static MySimpleButton _btn;
        private KartTuru _kartTuru;
        private OdemeTipi _odemeTipi;
        private BankaHesapTuru _hesapTuru;
        private IList<long> _listeDisiTutulacakKayitlar;
        private BaseEntity _baseEntity;


        public void Sec(MyButtonEdit btnEdit)
        {
            _btnEdit = btnEdit;
            SecimYap();
        }
        public object Sec(MyButtonEdit btnEdit,object baseEntity)
        {
            _btnEdit = btnEdit;
            _entity = baseEntity;
            SecimYap();
            return _entity;
        }
        public void Sec(MyButtonEdit btnEdit,OdemeTipi odemeTipi)
        {
            _btnEdit = btnEdit;
            _odemeTipi = odemeTipi;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit,KartTuru kartTuru, BankaHesapTuru hesapTuru)
        {
            _btnEdit = btnEdit;
            _kartTuru = kartTuru;
            _hesapTuru= hesapTuru;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit,KartTuru kartTuru)
        {
            _btnEdit = btnEdit;
            _kartTuru = kartTuru;
            SecimYap();
        }


        public void Sec(MyButtonEdit btnEdit,MyButtonEdit prmEdit)
        {
            _btnEdit = btnEdit;
            _prmEdit = prmEdit;
            SecimYap();
        }
        public void Sec(MyButtonEdit btnEdit, MyTextEdit txtKodEdit)
        {
            _btnEdit = btnEdit;
            _txtKodEdit = txtKodEdit;
            SecimYap();
        }
        public void Sec(MyButtonEdit btnEdit, MyTextEdit txtKodEdit,IList<long> listeDisiTutulacakKayitlar)
        {
            _btnEdit = btnEdit;
            _txtKodEdit = txtKodEdit;
            _listeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
            SecimYap();
        }
        public static T Sec<T>(Control control) where T:BaseEntity
        {
            T entity=null;
            switch (control)
            {
                case MyTextEdit edt :
                    _txtEdit =(MyTextEdit) control;
                    entity = (T)ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, _txtEdit.Id);
                    break;
                case MySimpleButton edt:
                    _btn = edt;
                    entity = (T)ShowListForms<MrpListForm>.ShowDialogListForm(KartTuru.Mrp,-1);
                    break;
            }
            return entity;
        }

        private void SecimYap()
        {
            switch (_btnEdit.Name)
            {
                case "txtIl":
                case "txtAdresIl":
                case "txtEvAdresiIlAdi":
                case "txtIsAdresiIlAdi":
                case "txtNufusIlAdi":
                    {
                        var entity = (Il)ShowListForms<IlListForm>.ShowDialogListForm(KartTuru.Il, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlAdi;
                        }
                    }
                    break;
                case "txtIlce":
                case "txtAdresIlce":
                case "txtEvAdresiIlceAdi":
                case "txtIsAdresiIlceAdi":
                case "txtNufusIlceAdi":
                    {
                        var entity = (Ilce)ShowListForms<IlceListForm>.ShowDialogListForm(KartTuru.Ilce, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlceAdi;
                        }
                    }
                    break;
                case "txtAdresUlke":
                    {
                        var entity = (Country)ShowListForms<CountryListForm>.ShowDialogListForm(KartTuru.Country, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.CountryName;
                        }
                    }
                    break;
                case "txtHizmetTuru":
                    {
                        var entity = (HizmetTuru)ShowListForms<HizmetTuruListForm>.ShowDialogListForm(KartTuru.HizmetTuru, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.HizmetTuruAdi;
                        }
                    }
                    break;
                case "txtIndirimTuru":
                    {
                        var entity = (IndirimTuru)ShowListForms<IndirimTuruListForm>.ShowDialogListForm(KartTuru.Indirim, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IndirimTuruAdi;
                        }
                    }
                    break;
                case "txtAltGrup":
                case "txtOzelKod1":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod1, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtOzelKod2":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod2, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtOzelKod3":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod3, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtOzelKod4":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod4, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtOzelKod5":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod5, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtBanka":
                case "txtBank":

                    {
                        var entity = (BankaL)ShowListForms<BankaListForm>.ShowDialogListForm(KartTuru.Banka, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.BankaAdi;
                        }
                    }
                    break;
                case "txtBankaSube":
                    {
                        var entity = (BankaSube)ShowListForms<BankaSubeListForm>.ShowDialogListForm(KartTuru.BankaSube, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SubeAdi;
                        }
                    }
                    break;
                case "txtMeslek":
                    {
                        var entity = (Meslek)ShowListForms<MeslekListForm>.ShowDialogListForm(KartTuru.Meslek, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.MeslekAdi;
                        }
                    }
                    break;
                case "txtIsyeri":
                    {
                        var entity = (Isyeri)ShowListForms<IsyeriListForm>.ShowDialogListForm(KartTuru.Isyeri, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IsyeriAdi;
                        }
                    }
                    break;
                case "txtGorev":
                    {
                        var entity = (Gorev)ShowListForms<GorevListForm>.ShowDialogListForm(KartTuru.Gorev, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.GorevAdi;
                        }
                    }
                    break;
                case "txtBankaHesapAdi":
                case "txtDefaultBankaHesap":
                    {
                        var entity = (BankaHesapL)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.BankaHesap, _btnEdit.Id, _odemeTipi);
                        if (entity != null)
                        {
                            _btnEdit.Tag = entity.BlokeGunSayisi;
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.HesapAdi;
                        }
                    }
                    break;
                case "txtBankAccount":
                    {
                        var entity = (BankaHesapL)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.BankaHesap, _btnEdit.Id, _prmEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.HesapAdi;
                        }
                    }
                    break;
                case "txtSube":
                    {
                        var entity = (SubeL)ShowListForms<SubeListForm>.ShowDialogListForm(KartTuru.Sube, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.SubeAdi;
                        }
                    }
                    break;
                case "txtRol":
                    {
                        var entity = (Rol)ShowListForms<RolListForm>.ShowDialogListForm(KartTuru.Rol, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.RolAdi;
                        }
                    }
                    break;
                case "txtOperasyon":
                    {
                        var entity = (Operasyon)ShowListForms<OperasyonListForm>.ShowDialogListForm(KartTuru.Operasyon, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OperasyonAdi;
                        }
                    }
                    break;
                case "txtVardiyaSistemi":
                    {
                        var entity = (Vardiya)ShowListForms<VardiyaListForm>.ShowDialogListForm(KartTuru.Vardiya, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.VardiyaAdi;
                        }
                    }
                    break;
                case "txtDepoAdi":
                    {
                        var entity = (WareHouse)ShowListForms<WarehouseListForm>.ShowDialogListForm(KartTuru.Depo, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.WarehouseName;
                        }
                    }
                    break;
                case "txtTransferWarehouse":
                case "txtTransferedWarehouse":
                case "txtDepom":
                case "txtDepo":
                case "txtDepoKodu":
                case "txtWarehouseCode":
                case "txtWarehouse":
                    {
                        var entity = (WareHouse)ShowListForms<WarehouseListForm>.ShowDialogListForm(KartTuru.Depo, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Kod;
                            _txtKodEdit.Text = entity.WarehouseName;
                        }
                    }
                    break;
                case "txtMalzemeKod":
                    {
                         _entity = (MaterialL)ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, _btnEdit.Id);
                        if (_entity != null)
                        {
                            _btnEdit.Id =((MaterialL) _entity).Id;
                            _btnEdit.EditValue =((MaterialL) _entity).Kod;
                        }
                    }
                    break;
                case "txtIsEmriKodu":
                    {
                        _entity = (WorkOrdersL)ShowListForms<IsEmriListForm>.ShowDialogHareketListForm(KartTuru.Stok,Convert.ToInt32( _btnEdit.Id));
                        if (_entity != null)
                        {
                            _btnEdit.Id =Convert.ToInt64( ((WorkOrdersL)_entity).Id);
                            _btnEdit.EditValue = ((WorkOrdersL)_entity).Kod;
                        }
                    }
                    break;
                case "txtKod":
                case "txtStokKodu":
                    {
                        MaterialL entity;
                        if(_listeDisiTutulacakKayitlar!=null)
                            entity=(MaterialL)ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Depo, _btnEdit.Id,_listeDisiTutulacakKayitlar,true);
                        else
                            entity = (MaterialL)ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Depo, _btnEdit.Id);

                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Kod;
                            _txtKodEdit.Text = entity.StockName;
                        }
                    }
                    break;
                case "txtDefaultAvukatHesap":
                    {
                        var entity = (AvukatL)ShowListForms<AvukatListForm>.ShowDialogListForm(KartTuru.Avukat, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.AdiSoyadi;
                        }
                        break;
                    }
                case "txtDefaultKasaHesap":
                    {
                        var entity = (KasaL)ShowListForms<KasaListForm>.ShowDialogListForm(KartTuru.Kasa, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.KasaAdi;
                        }
                        break;
                    }
                //case "txtVardiyaSistemi":
                //    {
                //        var entity = (Vardiya)ShowListForms<VardiyaListForm>.ShowDialogListForm(KartTuru.Vardiya, _btnEdit.Id);
                //        if (entity != null)
                //        {
                //            _btnEdit.Id = entity.Id;
                //            _btnEdit.EditValue = entity.KasaAdi;
                //        }
                //        break;
                //    }
                case "txtHesap":
                    {
                        switch (_kartTuru)
                        {
                            case KartTuru.Avukat:
                                {
                                    var entity = (AvukatL)ShowListForms<AvukatListForm>.ShowDialogListForm(KartTuru.Avukat, _btnEdit.Id);
                                    if (entity != null)
                                    {
                                        _btnEdit.Id = entity.Id;
                                        _btnEdit.EditValue = entity.AdiSoyadi;
                                    }
                                    break;
                                }

                            case KartTuru.Kasa:
                                {
                                    var entity = (KasaL)ShowListForms<KasaListForm>.ShowDialogListForm(KartTuru.Kasa, _btnEdit.Id);
                                    if (entity != null)
                                    {
                                        _btnEdit.Id = entity.Id;
                                        _btnEdit.EditValue = entity.KasaAdi;
                                    }
                                    break;
                                }
                            case KartTuru.Banka:
                                {
                                    var entity = (BankaL)ShowListForms<BankaListForm>.ShowDialogListForm(KartTuru.Banka, _btnEdit.Id);
                                    if (entity != null)
                                    {
                                        _btnEdit.Id = entity.Id;
                                        _btnEdit.EditValue = entity.BankaAdi;
                                    }
                                }
                                break;
                            case KartTuru.BankaHesap:
                                {
                                    var entity = (BankaHesapL)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.Banka, _btnEdit.Id, _hesapTuru);
                                    if (entity != null)
                                    {
                                        _btnEdit.Id = entity.Id;
                                        _btnEdit.EditValue = entity.HesapAdi;
                                    }
                                    break;
                                }

                            case KartTuru.Cari:
                                {
                                    var entity = (CariL)ShowListForms<CariListForm>.ShowDialogListForm(KartTuru.Cari, _btnEdit.Id);
                                    if (entity != null)
                                    {
                                        _btnEdit.Id = entity.Id;
                                        _btnEdit.EditValue = entity.CariAdi;
                                    }
                                    break;
                                }

                                //case KartTuru.Sube:
                                //    {
                                //        var entity = (SubeL)ShowListForms<SubeListForm>.ShowDialogListForm(KartTuru.Sube, _btnEdit.Id,true);
                                //        if (entity != null)
                                //        {
                                //            _btnEdit.Id = entity.Id;
                                //            _btnEdit.EditValue = entity.SubeAdi;
                                //        }
                                //        break;
                                //    }
                        }
                    }
                    break;
                case "txtReceteKodu":
                    {
                        var entity = (ReceteL)ShowListForms<ReceteListForm>.ShowDialogListForm(KartTuru.Recete, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Kod;
                            _txtKodEdit.Text = entity.StokAdi;
                        }
                    }
                    break;
                case "txtFirma":
                case "txtOfferedCompanyName":
                case "txtDeliveredCompany":
                case "txtCompanyName":
                    {
                        var entity = (CariL)ShowListForms<CariListForm>.ShowDialogListForm(KartTuru.Cari, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.CariAdi;
                        }
                        break;
                    }
                case "txtCari":
                    {
                        var entity = (CariL)ShowListForms<CariListForm>.ShowDialogListForm(KartTuru.Cari, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Kod;
                            _txtKodEdit.Text = entity.CariAdi;
                        }
                    }
                    break;
                case "txtDemandingUser":
                    {
                        var entity = (PersonelL)ShowListForms<PersonelListForm>.ShowDialogListForm(KartTuru.Personel, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Adi+" "+entity.Soyadi;
                        }
                    }
                    break;
                case "txtPlasiyer":
                    {
                        var entity = (PersonelL)ShowListForms<PersonelListForm>.ShowDialogListForm(KartTuru.Personel, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Kod;
                            _txtKodEdit.Text = entity.Adi;
                        }
                    }
                    break;

            }   
            

        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }

}

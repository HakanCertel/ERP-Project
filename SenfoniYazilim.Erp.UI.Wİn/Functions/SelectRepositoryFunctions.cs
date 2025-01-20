using System;
using System.Windows.Forms;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BankaForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BankaHesapForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BankaSubeForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IptalNedeniForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.KasaForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.MakinaForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.OgrenciForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.OperasyonForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using SenfoniYazilim.Erp.UI.Wİn.Forms.VardiyaForms;
using System.Collections.Generic;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.CariForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IlForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IlceForms;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.UI.Wİn.Forms.WarehouseProccesForms.WarehouseForms;
using SenfoniYazilim.Erp.Model.Entities.Company;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.FeaturesForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Functions
{
    public static class SelectRepositoryFunctions
    {
        private static GridView _tablo;
        private static ControlNavigator _navigator;
        private static RepositoryItemButtonEdit _buttonEdit;
        private static GridColumn _idColumn;
        private static GridColumn _nameColumn;
        private static GridColumn _nameGridColumn;
        private static GridColumn _prmIdColumn;
        private static GridColumn _prmNameColumn;
        private static int _operasyonBilgileriId;
        private static object _entity;

        private static void RemoveEvent()
        {
            if (_buttonEdit == null) return;

            _buttonEdit.ButtonClick -= ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown -= ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick -= ButtonEdit_DoubleClick;
            _tablo.KeyDown -= Tablo_KeyDown;
        }
        public static object Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn, object entity)
        {
            RemoveEvent();

            _tablo = tablo;
            _navigator = navigator;
            _buttonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;
            _entity = entity;

            _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown += ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;
            _tablo.KeyDown += Tablo_KeyDown;

            return _entity;
        }
        public static void Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn)
        {
            RemoveEvent();

            _tablo = tablo;
            _navigator = navigator;
            _buttonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;

            _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown += ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;
            _tablo.KeyDown += Tablo_KeyDown;
        }

        public static void Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn, GridColumn nameGridColumn)
        {
            RemoveEvent();

            _tablo = tablo;
            _navigator = navigator;
            _buttonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;
            _nameGridColumn = nameGridColumn;

            _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown += ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;
        }
        public static void Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn, GridColumn prmIdColumn,GridColumn prmNameColumn)
        {
            RemoveEvent();

            _tablo = tablo;
            _navigator = navigator;
            _buttonEdit = buttonEdit;
            _idColumn = idColumn;
            _nameColumn = nameColumn;
            _prmIdColumn = prmIdColumn;
            _prmNameColumn = prmNameColumn;

            _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
            _buttonEdit.KeyDown += ButtonEdit_KeyDown;
            _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;
            _tablo.KeyDown += Tablo_KeyDown;

        }
        //}
        public static void Sec(this GridColumn nameColumn, GridView tablo, int id, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn)
                {
                    RemoveEvent();

                    _tablo = tablo;
                    _operasyonBilgileriId = id;
                    _buttonEdit = buttonEdit;
                    _idColumn = idColumn;
                    _nameColumn = nameColumn;

                    _buttonEdit.ButtonClick += ButtonEdit_ButtonClick;
                    _buttonEdit.KeyDown += ButtonEdit_KeyDown;
                    _buttonEdit.DoubleClick += ButtonEdit_DoubleClick;
                    _tablo.KeyDown += Tablo_KeyDown;
                }

        private static void ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
                {
                    SecimYap();
                }

        private static void ButtonEdit_KeyDown(object sender, KeyEventArgs e)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Delete when e.Control && e.Shift:
                            _tablo.SetFocusedRowCellValue(_idColumn, null);
                            _tablo.SetFocusedRowCellValue(_nameColumn, null);
                            _navigator?.Buttons.DoClick(_navigator.Buttons.EndEdit);
                            break;
                        case Keys.F4:
                        case Keys.Down when e.Alt:
                            SecimYap();
                            break;
                    }
                }

        private static void ButtonEdit_DoubleClick(object sender, EventArgs e)
                {
                    SecimYap();
                }

        private static void Tablo_KeyDown(object sender, KeyEventArgs e)
                {
                    if (_tablo.FocusedColumn.ColumnEdit == null) return;
                    var type = _tablo.FocusedColumn.ColumnEdit.GetType();

                    if (type != typeof(RepositoryItemButtonEdit)) return;

                    switch (e.KeyCode)
                    {
                        case Keys.Delete when e.Control && e.Shift:
                            _tablo.SetFocusedRowCellValue(_idColumn, null);
                            _tablo.SetFocusedRowCellValue(_nameColumn, null);
                            _navigator?.Buttons.DoClick(_navigator.Buttons.EndEdit);
                            break;
                        case Keys.F4:
                        case Keys.Down when e.Alt:
                            SecimYap();
                            break;
                    }
                }

        private static void SecimYap()
                {
                    switch (_buttonEdit.Name)
                    {
                        case "repositoryItemStokKodu":
                            {
                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);
                                var entity = (ReceteL)ShowListForms<ReceteListForm>.ShowDialogListForm(KartTuru.Recete, id);
                                if (entity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.Kod);
                                    _tablo.SetFocusedRowCellValue(_nameGridColumn, entity.StokAdi);

                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                            }
                            break;
                        case "repositoryItemButtonMaterialCode":
                        case "repositoryItemButtonSatinalmaTalepStok":
                            {
                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);
                                var entity = (MaterialL)ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, id);
                                if (entity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.Kod);
                                    _tablo.SetFocusedRowCellValue(_nameGridColumn, entity.StockName);
                                    _tablo.Columns["Birim"].OptionsColumn.AllowEdit = true;
                                    _tablo.SetFocusedRowCellValue("Birim", entity.UnitCode);
                                    _tablo.Columns["Birim"].OptionsColumn.AllowEdit = false;

                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                            }
                            break;
                        case "repositoryItemButtonFirma":
                            {
                                if (!_nameColumn.OptionsColumn.AllowEdit) return;

                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);
                                var entity = (CariL)ShowListForms<CariListForm>.ShowDialogListForm(KartTuru.Cari, id);
                                if (entity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.CariAdi);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                            }
                            break;
                        case "repositoryItemButtonCountry":
                            {
                                if (!_nameColumn.OptionsColumn.AllowEdit) return;

                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);

                                var entity = (Country)ShowListForms<CountryListForm>.ShowDialogListForm(KartTuru.Country, id);
                                if (entity != null)
                                {
                                    //((AddressItemsL)_entity).CountryId = entity.Id;
                                    //((AddressItemsL)_entity).CountryName = entity.CountryName;
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.CountryName);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                            }
                            break;
                        case "repositoryItemButtonIlAdi":
                            {
                                if (!_nameColumn.OptionsColumn.AllowEdit) return;

                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);
                                var countryId = ((AddressItemsL)_entity).CountryId;//_tablo.GetRowCellId(_prmIdColumn);
                                var countryName = ((AddressItemsL)_entity).CountryName;//_tablo.GetFocusedRowCellValue(_prmNameColumn).ToString();
                                var entity = (Il)ShowListForms<IlListForm>.ShowDialogListForm(KartTuru.Il, id, countryId, countryName);
                                if (entity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.IlAdi);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                            }
                            break;
                        case "repositoryItemButtonEditFeature":
                            {
                                if (!_nameColumn.OptionsColumn.AllowEdit) return;

                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn,null);
                                var definationId =Convert.ToInt32( _tablo.GetRowCellId(_prmIdColumn,null));
                                //var featureDescription = _tablo.GetFocusedRowCellValue(_prmNameColumn).ToString();

                                var entity = (Features)ShowListForms<FeaturesListForm>.ShowDialogHareketListForm(KartTuru.Feature,Convert.ToInt32(id), definationId, KartTuru.Stok);
                                if (entity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.Description);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                        //if (!_nameColumn.OptionsColumn.AllowEdit) return;

                        ////var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                        ////var id = _tablo.GetRowCellId(_idColumn);
                        //var featureId = ((DefinationAndFeatureItems)_entity).DefinationId;//_tablo.GetRowCellId(_prmIdColumn);
                        //var countryName = ((DefinationAndFeatureItems)_entity).FeatureDescription;//_tablo.GetFocusedRowCellValue(_prmNameColumn).ToString();
                        //var entity = (Features)ShowListForms<FeaturesListForm>.ShowDialogHareketListForm(KartTuru.Il, featureId, null);
                        //((DefinationAndFeatureItems)_entity).FeatureId = entity?.Id;
                        //((DefinationAndFeatureItems)_entity).FeatureDescription = entity?.Description;
                        //((DefinationAndFeatureItems)_entity).FeatureCode = entity?.Code;

                        ////if (entity != null)
                        ////{
                        ////    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                        ////    _tablo.SetFocusedRowCellValue(_nameColumn, entity.Description);
                        ////    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                        ////}
                    }
                            break;
                        case "repositoryItemButtonIlceAdi":
                            {
                                if (!_nameColumn.OptionsColumn.AllowEdit) return;

                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);
                                var ilId = _tablo.GetRowCellId(_prmIdColumn);
                                var ilAdi = _tablo.GetFocusedRowCellValue(_prmNameColumn).ToString();

                                var entity = (Ilce)ShowListForms<IlceListForm>.ShowDialogListForm(KartTuru.Ilce, id, ilId, ilAdi);
                                if (entity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.IlceAdi);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                            }
                            break;
                        case "repositoryBanka":
                            {
                                if (!_nameColumn.OptionsColumn.AllowEdit) return;

                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);
                                var entity = (BankaL)ShowListForms<BankaListForm>.ShowDialogListForm(KartTuru.Banka, id);
                                if (entity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.BankaAdi);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                            }
                            break;
                        case "repositoryBankaSube":
                            {
                                if (!_nameColumn.OptionsColumn.AllowEdit) return;

                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);
                                var bankaId = _tablo.GetRowCellId(_prmIdColumn);
                                var bankaAdi = _tablo.GetFocusedRowCellValue(_prmNameColumn).ToString();

                                var entity = (BankaSube)ShowListForms<BankaSubeListForm>.ShowDialogListForm(KartTuru.BankaSube, id, bankaId, bankaAdi);
                                if (entity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.SubeAdi);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                            }
                            break;
                        case "repositoryBankaHesap":
                            {
                                if (!_nameColumn.OptionsColumn.AllowEdit) return;

                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);
                                var odemeTipi = _tablo.GetFocusedRowCellValue("OdemeTipi").ToString().GetEnum<OdemeTipi>();

                                var entity = (BankaHesapL)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.BankaHesap, id, odemeTipi);
                                if (entity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.HesapAdi);
                                    _tablo.SetFocusedRowCellValue("BlokeGunSayisi", entity.BlokeGunSayisi);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                            }
                            break;
                        case "repositoryIptalNedeni":
                            {
                                if (!_nameColumn.OptionsColumn.AllowEdit) return;

                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);
                                var entity = (IptalNedeni)ShowListForms<IptalNedeniListForm>.ShowDialogListForm(KartTuru.IptalNedeni, id);
                                if (entity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.IptalNedeniAdi);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                            }
                            break;
                        case "repositoryItemTuketimDepo":
                        case "repositoryItemDepo":
                            {
                                if (!_nameColumn.OptionsColumn.AllowEdit) return;

                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);
                                var entity = (WareHouse)ShowListForms<WarehouseListForm>.ShowDialogListForm(KartTuru.Depo, id);
                                if (entity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.Kod);
                                    _tablo.SetFocusedRowCellValue(_nameGridColumn, entity.WarehouseName);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                            }
                            break;
                        case "repositoryItemOperasyon":
                            {
                                if (!_nameColumn.OptionsColumn.AllowEdit) return;

                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);
                                var entity = (Operasyon)ShowListForms<OperasyonListForm>.ShowDialogListForm(KartTuru.Operasyon, id);
                                if (entity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.Kod);
                                    _tablo.SetFocusedRowCellValue(_nameGridColumn, entity.OperasyonAdi);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                            }
                            break;
                        case "repositoryItemMakina":
                            {
                                if (!_nameColumn.OptionsColumn.AllowEdit) return;

                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);
                                var entity = (MakinaL)ShowListForms<MakinaListForm>.ShowDialogListForm(KartTuru.Makina, id);
                                if (entity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.Kod);
                                    _tablo.SetFocusedRowCellValue(_nameGridColumn, entity.MakinaAdi);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                            }
                            break;
                        case "repositoryItemPersonel":
                            {
                                if (!_nameColumn.OptionsColumn.AllowEdit) return;

                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);
                                var entity = (PersonelL)ShowListForms<PersonelListForm>.ShowDialogListForm(KartTuru.Personel, id);
                                if (entity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.Adi + " " + entity.Soyadi);
                                    _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                            }
                            break;
                        case "repositoryButtonVardiya":
                            {
                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);
                                var entity = (Vardiya)ShowListForms<VardiyaListForm>.ShowDialogListForm(KartTuru.Vardiya, id);
                                if (entity != null)
                                {
                                    _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                    _tablo.SetFocusedRowCellValue(_nameColumn, entity.VardiyaAdi);
                                    //_tablo.SetFocusedRowCellValue(_nameGridColumn, entity.VardiyaAdi);

                                    // _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                }
                            }
                            break;
                        case "repositoryItemButtonTuketimKalemleri":// operasyona bağlı tüketim kalemlerin seçimi için düzenlenmiştir..
                            {
                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                //var id = _tablo.GetRowCellId(_idColumn);

                                var liste = new List<ReceteBilgileriL>();

                                liste = _tablo.DataController.ListSource.Cast<ReceteBilgileriL>().Where(x => x.OperasyonBilgileriId == 0).ToList();

                                var entities = ShowListForms<OperasyonaBagliTuketilecekReceteBilesenleriList>.ShowDialogListForm(KartTuru.Recete, liste.Select(x => (long)x.Id).ToList(), true).EntityListConvert<ReceteBilgileri>(true, false);

                                if (entities == null) return;

                                foreach (var item in entities)
                                {
                                    var index = _tablo.DataController.ListSource.Cast<ReceteBilgileri>().Where(x => x.Id == item.Id).FirstOrDefault();
                                    _tablo.FocusedRowHandle = _tablo.DataController.ListSource.IndexOf(index);
                                    var it = _tablo.FocusedRowHandle;
                                    _tablo.SetFocusedRowCellValue(_idColumn, _operasyonBilgileriId);

                                    var kkkkkk = _tablo.DataController.ListSource.Cast<ReceteBilgileri>().Where(x => x.Id == item.Id).FirstOrDefault();
                                    var mmmmm = _tablo.DataController.ListSource.Cast<ReceteBilgileri>().ToList();
                                }
                            }
                            break;
                        case "repositoryHesap":
                            {

                                //var id =(long)_tablo.GetRowCellValue(_tablo.FocusedRowHandle, _idColumn);
                                var id = _tablo.GetRowCellId(_idColumn);

                                switch (_tablo.GetRow<GeriOdemeBilgileriL>().HesapTuru)
                                {
                                    case GeriOdemeHesapTuru.Banka:
                                        {
                                            var entity = (BankaHesapL)ShowListForms<BankaHesapListForm>.ShowDialogListForm(KartTuru.BankaHesap, id, OdemeTipi.Elden);

                                            if (entity == null) return;

                                            _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                            _tablo.SetFocusedRowCellValue(_nameColumn, entity.HesapAdi);
                                            _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);

                                            break;
                                        }
                                    case GeriOdemeHesapTuru.Kasa:
                                        {
                                            var entity = (KasaL)ShowListForms<KasaListForm>.ShowDialogListForm(KartTuru.Kasa, id);
                                            if (entity == null) return;
                                            {
                                                _tablo.SetFocusedRowCellValue(_idColumn, entity.Id);
                                                _tablo.SetFocusedRowCellValue(_nameColumn, entity.KasaAdi);
                                                _navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
                                            }
                                            break;
                                        }
                                }

                            }
                            break;
                    }
                }
    }
}
    


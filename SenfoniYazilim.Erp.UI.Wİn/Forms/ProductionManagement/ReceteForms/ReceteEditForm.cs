using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.ReceteEditFormTable;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms
{
    public partial class ReceteEditForm : BaseEditForm
    {
        private readonly List<Birim> _units;
        private readonly List<WareHouse> _warehouses;

        private BaseTablo _receteBilesenleriTable;
        private BaseTablo _makinaBilgileriTable;
        private BaseTablo _makinaElemanlariTable;

        private long _kodId;
        protected internal readonly bool _durumKontrol;
        protected internal readonly IEnumerable<MalzemeIhtiyacBilgileriL> _mibListReceteBilesenleri;
        protected internal readonly IList _source;
        protected internal readonly GridView _tablo;

        public ReceteEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new ReceteBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Recete;
            EventsLoad();
            ShowItems = new BarItem[] { btnIceriVeriAktar ,btnKolonlar};
            KayitSonrasiFormuKapat = false;

            _units = GetAnySingleOrListBll.ListUnitItems(null);
            _warehouses = GetAnySingleOrListBll.ListWarehouses(null);

            txtCinsi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<UrunCinsi>());
            txtReceteDepo.FillLookUpEdit(_warehouses, "Id", "WarehouseName");
            txtReceteBirim.FillLookUpEdit(_units, "Id", "BirimAdi");
        }

        public ReceteEditForm(params object[] prm):this()
        {
            _durumKontrol=(bool)prm[0];
            //_mibListReceteBilesenleri = (IEnumerable<MalzemeIhtiyacBilgileriL>)prm[1];
            //_source = (IList)prm[2];
            //_tablo = (GridView)prm[3];

            if(_durumKontrol)
                HideItems = new BarItem[] { btnIceriVeriAktar, btnKolonlar,btnYeni,btnSil };
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new ReceteS() : ((ReceteBll)Bll).Single(FilterFunctions.Filter<Recete>(Id));

            if (BaseIslemTuru == IslemTuru.EntityInsert)
            {
                Id = BaseIslemTuru.IdOlustur(OldEntity);
                ((ReceteS)OldEntity).ReceteBirimId = _units?.FirstOrDefault().Id;
                ((ReceteS)OldEntity).DepoId = Convert.ToInt64(_warehouses?.FirstOrDefault().Id);
                ((ReceteS)OldEntity).Miktar = 1;
                NesneyiKontrollereBagla();
                TabloYukle();
                BagliTabloYukle();
                return;
            }

            NesneyiKontrollereBagla();

            BagliTabloYukle();
           
        }

        protected override void BagliTabloYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Insert || x.Update || x.Delete);
            }

            if (receteOperasyonBilgiTable.OwnerForm == null)
            {
                receteOperasyonBilgiTable.OwnerForm = this;
                receteOperasyonBilgiTable.Yukle();
            }
            if (_receteBilesenleriTable != null && TableValueChanged(_receteBilesenleriTable))
                _receteBilesenleriTable.Yukle();
            if (_makinaElemanlariTable != null && TableValueChanged(_makinaElemanlariTable))
                _makinaElemanlariTable.Yukle();
            if (_makinaBilgileriTable != null && TableValueChanged(_makinaBilgileriTable))
                _makinaBilgileriTable.Yukle();

            if (TableValueChanged(receteOperasyonBilgiTable))
            {
                var rowHandle = receteOperasyonBilgiTable.Tablo.FocusedRowHandle;
                receteOperasyonBilgiTable.Yukle();
                receteOperasyonBilgiTable.Tablo.FocusedRowHandle = rowHandle;
            }

        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (ReceteS)OldEntity;

            txtKod.Id = Id;
            txtKod.Text = entity.Kod;
            txtMalzemeKod.Id = entity.StokId;
            txtMalzemeKod.Text = entity.Kod;
            txtStokAdi.Text = entity.StokAdi;
            txtMalzemeBirim.Text = entity.MalzemeBirimAdi;
            txtMalzemeDepo.Text = entity.MalzemeDepoKodu;
            txtMalzemeDepoAdi.Text = entity.MalzemeDepoAdi;
            txtCinsi.Text = entity.UrunCinsi.toName();
            txtReceteAdi.Text = entity.ReceteAdi!=null?entity.ReceteAdi:entity.StokAdi;
            txtReceteDepo.EditValue = entity.DepoId;
            txtReceteBirim.EditValue = entity.ReceteBirimId;
            txtMiktar.EditValue = entity.Miktar;
            tglDurum.IsOn = entity.Durum;
            tglVarsayılan.IsOn = entity.Varsayılan;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Recete
            {
                Id = Id,
                Kod = txtKod.Text,
                ReceteAdi = txtReceteAdi.Text,
                StokId =Convert.ToInt64( txtMalzemeKod.Id),
                DepoId= Convert.ToInt64(txtReceteDepo.EditValue),
                ReceteBirimId=Convert.ToInt64( txtReceteBirim.EditValue),
                Miktar=(decimal)txtMiktar.EditValue,
                Durum=tglDurum.IsOn,
                Varsayılan=tglVarsayılan.IsOn
                
            };           

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            if (BagliTabloHataliGirisKontrol()) return false;
            var recete = ((ReceteBll)Bll).Single(x => x.StokId == ((Recete)CurrentEntity).StokId&&x.Varsayılan).EntityCovert<Recete>();
            if (recete != null && ((Recete)CurrentEntity).Varsayılan)
            {
                recete.Varsayılan = false;
                ((ReceteBll)Bll).Update(recete);
            }
            if(_receteBilesenleriTable!=null)
                _receteBilesenleriTable.Tablo.DataController.ListSource.Add(AddMainBomItem());
            var hhh = _receteBilesenleriTable.Tablo.DataController.ListSource;
            var result = ((ReceteBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod)&& BagliTabloKaydet();
            if (result && !KayitSonrasiFormuKapat)
                BagliTabloYukle();

            return result;
        }

        protected override bool EntityUpdate()
        {
            if (BagliTabloHataliGirisKontrol()) return false;

            var recete = ((ReceteBll)Bll).Single(x => x.StokId == ((Recete)OldEntity).StokId&&x.Varsayılan).EntityCovert<Recete>();
            if (recete != null&&recete.Id!=OldEntity.Id && recete.Varsayılan && ((Recete)CurrentEntity).Varsayılan)
            {
                recete.Varsayılan = !recete.Varsayılan;
                ((ReceteBll)Bll).Update(recete);
            }
            var result = ((ReceteBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod) && BagliTabloKaydet();// && BagliTabloKaydet();

            if (result && !KayitSonrasiFormuKapat)
                BagliTabloYukle();
            return result;
        }

        protected override void EntityDelete()
        {
            if (_receteBilesenleriTable!=null&& _receteBilesenleriTable.TopluHareketSil())
                Messages.TopluHareketSilMesaj(_receteBilesenleriTable.Tablo.ViewCaption);
            if (_makinaBilgileriTable!=null && _makinaBilgileriTable.TopluHareketSil())
                Messages.TopluHareketSilMesaj(_makinaBilgileriTable.Tablo.ViewCaption);
            if (_makinaElemanlariTable != null && _makinaElemanlariTable.TopluHareketSil())
                Messages.TopluHareketSilMesaj(_makinaElemanlariTable.Tablo.ViewCaption);
            if (receteOperasyonBilgiTable.TopluHareketSil())
                Messages.TopluHareketSilMesaj(receteOperasyonBilgiTable.Tablo.ViewCaption);
            if (!((ReceteBll)Bll).Delete(OldEntity))
                Messages.TopluHareketSilMesaj(OldEntity.Kod);
            RefreshYapilacak = true;
            Close();
        }

        protected override bool BagliTabloHataliGirisKontrol()
        {
            if (_receteBilesenleriTable != null && _receteBilesenleriTable.HatalıGiriş())
            {
                tabPane1.SelectedPage = pageBilesenler;
                _receteBilesenleriTable.Tablo.GridControl.Focus();
                return true;
            }
            if (_makinaBilgileriTable != null && _makinaBilgileriTable.HatalıGiriş())
            {
                tabPane1.SelectedPage = pageMakinalar;
                _makinaBilgileriTable.Tablo.GridControl.Focus();
                return true;
            }
            if (_makinaElemanlariTable != null && _makinaElemanlariTable.HatalıGiriş())
            {
                tabPane1.SelectedPage = pageMakinaElemanlari;
                _makinaElemanlariTable.Tablo.GridControl.Focus();
                return true;
            }

            return false;
        }

        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (receteOperasyonBilgiTable.TableValueChanged) return true;
                if (_receteBilesenleriTable!=null && _receteBilesenleriTable.TableValueChanged) return true;
                if (_makinaBilgileriTable!=null && _makinaBilgileriTable.TableValueChanged) return true;
                if (_makinaElemanlariTable!=null && _makinaElemanlariTable.TableValueChanged) return true;

                return false;
            }

            Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, TableValueChanged());
        }
               
        protected override void VeriAktar()
        {
            var list = new List<ReceteOperasyonMakinaBilgileri>();
            Expression<Func<ReceteOperasyonMakinaBilgileri, bool>> filter;
            filter = null;//x => x.Id != 0;
            ShowVeriAktarEditForms<VeriAktarimListForm, ReceteOperasyonMakinaBilgileri, ReceteOperasyonMakinaBilgileriBll>.ShowDialogListForm(KartTuru.Recete, filter, new ReceteOperasyonMakinaBilgileriBll());
        }
        
        protected override bool BagliTabloKaydet()
        {
            if (_receteBilesenleriTable!=null&& !_receteBilesenleriTable.Kaydet()) return false;
            if (_makinaBilgileriTable!=null&& !_makinaBilgileriTable.Kaydet()) return false;
            if (_makinaElemanlariTable!=null&& !_makinaElemanlariTable.Kaydet()) return false;
            if (!receteOperasyonBilgiTable.Kaydet()) return false;

            return true;
        }
        
        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (!IsLoaded) return;
            //if (receteOperasyonBilgiTable.Tablo.DataController.ListSource.Count == 0 )
            //{
            //    tabPane1.SelectedPage = pageOperasyonBilgileri;
            //    Messages.BilgiMesaji("Lütfen Operasyon Bilgisi Giriniz");
            //    receteOperasyonBilgiTable.Focus();
            //    return;
            //}
            if (txtMalzemeKod.Text == null)
            {
                Messages.BilgiMesaji("Lütfen Malzeme Seçiniz");
                txtMalzemeKod.Focus();
                return;
            }
            else if (e.Page == pageOperasyonBilgileri)
            { 
                receteOperasyonBilgiTable.Tablo.GridControl.Focus();
            }
            else if (e.Page == pageBilesenler)
            {
                if (pageBilesenler.Controls.Count == 0)
                {
                    _receteBilesenleriTable = new ReceteBilesenBilgileriTable().AddTable(this);
                    pageBilesenler.Controls.Add(_receteBilesenleriTable);
                    _receteBilesenleriTable.Yukle();
                }
                _receteBilesenleriTable.Tablo.Focus();
            }
            else if (e.Page == pageMakinalar)
            {
                if (pageMakinalar.Controls.Count == 0)
                {
                    _makinaBilgileriTable = new ReceteOperasyonMakinaBilgileriTable().AddTable(this);
                    pageMakinalar.Controls.Add(_makinaBilgileriTable);
                    _makinaBilgileriTable.Yukle();
                }
                _makinaBilgileriTable.Tablo.Focus();
            }
            else if (e.Page == pageMakinaElemanlari)
            {
                if (pageMakinaElemanlari.Controls.Count == 0)
                {
                    _makinaElemanlariTable = new ReceteMakinaElemaniBilgileriTable().AddTable(this);
                    pageMakinaElemanlari.Controls.Add(_makinaElemanlariTable);
                    _makinaElemanlariTable.Yukle();
                }
                _makinaElemanlariTable.Tablo.Focus();
            }
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is MyButtonEdit btn)) return;
            {
                using (var sec=new SelectFunctions())
                {
                    if (sender == txtMalzemeKod)
                    {
                        var materialL = new MaterialL();
                        var liste = ((ReceteBll)Bll).List(null).EntityListConvert<ReceteL>().Select(x => x.StokId).ToList();
                        _kodId = txtMalzemeKod.Id.Value;
                        //sec.Sec(txtMalzemeKod, txtStokAdi,liste);
                        materialL=(MaterialL)sec.Sec(txtMalzemeKod, materialL);
                        if (materialL == null) return;
                        txtKod.Text = materialL?.Kod;
                        txtReceteAdi.Text = materialL?.StockName;
                        txtReceteDepo.EditValue = materialL?.DepoId;
                        txtReceteBirim.EditValue = materialL?.UnitId;
                        txtMalzemeKod.Id = materialL?.Id;
                        txtMalzemeKod.Text = materialL?.Kod;
                        txtStokAdi.Text = materialL.StockName;
                        txtMalzemeBirim.Text = materialL?.UnitName;
                        txtMalzemeBirim.Id =(long)materialL.UnitId;
                        txtMalzemeDepo.Text = materialL?.DepoKodu;
                        txtMalzemeDepoAdi.Text = materialL?.DepoAdi;

                    }
                    if (((ReceteBll)Bll).List(x => x.StokId == ((ReceteS)OldEntity).StokId).EntityListConvert<Recete>().Any(x => x.Varsayılan))
                        tglVarsayılan.IsOn = false;
                }
            }
        }

        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //base.BaseEditForm_FormClosing(sender, e);

            if (btnKaydet.Visibility == BarItemVisibility.Never || !btnKaydet.Enabled) return;

            if (!Kaydet(true))
                e.Cancel = true;
        }

        private ReceteBilgileriL AddMainBomItem()
        {
            var row = new ReceteBilgileriL
            {
                ReceteId = Id,
                StokId = (long)txtMalzemeKod.Id,
                TuketimBirimId =(long)txtReceteBirim.EditValue,
                Miktar = txtMiktar.Value,
                TuketimDepoId =(long) txtReceteDepo.EditValue,
                Uretilebilir = Uretilebilir.AnaKod,
                Insert = true
            };

            return row;
        }
    }
}
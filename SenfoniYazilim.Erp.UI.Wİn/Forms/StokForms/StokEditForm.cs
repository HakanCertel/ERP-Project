using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Collections.Generic;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.Bll.Functions;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms.MaterialTables;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using DevExpress.XtraBars.Navigation;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.DefinationsForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms
{
    public partial class StokEditForm : BaseEditForm
    {
       
        private readonly List<Birim> _unitList;

        private BaseTablo _materialUnitsTable;

        public StokEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new MaterialBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Stok;
            EventsLoad();
            ShowItems = new BarItem[] { btnFeatures };

            KayitSonrasiFormuKapat = false;

            _unitList = GetAnySingleOrListBll.ListUnitItems();

            txtCinsi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<UrunCinsi>().Cast<object>().ToList());

            txtUnit.FillLookUpEdit(_unitList, "Id", "Kod");
        }
        public  override void Yukle()
        {
            if (BaseIslemTuru == IslemTuru.EntityInsert && txtKod.EditValue != null)

                OldEntity = new MaterialS
                {
                    Id = 0,
                    Kod = txtKod.Text,
                    StockName = txtStokAdi.Text,
                    UnitCode = txtUnit.Text,
                    DepoId = Convert.ToInt64(txtDepom.Id),
                    DepoKodu=txtDepom.Text,
                    DepoAdi=txtDepoAdi.Text,
                    UrunCinsi = txtCinsi.Text.GetEnum<UrunCinsi>(),
                    Durum = tglDurum.IsOn,
                    Uretilebilir = tglUretilebilir.IsOn
                };
            else
                OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new MaterialS() : ((MaterialBll)Bll).Single(FilterFunctions.Filter<Material>(Id));
            
            NesneyiKontrollereBagla();

            BagliTabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            //txtKod.Text = ((StokBll)Bll).YeniKodVer();
            txtKod.Focus();
        }

        //üsteki metodla alınan veriyi kontrollere bağlamak için aşağıdaki metod oluşturulacaktır..
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MaterialS)OldEntity;

            txtKod.Text = entity.Kod;
            txtKod.Id = entity.Id;
            txtStokAdi.Text = entity.StockName;
            txtUnit.EditValue = entity.UnitId;
            txtDepom.Id =Convert.ToInt64( entity.DepoId);
            txtDepom.Text = entity.DepoKodu;
            txtDepoAdi.Text = entity.DepoAdi;
            txtCinsi.SelectedItem = entity.UrunCinsi.toName();
            tglDurum.IsOn = entity.Durum;
            tglUretilebilir.IsOn = entity.Uretilebilir;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Material
            {
                Id = Id,
                Kod = txtKod.Text,
                StockName = txtStokAdi.Text,
                UnitId =Convert.ToInt64( txtUnit.EditValue),                
                DepoId =Convert.ToInt64(txtDepom.Id),
                UrunCinsi = txtCinsi.Text.GetEnum<UrunCinsi>(),
                Durum = tglDurum.IsOn,
                Uretilebilir=tglUretilebilir.IsOn,
                
                Feature1Id=((Material)OldEntity).Feature1Id,
                Feature2Id = ((Material)OldEntity).Feature2Id,
                Feature3Id = ((Material)OldEntity).Feature3Id,
                Feature4Id = ((Material)OldEntity).Feature4Id,
                Feature5Id = ((Material)OldEntity).Feature5Id,
                Feature6Id = ((Material)OldEntity).Feature6Id,
                Feature7Id = ((Material)OldEntity).Feature7Id,
                Feature8Id = ((Material)OldEntity).Feature8Id,
                Feature9Id = ((Material)OldEntity).Feature9Id,
                Feature10Id = ((Material)OldEntity).Feature10Id,
                Feature11Id = ((Material)OldEntity).Feature11Id,
                Feature12Id = ((Material)OldEntity).Feature12Id,
                Feature13Id = ((Material)OldEntity).Feature13Id,
                Feature14Id = ((Material)OldEntity).Feature14Id,
                Feature15Id = ((Material)OldEntity).Feature15Id,
                Feature16Id = ((Material)OldEntity).Feature16Id,
                Feature17Id = ((Material)OldEntity).Feature17Id,
                Feature18Id = ((Material)OldEntity).Feature18Id,
                Feature19Id = ((Material)OldEntity).Feature19Id,
                Feature20Id = ((Material)OldEntity).Feature20Id,
            };

            ButonEnabledDurumu();
        }
        protected override bool EntityInsert()
        {
            if (BagliTabloHataliGirisKontrol()) return false;

            var result = ((MaterialBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod) && BagliTabloKaydet();

            if (result && !KayitSonrasiFormuKapat)
                BagliTabloYukle();

            return result;
        }

        protected override bool EntityUpdate()
        {
            if (BagliTabloHataliGirisKontrol()) return false;

            var result = ((MaterialBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod) && BagliTabloKaydet();

            if (result && !KayitSonrasiFormuKapat)
                BagliTabloYukle();

            return result;
        }

        protected override void SecimYap(object sender)
        {
            if (sender is SimpleButton)
            {
                var entity =SelectFunctions.Sec<MaterialL>(txtKod);
                if (entity == null) return;
                txtKod.Text = entity.Kod;
                txtKod.Id = entity.Id;
                txtStokAdi.Text = entity.StockName;
                txtCinsi.SelectedItem = entity.UrunCinsi.toName();
                tglDurum.IsOn = entity.Durum;
                tglUretilebilir.IsOn = entity.Uretilebilir;
            }
            if(sender is MyButtonEdit)
            {
                using (var sec = new SelectFunctions())
                    if (sender == txtDepom)
                        sec.Sec(txtDepom, txtDepoAdi);
            }
        }

        protected override void BagliTabloYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Insert || x.Update || x.Delete);
            }

            if (_materialUnitsTable != null && TableValueChanged(_materialUnitsTable))
                _materialUnitsTable.Yukle();

        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (_materialUnitsTable != null && _materialUnitsTable.TableValueChanged) return true;

                return false;
            }

            Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial, OldEntity, CurrentEntity, TableValueChanged());

        }

        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page == pageGenel)
                btnMrpSorumlu.Focus();

            else if (e.Page == pageBirimler)
            {
                if (pageBirimler.Controls.Count == 0)
                {
                    _materialUnitsTable = new MaterialUnitsTable().AddTable(this);
                    pageBirimler.Controls.Add(_materialUnitsTable);
                    _materialUnitsTable.Yukle();
                }

                _materialUnitsTable.Tablo.GridControl.Focus();
            }

        }

        protected override bool BagliTabloKaydet()
        {
            if (_materialUnitsTable != null && !_materialUnitsTable.Kaydet()) return false;

            return true;

        }
        protected override bool BagliTabloHataliGirisKontrol()
        {
            if (_materialUnitsTable != null && _materialUnitsTable.HatalıGiriş()) return true;
            return false;
        }

        protected override void DefineFeature()
        {
            base.DefineFeature();
            var entity=ShowEditForms<DefinationAndFeaturesEditForm>.ShowDialogEditForm<Material>(KartTuru.Stok,(Material)OldEntity);
        }
    }
}
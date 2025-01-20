using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using System;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UretimSonuKayıtForms
{
    public partial class UretimSonuKayitEditFormPasif : BaseEditForm
    {
        private int _id;

        protected internal UretimSonuKayitBilgileriL _kayitBilgileriL;

        public UretimSonuKayitEditFormPasif()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new UretimSonuKayitBilgileriBll();
            BaseKartTuru = KartTuru.UretimSonuKayit;
            EventsLoad();
        }

        public override void Yukle()
        {
            _id = Convert.ToInt32(Id);

            NesneyiKontrollereBagla();

            BagliTabloYukle();
        }
        protected override void NesneyiKontrollereBagla()
        {
            OldEntity=new BaseEntity
            {
                Id=0,
                Kod=""
            };
            CurrentEntity = OldEntity;

            _kayitBilgileriL = (UretimSonuKayitBilgileriL) ((UretimSonuKayitBilgileriBll)Bll).Single(x => x.Id == _id);

            if (_kayitBilgileriL == null) return;           

            //txtKayitTarihi.EditValue = _kayitBilgileriL.KayitTarihi;
            //txtIsEmriKodu.Text = _kayitBilgileriL.IsEmriKodu;
            txtStokKodu.Text = _kayitBilgileriL.StokKodu;
            txtStokAdi.Text = _kayitBilgileriL.StokAdi;
            txtKayitMiktari.EditValue = _kayitBilgileriL.KayitMiktari;
        }
        protected override bool EntityUpdate()
        {
            if (BagliTabloHataliGirisKontrol()) return false;

            //var result = ((ReceteBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod); //&& BagliTabloKaydet();// && BagliTabloKaydet();
            var result1 = BagliTabloKaydet();
            if (result1 && !KayitSonrasiFormuKapat)
                uretimSonuKayitTable.Yukle();

            return result1;
        }
        protected override void EntityDelete()
        {
            
        }
        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
            if(sender is MyCalcEdit calcEdit)
            {
                var source = uretimSonuKayitTable.Tablo.DataController.ListSource.Cast<UretimSonuKayitBilgileriL>().ToList();

                //var oldEntity = (UretimSonuKayitBilgileriL)((UretimSonuKayitBilgileriBll)Bll).Single(x => x.Id == _id);

                source.ForEach(x => 
                {
                    x.KayitMiktari = calcEdit.Value * x.BirimIhtiyac;
                    x.Update = true;
                });

               // _kayitBilgileriL.FiltreleDataSource<UretimSonuKayitBilgileriL>(false, uretimSonuKayitTable.Tablo, x => !x.AnaKod);
            }

        }
        protected override void BagliTabloYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Insert || x.Update || x.Delete);
            }

            if (uretimSonuKayitTable.OwnerForm == null)
            {
                uretimSonuKayitTable.OwnerForm = this;
                uretimSonuKayitTable.Yukle();
            }
            
        }
        protected override bool BagliTabloKaydet()
        {
            if (!uretimSonuKayitTable.Kaydet()) return false;

            return true;
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (uretimSonuKayitTable.TableValueChanged) return true;               

                return false;
            }

            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial, OldEntity, CurrentEntity, TableValueChanged());
        }
        protected override bool BagliTabloHataliGirisKontrol()
        {
            if (uretimSonuKayitTable != null && uretimSonuKayitTable.HatalıGiriş())
            {
                uretimSonuKayitTable.Focus();
                return true;
            }
            return false;
        }
    }
}
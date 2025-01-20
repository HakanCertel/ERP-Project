using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraBars.Navigation;
using System.Linq;
using System;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.IstasyonForms
{
    public partial class IstasyonEditForm : BaseEditForm
    {
        public IstasyonEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IstasyonBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Istasyon;
            EventsLoad();
        }

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IstasyonS() : ((IstasyonBll)Bll).Single(FilterFunctions.Filter<Istasyon>(Id));

            NesneyiKontrollereBagla();
            BagliTabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IstasyonBll)Bll).YeniKodVer();
            txtIstasyonAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IstasyonS)OldEntity;

            txtKod.Text=entity.Kod;
            txtIstasyonAdi.Text = entity.IstasyonAdi;
            txtVardiyaSistemi.Id = entity.VardiyaId;
            txtVardiyaSistemi.Text = entity.VardiyaSistemAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;   
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Istasyon
            {
                Id=Id,
                Kod=txtKod.Text,
                IstasyonAdi=txtIstasyonAdi.Text,
                VardiyaId=Convert.ToInt64( txtVardiyaSistemi.Id),
                Aciklama=txtAciklama.Text,
                Durum=tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is MyButtonEdit)) return;

            using (var sec=new SelectFunctions())
            {
                if (sender == txtVardiyaSistemi)
                    sec.Sec(txtVardiyaSistemi);
            }
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (istasyonOperasyonBilgileriTable.TableValueChanged) return true;
                if (istasyon_Makina_Personel_BilgileriTable.TableValueChanged) return true;
                if (makina_MakinaElemenlari_BilgileriTable.TableValueChanged) return true;

                return false;
            }

            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial, OldEntity, CurrentEntity, TableValueChanged());
        }
        protected override bool EntityInsert()
        {
            if (BagliTabloHataliGirisKontrol()) return false;

            var result = ((IstasyonBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod) && BagliTabloKaydet();

            if (result && !KayitSonrasiFormuKapat)
                BagliTabloYukle();

            return result;
        }
        protected override bool EntityUpdate()
        {
            if (BagliTabloHataliGirisKontrol()) return false;

            var result = ((IstasyonBll)Bll).Update(OldEntity,CurrentEntity, x => x.Kod == CurrentEntity.Kod) && BagliTabloKaydet();

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

            if (istasyonOperasyonBilgileriTable.OwnerForm == null)
            {
                istasyonOperasyonBilgileriTable.OwnerForm = this;
                istasyonOperasyonBilgileriTable.Yukle();
            }
            if (istasyon_Makina_Personel_BilgileriTable.OwnerForm == null)
            {
                istasyon_Makina_Personel_BilgileriTable.OwnerForm = this;
                istasyon_Makina_Personel_BilgileriTable.Yukle();
            }
            if (makina_MakinaElemenlari_BilgileriTable.OwnerForm == null)
            {
                makina_MakinaElemenlari_BilgileriTable.OwnerForm = this;
                makina_MakinaElemenlari_BilgileriTable.Yukle();
            }
            if (TableValueChanged(istasyonOperasyonBilgileriTable))
            {
                var rowHandle = istasyonOperasyonBilgileriTable.Tablo.FocusedRowHandle;
                istasyonOperasyonBilgileriTable.Yukle();
                istasyonOperasyonBilgileriTable.Tablo.FocusedRowHandle = rowHandle;
            }
            if (TableValueChanged(istasyon_Makina_Personel_BilgileriTable))
            {
                var rowHandle = istasyon_Makina_Personel_BilgileriTable.Tablo.FocusedRowHandle;
                istasyon_Makina_Personel_BilgileriTable.Yukle();
                istasyon_Makina_Personel_BilgileriTable.Tablo.FocusedRowHandle = rowHandle;
            }
            if (TableValueChanged(makina_MakinaElemenlari_BilgileriTable))
            {
                var rowHandle = makina_MakinaElemenlari_BilgileriTable.Tablo.FocusedRowHandle;
                makina_MakinaElemenlari_BilgileriTable.Yukle();
                makina_MakinaElemenlari_BilgileriTable.Tablo.FocusedRowHandle = rowHandle;
            }
            

        }
        protected override bool BagliTabloKaydet()
        {
            if (!istasyonOperasyonBilgileriTable.Kaydet()) return false;
            if (!istasyon_Makina_Personel_BilgileriTable.Kaydet()) return false;
            if (!makina_MakinaElemenlari_BilgileriTable.Kaydet()) return false;

            return true;
        }
        protected override bool BagliTabloHataliGirisKontrol()
        {
            if (istasyonOperasyonBilgileriTable != null && istasyonOperasyonBilgileriTable.HatalıGiriş())
            {
                tabPane1.SelectedPage = pageOperasyonlar;
                istasyonOperasyonBilgileriTable.Focus();
                return true;
            }
            if (makina_MakinaElemenlari_BilgileriTable != null && makina_MakinaElemenlari_BilgileriTable.HatalıGiriş())
            {
                tabPane1.SelectedPage = pageMakinaElemenlari;
                makina_MakinaElemenlari_BilgileriTable.Focus();
                return true;
            }
            return false;
        }
        protected override void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (e.Page == pageOperasyonlar)
                istasyonOperasyonBilgileriTable.Focus();
            else if (e.Page == pagePersonel)
                istasyon_Makina_Personel_BilgileriTable.Focus();
            else if (e.Page == pageMakinaElemenlari)
                makina_MakinaElemenlari_BilgileriTable.Focus();
            //else if (e.Page == pageMakinalar)
            //{
            //    receteOperasyonMakinaBilgileriTable.Focus();

            //    var list = receteOperasyonBilgileriTable.Tablo.DataController.ListSource.Cast<ReceteOperasyonBilgileriL>().Where(x => x.ReceteId == Id).Select(x => x.OperasyonAdi).ToList();
            //    receteOperasyonMakinaBilgileriTable.repositoryItemComboOperasyon.Items.AddRange(list);
            //}
        }
        protected override void SablonKaydet()
        {
            base.SablonKaydet();
            istasyonOperasyonBilgileriTable.Tablo.TabloSablonKaydet(istasyonOperasyonBilgileriTable.Name + " Tablosu");
            istasyon_Makina_Personel_BilgileriTable.Tablo.TabloSablonKaydet(istasyon_Makina_Personel_BilgileriTable.Name + " Tablosu");
            makina_MakinaElemenlari_BilgileriTable.Tablo.TabloSablonKaydet(makina_MakinaElemenlari_BilgileriTable.Name + " Tablosu");
        }
        protected override void SablonYukle()
        {
            base.SablonYukle();
            istasyonOperasyonBilgileriTable.Tablo.TabloSablonYukle(istasyonOperasyonBilgileriTable.Name + " Tablosu");
            istasyon_Makina_Personel_BilgileriTable.Tablo.TabloSablonYukle(istasyon_Makina_Personel_BilgileriTable.Name + " Tablosu");
            makina_MakinaElemenlari_BilgileriTable.Tablo.TabloSablonYukle(makina_MakinaElemenlari_BilgileriTable.Name + " Tablosu");
        }

    }
}
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid.Events;
using System;

namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    public partial class DonemParametreEditForm : BaseEditForm
    {
        private readonly long _donemId;

        public DonemParametreEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new DonemParametreBll();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnYeni, btnSil };
            KayitSonrasiFormuKapat = false;
            EventsLoad();

            _donemId = (long)prm[0];
        }
        protected override void NesneyiKontrollereBagla()
        {
            var parametre = (DonemParametre)OldEntity;

            var entity = new DonemParametre
            {
                Id=parametre.Id,
                Kod=parametre.Kod,
                SubeId=parametre.SubeId,
                DonemId=parametre.DonemId,
                DonemBaslamaTarihi=parametre.DonemBaslamaTarihi,
                DonemBitisTarihi=parametre.DonemBitisTarihi,
                EgitimBaslamaTarihi=parametre.EgitimBaslamaTarihi,
                EgitimBitisTarihi=parametre.EgitimBitisTarihi,
                GünTarihininOncesineHizmetBaslamaTarihiGirilebilir=parametre.GünTarihininOncesineHizmetBaslamaTarihiGirilebilir,
                GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir=parametre.GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir,
                GünTarihininOncesineIptalTarihiGirilebilir=parametre.GünTarihininOncesineIptalTarihiGirilebilir,
                GünTarihininSonrasinaIptalTarihiGirilebilir=parametre.GünTarihininSonrasinaIptalTarihiGirilebilir,
                GünTarihininOncesineMakbuzTarihiGirilebilir=parametre.GünTarihininOncesineMakbuzTarihiGirilebilir,
                GünTarihininSonrasinaMakbuzTarihiGirilebilir=parametre.GünTarihininSonrasinaMakbuzTarihiGirilebilir,
                HizmetTahakkukKurusKullan=parametre.HizmetTahakkukKurusKullan,
                IndirimTahakkukKurusKullan=parametre.IndirimTahakkukKurusKullan,
                OdemePlaniKurusKullan=parametre.OdemePlaniKurusKullan,
                FaturaTahakkukKurusKullan=parametre.FaturaTahakkukKurusKullan,
                MaksimumTaksitTarihi=parametre.MaksimumTaksitTarihi,
                MaksimumTaksitSayisi=parametre.MaksimumTaksitSayisi,
                GittigiOkulZorunlu=parametre.GittigiOkulZorunlu,
                YetkiKontroluAnlikYapilacak=parametre.YetkiKontroluAnlikYapilacak
            };
            Id = entity.Id;
            propertyGridControl.SelectedObject = entity;
        }
        /// <summary>
        /// aşağıda if kontrolü ile subeId kontrolü yapılmasının sebebi sube Id null gelldiğinde hata alınmaktadır
        /// budurumu engellemek için eğer sube ıd null ise iki adet Instance olusturuyoruz.
        /// </summary>
        protected override void GuncelNesneOlustur()
        {
            if (txtSube.Id == null)
            {
                OldEntity = new DonemParametre();
                CurrentEntity = new DonemParametre();
                ButonEnabledDurumu();
                return;
            }
            CurrentEntity = new DonemParametre
            {
                Id = Id,
                Kod = Id.ToString(),
                SubeId =Convert.ToInt64( txtSube.Id),
                DonemId = _donemId,
                DonemBaslamaTarihi=(DateTime)DonemBaslamaTarihi.Value,
                DonemBitisTarihi=(DateTime)DonemBitisTarihi.Value,
                EgitimBaslamaTarihi=(DateTime)EgitimBaslamaTarihi.Value,
                EgitimBitisTarihi=(DateTime)EgitimBitisTarihi.Value,
                GünTarihininOncesineHizmetBaslamaTarihiGirilebilir=(bool)GünTarihininOncesineHizmetBaslamaTarihiGirilebilir.Properties.Value,
                GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir=(bool)GünTarihininSonrasinaHizmetBaslamaTarihiGirilebilir.Properties.Value,
                GünTarihininOncesineIptalTarihiGirilebilir=(bool)GünTarihininOncesineIptalTarihiGirilebilir.Properties.Value,
                GünTarihininSonrasinaIptalTarihiGirilebilir=(bool)GünTarihininSonrasinaIptalTarihiGirilebilir.Properties.Value,
                GünTarihininOncesineMakbuzTarihiGirilebilir=(bool)GünTarihininOncesineMakbuzTarihiGirilebilir.Properties.Value,
                GünTarihininSonrasinaMakbuzTarihiGirilebilir=(bool)GünTarihininSonrasinaMakbuzTarihiGirilebilir.Properties.Value,
                HizmetTahakkukKurusKullan=(bool)HizmetTahakkukKurusKullan.Properties.Value,
                IndirimTahakkukKurusKullan=(bool)IndirimTahakkukKurusKullan.Properties.Value,
                OdemePlaniKurusKullan=(bool)OdemePlaniKurusKullan.Properties.Value,
                FaturaTahakkukKurusKullan=(bool)FaturaTahakkukKurusKullan.Properties.Value,
                GittigiOkulZorunlu=(bool)GittigiOkulZorunlu.Properties.Value,
                MaksimumTaksitSayisi=(byte)MaksimumTaksitSayisi.Properties.Value,
                MaksimumTaksitTarihi=(DateTime)MaksimumTaksitTarihi.Properties.Value,
                YetkiKontroluAnlikYapilacak=(bool)YetkiKontroluAnlikYapilacak.Properties.Value,

            };

            ButonEnabledDurumu();
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtSube)
                    sec.Sec(txtSube);
        }
        protected override void Control_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            GuncelNesneOlustur();
        }
        protected override void Control_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            statusBarAciklama.Caption = e.Row.Properties.Caption;
        }
        protected override void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!(sender is ButtonEdit)) return;

            if (txtSube.Id == null) return;

            OldEntity = ((DonemParametreBll)Bll).Single(x => x.SubeId == txtSube.Id && x.DonemId == _donemId) ?? new DonemParametre();
            BaseIslemTuru = OldEntity.Id == 0 ? IslemTuru.EntityInsert : IslemTuru.EntityUpdate;
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
        }
        protected override void Control_EnabledChanged(object sender, EventArgs e)
        {
            
            if (sender != txtSube) return;
            txtSube.ControlEnabledChanged(propertyGridControl);
            GuncelNesneOlustur();
        }
    }
}
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

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.OgrenciForms
{
    public partial class PersonelEditForm : BaseEditForm
    {
        public PersonelEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new PersonelBll(myDataLayoutControl);
            txtCinsiyet.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<Cinsiyet>());
            txtKanGrubu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KanGrubu>());
            BaseKartTuru = KartTuru.Personel;
            EventsLoad();
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new PersonelS() : ((PersonelBll)Bll).Single(FilterFunctions.Filter<Personel>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((PersonelBll)Bll).YeniKodVer();
            txtTcKimlikNo.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (PersonelS)OldEntity;
            txtKod.Text = entity.Kod;
            txtTcKimlikNo.Text = entity.TcKimlikNo;
            txtAd.Text = entity.Adi;
            txtSoyadi.Text = entity.Soyadi;
            txtBaba.Text = entity.BabaAdi;
            txtAna.Text = entity.AnaAdi;
            txtDogumYeri.Text = entity.DogumYeri;
            txtDogumTarihi.EditValue = entity.DogumTarihi;
            txtKanGrubu.SelectedItem = entity.KanGrubu.toName();
            txtSeriNo.Text = entity.KimlikSeri;
            txtSiraNo.Text = entity.KimlikSiraNo;
            txtNufusIlAdi.Id = entity.KimlikIlId;
            txtNufusIlAdi.Text = entity.KimlikIlAdi;
            txtNufusIlceAdi.Id = entity.KimlikIlceId;
            txtNufusIlceAdi.Text = entity.KimlikIlceAdi;
            txtMahalleKoy.Text = entity.KimlikMahalleKoy;
            txtCiltNo.Text = entity.KimlikCiltNo;
            txtAileSiraNo.Text = entity.KimlikAileSiraNo;
            txtBireySiraNo.Text = entity.KimlikBireySiraNo;
            txtVerildiğiYer.Text = entity.KimlikVerildiğiYer;
            txtVerilisNedeni.Text = entity.KimlikVerilisNedeni;
            txtKayitNo.Text = entity.KimlikKayitNo;
            txtVerilisTarihi.EditValue = entity.KimlikVerilisTarihi;
            txtTelefonu.Text = entity.Telefon;
            txtCinsiyet.SelectedItem = entity.Cinsiyet.toName();
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtOzelKod3.Id = entity.OzelKod3Id;
            txtOzelKod3.Text = entity.OzelKod3Adi;
            txtOzelKod4.Id = entity.OzelKod4Id;
            txtOzelKod4.Text = entity.OzelKod4Adi;
            txtOzelKod5.Id = entity.OzelKod5Id;
            txtOzelKod5.Text = entity.OzelKod5Adi;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Personel
            {
                Id = Id,
                Kod = txtKod.Text,
                TcKimlikNo = txtTcKimlikNo.Text,
                Adi = txtAd.Text,
                Soyadi = txtSoyadi.Text,
                BabaAdi = txtBaba.Text,
                AnaAdi = txtAna.Text,
                DogumYeri = txtDogumYeri.Text,
                DogumTarihi = (DateTime?)txtDogumTarihi.EditValue,
                KanGrubu = txtKanGrubu.Text.GetEnum<KanGrubu>(),
                KimlikSeri = txtSeriNo.Text,
                KimlikSiraNo = txtSiraNo.Text,
                KimlikIlId = txtNufusIlAdi.Id,
                KimlikIlceId = txtNufusIlceAdi.Id,
                KimlikMahalleKoy = txtMahalleKoy.Text,
                KimlikCiltNo = txtCiltNo.Text,
                KimlikAileSiraNo = txtAileSiraNo.Text,
                KimlikBireySiraNo = txtBireySiraNo.Text,
                KimlikVerildiğiYer = txtVerildiğiYer.Text,
                KimlikVerilisNedeni = txtVerilisNedeni.Text,
                KimlikKayitNo = txtKayitNo.Text,
                KimlikVerilisTarihi = (DateTime?)txtVerilisTarihi.EditValue,
                Telefon = txtTelefonu.Text,
                Cinsiyet=txtCinsiyet.Text.GetEnum<Cinsiyet>(),
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                OzelKod3Id = txtOzelKod3.Id,
                OzelKod4Id = txtOzelKod4.Id,
                OzelKod5Id = txtOzelKod5.Id,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtNufusIlAdi)
                    sec.Sec(txtNufusIlAdi);
                else if (sender == txtNufusIlceAdi)
                    sec.Sec(txtNufusIlceAdi, txtNufusIlAdi);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Ogrenci);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Ogrenci);
                else if (sender == txtOzelKod3)
                    sec.Sec(txtOzelKod3, KartTuru.Ogrenci);
                else if (sender == txtOzelKod4)
                    sec.Sec(txtOzelKod4, KartTuru.Ogrenci);
                else if (sender == txtOzelKod5)
                    sec.Sec(txtOzelKod5, KartTuru.Ogrenci);
        }

        protected override void Control_EnabledChanged(object sender, EventArgs e)
        {
            if (sender !=  txtNufusIlAdi) return;
            if (sender == txtNufusIlAdi)
                txtNufusIlAdi.ControlEnabledChanged(txtNufusIlceAdi);
        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(resimMenu);
        }
    }
}
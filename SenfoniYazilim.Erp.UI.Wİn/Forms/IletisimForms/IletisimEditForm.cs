using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraEditors;
using System;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.IletisimForms
{
    public partial class IletisimEditForm : BaseEditForm
    {
        public IletisimEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IletisimBll(myDataLayoutControl);
            txtKanGrubu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KanGrubu>());
            BaseKartTuru = KartTuru.Iletisim;
            EventsLoad();
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IletisimS() : ((IletisimBll)Bll).Single(FilterFunctions.Filter<Iletisim>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IletisimBll)Bll).YeniKodVer();
            txtTcKimlikNo.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IletisimS)OldEntity;
            txtKod.Text = entity.Kod;
            txtTcKimlikNo.Text = entity.TcKimlikNo;
                txtAd.Text = entity.Adi;
            txtSoyad.Text = entity.Soyadi;
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
                txtEvTelefonu.Text = entity.EvTelefonu;
                txtIsTelefonu1.Text = entity.IsTelefonu1;
                txtIsTelefonu2.Text = entity.IsTelefonu2;
                txtDahili1.Text = entity.Dahili1;
                txtDahili2.Text = entity.Dahili2;
                txtCepTelefonu1.Text = entity.CepTelefonu1;
                txtCepTelefonu2.Text = entity.CepTelefonu2;
                txtWeb.Text = entity.Web;
                txtEMail.Text = entity.EMail;
                txtEvAdresi.Text = entity.EvAdres;
                txtEvAdresiIlAdi.Id = entity.EvAdresIlId;
                txtEvAdresiIlAdi.Text = entity.EvAdresIlAdi;
                txtEvAdresiIlceAdi.Id = entity.EvAdresiIlceId;
            txtEvAdresiIlceAdi.Text = entity.EvAdresIlceAdi;
                txtIsAdresi.Text = entity.IsAdresi;
                txtIsAdresiIlAdi.Id = entity.IsAdresIlId;
                txtIsAdresiIlAdi.Text = entity.IsAdresIlAdi;
                txtIsAdresiIlceAdi.Id = entity.IsAdresIlceId;
                txtIsAdresiIlceAdi.Text = entity.IsAdresIlceAdi;
                txtMeslek.Text = entity.MeslekAdi;
            txtMeslek.Id = entity.MeslekId;
                txtIsyeri.Text = entity.IsyeriAdi;
            txtIsyeri.Id = entity.IsyeriId;
                txtGorev.Text = entity.GorevAdi;
            txtGorev.Id = entity.GorevId;
            txtIbanNo.Text = entity.IbanNo;
                txtKartNo.Text = entity.KartNo;
                txtOzelKod1.Id = entity.OzelKod1Id;
                txtOzelKod1.Text = entity.OzelKod1Adi;
                txtOzelKod2.Id = entity.OzelKod2Id;
                txtOzelKod2.Text= entity.OzelKod2Adi;
                txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Iletisim
            {
                Id = Id,
                Kod = txtKod.Text,
                TcKimlikNo = txtTcKimlikNo.Text,
                Adi = txtAd.Text,
                Soyadi = txtSoyad.Text,
                BabaAdi = txtBaba.Text,
                AnaAdi = txtAna.Text ,
                DogumYeri = txtDogumYeri.Text,
                DogumTarihi =(DateTime?)txtDogumTarihi.EditValue,
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
                EvTelefonu = txtEvTelefonu.Text,
                IsTelefonu1 = txtIsTelefonu1.Text,
                IsTelefonu2 = txtIsTelefonu2.Text,
                Dahili1 = txtDahili1.Text,
                Dahili2 = txtDahili2.Text,
                CepTelefonu1 = txtCepTelefonu1.Text,
                CepTelefonu2 = txtCepTelefonu2.Text,
                Web = txtWeb.Text,
                EMail = txtEMail.Text,
                EvAdres = txtEvAdresi.Text,
                EvAdresIlId = txtEvAdresiIlAdi.Id,
                EvAdresiIlceId = txtEvAdresiIlceAdi.Id,
                IsAdresi = txtIsAdresi.Text,
                IsAdresIlId = txtIsAdresiIlAdi.Id,
                IsAdresIlceId = txtIsAdresiIlceAdi.Id,
                MeslekId = txtMeslek.Id,
                IsyeriId = txtIsyeri.Id,
                GorevId = txtGorev.Id,
                IbanNo = txtIbanNo.Text,
                KartNo = txtKartNo.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtEvAdresiIlAdi)
                    sec.Sec(txtEvAdresiIlAdi);
                else if (sender == txtEvAdresiIlceAdi)
                    sec.Sec(txtEvAdresiIlceAdi, txtEvAdresiIlAdi);
                else if (sender == txtIsAdresiIlAdi)
                    sec.Sec(txtIsAdresiIlAdi);
                else if (sender == txtIsAdresiIlceAdi)
                    sec.Sec(txtIsAdresiIlceAdi, txtIsAdresiIlAdi);
                else if (sender == txtIsyeri)
                    sec.Sec(txtIsyeri);
                else if (sender == txtMeslek)
                    sec.Sec(txtMeslek);
                else if (sender == txtGorev)
                    sec.Sec(txtGorev);
                else if (sender == txtNufusIlAdi)
                    sec.Sec(txtNufusIlAdi);
                else if (sender == txtNufusIlceAdi)
                    sec.Sec(txtNufusIlceAdi, txtNufusIlAdi);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.Iletisim);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.Iletisim);
        }

        protected override void Control_EnabledChanged(object sender, EventArgs e)
        {
            if (sender != txtEvAdresiIlAdi&&sender==txtIsAdresiIlAdi&&sender==txtNufusIlAdi) return;
            if (sender == txtEvAdresiIlAdi)
                txtEvAdresiIlAdi.ControlEnabledChanged(txtEvAdresiIlceAdi);
            else if (sender == txtIsAdresiIlAdi)
                txtIsAdresiIlAdi.ControlEnabledChanged(txtIsAdresiIlceAdi);
            else if (sender == txtNufusIlAdi)
                txtNufusIlAdi.ControlEnabledChanged(txtNufusIlceAdi);            
        }
    }
}
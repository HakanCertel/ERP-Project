using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using DevExpress.XtraEditors;
using System;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.BankaHesapForms
{
    public partial class BankaHesapEditForm : BaseEditForm
    {
        public BankaHesapEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new BankaHesapBll(myDataLayoutControl);
            txtHesapTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<BankaHesapTuru>());
            BaseKartTuru = KartTuru.BankaHesap;
            EventsLoad();
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new BankaHesapS() : ((BankaHesapBll)Bll).Single(FilterFunctions.Filter<BankaHesap>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((BankaHesapBll)Bll).YeniKodVer(x => x.SubeId == AnaForm.SubeId);
            txtHesapAdi.Focus();
        }

        //üsteki metodla alınan veriyi kontrollere bağlamak için aşağıdaki metod oluşturulacaktır..
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (BankaHesapS)OldEntity;

            txtKod.Text = entity.Kod;
            txtHesapAdi.Text = entity.HesapAdi;
            txtHesapTuru.SelectedItem = entity.HesapTuru.toName();
            txtBanka.Id = entity.BankaId;
            txtBanka.Text = entity.BankaAdi;
            txtBankaSube.Id = entity.BankaSubeId;
            txtBankaSube.Text = entity.BankaSubeAdi;
            txtHesapAcilisTarihi.DateTime = entity.HesapAcilisTarihi;
            txtBlokeGunSayisi.Value = entity.BlokeGunSayisi;
            txtIsyeriNo.Text = entity.IsyeriNo;
            txtTerminalNo.Text = entity.TerminalNo;
            txtHesapNo.Text = entity.HesapNo;
            txtIbanNo.Text = entity.IbanNo;                
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new BankaHesap
            {
                Id = Id,
                Kod = txtKod.Text,
                HesapAdi = txtHesapAdi.Text,
                HesapTuru = txtHesapTuru.Text.GetEnum<BankaHesapTuru>(),
                BankaId=Convert.ToInt64(txtBanka.Id),
                BankaSubeId= Convert.ToInt64(txtBankaSube.Id),
                HesapAcilisTarihi=txtHesapAcilisTarihi.DateTime.Date,
                BlokeGunSayisi=(byte)txtBlokeGunSayisi.Value,
                IsyeriNo=txtIsyeriNo.Text,
                TerminalNo=txtTerminalNo.Text,
                HesapNo=txtHesapNo.Text,
                IbanNo=txtIbanNo.Text,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
                SubeId = AnaForm.SubeId,
            };

            ButonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((BankaHesapBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId );
        }

        protected override bool EntityUpdate()
        {
            return ((BankaHesapBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.SubeId == AnaForm.SubeId);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
                if (sender == txtBanka)
                    sec.Sec(txtBanka);
                else if (sender == txtBankaSube)
                    sec.Sec(txtBankaSube, txtBanka);
                else if (sender == txtOzelKod1)
                    sec.Sec(txtOzelKod1, KartTuru.BankaHesap);
                else if (sender == txtOzelKod2)
                    sec.Sec(txtOzelKod2, KartTuru.BankaHesap);

        }

        protected override void Control_EnabledChanged(object sender, EventArgs e)
        {
            if (sender != txtBanka) return;
            txtBanka.ControlEnabledChanged(txtBankaSube);
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edt)) return;

            var hesapTuru = edt.Text.GetEnum<BankaHesapTuru>();

            if(hesapTuru==BankaHesapTuru.EPosBlokeHesabi||hesapTuru==BankaHesapTuru.OtsBlokeHesabi||hesapTuru==BankaHesapTuru.PosBlokeHesabi)
            {
                txtBlokeGunSayisi.Enabled = true;
                txtTerminalNo.Enabled = true;
                txtIsyeriNo.Enabled = true;
            }
            else
            {
                txtBlokeGunSayisi.Enabled = false;
                txtTerminalNo.Enabled = false;
                txtIsyeriNo.Enabled = false;

                txtBlokeGunSayisi.Value = 0;
                txtTerminalNo.Text = null;
                txtIsyeriNo.Text = null;
            }
        }
    }
}
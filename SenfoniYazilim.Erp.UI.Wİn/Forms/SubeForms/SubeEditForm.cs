using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SubeForms
{
    public partial class SubeEditForm : BaseEditForm
    {
        public SubeEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new SubeBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Sube;
            EventsLoad();
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new SubeS() : ((SubeBll)Bll).Single(FilterFunctions.Filter<Sube>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((SubeBll)Bll).YeniKodVer();
            txtKod.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (SubeS)OldEntity;

            txtKod.Text = entity.Kod;
            txtSubeAdi.Text = entity.SubeAdi;
            txtGrupAdi.Text = entity.GrupAdi;
            txtSiraNo.EditValue = entity.SiraNo;
            txtTelefon.Text = entity.Telefon;
            txtFaks.Text = entity.Fax;
            txtIbanNo.Text = entity.IbanNo;
            txtAdres.Text = entity.Adres;
            txtAdresUlke.Id = entity.AdresUlkeId;
            txtAdresUlke.Text = entity.AdresUlkeAdi;
            txtAdresIl.Id = entity.AdresIlId;
            txtAdresIl.Text = entity.AdresIlAdi;
            txtAdresIlce.Id = entity.AdresIlceId;
            txtAdresIlce.Text = entity.AdresIlceAdi;
            imgLogo.EditValue = entity.Logo;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Sube
            {
                Id=Id,
                Kod=txtKod.Text,
                SubeAdi=txtSubeAdi.Text,
                GrupAdi=txtGrupAdi.Text,
                SiraNo=(int)txtSiraNo.Value,
                Telefon=txtTelefon.Text,
                Fax=txtFaks.Text,
                Adres=txtAdres.Text,
                AdresUlkeId= Convert.ToInt64(txtAdresUlke.Id),
                AdresIlId =Convert.ToInt64(txtAdresIl.Id),
                AdresIlceId=Convert.ToInt64(txtAdresIlce.Id),
                Durum=tglDurum.IsOn,
                Logo=(byte[])imgLogo.EditValue
            };

            ButonEnabledDurumu();
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtAdresUlke)
                    sec.Sec(txtAdresUlke);
                else if (sender == txtAdresIl)
                    sec.Sec(txtAdresIl,txtAdresUlke);
                else if (sender == txtAdresIlce)
                    sec.Sec(txtAdresIlce, txtAdresIl);
            }
        }

        protected override void Control_EnabledChanged(object sender, EventArgs e)
        {
            if (sender != txtAdresIl) return;

            txtAdresIl.ControlEnabledChanged(txtAdresIlce);
        }

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;

            resim.Sec(resimMenu);
        }
    }
}
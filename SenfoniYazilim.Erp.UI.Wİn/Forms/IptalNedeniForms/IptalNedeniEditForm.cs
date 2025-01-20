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
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.IptalNedeniForms
{
    public partial class IptalNedeniEditForm :BaseEditForm
    {
        public IptalNedeniEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IptalNedeniBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.IptalNedeni;
            EventsLoad();
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new IptalNedeni() : ((IptalNedeniBll)Bll).Single(FilterFunctions.Filter<IptalNedeni>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IptalNedeniBll)Bll).YeniKodVer();
            txtIptalNedeniAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (IptalNedeni)OldEntity;

            txtKod.Text = entity.Kod;
            txtIptalNedeniAdi.Text = entity.IptalNedeniAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new IptalNedeni
            {
                Id = Id,
                Kod = txtKod.Text,
                IptalNedeniAdi = txtIptalNedeniAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}
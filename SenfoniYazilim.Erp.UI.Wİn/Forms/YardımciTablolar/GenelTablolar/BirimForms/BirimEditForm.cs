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
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımcıTablolar.GenelTablolar
{
    public partial class BirimEditForm : BaseEditForm
    {
        public BirimEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new BirimBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Birim;

            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Birim() : ((BirimBll)Bll).Single(FilterFunctions.Filter<Birim>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            //txtKod.Text = ((BirimBll)Bll).YeniKodVer();
            txtBirim.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Birim)OldEntity;

            txtKod.Text = entity.Kod;
            txtBirim.Text = entity.BirimAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Birim
            {
                Id = Id,
                Kod = txtKod.Text,
                BirimAdi = txtBirim.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}
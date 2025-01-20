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

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.KdvOranlariForms
{
    public partial class KdvEditForm : BaseEditForm
    {
        public KdvEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new KdvBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Kdv;

            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Kdv() : ((KdvBll)Bll).Single(FilterFunctions.Filter<Kdv>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            //txtKod.Text = ((GorevBll)Bll).YeniKodVer();
            txtKod.Focus();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Kdv)OldEntity;

            txtKod.Text = entity.Kod;
            txtKdvOran.EditValue = entity.KdvOrani;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Kdv
            {
                Id = Id,
                Kod = txtKod.Text,
                KdvOrani =(decimal) txtKdvOran.EditValue,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
    }
}
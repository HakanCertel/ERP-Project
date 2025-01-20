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

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.VardiyaForms
{
    public partial class VardiyaLastVersionEditFrom : BaseEditForm
    {
        public VardiyaLastVersionEditFrom()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new VardiyaBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Vardiya;
            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Vardiya() : ((VardiyaBll)Bll).Single(FilterFunctions.Filter<Vardiya>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtVardiyaSistemKod.Text = ((VardiyaBll)Bll).YeniKodVer();
            txtVardiyaSistemAd.Focus();

        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Vardiya)OldEntity;
            txtVardiyaSistemKod.Text = entity.Kod;
            txtVardiyaSistemAd.Text = entity.VardiyaAdi;
            txtVardiyaSayisi.EditValue = entity.VardiyaSayisi;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Vardiya
            {
                Id = Id,
                Kod=txtVardiyaSistemKod.Text,
                VardiyaAdi=txtVardiyaSistemAd.Text,
                VardiyaSayisi=Convert.ToInt32( txtVardiyaSayisi.EditValue),
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, vardiyaBilgileriTable.TableValueChanged);
        }
        protected override bool EntityInsert()
        {
            //if (vardiyaBilgileriTable.HatalıGiriş()) return false;
            return ((VardiyaBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod) && vardiyaBilgileriTable.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            //if (vardiyaBilgileriTable.HatalıGiriş()) return false;
            return ((VardiyaBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod ) && vardiyaBilgileriTable.Kaydet();
        }
        protected override void TabloYukle()
        {
            vardiyaBilgileriTable.OwnerForm = this;
            vardiyaBilgileriTable.Yukle();
        }
    }
}
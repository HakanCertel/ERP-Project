using System;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.KullaniciForms
{
    public partial class RolEditForm : BaseEditForm
    {
        public RolEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new RolBll(myDataLayoutControl);
            EventsLoad();

            txtKullaniciYetkisi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KullaniciYetkisi>());
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Rol() : ((RolBll)Bll).Single(FilterFunctions.Filter<Rol>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((RolBll)Bll).YeniKodVer();
            txtRolAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Rol)OldEntity;

            txtKod.Text = entity.Kod;
            txtRolAdi.Text = entity.RolAdi;
            txtxAciklama.Text = entity.Aciklam;
            txtKullaniciYetkisi.Text = entity.KullaniciYetkisi.toName();
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Rol
            {
                Id = Id,
                Kod = txtKod.Text,
                RolAdi = txtRolAdi.Text,
                KullaniciYetkisi = txtKullaniciYetkisi.Text.GetEnum<KullaniciYetkisi>(),
                Aciklam = txtxAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnabledDurumu();
        }
        protected override void TabloYukle()
        {
            rolYetkileriTable.OwnerForm = this;
            rolYetkileriTable.Yukle();
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, rolYetkileriTable.TableValueChanged);
        }

        protected override bool EntityInsert()
        {
            return ((RolBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod ) && rolYetkileriTable.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            return ((RolBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod ) && rolYetkileriTable.Kaydet();
        }
        /// <summary>
        /// bu event in amacı form açılırken eğer işlem türü Insert ise form a odaklanması 
        /// yapılacak işlem update işlemi ise direkt tbloya odaklanmasını sağlayacak kodların oluşturulmaıdır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            if (BaseIslemTuru == IslemTuru.EntityUpdate)
                rolYetkileriTable.Tablo.Focus();
        }
    }
}
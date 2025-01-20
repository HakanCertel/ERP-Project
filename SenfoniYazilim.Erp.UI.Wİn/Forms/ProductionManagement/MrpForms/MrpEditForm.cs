using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraBars;
using DevExpress.XtraPrinting.Native;
using System;
using System.Linq;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Model.ProductionManagmentEntites.MrpEntites;
using SenfoniYazilim.Erp.Model.ProductionMangmentDto.MrpDto;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms
{
    public partial class MrpEditForm : BaseEditForm
    {
        public MrpEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new MrpBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Mrp;
            EventsLoad();
            ShowItems = new BarItem[] { btnRunMrp ,btnShowDetail};

            KayitSonrasiFormuKapat = false;
        }

        public  override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Mrp() : ((MrpBll)Bll).Single(FilterFunctions.Filter<Mrp>(Id));
            NesneyiKontrollereBagla();
            TabloYukle();
            txtMrpCreatingMethod.Text = ((Mrp)OldEntity).MrpCreatingMethod.toName();
            if (BaseIslemTuru != IslemTuru.EntityInsert) { return; }

            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtMrpKod.Text = ((MrpBll)Bll).YeniKodVer();

            txtMrpKod.Focus();
            txtTarih.DateTime = DateTime.Now.Date;
            txtTarih.Properties.MinValue = DateTime.Now.Date;
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Mrp)OldEntity;

            txtMrpKod.Text = entity.Kod;
            txtTarih.DateTime = entity.EvrakTarihi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
            txtMrpCreatingMethod.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<MrpCreatingMethod>());
        }
        
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Mrp
            {
                Id = Id,
                Kod = txtMrpKod.Text,
                EvrakTarihi = txtTarih.DateTime,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
                IsRun = ((Mrp)OldEntity).IsRun,
                MrpCreatingMethod = txtMrpCreatingMethod.Text.GetEnum<MrpCreatingMethod>()
            };
            //tglDurum.Enabled = !((Mrp)CurrentEntity).IsRun;
            btnRunMrp.Enabled = mrpBilgileriTable.Tablo.DataController.ListSource.Cast<MrpBilgileri>().Any(x=>!x.IsTakenToProcess);
            btnShowDetail.Enabled = ((Mrp)CurrentEntity).IsRun;
            ButonEnabledDurumu();
        }

        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (mrpBilgileriTable != null && mrpBilgileriTable.TableValueChanged) return true;
                return false;
            }

            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial, OldEntity, CurrentEntity, TableValueChanged());
        }

        protected override bool EntityInsert()
        {
            if (mrpBilgileriTable.HatalıGiriş()) return false;
            GuncelNesneOlustur();

            var result = ((MrpBll)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod);//&& mrpBilgileriTable.Kaydet();
            var resultTableInsert = mrpBilgileriTable.Kaydet();
            result = (result && resultTableInsert) ? true : false;
            if (result && !KayitSonrasiFormuKapat)
                mrpBilgileriTable.Yukle();
            BaseIslemTuru = result ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
            return result;
        }

        protected override bool EntityUpdate()
        {
            if (mrpBilgileriTable.HatalıGiriş()) return false;
            GuncelNesneOlustur();
            //if (HataliGiris()) return false;

            var result = ((MrpBll)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod) && mrpBilgileriTable.Kaydet();// && BagliTabloKaydet();

            if (result && !KayitSonrasiFormuKapat)
                mrpBilgileriTable.Yukle();

            return result;
        }

        protected override void TabloYukle()
        {
            mrpBilgileriTable.OwnerForm = this;
            mrpBilgileriTable.Yukle();
        }

        protected override void RunMrp()
        {
            var source = mrpBilgileriTable.Tablo.DataController.ListSource;
            source.Cast<MrpBilgileriL>().ForEach(x =>
            {
                var recete = x.ReceteId.ReceteIdIleReceteAnaRow();
                if (recete != null && !x.IsTakenToProcess)
                {
                    x.IsTakenToProcess = true;
                    x.Update = true;
                    recete.MrpCalistir(true, x.Miktar, x.BitisTarihi, x.Id);
                }
                mrpBilgileriTable.Tablo.FocusedRowHandle = source.IndexOf(x);
            });
            ((Mrp)OldEntity).IsRun = true;
            tglDurum.IsOn = !((Mrp)CurrentEntity).IsRun;
            GuncelNesneOlustur();

            var mrpBilgileri=mrpBilgileriTable.Tablo.DataController.ListSource.Cast<MrpBilgileri>(); ;
            mrpBilgileri.ForEach(x => x.IsClosed = true);

            if (BaseIslemTuru == IslemTuru.EntityInsert)
                EntityInsert();
            else
                EntityUpdate();
        }

        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //base.BaseEditForm_FormClosing(sender, e);
            if (btnKaydet.Visibility == BarItemVisibility.Never || !btnKaydet.Enabled) return;

            if (!Kaydet(true))
                e.Cancel = true;
        }
    }
}
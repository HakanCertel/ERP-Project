using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.Windows.Forms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.Common.Enums;
using System;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.MrpForms
{
    public partial class MalzemeIhtiyacPlanlamaEditForm : BaseEditForm
    {

        public MalzemeIhtiyacPlanlamaEditForm()
        {
            InitializeComponent();

            //DataLayoutControl = myDataLayoutControl;
            Bll = new MalzemeIhtiyacBilgileriBll();
            EventsLoad();

            KayitSonrasiFormuKapat = false;

            ShowItems = new BarItem[] { btnKolonlar,btnPlanKesinlestir ,btnAnaliz};
            HideItems = new BarItem[] { btnYeni, btnSil };

            txtDonemBaslangicTarihi.EditValue = DateTime.Now;
            txtDonemBitisTarihi.EditValue = DateTime.Now.AddDays(7);

            btnKolonlar.CreatDropDownMenu(new BarItem[] { btnMakina,btnMalzeme,btnMrpMakinaMalzeme});
            KayitSonrasiFormuKapat = false;
            OldEntity = new BaseEntity() ;
            CurrentEntity = new BaseEntity();
        }

        public override void Yukle()
        {
            BagliTabloYukle();
            btnKaydet.Enabled = false;
        }
        protected override void GuncelNesneOlustur()
        {
            ButonEnabledDurumu();
        }
        protected override void BagliTabloYukle()
        {
            bool TableValueChanged(BaseTablo tablo)
            {
                return tablo.Tablo.DataController.ListSource.Cast<IBaseHareketEntity>().Any(x => x.Insert || x.Update || x.Delete);
            }
           
            if (mrpMakinaBilgileriTable.OwnerForm == null)
            {
                mrpMakinaBilgileriTable.OwnerForm = this;
                mrpMakinaBilgileriTable.Yukle();
                Id = -1;
                 //Id= mrpMakinaBilgileriTable.Tablo.DataController
                 //   .ListSource.Cast<MrpMakinaBilgileriL>().FirstOrDefault().MakinaId;
                //mrpMakinaBilgileriTable.Tablo.Focus();
                mrpMakinaBilgileriTable.SablonYukle();
            }
            if (planlanmisMalzemeKalemleriTable.OwnerForm == null)
            {
                planlanmisMalzemeKalemleriTable.OwnerForm = this;

                planlanmisMalzemeKalemleriTable.Yukle();
                planlanmisMalzemeKalemleriTable.SablonYukle();
            }
        }

        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;

            bool TableValueChanged()
            {
                if (mrpMakinaBilgileriTable.TableValueChanged) return true;
                if (planlanmisMalzemeKalemleriTable.TableValueChanged) return true;
                return false;
            }
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnSil, btnKaydet, btnGerial, OldEntity, CurrentEntity, TableValueChanged());
            btnAnaliz.Enabled = !btnKaydet.Enabled;
        }

        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            base.Button_ItemClick(sender, e);
            if (e.Item == btnMakina)
            {
                if (mrpMakinaBilgileriTable.Tablo.CustomizationForm == null)
                    mrpMakinaBilgileriTable.Tablo.ShowCustomization();
                else
                    mrpMakinaBilgileriTable.Tablo.HideCustomization();
            }
            else if (e.Item == btnMrpMakinaMalzeme)
            {
                if (planlanmisMalzemeKalemleriTable.Tablo.CustomizationForm == null)
                    planlanmisMalzemeKalemleriTable.Tablo.ShowCustomization();
                else
                    planlanmisMalzemeKalemleriTable.Tablo.HideCustomization();
            }
            
        }

        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnKaydet.Visibility == BarItemVisibility.Never || !btnKaydet.Enabled) return;

            if (!Kaydet(true))
                e.Cancel = true;
            if (planlanmisMalzemeKalemleriTable.TabloSablonKaydedilecek)
                planlanmisMalzemeKalemleriTable.SablonKaydet();
            if (mrpMakinaBilgileriTable.TabloSablonKaydedilecek)
                mrpMakinaBilgileriTable.SablonKaydet();
        }

        protected override void Yazdir()
        {
            ShowListForms<IsEmriRaporSecimListForm>.ShowDialogListForm(KartTuru.Mrp, true);
        }

        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;

            if (!(sender is MyDateEdit)) return;

            mrpMakinaBilgileriTable.KapasiteHesapla();
            Donem();
        }

        protected override bool EntityInsert()
        {
            var result = planlanmisMalzemeKalemleriTable.Kaydet();

            if (result && !KayitSonrasiFormuKapat)
                planlanmisMalzemeKalemleriTable.Yukle();

            return result;
        }

        protected override bool EntityUpdate()
        {
            var result = BagliTabloKaydet();

            if (!KayitSonrasiFormuKapat)
                BagliTabloYukle();
            return result;
        }

        protected override bool BagliTabloKaydet()
        {
            if (planlanmisMalzemeKalemleriTable != null && !planlanmisMalzemeKalemleriTable.Kaydet()) return false;
            return true;
        }

        protected override void PlanKesinlestir()
        {
            planlanmisMalzemeKalemleriTable.PlanKesinlestir();
            planlanmisMalzemeKalemleriTable.Yukle();
        }
        protected internal override void Analiz()
        {
            //base.Analiz();
            if (Id < 0) return;//Analis işlemi herhangi bir makine seçildiği anda gerçekleşmesi gerektiği için bir makine seçilmedi ise çalışmamalı
            planlanmisMalzemeKalemleriTable.Analiz();
        }
        private void Donem()
        {
            //var source = mrpMalzemeIhtiyacBilgileriTable.Tablo.DataController.ListSource.Cast<MrpMalzemeIhtiyacBilgileriL>().Where(x => x.TavsiyeEdilenUretimBaslamaTarihi >= txtDonemBaslangicTarihi.DateTime&&x.IhtiyacTarihi<=txtDonemBitisTarihi.DateTime);

            //foreach (var item in source)
            //{
            //    var makinaSource = mrpMakinaBilgileriTable.Tablo.DataController.ListSource.Cast<MrpMakinaBilgileriL>();
            //    var makina =makinaSource.Where(x => x.MakinaId == item.MakinaId).FirstOrDefault();
            //    if (makina == null) continue;
            //    makina.DonemselKapasite = makina.DonemselKapasite + item.KapasiteIhtiyaci.Value;
            //    mrpMakinaBilgileriTable.Tablo.RefreshData();
            //}

            //mrpMalzemeIhtiyacBilgileriTable.Tablo.RefreshData();
        }

    }
}
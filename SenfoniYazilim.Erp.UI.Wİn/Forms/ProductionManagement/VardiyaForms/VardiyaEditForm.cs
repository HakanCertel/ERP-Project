using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.VardiyaForms
{
    public partial class VardiyaEditForm : BaseEditForm
    {
        private int _vardiyaSayidsi;

        public VardiyaEditForm()
        {
            InitializeComponent();

            DataLayoutControls = new[] { myDataLayoutControl,myDataLayoutControlVardiya1, myDataLayoutControlVardiya2, myDataLayoutControlVardiya3 };
            //myDataLayoutControl.Controls.AddRange(DataLayoutControls);
            Bll = new VardiyaBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Vardiya;
            EventsLoad();

            //ShowItems = new BarItem[] { btnTaksitOlustur };
        }
        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new VardiyaS() : ((VardiyaBll)Bll).Single(FilterFunctions.Filter<Vardiya>(Id));

            _vardiyaSayidsi = ((VardiyaS)OldEntity).VardiyaSayisi;

            NesneyiKontrollereBagla();
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtVardiyaSistemKod.Text = ((VardiyaBll)Bll).YeniKodVer();
            txtVardiyaSistemAd.Focus();

        }
        protected override void NesneyiKontrollereBagla()
        {
            KontrolleriBagla(_vardiyaSayidsi);
        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Vardiya
            {
                Id = Id,
                Kod = txtVardiyaSistemKod.Text,
                VardiyaAdi = txtVardiyaSistemAd.Text,
                VardiyaSayisi = (int)txtVardiyaSayisi.Value,
                HaftalikCalismaGunSayisi1 = Convert.ToInt32(txtHaftalikCalismaGunSayisi1.Value),
                MesaiBaslamaSaati1 = txtMesaiBaslamaSaati1.Text,
                MesaiBitisSaati1 = txtMesaiBitisSaati1.Text,
                StandartMolaSuresi1 = txtStandartMolaSuresi1.Value,
                YarimGun1 = txtYarimGun1.Checked,
                YarimBaslamaSaati1 = txtBaslamaSaati1.Text,
                YarimBitisSaati1 = txtBitisSaati1.Text,
                YarimGunMolaSuresi1 = txtYarimGunMolaSuresi1.Value,

                HaftalikCalismaGunSayisi2 = Convert.ToInt32(txtHaftalikCalismaGunSayisi2.Value),
                MesaiBaslamaSaati2 = txtMesaiBaslamaSaati2.Text,
                MesaiBitisSaati2 = txtMesaiBitisSaati2.Text,
                StandartMolaSuresi2 = txtStandartMolaSuresi2.Value,
                YarimGun2 = txtYarimGun2.Checked,
                YarimBaslamaSaati2 = txtBaslamaSaati2.Text,
                YarimBitisSaati2 = txtBitisSaati2.Text,
                YarimGunMolaSuresi2 = txtYarimGunMolaSuresi2.Value,

                HaftalikCalismaGunSayisi3 = Convert.ToInt32(txtHaftalikCalismaGunSayisi3.Value),
                MesaiBaslamaSaati3 = txtMesaiBaslamaSaati3.Text,
                MesaiBitisSaati3 = txtMesaiBitisSaati3.Text,
                StandartMolaSuresi3 = txtStandartMolaSuresi3.Value,
                YarimGun3 = txtYarimGun3.Checked,
                YarimBaslamaSaati3 = txtBaslamaSaati3.Text,
                YarimBitisSaati3 = txtBitisSaati3.Text,
                YarimGunMolaSuresi3 = txtYarimGunMolaSuresi3.Value,
            };

            ButonEnabledDurumu();
        }
        //protected override bool EntityInsert()
        //{
        //    if (HataliGirisKontrol())
        //        return false;

        //    var result = ((VardiyaBll)Bll).Insert(CurrentEntity);
        //    return result;
        //}
        protected override void Control_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
            var entity = (Vardiya)CurrentEntity;

            if (sender == txtYarimGun1)
            {
                txtBaslamaSaati1.ControlEnabledChanged(txtBaslamaSaati1, txtYarimGun1.Checked);
                txtBaslamaSaati1.EditValue = txtYarimGun1.Checked ?entity.YarimBaslamaSaati1 /*DateTime.Parse(entity.YarimBaslamaSaati1).ToShortTimeString() */: "";
                txtBitisSaati1.ControlEnabledChanged(txtBitisSaati1, txtYarimGun1.Checked);
                txtBitisSaati1.EditValue = txtYarimGun1.Checked ?entity.YarimBitisSaati1 /*DateTime.Parse(entity.YarimBitisSaati1).ToShortTimeString() */: null;
                txtYarimGunMolaSuresi1.ControlEnabledChanged(txtYarimGunMolaSuresi1, txtYarimGun1.Checked);
                txtYarimGunMolaSuresi1.Value = txtYarimGun1.Checked ? entity.YarimGunMolaSuresi1 : 0;
            }
            if (sender == txtYarimGun2)
            {
                txtBaslamaSaati2.ControlEnabledChanged(txtBaslamaSaati2, txtYarimGun2.Checked);
                txtBaslamaSaati2.EditValue = txtYarimGun2.Checked ? entity.YarimBaslamaSaati2/*DateTime.Parse(entity.YarimBaslamaSaati2).ToShortTimeString()*/ : null;
                txtBitisSaati2.ControlEnabledChanged(txtBitisSaati2, txtYarimGun2.Checked);
                txtBitisSaati2.EditValue = txtYarimGun2.Checked ? entity.YarimBitisSaati2/*DateTime.Parse(entity.YarimBitisSaati2).ToShortTimeString()*/ : null;
                txtYarimGunMolaSuresi2.ControlEnabledChanged(txtYarimGunMolaSuresi2, txtYarimGun2.Checked);
                txtYarimGunMolaSuresi2.Value = txtYarimGun2.Checked ? entity.YarimGunMolaSuresi2 : 0;
            }
            if (sender == txtYarimGun3)
            {
                txtBaslamaSaati3.ControlEnabledChanged(txtBaslamaSaati3, txtYarimGun3.Checked);
                txtBaslamaSaati3.EditValue = txtYarimGun3.Checked ?entity.YarimBaslamaSaati3 /*DateTime.Parse(entity.YarimBaslamaSaati3).ToShortTimeString() */: null;
                txtBitisSaati3.ControlEnabledChanged(txtBitisSaati3, txtYarimGun3.Checked);
                txtBitisSaati3.EditValue = txtYarimGun3.Checked ? entity.YarimBitisSaati3/*DateTime.Parse(entity.YarimBitisSaati3).ToShortTimeString() */: null;
                txtYarimGunMolaSuresi3.ControlEnabledChanged(txtYarimGunMolaSuresi3, txtYarimGun3.Checked);
                txtYarimGunMolaSuresi3.Value = txtYarimGun3.Checked ? entity.YarimGunMolaSuresi3 : 0;
            }

            GuncelNesneOlustur();
        }
        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            base.Control_EditValueChanged(sender, e);

            if (sender == txtVardiyaSayisi)
            {
                //var hour = DateTime.Parse(txtMesaiBitisSaati1.Text).Hour;
                //var minute = DateTime.Parse(txtMesaiBitisSaati1.Text).Minute;
                //var fark=DateTime.Now.AddHours(-)
                LayoutGroupItemVisibilityAndColumnSpan((int)txtVardiyaSayisi.Value);
                var checkEdit = txtVardiyaSayisi.Value == 2 ? txtYarimGun2 : txtVardiyaSayisi.Value == 3 ? txtYarimGun3 : txtYarimGun1;
                Control_CheckedChanged(checkEdit, null);
            }
        }
        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            LayoutGroupItemVisibilityAndColumnSpan((int)txtVardiyaSayisi.Value);
        }
        private bool HataliGirisKontrol()
        {
            foreach (Control ctrl in myDataLayoutControl.Controls)
            {
                switch (ctrl)
                {
                    case BaseEdit edt:
                        if (!edt.Enabled) continue;

                        if (edt.HataliGirisKontrol(ctrl, false, edt.EditValue))
                            return true;
                        break;
                }

            }

            return false;
        }

        private void LayoutGroupItemVisibilityAndColumnSpan(int vardiyaSayisi)
        {
            
            vardiyaItem2.Visibility = vardiyaSayisi > 1 ? LayoutVisibility.Always : LayoutVisibility.Never;
            vardiyaItem3.Visibility= vardiyaSayisi > 2 ? LayoutVisibility.Always : LayoutVisibility.Never;
            vardiyaItem1.OptionsTableLayoutItem.RowSpan = vardiyaSayisi == 3 ? 1 : vardiyaSayisi == 2 ? 1 : 3;
            layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions[1].Height = vardiyaSayisi < 3 ? 50 : 33;
            vardiyaItem2.OptionsTableLayoutItem.RowSpan = vardiyaSayisi == 3 ? 1 : vardiyaSayisi == 2 ? 2 : 1;
            MinimumSize = vardiyaSayisi == 1 ? new Size(880, 272) : vardiyaSayisi == 2 ? new Size(880, 464) : new Size(880, 648);
            Size = MinimumSize;
        }
        private void KontrolleriBagla(int vardiyaSayisi)
        {
            Vardiya1_KontrollereBagla();

            if (vardiyaSayisi == 2) 
                Vardiya2_KontrollereBagla();
            if (vardiyaSayisi == 3)
            {
                Vardiya2_KontrollereBagla();
                Vardiya3_KontrollereBagla();
            }
        }
        private void Vardiya1_KontrollereBagla()
        {
            var entity = (VardiyaS)OldEntity;

            txtVardiyaSistemKod.Text = entity.Kod;
            txtVardiyaSistemAd.Text = entity.VardiyaAdi;
            txtVardiyaSayisi.Value = entity.VardiyaSayisi;
            txtHaftalikCalismaGunSayisi1.Value = entity.HaftalikCalismaGunSayisi1;
            txtMesaiBaslamaSaati1.EditValue =entity.MesaiBaslamaSaati1;
            txtMesaiBitisSaati1.EditValue = entity.MesaiBitisSaati1; //DateTime.Parse(entity.MesaiBitisSaati1).ToShortTimeString();
            txtStandartMolaSuresi1.Value = entity.StandartMolaSuresi1;
            txtYarimGun1.Checked = entity.YarimGun1;
            txtBaslamaSaati1.ControlEnabledChanged(txtBaslamaSaati1, entity.YarimGun1);
            txtBitisSaati1.ControlEnabledChanged(txtBitisSaati1, entity.YarimGun1);
            txtYarimGunMolaSuresi1.ControlEnabledChanged(txtYarimGunMolaSuresi1, entity.YarimGun1);
            txtBaslamaSaati1.EditValue = entity.YarimBaslamaSaati1;
            txtBitisSaati1.EditValue = entity.YarimBitisSaati1;
            txtYarimGunMolaSuresi1.Value = txtYarimGun1.Checked ? entity.YarimGunMolaSuresi1 : 0;
        }
        private void Vardiya2_KontrollereBagla()
        {
            var entity = (VardiyaS)OldEntity;

            txtHaftalikCalismaGunSayisi2.Value = entity.HaftalikCalismaGunSayisi2.Value;
            txtMesaiBaslamaSaati2.EditValue = entity.MesaiBaslamaSaati2;
            txtMesaiBitisSaati2.EditValue = entity.MesaiBitisSaati2;
            txtStandartMolaSuresi2.Value = entity.StandartMolaSuresi2;
            txtYarimGun2.Checked = entity.YarimGun2;
            txtBaslamaSaati2.ControlEnabledChanged(txtBaslamaSaati2, entity.YarimGun2);
            txtBitisSaati2.ControlEnabledChanged(txtBitisSaati2, entity.YarimGun2);
            txtYarimGunMolaSuresi2.ControlEnabledChanged(txtYarimGunMolaSuresi2, entity.YarimGun2);
            txtBaslamaSaati2.EditValue = entity.YarimBaslamaSaati2;
            txtBitisSaati2.EditValue = entity.YarimBitisSaati2;
            txtYarimGunMolaSuresi2.Value = txtYarimGun2.Checked ? entity.YarimGunMolaSuresi2 : 0;
        }
        private void Vardiya3_KontrollereBagla()
        {
            var entity = (VardiyaS)OldEntity;

            txtHaftalikCalismaGunSayisi3.Value = entity.HaftalikCalismaGunSayisi3.Value;
            txtMesaiBaslamaSaati3.EditValue = entity.MesaiBaslamaSaati3;
            txtMesaiBitisSaati3.EditValue = entity.MesaiBitisSaati3;
            txtStandartMolaSuresi3.Value = entity.StandartMolaSuresi3;
            txtBaslamaSaati3.ControlEnabledChanged(txtBaslamaSaati3, entity.YarimGun3);
            txtBitisSaati3.ControlEnabledChanged(txtBitisSaati3, entity.YarimGun3);
            txtYarimGunMolaSuresi3.ControlEnabledChanged(txtYarimGunMolaSuresi3, entity.YarimGun3);
            txtYarimGun3.Checked = entity.YarimGun3;
            txtBaslamaSaati3.EditValue = entity.YarimBaslamaSaati3;
            txtBitisSaati3.EditValue = entity.YarimBitisSaati3;
            txtYarimGunMolaSuresi3.Value = txtYarimGun3.Checked ? entity.YarimGunMolaSuresi3 : 0;
        }
    }
}
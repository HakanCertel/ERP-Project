using System;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using DevExpress.XtraBars;
using DevExpress.XtraPrinting.Native;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.FaturaForms
{
    public partial class FaturaTahakkukEditForm : BaseEditForm
    {
        public FaturaTahakkukEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BaseKartTuru = KartTuru.Fatura;

            EventsLoad();

            HideItems = new BarItem[] { btnYeni,btnSil };
            ShowItems = new BarItem[] { btnYazdir };
            txtKdvSekli.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<KdvSekli>());
            txtFaturaAdresi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<AdresTuru>());
            KayitSonrasiFormuKapat = false;
        }

        public  override void Yukle()
        {
            txtKdvSekli.SelectedItem = KdvSekli.Dahil.toName();
            txtFaturaAdresi.SelectedItem = AdresTuru.EvAdresi.toName();
            FaturaDonemiYukle();
            FaturaNoYukle();

            TabloYukle();
        }
        private void FaturaDonemiYukle()
        {
            using (var bll=new FaturaBll())
            {
                var list = bll.FaturaDonemiList(x => x.Tahakkuk.SubeId == AnaForm.SubeId && x.Tahakkuk.DonemId == AnaForm.DonemId);
                list.ForEach(x => txtFaturaDonemi.Properties.Items.Add(x.Date.ToString("d")));
            }
        }

        private void FaturaNoYukle()
        {
            using (var bll = new FaturaBll())
            {
                txtSonFaturaNo.Value = bll.MaxFaturaNo(x => x.Tahakkuk.SubeId == AnaForm.SubeId && x.Tahakkuk.DonemId == AnaForm.DonemId);
                txtFaturaNo.Value = txtSonFaturaNo.Value + 1;
            }
        }

        protected internal override void ButonEnabledDurumu()
        {
            GeneralFunctions.ButtonEnabledDurumu(btnKaydet, btnGerial, faturaTahakkukTable.TableValueChanged);
        }

        protected override void TabloYukle()
        {
            faturaTahakkukTable.OwnerForm = this;
            faturaTahakkukTable.Yukle();
        }

        protected override bool EntityUpdate()
        {
            if (!faturaTahakkukTable.Kaydet()) return false;

            faturaTahakkukTable.Yukle();
            FaturaNoYukle();
            return true;
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtFaturaDonemi) return;

            faturaTahakkukTable.Listele();
            faturaTahakkukTable.Tablo.Focus();
        }
    }
}
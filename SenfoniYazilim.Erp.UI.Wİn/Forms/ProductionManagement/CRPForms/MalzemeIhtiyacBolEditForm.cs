using System;
using System.Collections;
using System.Windows.Forms;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using DevExpress.XtraBars;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.MrpForms
{
    public partial class MalzemeIhtiyacBolEditForm : BaseEditForm
    {
        private readonly MrpMalzemeIhtiyacBilgileriL _mibL;
        private readonly IList _source;

        public MalzemeIhtiyacBolEditForm(params object[] prm)
        {
            InitializeComponent();

            _mibL = (MrpMalzemeIhtiyacBilgileriL)prm[0];
            _source = (IList)prm[1];

            DataLayoutControl = myDataLayoutControl;
            EventsLoad();
            ShowItems = new BarItem[] { btnUygulaBol};
            HideItems = new BarItem[] { btnYeni, btnKaydet, btnFarkliKaydet, btnGerial, btnSil };
        }

        public override void Yukle()
        {
            txtKod.Text = _mibL.StokKodu;
            txtStokAdi.Text = _mibL.StokAdi;
            txtToplamIhtiyac.Value = _mibL.ToplamIhtiyac;
            txtBrutIhtiyac.Value = _mibL.BrutIhtiyac;
            txtNetIhtiyac.Value = _mibL.NetIhtiyac;
            txtOranliBol.Enabled = false;
            txtMiktaraGoreBol.Enabled = false;
        }
        protected override void Bol()
        {
            
                //if (HataliGirs()) return;
                //txtOdemeTuru.Focus();

            var netIhtiyac = chkMiktaraGoreBol.Checked ? txtMiktaraGoreBol.Value
                : Math.Round(txtNetIhtiyac.Value / txtOranliBol.Value,2);
            var brutIhtiyac = chkMiktaraGoreBol.Checked ? txtMiktaraGoreBol.Value
                : Math.Round(txtBrutIhtiyac.Value / txtOranliBol.Value, 2);
            var toplamIhtiyac = chkMiktaraGoreBol.Checked ? txtMiktaraGoreBol.Value
                : Math.Round(txtToplamIhtiyac.Value / txtOranliBol.Value, 2);

            decimal toplamGirilenNetIhtiyac = 0;
            decimal toplamGirilenBrutIhtiyac= 0;
            decimal toplamGirilenToplamIhtiyac = 0;

            int donguSayisi = chkOranliBol.Checked ?Convert.ToInt32( txtOranliBol.Value) : Convert.ToInt32(txtNetIhtiyac.Value / txtMiktaraGoreBol.Value);

            for (int i = 0; i < donguSayisi; i++)
            {
                var mibL = new MrpMalzemeIhtiyacBilgileriL
                {
                    Id = 0,
                    NetIhtiyac = i == txtOranliBol.Value - 1 && chkOranliBol.Checked ? txtNetIhtiyac.Value - toplamGirilenNetIhtiyac : netIhtiyac,
                    BrutIhtiyac = i == txtOranliBol.Value - 1 && chkOranliBol.Checked ? txtBrutIhtiyac.Value - toplamGirilenNetIhtiyac : brutIhtiyac,
                    ToplamIhtiyac = i == txtOranliBol.Value - 1 && chkOranliBol.Checked ? txtToplamIhtiyac.Value - toplamGirilenNetIhtiyac : toplamIhtiyac,

                    Bolunen = true,
                    Insert = true,
                    Delete = false
                };

                //mibL = _mibL;
                //mibL.Id = 0;
                //mibL.NetIhtiyac = i == txtOranliBol.Value - 1 && chkOranliBol.Checked ? txtNetIhtiyac.Value - toplamGirilenNetIhtiyac : netIhtiyac;
                //mibL.BrutIhtiyac = i == txtOranliBol.Value - 1 && chkOranliBol.Checked ? txtBrutIhtiyac.Value - toplamGirilenNetIhtiyac : brutIhtiyac;
                //mibL.ToplamIhtiyac = i == txtOranliBol.Value - 1 && chkOranliBol.Checked ? txtToplamIhtiyac.Value - toplamGirilenNetIhtiyac : toplamIhtiyac;

                //mibL.Bolunen = true;
                //mibL.Insert = true;
                //mibL.Delete = false;
                    
                toplamGirilenNetIhtiyac += mibL.NetIhtiyac;
                toplamGirilenBrutIhtiyac += mibL.BrutIhtiyac;
                toplamGirilenToplamIhtiyac += mibL.ToplamIhtiyac;
                _source.Add(mibL);
            }
            _mibL.Delete = true;
            DialogResult = DialogResult.OK;
            Close();
        }
        protected override void Control_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == chkOranliBol)
            {
                chkMiktaraGoreBol.Checked = !chkOranliBol.Checked;
                txtMiktaraGoreBol.EditValue = chkOranliBol.Checked?null: txtMiktaraGoreBol.EditValue;
                txtOranliBol.EditValue = !chkOranliBol.Checked ? null: txtOranliBol.EditValue ;
                txtMiktaraGoreBol.Enabled = !chkOranliBol.Checked;
                txtOranliBol.Enabled = chkOranliBol.Checked;
            }
            else if(sender == chkMiktaraGoreBol)
            {
                chkOranliBol.Checked = !chkMiktaraGoreBol.Checked;
                txtMiktaraGoreBol.EditValue = chkOranliBol.Checked ? null : txtMiktaraGoreBol.EditValue;
                txtOranliBol.EditValue = !chkOranliBol.Checked ? null : txtOranliBol.EditValue;
                txtOranliBol.Enabled = !chkMiktaraGoreBol.Checked;
                txtMiktaraGoreBol.Enabled = !chkOranliBol.Checked;
            }
        }
    }
}
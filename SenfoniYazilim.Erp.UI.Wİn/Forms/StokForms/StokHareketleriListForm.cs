using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms
{
    public partial class StokHareketleriListForm : BaseListForm
    {
        private HareketTuru _hareketTuru;

        private Expression<Func<StokHareketleri, bool>> _filter;

        public StokHareketleriListForm()
        {
            InitializeComponent();

            Bll = new StokHareketleriBll();

            txtHareketTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<HareketTuru>().Cast<object>().ToList());
            txtTarihBitis.Properties.MaxValue = DateTime.Now;
            txtTarihBaslangic.Properties.MinValue = new DateTime(2022, 01, 01);
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            BaseKartTuru = KartTuru.StokHareket;
            if (myDataLayoutControl == null) return;
            foreach (Control ctrl in myDataLayoutControl.Controls)
                ControlEvents(ctrl);
            txtTarihBaslangic.EditValue =new DateTime(2022,01,01);
            txtTarihBitis.EditValue = DateTime.Now;
            txtHareketTuru.SelectedItem = HareketTuru.Hepsi.toName();

            //FormShow = new ShowEditForms<TesvikEditForm>();
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((StokHareketleriBll)Bll).List(x => x.Id!=0).toBindingList<StokHareketleriL>();
        }

        protected override void Tablo_DoubleClick(object sender, EventArgs e){}

        protected override void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            base.Tablo_KeyDown(sender, e);
        }

        private void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!TabloLoaded) return;

            if (sender==txtTarihBaslangic||sender==txtTarihBitis)
            {
                if(txtStokKodu.EditValue!=null)
                    _filter=x => x.StokId == txtStokKodu.Id && x.HareketTuru == _hareketTuru&&x.HareketTarihi>txtTarihBaslangic.DateTime&& x.HareketTarihi < txtTarihBitis.DateTime;
                else
                    _filter = x => x.HareketTuru == _hareketTuru && x.HareketTarihi > txtTarihBaslangic.DateTime && x.HareketTarihi < txtTarihBitis.DateTime;

                Tablo.GridControl.DataSource = ((StokHareketleriBll)Bll).List(_filter).toBindingList<StokHareketleriL>();
                _filter = null;
            }
        }

        private void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender == txtHareketTuru)
            {
                _hareketTuru = txtHareketTuru.Text.GetEnum<HareketTuru>();
                if (txtStokKodu.EditValue != null)
                    if(_hareketTuru!=HareketTuru.Hepsi)
                        _filter = x => x.StokId == txtStokKodu.Id && x.HareketTuru == _hareketTuru;
                    else
                        _filter = x => x.StokId == txtStokKodu.Id;
                else if (_hareketTuru == HareketTuru.Hepsi)
                    _filter = x => x.Id!=0;
                else
                    _filter = x => x.HareketTuru == _hareketTuru;

                Tablo.GridControl.DataSource = ((StokHareketleriBll)Bll).List(_filter).toBindingList<StokHareketleriL>();
            }
        }
        private  void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtStokKodu)
                { 
                    sec.Sec(txtStokKodu, txtStokAdi);
                    Tablo.GridControl.DataSource = ((StokHareketleriBll)Bll).List(x => x.StokId == txtStokKodu.Id).toBindingList<StokHareketleriL>();
                }
            }
                
        }
        private void ControlEvents(Control control)
        {
            control.KeyDown += Control_KeyDown;
            control.GotFocus += Control_GotFocus;

            switch (control)
            {
                case ComboBoxEdit edt:
                    edt.EditValueChanged += Control_EditValueChanged;
                    edt.SelectedValueChanged += Control_SelectedValueChanged;
                    break;
                case MyButtonEdit edt:
                    edt.EnabledChanged += Control_EnabledChanged;
                    edt.ButtonClick += Control_ButtonClick;
                    edt.DoubleClick += Control_DoubleClick;
                    break;
                case BaseEdit edt:
                    edt.EditValueChanged += Control_EditValueChanged;
                    break;
            }

        }

        private void Control_EnabledChanged(object sender, EventArgs e)
        {
            if (sender != txtStokKodu) return;
            txtStokKodu.ControlEnabledChanged(txtStokAdi);
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            if (sender is MyButtonEdit edt)
                switch (e.KeyCode)
                {
                    case Keys.Delete when e.Control && e.Shift://burada ctrl+shift+delete yaptığımızda kontrolün içeriğini boşaltmış olacağız..
                        edt.Id = null;
                        edt.EditValue = null;
                        break;
                    case Keys.F4:
                    case Keys.Down when e.Modifiers == Keys.Alt:
                        SecimYap(edt);
                        break;
                }
        }

        private void Control_GotFocus(object sender, EventArgs e){}

        private void Control_DoubleClick(object sender, EventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            SecimYap(sender);
        }
    }
}

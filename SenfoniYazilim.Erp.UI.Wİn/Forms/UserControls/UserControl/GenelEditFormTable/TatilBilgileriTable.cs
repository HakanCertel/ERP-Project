using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.GenelEditFormTable
{
    public partial class TatilBilgileriTable : BaseTablo
    {
        public TatilBilgileriTable()
        {
            InitializeComponent();
            Bll = new TatilBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((TatilBilgileriBll)Bll).List(null,x=>new TatilBilgileriL {
                Id=x.Id,
                Tarih =x.Tarih,
                Aciklama=x.Aciklama,
                ZamanDilimi =x.ZamanDilimi
            }).ToList().toBindingList<TatilBilgileriL>();
        }
        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            var row = new TatilBilgileriL
            {
                Tarih = DateTime.Today,
                Insert = true
            };

            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colTarih;

            ButtonEnabledDurum(true);
        }
    }
}

using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraBars;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.FaturaForms
{
    public partial class FaturaPlaniEditForm :BaseEditForm
    {
        //private readonly long _tahakkukId;

        public FaturaPlaniEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            BaseKartTuru = KartTuru.Gorev;

            EventsLoad();

            HideItems = new BarItem[] { btnYeni };
            btnSil.Caption = "İptal Et";
        }
        //public FaturaPlaniEditForm(params object[] prm):this()
        //{
        //    _tahakkukId = (long)prm[0];
        //}

        public  override void Yukle()
        {
            TabloYukle();

            using (var bll=new HizmetBilgileriBll())
            {
                var list = bll.FaturaPlaniList(x => x.TahakkukId == Id).ToList();

                txtOgrenciNo.Text = list[0].OkulNo;
                txtAdi.Text = list[0].Adi;
                txtSoyadi.Text = list[0].Soyadi;
                txtSinifi.Text = list[0].SinifAdi;
                txtVeliAdi.Text = list[0].VeliAdi;
                txtVeliSoyadi.Text = list[0].VeliSoyadi;
                txtYakinlik.Text = list[0].VeliYakinlikAdi;
                txtMeslek.Text = list[0].VeliMeslekAdi;

                tablo.GridControl.DataSource = list;

                //Id = list[0].TahakkukId;
            }
        }

        protected override void TabloYukle()
        {
            faturaPlaniTable.OwnerForm = this;
            faturaPlaniTable.Yukle();
        }

        protected internal override void ButonEnabledDurumu()
        {
            GeneralFunctions.ButtonEnabledDurumu(btnKaydet, btnGerial, faturaPlaniTable.TableValueChanged);
        }

        protected override bool EntityInsert()
        {
            return faturaPlaniTable.Kaydet();
        }
        protected override bool EntityUpdate()
        {
            return faturaPlaniTable.Kaydet();
        }
        protected override void EntityDelete()
        {
            if (Messages.HayirSeciliEvetHayir("Fatura Planı Iptal Edilecek Onaylıyor Musunuz?", "İptal Onay") != DialogResult.Yes) return;
            var source = faturaPlaniTable.Tablo.DataController.ListSource.Cast<FaturaPlaniL>().Where(x => x.TahakkukTarih == null).ToList();
            if (source == null) return;

            source.ForEach(x => x.Delete = true);
            faturaPlaniTable.Tablo.RefreshDataSource();
            faturaPlaniTable.TableValueChanged = true;
            ButonEnabledDurumu();
        }

        protected override void BaseEditForm_Shown(object sender, EventArgs e)
        {
            faturaPlaniTable.Tablo.Focus();
        }
    }
}
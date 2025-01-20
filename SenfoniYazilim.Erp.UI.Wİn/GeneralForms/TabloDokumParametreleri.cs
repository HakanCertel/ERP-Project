using System;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    public partial class TabloDokumParametreleri : BaseEditForm
    {
        private DokumSekli _dokumSekli;
        private string _raporBasligi;

        public TabloDokumParametreleri(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl2;
            HideItems = new DevExpress.XtraBars.BarItem[] { btnYeni,btnKaydet,btnGerial,btnSil,};
            ShowItems = new DevExpress.XtraBars.BarItem[] {btnYazdir,btnBaskiOnIzleme };
            EventsLoad();

            _raporBasligi = prm[0].ToString();
        }

        public  override void Yukle()
        {
            txtRaporBasligi.Text = _raporBasligi;
            txtBaslikEkle.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtRaporKagidaSigdir.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<RaporuKagidaSigdirma>());
            txtYazdirmaYonu.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YazdirmaYonu>());
            txtYatayCizgileriGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtDikeyCizgileriGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtSutunBaslikleriniGoster.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtYaziciAdi.Properties.Items.AddRange(GeneralFunctions.YazicilariListele());

            txtBaslikEkle.SelectedItem = EvetHayir.Evet.toName();
            txtRaporKagidaSigdir.SelectedItem = RaporuKagidaSigdirma.YaziBoyutunuKuculterekSigdir.toName();
            txtYazdirmaYonu.SelectedItem = YazdirmaYonu.Ototmatik.toName();
            txtYatayCizgileriGoster.SelectedItem = EvetHayir.Evet.toName();
            txtDikeyCizgileriGoster.SelectedItem = EvetHayir.Evet.toName();
            txtSutunBaslikleriniGoster.SelectedItem = EvetHayir.Evet.toName();
            txtYaziciAdi.EditValue = GeneralFunctions.DefaultYazici();
        }

        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new DokumParametreleri
            {
                RaporBaslik = txtRaporBasligi.Text,
                BaslikEkle = txtBaslikEkle.Text.GetEnum<EvetHayir>(),
                RaporuKagidaSigdir = txtRaporKagidaSigdir.Text.GetEnum<RaporuKagidaSigdirma>(),
                YazdirmaYonu = txtYazdirmaYonu.Text.GetEnum<YazdirmaYonu>(),
                YatayCizgileriGoster=txtYatayCizgileriGoster.Text.GetEnum<EvetHayir>(),
                DİkeyCizgileriGoster=txtDikeyCizgileriGoster.Text.GetEnum<EvetHayir>(),
                SutunBaslikleriniGoster=txtSutunBaslikleriniGoster.Text.GetEnum<EvetHayir>(),
                YaziciAdi=txtYaziciAdi.Text,
                YazdirilacakAdet=(int)txtYazdirilacakAdet.Value,
                DokumSekli=_dokumSekli
            };

            return entity;
        }

        protected override void Yazdir()
        {
            _dokumSekli = DokumSekli.TabloYazdir;
            Close();
        }

        protected override void BaskiOnIzlem()
        {
            _dokumSekli = DokumSekli.TabloBaskiOnizleme;
            Close();
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtBaslikEkle) return;
            txtRaporBasligi.Enabled = txtBaslikEkle.Text.GetEnum<EvetHayir>() == EvetHayir.Evet; 
        }
    }
}
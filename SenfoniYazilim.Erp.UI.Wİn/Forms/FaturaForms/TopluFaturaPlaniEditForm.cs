using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using DevExpress.XtraBars;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Drawing;
using DevExpress.XtraLayout.Utils;
using SenfoniYazilim.Erp.Bll.General;
using DevExpress.XtraPrinting.Native;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.FaturaForms
{
    public partial class TopluFaturaPlaniEditForm : BaseEditForm
    {
        private readonly IList<FaturaAlinanHizmetlerL> _alinanHizmetlerSource;
        private readonly IList _faturaPlaniSource;
        private readonly IList<FaturaL> _faturaPlaniKartlari;

        public TopluFaturaPlaniEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            EventsLoad();

            HideItems = new BarItem[] { btnYeni, btnKaydet, btnFarkliKaydet, btnUygula, btnGerial };
            ShowItems = new BarItem[] { btnTaksitOlustur };

            txtOzelTahakkuk.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            txtAyBilgisi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
        }
        public TopluFaturaPlaniEditForm(params object[] prm):this()
        {
            if (prm.Length == 1)
                _faturaPlaniKartlari = (IList<FaturaL>)prm[0];
            else
            { 
            _alinanHizmetlerSource = (IList<FaturaAlinanHizmetlerL>)prm[0];
            _faturaPlaniSource = (IList)prm[1];
            }
        }

        public  override void Yukle()
        {
            btnTaksitOlustur.Caption = "Plan Oluştur";
            txtIlkFaturaTarih.DateTime = DateTime.Now.Date;
            txtSabitTutar.Value = 0;
            txtOzelTahakkuk.SelectedItem = EvetHayir.Hayır.toName();
            txtAyBilgisi.SelectedItem = EvetHayir.Hayır.toName();

            if (_faturaPlaniKartlari != null)
                MinimumSize = new Size(475, 280);
            else
            {
                layoutControlProgress.Visibility = LayoutVisibility.Never;
                layoutControlGroup.OptionsTableLayoutGroup.RowDefinitions.RemoveAt(4);
                layoutControlGroup.Update();
                MaximumSize = new Size(475, 250);
            }
        }

        private static string AlinanHizmetler(IList<string> hizmetlerSource)            
        {
            var alinanHizmetler = "";
            for (int i = 0; i < hizmetlerSource.Count; i++)
            {
                alinanHizmetler += hizmetlerSource[i];
                if (i + 1 < hizmetlerSource.Count)
                    alinanHizmetler += ", ";
            }
            return alinanHizmetler;
        }

        protected override void RunMrp()
        {
            if (_faturaPlaniKartlari != null)
            {
                TopluFaturaPlani();
                return;
            }
            var tahakkukId = _alinanHizmetlerSource.Select(x => x.TahakkukId).First();
            var alinanHizmetler = _alinanHizmetlerSource.Select(x => x.HizmetAdi).ToList();
            var hizmetlerToplami = _alinanHizmetlerSource.Sum(x => x.BrutUcret);
            var indirimlerToplami= _alinanHizmetlerSource.Sum(x => x.Indirim);

            var ilkFaturaTarihi = txtIlkFaturaTarih.DateTime.Date;
            var faturaAdet =(int) txtAdet.Value;
            var sabitTurar = txtSabitTutar.Value;
            var ozetTahakkuk = txtOzelTahakkuk.Text.GetEnum<EvetHayir>();
            var ozetAciklama = txtOzelTahakkukAciklama.Text;

            var girilenBrutTutarToplami = _faturaPlaniSource.Cast<FaturaPlaniL>().Where(x => !x.Delete).Sum(x => x.PlanTutar);
            var girilenIndirimTutarToplami = _faturaPlaniSource.Cast<FaturaPlaniL>().ToList().Where(x => !x.Delete).Sum(x => x.PlanIndirimTutar);

            var girilecekBrutTutar = sabitTurar > 0 ? sabitTurar : Math.Round((hizmetlerToplami - girilenBrutTutarToplami) / faturaAdet, AnaForm.DonemParametreleri.FaturaTahakkukKurusKullan ? 2 : 0);
            var girilecekIndirimTutar = sabitTurar > 0 ? 0 : Math.Round((indirimlerToplami - girilenIndirimTutarToplami) / faturaAdet, AnaForm.DonemParametreleri.FaturaTahakkukKurusKullan ? 2 : 0);
            var girilecekNetTutar = girilecekBrutTutar - girilecekIndirimTutar;

            if (girilecekBrutTutar < 0)
            {
                Messages.UyariMesaji("Verilen Hizmetler Toplamı Kadar Fatura Planı Zaten Oluşturulmuştur.");
                return;
            }

            for (int i = 0; i < faturaAdet; i++)
            {
                var row = new FaturaPlaniL
                {
                    TahakkukId = tahakkukId,
                    Aciklama = ozetTahakkuk == EvetHayir.Evet ? ozetAciklama : AlinanHizmetler(alinanHizmetler) + " Bedeli",
                    PlanTarihi = ilkFaturaTarihi.AddMonths(i),
                    PlanTutar = girilecekBrutTutar,
                    PlanIndirimTutar = girilecekIndirimTutar,
                    PlanNetTutar = girilecekNetTutar,
                    Insert = true
                };

                if (txtOzelTahakkuk.Text.GetEnum<EvetHayir>() == EvetHayir.Evet)
                    row.Aciklama = ozetAciklama;
                if(txtAyBilgisi.Text.GetEnum<EvetHayir>()==EvetHayir.Evet)
                {
                    var ay =(Aylar)row.PlanTarihi.Month;
                    row.Aciklama = ay.toName() + "-" + row.PlanTarihi.Year + " Ayı " + row.Aciklama;
                }

                if (i + 1 == faturaAdet && sabitTurar == 0)
                {
                    row.PlanTutar=hizmetlerToplami- _faturaPlaniSource.Cast<FaturaPlaniL>().Where(x => !x.Delete).Sum(x => x.PlanTutar);
                    row.PlanIndirimTutar=indirimlerToplami- _faturaPlaniSource.Cast<FaturaPlaniL>().Where(x => !x.Delete).Sum(x => x.PlanIndirimTutar);
                    row.PlanNetTutar = row.PlanTutar - row.PlanIndirimTutar;
                }

                _faturaPlaniSource.Add(row);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void TopluFaturaPlani()
        {
            if (Messages.HayirSeciliEvetHayir("Toplu Fatura Planı Oluşturulacak . Onaylıyor Musunuz?", "Onay") != DialogResult.Yes) return;

            var ilkFaturaTarihi = txtIlkFaturaTarih.DateTime.Date;
            var faturaAdet = (int)txtAdet.Value;
            var sabitTurar = txtSabitTutar.Value;
            var ozetTahakkuk = txtOzelTahakkuk.Text.GetEnum<EvetHayir>();
            var ozetAciklama = txtOzelTahakkukAciklama.Text;
            var position = 0.0;

            using (var faturaBll=new FaturaBll())
            {
                using (var hizmetBilgileriBll =new HizmetBilgileriBll())
                {
                    _faturaPlaniKartlari.ForEach(x =>
                    {
                        var yuzde = 100.0 / _faturaPlaniKartlari.Count;
                        position += yuzde;

                        var hizmetTutarı = x.HizmetTutar;
                        var hizmetIndirim = x.HizmetIndirim;
                        var planTutar = x.PlanTutar;
                        var planIndirim = x.PlanIndirim;
                        var alinanHizmetler = AlinanHizmetler(hizmetBilgileriBll.FaturaPlaniList(y => y.TahakkukId == x.Id).Select(y => y.HizmetAdi).ToList());

                        var girilecekBrutTutar = sabitTurar > 0 ? sabitTurar : Math.Round((hizmetTutarı - planTutar) / faturaAdet, AnaForm.DonemParametreleri.FaturaTahakkukKurusKullan ? 2 : 0);
                        var girilecekIndirimTutar = sabitTurar > 0 ? 0 : Math.Round((hizmetIndirim - planIndirim) / faturaAdet, AnaForm.DonemParametreleri.FaturaTahakkukKurusKullan ? 2 : 0);
                        var girilecekNetTutar = girilecekBrutTutar - girilecekIndirimTutar;

                        if (hizmetTutarı == 0 || hizmetTutarı == planTutar && hizmetIndirim == planIndirim)
                        {
                            progressBarControl.Position = 100;
                            return;
                        }

                        for (int i = 0; i < faturaAdet; i++)
                        {
                            var row = new FaturaPlaniL
                            {
                                TahakkukId = x.Id,
                                Aciklama = ozetTahakkuk == EvetHayir.Evet ? ozetAciklama :alinanHizmetler + " Bedeli",
                                PlanTarihi = ilkFaturaTarihi.AddMonths(i),
                                PlanTutar = girilecekBrutTutar,
                                PlanIndirimTutar = girilecekIndirimTutar,
                                PlanNetTutar = girilecekNetTutar,
                                Insert = true
                            };

                            if (txtOzelTahakkuk.Text.GetEnum<EvetHayir>() == EvetHayir.Evet)
                                row.Aciklama = ozetAciklama;
                            if (txtAyBilgisi.Text.GetEnum<EvetHayir>() == EvetHayir.Evet)
                            {
                                var ay = (Aylar)row.PlanTarihi.Month;
                                row.Aciklama = ay.toName() + "-" + row.PlanTarihi.Year + " Ayı " + row.Aciklama;
                            }

                            if (i + 1 == faturaAdet && sabitTurar == 0)
                            {
                                row.PlanTutar = (hizmetTutarı - planTutar)-(girilecekBrutTutar*i);
                                row.PlanIndirimTutar = (hizmetIndirim-planIndirim)-(girilecekIndirimTutar*i);
                                row.PlanNetTutar = row.PlanTutar - row.PlanIndirimTutar;
                            }

                            if (!faturaBll.InsertSingle(row)) return;
                            progressBarControl.Position = (int)position;
                            progressBarControl.Update();
                        }

                    });
                }
            }

            Messages.BilgiMesaji("Fatura Planı Oluşturma İşlemi Başarılı Bir Şekilde Tamalanmıştır.");
            DialogResult=DialogResult.OK;
            Close();
        }

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender != txtOzelTahakkuk) return;
            txtOzelTahakkukAciklama.Enabled = txtOzelTahakkuk.Text.GetEnum<EvetHayir>() == EvetHayir.Evet;
            txtOzelTahakkukAciklama.Focus();
        }
    }
}
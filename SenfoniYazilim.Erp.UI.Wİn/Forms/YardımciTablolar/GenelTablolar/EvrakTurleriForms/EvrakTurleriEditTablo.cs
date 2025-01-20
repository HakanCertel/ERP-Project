using System;
using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using DevExpress.XtraPrinting.Native;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.Common.Message;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.EvrakTurleriForms
{
    public partial class EvrakTurleriEditTablo : BaseTablo
    {
        public EvrakTurleriEditTablo()
        {
            InitializeComponent();

            Bll = new EvrakTurleriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((EvrakTurleriBll)Bll).List(x=>x.Id>0).toBindingList<EvrakTurleriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            var row = new EvrakTurleriL
            {
                Insert = true,
                KayitTarihi=null,
                GuncellemeTarihi=null
            };

            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colEvrakTurKodu;

            ButtonEnabledDurum(true);
        }

        protected internal override bool Kaydet()
        {
            var source = tablo.DataController.ListSource.Cast<EvrakTurleriL>();
            source.ForEach(x =>
            {
                if (x.Insert)
                {
                    x.KayitTarihi = DateTime.Now;
                    x.KaydiOlusturan = AnaForm.KullaniciAdi;
                }
                else if (x.Update)
                {
                    x.GuncellemeTarihi = DateTime.Now;
                    x.KaydiGuncelleyen = AnaForm.KullaniciAdi;
                }

            });
            return base.Kaydet();   
        }
        protected internal override bool HatalıGiriş()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<EvrakTurleriL>(i);
                if (string.IsNullOrEmpty(entitiy.EvrakTurAdi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colEvrakTurAdi;
                    tablo.SetColumnError(colEvrakTurAdi, "Evrak Tur Adı Alanına Geçerli Bir Değer Giriniz .");
                }
                if (string.IsNullOrEmpty(entitiy.EvrakTurAdi))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colEvrakTurKodu;
                    tablo.SetColumnError(colEvrakTurKodu, "Evrak Tur Kodu Alanına Geçerli Bir Değer Giriniz .");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }
        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var source = tablo.DataController.ListSource.Cast<EvrakTurleriL>().ToList();
            if (source.Count == 0) return;

            var rowHandle = tablo.FocusedRowHandle;
            if(!source[rowHandle].Insert)
                source[rowHandle].Update = true;
            
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        }

    }
}

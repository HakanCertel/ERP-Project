using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.FaturaForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using System;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.FaturaEditFormTable
{
    public partial class FaturaTahakkukTable : BaseTablo
    {
        public FaturaTahakkukTable()
        {
            InitializeComponent();

            Bll = new FaturaBll();
            Tablo = tablo;
            EventsLoad();

            btnHareketEkle.Caption = "Tahakkuk Yap";
            btnHareketSil.Caption = "Tahakkuk İptal Et";
            insUpNavigator.Navigator.Buttons.Append.Hint = "Tahakkuk Yap";
            insUpNavigator.Navigator.Buttons.Remove.Hint = "Tahakkuk İptal Et";
        }

        protected internal override void Listele()
        {
            var selectedItem = ((FaturaTahakkukEditForm)OwnerForm).txtFaturaDonemi.SelectedItem;
            if (selectedItem == null) return;

            var tarih = DateTime.Parse(selectedItem.ToString());
            tablo.GridControl.DataSource = ((FaturaBll)Bll).FaturaTahakkukList(x => x.Tahakkuk.SubeId == AnaForm.SubeId && x.Tahakkuk.DonemId == AnaForm.DonemId && x.PlanTarihi == tarih).toBindingList<FaturaPlaniL>();

        }
        protected override void HareketEkle()
        {
            if (tablo.DataRowCount == 0)
            {
                Messages.HataMesaji("Fatura Tahakkuk Yapılacak Öğrenci Bulanamadı. Fatura Dönemi Seçmemiş Olabilirsiniz.");
                return;
            }
            if (Messages.HayirSeciliEvetHayir("Seçilen Öğrencilere Yukarıda Seçmiş Olduğunuz Parametrelere Göre Fatura Tahakkuku Yapılacaktır.Onaylıyor Musunuz?", "Tahakkuk Onay") != DialogResult.Yes) return;

            var faturaNo =(int) ((FaturaTahakkukEditForm)OwnerForm).txtFaturaNo.Value;
            var kdvSekli = ((FaturaTahakkukEditForm)OwnerForm).txtKdvSekli.Text.GetEnum<KdvSekli>();
            var kdvOrani = (byte)((FaturaTahakkukEditForm)OwnerForm).txtKdvOrani.Value;
            var adresTuru = ((FaturaTahakkukEditForm)OwnerForm).txtFaturaAdresi.Text.GetEnum<AdresTuru>();

            decimal KdvHesapla(decimal tutar)
            {
                return kdvSekli == KdvSekli.Dahil ? Math.Round(tutar * kdvOrani / (100 + kdvOrani), 2) : Math.Round(tutar * kdvOrani / 100, 2);
            }

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<FaturaPlaniL>(i);
                if (entity == null) return;

                entity.FaturaNo = faturaNo + i;
                entity.TahakkukTarih = entity.PlanTarihi;
                entity.TahakkukTutar = entity.PlanTutar;
                entity.TahakkukIndirimTutar = entity.PlanIndirimTutar;
                entity.TahakkukNetTutar = entity.PlanNetTutar;
                entity.KdvOrani = kdvOrani;
                entity.KdvTutari = KdvHesapla(entity.TahakkukNetTutar.Value);
                entity.KdvHaricTutar = kdvSekli == KdvSekli.Haric ? entity.TahakkukNetTutar : entity.TahakkukNetTutar - entity.KdvTutari;
                entity.FaturaAdres = adresTuru == AdresTuru.EvAdresi ? entity.VeliEvAdres : entity.VeliIsAdres;
                entity.FaturaAdresIlId = adresTuru == AdresTuru.EvAdresi ? entity.VeliEvAdresIlId : entity.VeliIsAdresIlId;
                entity.FaturaAdresIlAdi = adresTuru == AdresTuru.EvAdresi ? entity.VeliEvAdresIlAdi : entity.VeliIsAdresIlAdi;
                entity.FaturaAdresiIlceId= adresTuru == AdresTuru.EvAdresi ? entity.VeliEvAdresIlceId : entity.VeliIsAdresIlceId;
                entity.FaturaAdresIlceAdi= adresTuru == AdresTuru.EvAdresi ? entity.VeliEvAdresIlceAdi : entity.VeliIsAdresIlceAdi;
                entity.Update = true;
            }

            tablo.RefreshData();
            ButtonEnabledDurum(true);
        }

        protected override void HareketSil()
        {
            if (Messages.HayirSeciliEvetHayir("Seçilen Öğrencilere Yapılan Fatura Tahakkukları İptal Edilecektir. Onaylıyor Musunuz?", "İptal Onay") != DialogResult.Yes) return;

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<FaturaPlaniL>(i);
                if (entity == null) return;

                entity.FaturaNo = null;
                entity.TahakkukTarih = null;
                entity.TahakkukTutar = null;
                entity.TahakkukIndirimTutar = null;
                entity.TahakkukNetTutar = null;
                entity.KdvOrani = null;
                entity.KdvTutari = null;
                entity.KdvHaricTutar = null;
                entity.FaturaAdres = null;
                entity.FaturaAdresIlId = null;
                entity.FaturaAdresIlAdi = null;
                entity.FaturaAdresiIlceId = null;
                entity.FaturaAdresIlceAdi = null;
                entity.Update = true;
            }

            tablo.RefreshData();
            ButtonEnabledDurum(true);
        }
    }
}

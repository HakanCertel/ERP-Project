using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.IletisimForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.TahakkukEditFormTable
{
    public partial class IletisimBilgileriTable : BaseTablo
    {
        public IletisimBilgileriTable()
        {
            InitializeComponent();

            Bll = new IletisimBilgileriBll();
            Tablo = tablo;
            EventsLoad();

            ShowItems = new BarItem[] { btnKartDuzenle };

            repositoryAdres.Items.AddEnum<AdresTuru>();
        }

        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((IletisimBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).toBindingList<IletisimBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<IletisimBilgileriL>().Where(x => !x.Delete).Select(x => x.IletisimId).ToList();
            //ListeDisiTutulacakKayitlar.Add(OwnerForm.Id);

            var entities = ShowListForms<IletisimListForm>.ShowDialogListForm(KartTuru.Iletisim, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<IletisimL>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new IletisimBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    IletisimId=entity.Id,
                    TcKimlikNo=entity.TcKimlikNo,
                    Adi=entity.Adi,
                    Soyadi=entity.Soyadi,
                    EvTel=entity.EvTelefonu,
                    IsTel1=entity.IsTelefonu1,
                    IsTel2=entity.IsTelefonu2,
                    CepTel1=entity.CepTelefonu1,
                    CepTel2=entity.CepTelefonu2,
                    EvAdres=entity.EvAdres,
                    EvAdresIlAdi=entity.EvAdresIlAdi,
                    EvAdresIlceAdi=entity.EvAdresIlceAdi,
                    IsAdres=entity.IsAdresi,
                    IsAdresIlAdi=entity.IsAdresIlAdi,
                    IsAdresIlceAdi=entity.IsAdresIlceAdi,
                    IsyeriAdi=entity.IsyeriAdi,
                    MeslekAdi=entity.MeslekAdi,
                    GorevAdi=entity.GorevAdi,
                    Insert = true
                };
                if (source.Count == 0)
                {
                    row.Veli = true;
                    row.FaturaAdresi = AdresTuru.EvAdresi;
                }

                //var yakinlik =(Yakinlik) ShowListForms<YakinlikListForm>.ShowDialogListForm(KartTuru.Yakinlik, -1);
                //if (yakinlik == null) return;
                //row.YakinlikId = yakinlik.Id;
                //row.YakinlikAdi = yakinlik.YakinlikAdi;

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colVeli;

            ButtonEnabledDurum(true);
            //bir tabloya row eklemenin başka bir yolu ise aşğıda yazılmış olan kodlar gibidir fakat zor olanıdır bu yöntem.
            //var row1 = new IndiriminUygulanacagiHizmetBilgileriL();
            //tablo.AddNewRow();
            //tablo.SetFocusedRowCellValue(colHizmetAdi, row1.HizmetAdi);
            //tablo.SetFocusedRowCellValue(colIndirimTutari, row1.IndirimTutari);
        }

        protected internal override bool HatalıGiriş()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<IletisimBilgileriL>(i);

                if (entitiy.YakinlikAdi==null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colYakinlikAdi;
                    tablo.SetColumnError(colYakinlikAdi, "Yakınlık Adı Alanına Geçerli Bir Değer Giriniz .");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

        protected override void OpenEntity()
        {
            var entity = tablo.GetRow<IletisimBilgileriL>();
            if (entity == null) return;

            ShowEditForms<IletisimEditForm>.ShowDialogForm(KartTuru.Iletisim, entity.IletisimId,null);
        }

        protected override void ImageComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var source = tablo.DataController.ListSource.Cast<IletisimBilgileriL>().ToList();
            if (source.Count == 0) return;

            var rowHandle = tablo.FocusedRowHandle;

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                if (i == rowHandle) continue;

                if (source[i].FaturaAdresi == null) continue;

                source[i].FaturaAdresi = null;

                if (!source[i].Insert)
                    source[i].Update = true;
            }

            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        }

        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            var source = tablo.DataController.ListSource.Cast<IletisimBilgileriL>().ToList();
            if (source.Count == 0) return;

            var rowHandle = tablo.FocusedRowHandle;

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                if (i == rowHandle) continue;

                if (source[i].Veli == false) continue;

                source[i].FaturaAdresi = null;

                if (!source[i].Insert)
                    source[i].Update = true;
            }

            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colYakinlikAdi)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryYakinlik, colYakinlikId);
        }
    }
}

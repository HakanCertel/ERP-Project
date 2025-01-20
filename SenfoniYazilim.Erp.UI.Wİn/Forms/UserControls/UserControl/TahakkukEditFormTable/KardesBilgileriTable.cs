using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.TahakkukForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using System.ComponentModel;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.TahakkukEditFormTable
{
    [ToolboxItem(true)]
    public partial class KardesBilgileriTable : BaseTablo
    {
        [ToolboxItem(true)]
        public KardesBilgileriTable()
        {
            InitializeComponent();

            Bll = new KardesBilgileriBll();
            Tablo = tablo;
            EventsLoad();

            ShowItems = new BarItem[] { btnKartDuzenle };
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((KardesBilgileriBll)Bll).List(x => x.TahakkukId == OwnerForm.Id).toBindingList<KardesBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<KardesBilgileriL>().Where(x => !x.Delete).Select(x => x.KardesTahakkukId).ToList();
            ListeDisiTutulacakKayitlar.Add(OwnerForm.Id);
            
            var entities = ShowListForms<TahakkukListForm>.ShowDialogListForm(KartTuru.Tahakkuk, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<TahakkukL>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new KardesBilgileriL
                {
                    TahakkukId = OwnerForm.Id,
                    KardesTahakkukId = entity.Id,
                    Adi = entity.Adi,
                    Soyadi=entity.Soyadi,
                    SinifAdi=entity.SinifAdi,
                    KayitSekli=entity.KayitSekli,
                    KayitDurumu=entity.KayitDurumu,
                    IptalDurumu=entity.Durum?IptalDurumu.DevamEdiyor:IptalDurumu.IptalEdildi,
                    SubeAdi=entity.SubeAdi,
                    SubeId = AnaForm.SubeId,
                    Insert = true
                };

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colAdi;

            ButtonEnabledDurum(true);
            //bir tabloya row eklemenin başka bir yolu ise aşğıda yazılmış olan kodlar gibidir fakat zor olanıdır bu yöntem.
            //var row1 = new IndiriminUygulanacagiHizmetBilgileriL();
            //tablo.AddNewRow();
            //tablo.SetFocusedRowCellValue(colHizmetAdi, row1.HizmetAdi);
            //tablo.SetFocusedRowCellValue(colIndirimTutari, row1.IndirimTutari);
        }

        protected override void OpenEntity()
        {
            var entity = tablo.GetRow<KardesBilgileriL>();
            if (entity == null) return;

            ShowEditForms<TahakkukEditForm>.ShowDialogForm(KartTuru.Tahakkuk, entity.KardesTahakkukId, entity.SubeId==AnaForm.SubeId);
        }
    }
}

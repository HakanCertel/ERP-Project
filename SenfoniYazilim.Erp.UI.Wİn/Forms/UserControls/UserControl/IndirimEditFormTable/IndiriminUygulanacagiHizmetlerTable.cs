using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.HizmetForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System.ComponentModel;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.IndirimEditFormTable
{
    [ToolboxItem(true)]
    public partial class IndiriminUygulanacagiHizmetlerTable : BaseTablo
    {
        public IndiriminUygulanacagiHizmetlerTable()
        {
            InitializeComponent();

            Bll = new IndiriminUygulanacagiHizmetBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            /*bu tarz bir tabloya veri eklemek ve üzerinde işlemler yapabilmek için veriler ToList olarak
             değil bindingLİst olarak gönderilmeli buyüzden bll ile filtrelenerek datasource e eklenecek veriler 
             bindinglist e cast edilmeli..*/
            tablo.GridControl.DataSource = ((IndiriminUygulanacagiHizmetBilgileriBll)Bll).List(x => x.IndirimId == OwnerForm.Id).toBindingList< IndiriminUygulanacagiHizmetBilgileriL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<IndiriminUygulanacagiHizmetBilgileriL>().Where(x => !x.Delete).Select(x => x.HizmetId).ToList();
            var entities = ShowListForms<HizmetListForm>.ShowDialogListForm(KartTuru.Hizmet, ListeDisiTutulacakKayitlar, true,false).EntityListConvert<HizmetL>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new IndiriminUygulanacagiHizmetBilgileriL
                {
                    IndirimId=OwnerForm.Id,
                    HizmetId=entity.Id,
                    HizmetAdi=entity.HizmetAdi,
                    IndirimTutari=0,
                    IndirimOrani=0,
                    SubeId=AnaForm.SubeId,
                    DonemId=AnaForm.DonemId,
                    Insert=true
                };

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colIndirimTutari;

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
            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<IndiriminUygulanacagiHizmetBilgileriL>();

                if (entity.IndirimOrani == 0 || entity.IndirimTutari == 0) continue;
                tablo.Focus();
                tablo.FocusedRowHandle = i;
                Messages.HataMesaji("İndirim Tutarı ve İndirim Oranı alanlarından Sadece Biri Sıfırdan Büyük Olabilir");
                return false;
            }
            return false;
        }
    }
}

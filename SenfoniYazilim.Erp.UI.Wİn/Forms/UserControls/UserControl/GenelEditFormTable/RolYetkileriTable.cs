using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.KullaniciForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using System;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.GenelEditFormTable
{
    public partial class RolYetkileriTable : BaseTablo
    {
        public RolYetkileriTable()
        {
            InitializeComponent();

            Bll = new RolYetkileriBll();
            Tablo = tablo;
            ShowItems = new DevExpress.XtraBars.BarItem[] { btnTumunuSec, btnTumSecimleriKaldir };
            EventsLoad();
        }
        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((RolYetkileriBll)Bll).List(x => x.RolId == OwnerForm.Id).toBindingList<RolYetkileriL>();
        }
        protected override void HareketEkle()
        {
            ///bu fonksiyon ile rolEditForma eklenen kartturlerinden verilecek rollerle ilgili olarak
            ///bazı formlarlarla ilgili verilebilecek tek yetki görüntüleme yetkisi olabililektitr,
            ///raporlar gibi, bundan dolayı diğer roller değiştirilemez bir şekilde gelmesi gerkmektedir
            ///bu metod bu işlemi yapacaktır.
            ///Burada if blok unun içine bu işlemi kapsayacak bütün kart turleri yazılarak işlem tamamlanmış olacaktır.

            byte CheckBoxValue(KartTuru kartTuru)
            {
                if (kartTuru == KartTuru.OgrenciKartiRaporu)
                    return 2;
                return 0;
            }
            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<RolYetkileriL>().Where(x => !x.Delete).Select(x =>(long) x.KartTuru).ToList();
            var entities = ShowListForms<RolYetkiKartlariListForm>.ShowDialogListForm(ListeDisiTutulacakKayitlar, true).EntityListConvert<RolYetki>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new RolYetkileriL
                {
                    RolId=OwnerForm.Id,
                    KartTuru=entity.KartTuru,
                    Ekleyebilir= CheckBoxValue(entity.KartTuru),
                    Degistirebilir = CheckBoxValue(entity.KartTuru),
                    Silebilir = CheckBoxValue(entity.KartTuru),
                    Insert = true
                };

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;

            ButtonEnabledDurum(true);
            //bir tabloya row eklemenin başka bir yolu ise aşğıda yazılmış olan kodlar gibidir fakat zor olanıdır bu yöntem.
            //var row1 = new IndiriminUygulanacagiHizmetBilgileriL();
            //tablo.AddNewRow();
            //tablo.SetFocusedRowCellValue(colHizmetAdi, row1.HizmetAdi);
            //tablo.SetFocusedRowCellValue(colIndirimTutari, row1.IndirimTutari);
        }

        protected override void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
        }
        protected override void RowCellAllowEdit()
        {
            if (tablo.DataRowCount == 0) return;

            var entity = Tablo.GetRow<RolYetkileriL>();
            if (entity == null) return;
            colEkleyebilir.OptionsColumn.AllowEdit = entity.Ekleyebilir != 2;
            colDegistirebilir.OptionsColumn.AllowEdit = entity.Degistirebilir != 2;
            colSilebilir.OptionsColumn.AllowEdit = entity.Silebilir != 2;

        }
        protected override void TumunuSec()
        {
            var source = Tablo.DataController.ListSource.Cast<RolYetkileriL>().ToList();

            for (int i = 0; i < source.Count; i++)
            {
                if (Tablo.FocusedColumn == colGorebilir && source[i].Gorebilir == 0)
                    source[i].Gorebilir = 1;
                else if (Tablo.FocusedColumn == colEkleyebilir&& source[i].Ekleyebilir == 0)
                    source[i].Ekleyebilir = 1;
                else if (Tablo.FocusedColumn == colDegistirebilir&& source[i].Degistirebilir == 0)
                    source[i].Degistirebilir = 1;
                else if (Tablo.FocusedColumn == colSilebilir&& source[i].Silebilir == 0)
                    source[i].Silebilir = 1;
                else if (Tablo.FocusedColumn == colKartTuru)
                {
                    if (source[i].Gorebilir == 0)
                        source[i].Gorebilir = 1;
                    if (source[i].Ekleyebilir == 0)
                        source[i].Ekleyebilir = 1;
                    if (source[i].Degistirebilir == 0)
                        source[i].Degistirebilir = 1;
                    if (source[i].Silebilir == 0)
                        source[i].Silebilir = 1;
                }

                if (!source[i].Insert)
                    source[i].Update = true;
                ///aşağıdaki fonksiyon tabloda yapılan değişikliklerin anında tabloya yansıtılabilmesini sağ
                ///lamak maksadıyla kullanılmıştır.
                tablo.RefreshRow(i);
            }

            ButtonEnabledDurum(true);
        }
        protected override void TumSecimleriKaldir()
        {
            var source = Tablo.DataController.ListSource.Cast<RolYetkileriL>().ToList();

            for (int i = 0; i < source.Count; i++)
            {
                if (Tablo.FocusedColumn == colGorebilir && source[i].Gorebilir == 1)
                    source[i].Gorebilir = 0;
                else if (Tablo.FocusedColumn == colEkleyebilir && source[i].Ekleyebilir == 1)
                    source[i].Ekleyebilir = 0;
                else if (Tablo.FocusedColumn == colDegistirebilir && source[i].Degistirebilir == 1)
                    source[i].Degistirebilir = 0;
                else if (Tablo.FocusedColumn == colSilebilir && source[i].Silebilir == 1)
                    source[i].Silebilir = 0;
                else if (Tablo.FocusedColumn == colKartTuru)
                {
                    if (source[i].Gorebilir == 1)
                        source[i].Gorebilir = 0;
                    if (source[i].Ekleyebilir == 1)
                        source[i].Ekleyebilir = 0;
                    if (source[i].Degistirebilir == 1)
                        source[i].Degistirebilir = 0;
                    if (source[i].Silebilir == 1)
                        source[i].Silebilir = 0;
                }

                if (!source[i].Insert)
                    source[i].Update = true;
                ///aşağıdaki fonksiyon tabloda yapılan değişikliklerin anında tabloya yansıtılabilmesini sağ
                ///lamak maksadıyla kullanılmıştır.
                tablo.RefreshRow(i);
            }

            ButtonEnabledDurum(true);
        }
    }
}

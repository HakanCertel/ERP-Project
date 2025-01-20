using System.Collections.Generic;
using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.General.MaterialBlls;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto.MaterialDtos;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.UI.Wİn.Forms.YardımcıTablolar.GenelTablolar.BirimForms;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using DevExpress.XtraGrid.Views.Base;
using SenfoniYazilim.Erp.Bll.Functions.Converts;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.StokForms.MaterialTables
{
    public partial class MaterialUnitsTable : BaseTablo
    {
        private List<Birim> _units;

        public MaterialUnitsTable()
        {
            InitializeComponent();
            Bll = new MaterialUnitsBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected internal override void Yukle()
        {
            base.Yukle();

            _units = Erp.Bll.Functions.GetAnySingleOrListBll.ListUnitItems(null);

            repositoryItemLookUpUnit.DataSource = _units;
            repositoryItemLookUpUnit.ValueMember = "Id";
            repositoryItemLookUpUnit.DisplayMember = "BirimAdi";
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((MaterialUnitsBll)Bll).List(x => x.MaterialId == OwnerForm.Id).toBindingList<MaterialUnitL>();
        }
        protected override void HareketEkle()
        {
            var source = Tablo.DataController.ListSource;

            if (((StokEditForm)OwnerForm).txtUnit.EditValue == null)
            {
                Messages.HataMesaji("Lütfen Malzeme İçin Geçerli Birim Seçimi Yapınız!");
                ((StokEditForm)OwnerForm).txtUnit.Focus();
                return;
            }

            ListeDisiTutulacakKayitlar = source.Cast<MaterialUnitL>().ToList().Where(x => !x.Delete).Select(x => x.UnitId).ToList();

            var entities = ShowListForms<BirimListForm>.ShowDialogListForm(ListeDisiTutulacakKayitlar, true, true).EntityListConvert<Birim>();

            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new MaterialUnitL
                {
                    MaterialId=((StokEditForm)OwnerForm).txtKod.Id,
                    UnitId=entity.Id,//(long)((StokEditForm)OwnerForm).txtUnit.EditValue,
                    MaterialUnitName=((StokEditForm)OwnerForm).txtUnit.Text,
                    Insert = true,
                };
                source.Add(row);
            }

            Tablo.Focus();
            Tablo.RefreshDataSource();
            Tablo.FocusedRowHandle = Tablo.DataRowCount - 1;
            Tablo.FocusedColumn = colUnitId;
            ButtonEnabledDurum(true);
        }
       
    }
}

using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.General.PurchaseBll;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto.Satınalma;
using SenfoniYazilim.Erp.Common.Message;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.SatınalmaForms.SatinalmaTalepForms
{
    public partial class PurchaseDemandItemsFeatureTable : BaseTablo
    {
        public PurchaseDemandItemsFeatureTable()
        {
            InitializeComponent();

            Bll = new PurchaseDemandItemsFeatureBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((PurchaseDemandItemsFeatureBll)Bll).List(x => x.OwnerFormId == OwnerForm.Id).toBindingList<PurchaseDemandItemsFeatureL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            var row = new PurchaseDemandItemsFeatureL
            {
                OwnerFormId = OwnerForm.Id,
                Insert = true
            };

            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colFeatureDescription;

            ButtonEnabledDurum(true);
        }

        protected internal override bool HatalıGiriş()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<PurchaseDemandItemsFeatureL>(i);
                if (string.IsNullOrEmpty(entitiy.FeatureDescription))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colFeatureDescription;
                    tablo.SetColumnError(colFeatureDescription, "Özellik Alanına Geçerli Bir Değer Giriniz .");
                }

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

    }
}

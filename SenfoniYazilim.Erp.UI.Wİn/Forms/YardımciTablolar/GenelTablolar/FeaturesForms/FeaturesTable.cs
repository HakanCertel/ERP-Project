using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using System;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.FeaturesForms
{
    public partial class FeaturesTable : BaseTablo
    {
        private KartTuru _kartTuru;

        public FeaturesTable()
        {
            InitializeComponent();
            Bll = new FeaturesBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            _kartTuru = ((FeaturesEditForm)OwnerForm)._kartTuru;
            var definationId =Convert.ToInt32( ((FeaturesEditForm)OwnerForm).txtDefination.EditValue);
            Tablo.GridControl.DataSource = ((FeaturesBll)Bll).List(x=>x.KartTuru==_kartTuru&&x.DefinationId==definationId).toBindingList<FeatureL>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;

            if (((FeaturesEditForm)OwnerForm).txtDefination.EditValue == null)
            {
                Messages.BilgiMesaji("Lütfen Bir Tanım Seçiniz");
                ((FeaturesEditForm)OwnerForm).txtDefination.Focus();
                return;
            }

            var row = new FeatureL
            {
                DefinationId= (int)((FeaturesEditForm)OwnerForm).txtDefination.EditValue,
                KartTuru = _kartTuru,
                Insert = true
            };

            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colCode;

            ButtonEnabledDurum(true);
        }

        protected internal override bool HatalıGiriş()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<FeatureL>(i);

                if (string.IsNullOrEmpty(entitiy.Code))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colCode;
                    tablo.SetColumnError(colCode, "Kod Alanına Geçerli Bir Değer Giriniz .");
                }
                if (string.IsNullOrEmpty(entitiy.Description))
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colDescription;
                    tablo.SetColumnError(colDescription, "Açıklama Alanına Geçerli Bir Değer Giriniz .");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }

    }
}

using System.Data;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.DefinationsForms
{
    public partial class DefinationsTable : BaseTablo
    {
        private KartTuru _kartTuru;

        public DefinationsTable()
        {
            InitializeComponent();
            Bll = new DefinationsBll();
            Tablo = tablo;
            EventsLoad();
        }

        protected internal override void Listele()
        {
            _kartTuru = ((DefinationsEditForm)OwnerForm)._kartTuru;

            Tablo.GridControl.DataSource = ((DefinationsBll)Bll).List(x=>x.KartTuru==_kartTuru).toBindingList<DefinationItems>();
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;

            if (source.Cast<DefinationItems>().Where(x=>!x.Delete).ToList().Count > 20)
            {
                Messages.HataMesaji("20 dan Fazla Tanım Giremezsiniz!");
                return;
            }

            var row = new DefinationItems
            {
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
                var entitiy = tablo.GetRow<DefinationItems>(i);

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

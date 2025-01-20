using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.FaturaForms
{
    public partial class FaturaPlaniListForm : BaseListForm
    {
        public FaturaPlaniListForm()
        {
            InitializeComponent();

            Bll = new TahakkukBll();
            HideItems = new BarItem[] { btnYeni, barYeni, barYeniAciklama, barDelete, barDeleteAciklama, btnAktifPasifKartlar };
            ShowItems = new BarItem[] { btnTahakkukYap };
            btnSil.Caption = "Fatura Planı Iptal Et";
            btnTahakkukYap.Caption = "Toplu Fatura Planı";
            btnYazdir.CreatDropDownMenu(new BarItem[] { btnTabloYazdir });
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Fatura;
            Navigator = longNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((TahakkukBll)Bll).FaturaTahakkukList(x => x.SubeId == AnaForm.SubeId && x.DonemId == AnaForm.DonemId);
        }
        protected override void ShowEditForm(long id)
        {
            var entity = tablo.GetRow<FaturaL>();
            if (entity == null) return;
            if (entity.HizmetNetTutar == 0)
            {
                Messages.HataMesaji("Öğrencinin Net Ücreti Sıfır Olduğu İçin Fatura Planı Oluşturulamaz .");
                return;                
            }

            var result = ShowEditForms<FaturaPlaniEditForm>.ShowDialogForm(KartTuru.Fatura, id, null);
            ShowEditFormDefault(result);
        }

        protected override void TahakkukYap()
        {
            var source = new List<FaturaL>();
            for (int i = 0; i < tablo.DataRowCount; i++)
                source.Add(tablo.GetRow<FaturaL>(i));
            if (source.Count == 0) return;

            if (ShowEditForms<TopluFaturaPlaniEditForm>.ShowDialogForm(KartTuru.Fatura, source))
                Listele();

        }
        protected override void EntityDelete()
        {
            if (Messages.HayirSeciliEvetHayir("Seçilen Öğrencilere Ait Hareket Görmeyen Tüm Fatura Planları İptal Edilecektir. Onaylıyor Musunuz?", "Iptal Onay") != DialogResult.Yes) return;

            var source = new List<FaturaL>();
            for (int i = 0; i < tablo.DataRowCount; i++)
                source.Add(tablo.GetRow<FaturaL>(i));
            if (source.Count == 0) return;

            using (var bll=new FaturaBll())
            {                
                var position = 0.0;
                progressBarControl.Visible = true;
                progressBarControl.Left = (ClientSize.Width - progressBarControl.Width) / 2;
                progressBarControl.Top= (ClientSize.Height - progressBarControl.Height) / 2;

                source.ForEach(x =>
                {                    
                    var yuzde = 100.0 / source.Count;
                    position += yuzde;

                    var planSource = bll.List(y => y.TahakkukId == x.Id).Where(y => ((FaturaPlaniL)y).TahakkukTarih == null).ToList();
                    bll.Delete(planSource);

                    progressBarControl.Position =(int) position;
                    progressBarControl.Update();
                });
            }
            progressBarControl.Visible = false;
            Messages.BilgiMesaji("Seçilen Öğrenciler Ait Fatura Planları Başarılı Bir Şekilde İptal Edilmiştir.");
            Listele();
        }
    }
}
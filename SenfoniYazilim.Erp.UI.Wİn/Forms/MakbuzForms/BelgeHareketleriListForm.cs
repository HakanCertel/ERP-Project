using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using DevExpress.XtraBars;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.MakbuzForms
{
    public partial class BelgeHareketleriListForm : BaseListForm
    {
        private readonly int _odemeBilgileriId;

        public BelgeHareketleriListForm(params object[] prm)
        {
            InitializeComponent();

            HideItems = new BarItem[] { btnYeni, btnSil, btnSec,barYeni,barYeniAciklama,barDelete,barDeleteAciklama,barEnter,barEnterAciklama };

            _odemeBilgileriId = (int)prm[0]; 
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator.Navigator;
            BaseKartTuru = KartTuru.BelgeHareketleri;
            Navigator.TextStringFormat = "Belge Hareketleri ( {0} / {1} )";
        }

        protected override void Listele()
        {
            using (var bll=new BelgeHareketleriBll())
            {
                var list = bll.List(x => x.OdemeBilgileriId == _odemeBilgileriId).Cast<BelgeHareketleriL>().ToList();
                if (!list.Any())
                {
                    Messages.UyariMesaji("Seçmiş Olduğunuz Ödeme Belgesine Ait Hareket Bulunmamaktadır.");
                    Close();
                    return;
                }

                var entity = list[0];
                txtNo.Text = entity.OgrenciNo;
                txtAdi.Text = entity.Adi;
                txtSoyadi.Text = entity.Soyadi;
                txtSinifAdi.Text = entity.SinifAdi;
                txtSubeAdi.Text = entity.OgrenciSubeAdi;
                txtPortfoyNo.EditValue = entity.OdemeBilgileriId;
                txtOdemeTuru.Text = entity.OdemeTutariAdi;
                txtGirisTarihi.DateTime = entity.GirisTarihi;
                txtVade.DateTime = entity.Vade;
                txtHesabaGecisTarihi.DateTime = entity.HesabaGecisTarihi;
                txtTutar.Value = entity.Tutar;
                txtBankaAdi.Text = entity.BankaAdi;
                txtBankaSubeAdi.Text = entity.BankaSubeAdi;
                txtAsilBorclu.Text = entity.AsilBorclu;
                txtCiranta.Text = entity.Ciranta;
                txtHesapNo.Text = entity.HesapNo;
                txtBelgeNo.Text = entity.BelgeNo;

                grid.DataSource = list;
                //tablo.GridControl.DataSource = list;
            }
        }

        protected override void ShowEditForm(long id)
        {
            var entity = tablo.GetRow<BelgeHareketleriL>();
            if (entity == null) return;

            if (entity.SubeId != AnaForm.SubeId)
                ShowEditForms<MakbuzEditForm>.ShowDialogForm(KartTuru.Makbuz,id,entity.MakbuzTuru,entity.HesapTuru,true);
            else
            {
                var result = ShowEditForms<MakbuzEditForm>.ShowDialogForm(KartTuru.Makbuz, id, entity.MakbuzTuru, entity.HesapTuru);
                ShowEditFormDefault(result);
            }

        }
    }
}
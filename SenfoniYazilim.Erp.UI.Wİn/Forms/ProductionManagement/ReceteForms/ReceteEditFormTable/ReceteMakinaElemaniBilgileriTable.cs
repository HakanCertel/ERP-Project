using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.DataProcessing;
using System.Linq;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.ReceteEditFormTable
{
    public partial class ReceteMakinaElemaniBilgileriTable : BaseTablo
    {
        public ReceteMakinaElemaniBilgileriTable()
        {
            InitializeComponent();

            Bll = new ReceteMakinaElemaniBilgileriBll();
            Tablo = tablo;
            EventsLoad();
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((ReceteMakinaElemaniBilgileriBll)Bll).List(x => x.ReceteId == OwnerForm.Id).toBindingList<ReceteMakinaElemaniBilgileriL>();
        }

        protected override void HareketEkle()
        {
            //var makinalar = ((ReceteEditForm)OwnerForm).receteOperasyonMakinaBilgileriTable.Tablo.DataController.ListSource.Cast<ReceteOperasyonMakinaBilgileriL>().Where(x=>!x.Delete).Select(x => x.MakinaId).ToList();
            var source = Tablo.DataController.ListSource;

            //ListeDisiTutulacakKayitlar = source.Cast<ReceteMakinaElemaniBilgileriL>().Where(x => !x.Delete).Select(x => x.StokId).ToList();
            //makinalar.ForEach(x =>
            //{
            //    ListeDisiTutulacakKayitlar.Add(x);
            //});

            var entitiesMakinaElemanlari = ShowListForms<MakinaElemanlariListForm>.ShowDialogListForm(KartTuru.Makina,null /*makinalar*/, true).EntityListConvert<ReceteIstasyonMakinaElemanlariL>();

            if (entitiesMakinaElemanlari == null) return;

            foreach (var entity in entitiesMakinaElemanlari)
            {
                var row = new ReceteMakinaElemaniBilgileriL
                {
                    ReceteId = OwnerForm.Id,
                    MakinaId = entity.MakinaId,
                    MakinaKodu = entity.MakinaKodu,
                    MakinaAdi = entity.MakinaAdi,
                    StokId = entity.StokId,
                    StokKodu = entity.StokKodu,
                    StokAdi = entity.StokAdi,
                    Insert = true
                };

                source.Add(row);
            }
        }
        protected override void HareketSil()
        {
            base.HareketSil();
        }
        protected internal override bool TopluHareketSil()
        {
            var source = tablo.DataController.ListSource.Cast<ReceteMakinaElemaniBilgileriL>();

            if (source == null) return true;

            source.ForEach(x =>
            {
                if (!x.Insert)
                    x.Delete = true;
                if (x.Insert) x.Insert = false;
            });

            return Kaydet();
        }
    }
}

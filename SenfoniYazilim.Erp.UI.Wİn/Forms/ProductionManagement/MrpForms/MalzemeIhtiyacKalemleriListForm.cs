using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using SenfoniYazilim.Erp.Common.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.MrpForms
{
    public partial class MalzemeIhtiyacKalemleriListForm : BaseListForm
    {
        #region Parameters
        private readonly List<MalzemeIhtiyacBilgileriL> _mibList;//= new List<MalzemeIhtiyacBilgileriL>();
        private readonly bool _anaFonksiyon=false;

        private decimal _rezerveMiktari;
        private Expression<Func<MalzemeIhtiyacBilgileriL, bool>> _filtre= x => !x.Planlandi;
        private static GridView _tablo;
        private static IList _source;
        #endregion

        public MalzemeIhtiyacKalemleriListForm()
        {
            InitializeComponent();

            Bll = new MalzemeIhtiyacBilgileriBll();

            //ShowItems = new BarItem[] { };
            HideItems = new BarItem[] { btnDuzelt ,btnSil,btnSec};

        }

        public MalzemeIhtiyacKalemleriListForm(params object[] prm):this()
        {
            _anaFonksiyon = (bool)prm[0];

            HideItems = new BarItem[] { btnDuzelt, btnSil, btnSec };
            ShowItems = new BarItem[] { btnKaydet };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Mrp;
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            if (!TabloLoaded)
                Tablo.GridControl.DataSource = ((MalzemeIhtiyacBilgileriBll)Bll).List(null).toBindingList<MalzemeIhtiyacBilgileriL>();

            else
                Tablo.FiltreTemizleDataSource<MalzemeIhtiyacBilgileriL>();

            btnAktifPasifKartlar.Caption = "Malzeme Planla";
            HideOrShow(btnAktifPasifKartlar.Caption);
        }

        //protected override void ShowEditForm(long id)
        //{
        //    var entity = Tablo.GetRow<MalzemeIhtiyacBilgileriL>();
        //    var source = Tablo.DataController.ListSource;
        //    if (!entity.Uretim || entity == null) return;
        //    var receteId = entity.StokId.StokIdIleReceteAnaRow().ReceteId;
        //    entity.Filter = true;
        //    var receteBilesenler = entity.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(true, Tablo, x => x.BagliOlduguUstReceteStokKodu == entity.StokKodu && x.MrpBilgileriId == entity.MrpBilgileriId);
        //    //var yeniMibList = ShowEditForms<MrpReceteEditForm>.ShowDialogEditForm<MalzemeIhtiyacBilgileriL>(KartTuru.Mrp, receteBilesenler,source,Tablo); 
        //    var yeniMibList = ShowEditForms<ReceteEditForm>.ShowDialogForm(KartTuru.Recete, receteId, true, receteBilesenler, source, tablo);
        //    entity.Filter = false;
        //}

        //protected override bool UretimSonuKaydi()
        //{
        //    _tablo = Tablo;
        //    _source = Tablo.DataController.ListSource;
        //    ListeDisiTutulacakKayitlar = ((MalzemeIhtiyacBilgileriBll)Bll).BirlestirList(x => x.Planlandi && !x.Kapandi).Cast<MrpMalzemeIhtiyacBilgileriBirlestirL>().Select(x => x.StokId).ToList();

        //    return ShowListForms<UretimSonuKayitIslemleriListForm>.ShowDialogListForm(true, ListeDisiTutulacakKayitlar, true, Tablo);
        //}

        //protected override void TahakkukYap()//CRM Aç
        //{
        //    ShowEditForms<MalzemeIhtiyacPlanlamaEditForm>.ShowDialogForm(KartTuru.Mrp);
        //}

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            if (e.Column == colRezerveMiktar)
            {
                var mib = Tablo.GetRow<MalzemeIhtiyacBilgileriL>();
                var source = Tablo.DataController.ListSource;

                mib.Update = true;

                if (mib.Uretim)
                {
                    var mibList=mib.MrpCalistir(Tablo, source,false);
                    if (mibList == null) return;
                }
                //else
                //{
                //    mib.NetIhtiyac = mib.BrutIhtiyac - mib.PlanlananMiktar;
                //}
            }
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colRezerveMiktar)
            {
                var mib = Tablo.GetRow<MalzemeIhtiyacBilgileriL>();

                if (mib == null) return;

                _rezerveMiktari = mib.RezerveMiktar;
            }
        }

        protected override void Tablo_DoubleClick(object sender, EventArgs e)
        {
            var mib = Tablo.GetRow<MalzemeIhtiyacBilgileriL>();
            if (mib == null || !mib.Uretim) return;
            _filtre = x => x.BagliOlduguUstReceteStokKodu == mib.StokKodu && x.MrpBilgileriId == mib.MrpBilgileriId;
             mib.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(true,Tablo, _filtre);
            _filtre = null;
        }

        protected override void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            MalzemeIhtiyacBilgileriL mib=new MalzemeIhtiyacBilgileriL();

            if (e.KeyCode != Keys.Escape)
            { 
                mib = Tablo.GetRow<MalzemeIhtiyacBilgileriL>();
                if (mib == null) return;
            }

            switch (e.KeyCode)
            {
                case Keys.Escape:
                     Close();
                    break;
                case Keys.A when e.Modifiers == Keys.Shift:
                    _filtre = x => x.AnaReceteKodu == mib.AnaReceteKodu && x.MrpBilgileriId == mib.MrpBilgileriId;
                    mib.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(true, Tablo, _filtre);
                    _filtre = null;
                    break;
                case Keys.B when e.Modifiers == Keys.Shift:
                    if (mib.Uretim)
                        Tablo.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(mib.FilterDataSourceCompositeBased(Tablo));
                    _filtre = null;
                    break;
                case Keys.C when e.Modifiers == Keys.Shift:
                     _filtre = x => (x.BagliOlduguUstReceteStokKodu == mib.BagliOlduguUstReceteStokKodu && x.MrpBilgileriId == mib.MrpBilgileriId) || mib.BagliOlduguUstReceteStokKodu == x.StokKodu&& x.MrpBilgileriId == mib.MrpBilgileriId;
                     mib.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(true, Tablo, _filtre);
                    _filtre = null;
                    break;
                case Keys.A when e.Control:
                    Tablo.FiltreTemizleDataSource<MalzemeIhtiyacBilgileriL>();
                    btnAktifPasifKartlar.Caption = "Malzeme Planla";
                    break;
                case Keys.Delete when e.Modifiers == Keys.Shift:
                    HareketSil();
                    break;
            }
        }

        protected override void FormCaptionAyarla(bool _switch)
        {
            Tablo.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(x => x.Uretim==AktifKartlariGoster);
            btnAktifPasifKartlar.Caption = btnAktifPasifKartlar.Caption = AktifKartlariGoster ? "Üretim Planla" : "Hammadde Planla";
            HideOrShow(btnAktifPasifKartlar.Caption);
        }

        private void HareketSil()
        {
            if (Tablo.DataRowCount == 0) return;
            var entity = Tablo.GetRow<MalzemeIhtiyacBilgileriL>();
            if (entity.Uretim)
            {
                var result=Messages.SilMesajIptal("İşlem Satırı Kenddisine Bağlı Bileşenleri Olan Bir Recete Kaydıdır. Bağlı Tüm Kayıtlar");

                switch (result)
                {
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.Yes:
                        entity.FilterDataSourceCompositeBased(Tablo)?.ForEach(x =>
                        {
                            var mib = Tablo.DataController.ListSource.Cast<MalzemeIhtiyacBilgileriL>().Where(y => y == x).FirstOrDefault(); ;
                            mib.Delete = true;
                        });
                        Tablo.RefreshDataSource();
                        return;
                    case DialogResult.No:
                        entity.Delete = true;
                        Tablo.RefreshDataSource();
                        return;
                }
                
            }

            if (Messages.SilMesaj("İşlem Satırı") != DialogResult.Yes) return;
            
            entity.Delete = true;
            Tablo.RefreshDataSource();
        }

        private void HideOrShow(string requirementStatus)
        {
            var status = requirementStatus.GetEnum<RequirementStatus>();

            colBirimIhtiyac.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colToplamIhtiyac.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colBrutIhtiyac.Visible=status== RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colToplamIhtiyac.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colToplamRezerveMiktar.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colAcikMiktar.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colRezerveMiktar.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colOperasyonSuresi.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colToplamUretimSuresi.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colReceteSeviyesi.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colOperasyonSeviyesi.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colIstasyonKodu.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colIstasyonAdi.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colOperasyonKodu.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colOperasyonAdi.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colMakinaKodu.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            colMakinaAdi.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
        }

        private void FilterBasedOnRequirementStatus(string requirementStatus, MalzemeIhtiyacBilgileriL mib)
        {
            _filtre = x => x.AnaReceteKodu == mib.AnaReceteKodu && x.MrpBilgileriId == mib.MrpBilgileriId;
            mib.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(true, Tablo, _filtre);
            _filtre = null;
        }
    }
}
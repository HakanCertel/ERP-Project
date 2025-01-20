using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.MrpForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Forms.PurchaseForms.PurchaseDemandForms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms
{
    public partial class MalzemeIhtiyaclarıListForm : BaseListForm
    {
        #region Parameters
        private readonly List<MalzemeIhtiyacBilgileriL> _mibList;//= new List<MalzemeIhtiyacBilgileriL>();
        private readonly bool _anaFonksiyon=false;

        private decimal _rezerveMiktari;
        private Expression<Func<MalzemeIhtiyacBilgileriL, bool>> _filtre= x => !x.Planlandi;
        private static GridView _tablo;
        private static IList _source;
        #endregion

        public MalzemeIhtiyaclarıListForm()
        {
            InitializeComponent();

            Bll = new MalzemeIhtiyacBilgileriBll();

            insUpNavigator.Navigator.ButtonClick += Navigator_ButtonClick;

            ShowItems = new BarItem[] { btnKaydet,btnCreateCrp,btnActive,btnCreatePurchaseDemand};
            HideItems = new BarItem[] { btnYeni, btnDuzelt ,btnSil,btnSec, btnCancel,btnCloseItem};

            btnTahakkukYap.Caption = "CRP";

        }

        public MalzemeIhtiyaclarıListForm(params object[] prm):this()
        {
            _anaFonksiyon = (bool)prm[0];

            HideItems = new BarItem[] { btnYeni, btnDuzelt, btnSil, btnSec,btnCloseItem };
            ShowItems = new BarItem[] { btnKaydet,btnCreateCrp,btnActive };
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.MaterialRequirmentPlaning;
            Navigator = insUpNavigator.Navigator;
        }

        protected override void Listele()
        {
            if (!TabloLoaded)
                Tablo.GridControl.DataSource = !_anaFonksiyon
                    ? ((MalzemeIhtiyacBilgileriBll)Bll).List(x => x.IsActive).toBindingList<MalzemeIhtiyacBilgileriL>()
                    : _mibList.toBindingList<MalzemeIhtiyacBilgileriL>();
            else
                Tablo.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(x => x.IsActive);
            btnCreateCrp.Enabled = false;
            btnCreatePurchaseDemand.Enabled = false;
            btnAktifPasifKartlar.Caption = "Malzeme Planla";
            HideOrShow(btnAktifPasifKartlar.Caption);
        }

        protected override void SendToCrp()
        {
            var selectedEntites = HareketRowsSelected.GetSelectedRows().Cast<MalzemeIhtiyacBilgileriL>().ToList();
            if (selectedEntites.Count == 0) return;
            var list = new List<MalzemeIhtiyacBilgileriL>();
            selectedEntites.ForEach(x =>
            {
                if (x.Uretim)
                {
                    x.FilterDataSourceCompositeBased(Tablo)?.ForEach(y =>
                    {
                        var mib = Tablo.DataController.ListSource.Cast<MalzemeIhtiyacBilgileriL>().Where(z => z == y&&!z.Planlandi).FirstOrDefault();
                        if (mib != null)
                        {
                            mib.Planlandi = true;
                            mib.Update = true;
                            list.Add(y);
                        }
                    });
                }
                else
                    x.Planlandi = true;
            });
           
            ((MalzemeIhtiyacBilgileriBll)Bll).Update(list.Cast<BaseHareketEntity>().ToList());

            Tablo.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(x => x.IsActive&&x.Uretim&&!x.Planlandi);
            
            UretKapasiteIhtiyacBilgi(list);

            HareketRowsSelected.ClearSelection();
        }

        protected override void FormCaptionAyarla(bool _switch)
        {

            btnAktifPasifKartlar.Caption = btnAktifPasifKartlar.Caption = AktifKartlariGoster ? "Üretim Planla" : "Hammadde Planla";
            if(btnAktifPasifKartlar.Caption== "Üretim Planla")
                Tablo.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(x => x.IsActive && x.Uretim && !x.Planlandi);
            else
                Tablo.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(x => x.Uretim == AktifKartlariGoster && x.IsActive);

            btnCreateCrp.Enabled = btnAktifPasifKartlar.Caption == "Üretim Planla";
            btnCreatePurchaseDemand.Enabled = btnAktifPasifKartlar.Caption == "Hammadde Planla";
            HideOrShow(btnAktifPasifKartlar.Caption);
        }

        protected override void ChangeStatus(ItemStatus status)
        {
            if (ItemStatus.Active == status)
            {
                var entites = HareketRowsSelected.GetSelectedRows().Cast<MalzemeIhtiyacBilgileriL>().ToList();
                if(entites.Any(x=>x.Uretim))
                foreach (var entity in entites)
                {
                    if (entity.Planlandi)
                    {
                        Messages.BilgiMesaji("Seçili Kayıt Kapasite Planına Alınmıştır. Pasif Duruma Alınamaz.");
                        return;
                    }
                    if (entites.Any(x => x.Uretim))
                    {
                        var result = Messages.KapatMesajIptal("Seçili Kayıtlar Arasında Bağlı Bileşenleri Olan Recete Kayıtları Mevcut. Bağlı Tüm Kayıtlar");

                        switch (result)
                        {
                            case DialogResult.Cancel:
                                return;
                            case DialogResult.Yes:
                                entity.FilterDataSourceCompositeBased(Tablo)?.ForEach(x =>
                                {
                                    var mib = Tablo.DataController.ListSource.Cast<MalzemeIhtiyacBilgileriL>().Where(y => y == x).FirstOrDefault(); ;
                                    mib.IsActive = false;
                                    mib.Update = true;
                                });
                                //Tablo.RefreshDataSource();
                                return;
                            case DialogResult.No:
                                entity.IsActive = false;
                                    entity.Update = true;
                                //Tablo.RefreshDataSource();
                                return;
                        }

                    }
                }
                HareketRowsSelected.ClearSelection();

                Tablo.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(x => x.IsActive);

            }
        }

        protected override bool Kaydet()
        {
            var source = Tablo.DataController.ListSource;

            var insert = source.Cast<IBaseHareketEntity>().Where(x => x.Insert && !x.Delete).Cast<BaseHareketEntity>().ToList();
            var update = source.Cast<BaseHareketEntity>().Where(x => ((IBaseHareketEntity)x).Update && !((IBaseHareketEntity)x).Delete).ToList();
            var delete = source.Cast<IBaseHareketEntity>().Where(x => x.Delete && !x.Insert).Cast<BaseHareketEntity>().ToList();

            if (insert.Any())
                if (!((IBaseHareketGenelBll)Bll).Insert(insert))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Eklenemedi");
                    return false;
                }

            if (update.Any())
                if (!((IBaseHareketGenelBll)Bll).Update(update))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Güncellenemedi");
                    return false;
                }
            if (delete.Any())
                if (!((IBaseHareketGenelBll)Bll).Delete(delete))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} Tablosundaki Hareketler Silinemedi");
                    return false;
                }

            GeneralFunctions.RezervasyonBilgisiOlustur();

            TabloLoaded = false;
            if (!_anaFonksiyon)
                Listele();
            else
                Close();
            TabloLoaded = true;
            return true;
        }

        private void HareketSil()
        {
            if (Tablo.DataRowCount == 0) return;
            var entity = Tablo.GetRow<MalzemeIhtiyacBilgileriL>();
            if (entity.Uretim)
            {
                var result=Messages.SilMesajIptal("İşlem Satırı Kendisine Bağlı Bileşenleri Olan Bir Recete Kaydıdır. Bağlı Tüm Kayıtlar");

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

        private void UretKapasiteIhtiyacBilgi(List<MalzemeIhtiyacBilgileriL> mibL)
        {
            var kibL = new List<BaseHareketEntity>();

            foreach (var mib in mibL)
            {
                var recete = Erp.Bll.Functions.GetAnySingleOrListBll
                    .GetRecete(x => x.StokId == mib.StokId && x.Varsayılan);

                var operasyonMakine = recete?.ReceteOperasyonMakinaBilgileri?.Where(x => x.VarsayilanMakina)?.ToList();


                var operasyonBilgileri = recete?.ReceteOperasyonBilgileri?.ToList();

                var operasyonSayisi = recete?.ReceteOperasyonBilgileri?.Count;

                for (int i = 0; i < operasyonSayisi; i++)
                {
                    var kibEntity = new KapasiteIhtiyacBilgileri
                    {
                        ReceteId = mib.ReceteId,
                        MalzemeIhtiyacBilgiId=mib.Id,
                        MrpBilgileriId = mib.MrpBilgileriId,
                        StokId = mib.StokId,
                        DepoId = mib.DepoId,
                        BagliOlduguUstReceteId = mib.BagliOlduguUstReceteId,
                        BagliOlduguAnaReceteId = mib.BagliOlduguAnaReceteId,
                        OperasyonId = operasyonBilgileri[i].OperasyonId,
                        BirimId = mib.BirimId,
                        BirimIhtiyac = mib.BirimIhtiyac,
                        NetIhtiyac = mib.NetIhtiyac,
                        //ReceteSeviyesi = mib.ReceteSeviyesi,
                        TavsiyeEdilenUretimBaslamaTarihi = mib.TavsiyeEdilenBaslamaTarihi,
                        IhtiyacTarihi = mib.TalepTarihi,
                        TahminiTeslimTarihi=mib.TalepTarihi,
                        PlanlandigiTarih=mib.TavsiyeEdilenBaslamaTarihi,
                    };
                    var opMak = operasyonMakine?.Where(x => x.OperasyonId == kibEntity.OperasyonId && x.VarsayilanMakina).FirstOrDefault();

                    var calisanSayisi = Erp.Bll.Functions.GetAnySingleOrListBll.ListIstasyonMakinePersonel(y => y.MakinaId == opMak.MakinaId).Count();

                    kibEntity.OperasyonSeviyesi = i;
                    kibEntity.IstasyonId = opMak?.IstasyonId;
                    kibEntity.MakinaId = opMak?.MakinaId;
                    kibEntity.OperasyonSuresi =Convert.ToDecimal( opMak?.OperasyonSuresi);
                    kibEntity.HazirlikSuresi =Convert.ToDecimal( opMak?.MakinaHazirlikSuresi);
                    //kibEntity.MakinaElemaniId = receteAnaKod.ReceteMakinaElemaniBilgileri.Where(x => x.MakinaId == mibEntity.MakinaId && x.VarsayilanEleman).FirstOrDefault()?.StokId;
                    //kibEntity.DegisimSuresi = receteAnaKod.ReceteMakinaElemaniBilgileri.Where(x => x.MakinaId == mibEntity.MakinaElemaniId).FirstOrDefault()?.DegisimSuresi;
                    kibEntity.KapasiteIhtiyaci = Convert.ToDecimal(kibEntity.OperasyonSuresi) * kibEntity.NetIhtiyac / recete.Miktar + Convert.ToDecimal(kibEntity.HazirlikSuresi);
                    kibEntity.KapasiteIhtiyaci = calisanSayisi != 0 ? kibEntity.KapasiteIhtiyaci / calisanSayisi : kibEntity.KapasiteIhtiyaci;
                    kibEntity.TavsiyeEdilenUretimBaslamaTarihi = Convert.ToDateTime(kibEntity.KapasiteIhtiyaci.BaslamaTarihiHesapla(kibEntity.IhtiyacTarihi));

                    kibL.Add(kibEntity);
                }
            }

            MrpCalistirFunctions.CrpKaydet(kibL);
        }

        protected override void CreatePurchaseDemand()
        {
            var entities = HareketRowsSelected.GetSelectedRows().Cast<MalzemeIhtiyacBilgileriL>()
                .Where(x => x.IsActive).ToList();

            if (entities.Count == 0)
            {
                Messages.KartSecmemeUyariMesaji();
                HareketRowsSelected.ClearSelection();
                return;
            }

            ShowEditForms<PurchaseDemanEditForm>.ShowDialogForm(IslemTuru.EntityInsert, BaseKartTuru, entities.Cast<BaseHareketEntity>().ToList(), null);

            HareketRowsSelected.ClearSelection();
        }
        private void Navigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            var entity = Tablo.GetRow<MalzemeIhtiyacBilgileriL>(false);

            if (e.Button == insUpNavigator.Navigator.Buttons.Append) { }
                //HareketEkle();
            else if (e.Button == insUpNavigator.Navigator.Buttons.Remove)
            {
                if (entity.Planlandi)
                {
                    Messages.BilgiMesaji("Seçili Kayıt Kapasite Planına Alınmıştır. Pasif Duruma Alınamaz.");
                    return;
                }
                ChangeStatus(ItemStatus.Active);
            }

            if (e.Button == insUpNavigator.Navigator.Buttons.Append || e.Button == insUpNavigator.Navigator.Buttons.Remove)
                e.Handled = true;
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            if (e.Column == colRezerveMiktar)
            {
                var mib = Tablo.GetRow<MalzemeIhtiyacBilgileriL>();

                var source = Tablo.DataController.ListSource;

                var rezervToplami =source.Cast<MalzemeIhtiyacBilgileriL>().ToList().Where(x => x.StokId == mib.StokId&&x.DepoId==mib.DepoId).Select(x => x.RezerveMiktar).Sum();

                //if (mib.NetIhtiyac < mib.RezerveMiktar||mib.AcikMiktar<mib.RezerveMiktar/*mib.ToplamStokMiktari<rezervToplami*/)
                //{
                //    Messages.BilgiMesaji("İlgili Stok' a Ait Kullanılabilri Açık Miktar Yetersiz yada İhtiyaçtan Fazla Rezerve İşlemi Yapılmaya Çalışılmaktadır .");
                //    mib.RezerveMiktar = _rezerveMiktari;
                //    return;
                //}
                //else if(mib.DepoId == null)
                //{
                //    Messages.BilgiMesaji("İlgili Stok' a Ait Kullanılabilri Açık Miktar Yetersiz yada İhtiyaçtan Fazla Rezerve İşlemi Yapılmaya Çalışılmaktadır .");
                //    mib.RezerveMiktar = _rezerveMiktari;
                //    return;
                //}

                mib.RezervasyonBilgisiAl();

                source.Cast<MalzemeIhtiyacBilgileriL>().ToList().Where(x => x.StokKodu == mib.StokKodu&&x.DepoId==mib.DepoId).ToList().ForEach(x =>
                {
                    x.AcikMiktar =Convert.ToDecimal( x.ToplamStokMiktari)  - rezervToplami;
                    x.ToplamRezerveMiktar = rezervToplami;
                });

                mib.Update = true;

                if (mib.Uretim)
                {
                    var mibList=mib.MrpCalistir(Tablo, source,false);
                    if (mibList == null) return;
                }
                else
                {
                    mib.NetIhtiyac = mib.BrutIhtiyac - mib.RezerveMiktar;
                    mib.KapasiteIhtiyaci = mib.NetIhtiyac * mib.OperasyonSuresi;
                }
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

        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            base.Tablo_MouseUp(sender, e);
            if (!TabloLoaded) return;
            //birden fazla Kaydın aynı anda silinememsi için aşağıdaki kod yazılmıştır
            //bu event in kullanılmasının nedeni even çağrı hiyerarşisinde uygun bir ana denk gelmesidir.
            insUpNavigator.Navigator.Buttons.Remove.Enabled = HareketRowsSelected.GetSelectedRows().Count <= 1;
        }

        private void FilterBasedOnRequirementStatus(string requirementStatus, MalzemeIhtiyacBilgileriL mib)
        {
            _filtre = x => x.AnaReceteKodu == mib.AnaReceteKodu && x.MrpBilgileriId == mib.MrpBilgileriId;
            mib.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(true, Tablo, _filtre);
            _filtre = null;
        }


        protected override void ShowEditForm(long id)
        {
            //var entity = Tablo.GetRow<MalzemeIhtiyacBilgileriL>();
            //var source = Tablo.DataController.ListSource;
            //if (!entity.Uretim || entity == null) return;
            //var receteId = entity.StokId.StokIdIleReceteAnaRow().ReceteId;
            //entity.Filter = true;
            //var receteBilesenler = entity.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(true, Tablo, x => x.BagliOlduguUstReceteStokKodu == entity.StokKodu && x.MrpBilgileriId == entity.MrpBilgileriId);
            ////var yeniMibList = ShowEditForms<MrpReceteEditForm>.ShowDialogEditForm<MalzemeIhtiyacBilgileriL>(KartTuru.Mrp, receteBilesenler,source,Tablo); 
            //var yeniMibList = ShowEditForms<ReceteEditForm>.ShowDialogForm(KartTuru.Recete, receteId, true, receteBilesenler, source, tablo);
            //entity.Filter = false;
        }

        private void HideOrShow(string requirementStatus)
        {
            //btnCreateCrp.Enabled = btnAktifPasifKartlar.Caption == "Üretim Planla";

            //var status = requirementStatus.GetEnum<RequirementStatus>();

            //colBirimIhtiyac.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colToplamIhtiyac.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colBrutIhtiyac.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colToplamIhtiyac.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colToplamRezerveMiktar.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colAcikMiktar.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colRezerveMiktar.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colOperasyonSuresi.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colToplamUretimSuresi.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colReceteSeviyesi.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colOperasyonSeviyesi.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colIstasyonKodu.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colIstasyonAdi.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colOperasyonKodu.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colOperasyonAdi.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colMakinaKodu.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
            //colMakinaAdi.Visible = status == RequirementStatus.MainProductPrograming || status == RequirementStatus.ProductionPrograming;
        }
    }
}
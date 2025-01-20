using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General.CRP;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using System.Linq.Expressions;
using System;
using SenfoniYazilim.Erp.Model.Entities;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.Common.Message;
using System.Windows.Forms;
using System.Linq;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.CRP;
using SenfoniYazilim.Erp.Model.Dto.CRPDto;
using System.Collections.Generic;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Model.Entities.SalesEntities;
using SenfoniYazilim.Erp.Bll.General.SalesBll;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ProductionManagement.CRPForms
{
    public partial class KapasiteIhtiyacListForm : BaseListForm
    {
        private  Expression<Func<KapasiteIhtiyacBilgileri, bool>> _filter;

        private readonly long _makineId;

        public KapasiteIhtiyacListForm()
        {
            InitializeComponent();

            Bll = new KapasiteIhtiyacBilgileriBll();

            insUpNavigator.Navigator.ButtonClick += Navigator_ButtonClick;

            HideItems = new BarItem[] { btnDuzelt,btnYeni,btnCancel};
            ShowItems = new BarItem[] { btnProductionDeman };
            btnProductionDeman.Caption = "Üretim Planına Al";
            _filter = x=>x.IsActive&&!x.IsClosed;
        }
        public KapasiteIhtiyacListForm(params object[] prm):this()
        {
            _makineId = (long)prm[0];
            var filteredId = ListelenecekKayitlar();

            if (filteredId != null)
                _filter = x => x.IsActive && !x.IsClosed && filteredId.Contains(x.StokId);
            else
                _filter = x => x.IsActive && !x.IsClosed;
            ShowItems = new BarItem[] { btnSec };
            HideItems = new BarItem[] { btnProductionDeman };
        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Crp;
            Navigator = insUpNavigator.Navigator;
        }
        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KapasiteIhtiyacBilgileriBll)Bll).List(_filter).toBindingList<KapasiteIhtiyacBilgileriL>();
        }
        protected override void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            base.Tablo_MouseUp(sender, e);
            if (!TabloLoaded) return;
            //birden fazla Kaydın aynı anda silinememsi için aşağıdaki kod yazılmıştır
            //bu event in kullanılmasının nedeni even çağrı hiyerarşisinde uygun bir ana denk gelmesidir.
            insUpNavigator.Navigator.Buttons.Remove.Enabled = HareketRowsSelected.GetSelectedRows().Count <= 1;
        }

        protected override void FormCaptionAyarla(bool _switch = false)
        {
            if (AktifKartlariGoster)
            {
                btnAktifPasifKartlar.Caption = "Pasif Kartlar";
                btnChangeBaseStatus.Caption = "Pasif";
                Tablo.ViewCaption = Text;
                _filter = x => x.IsActive&&!x.IsClosed;
                Listele();
            }
            else
            {
                btnAktifPasifKartlar.Caption = "Aktif Kartlar";
                btnChangeBaseStatus.Caption = "Aktif";
                Tablo.ViewCaption = Text + "- Pasif Kartlar";
                _filter = x => !x.IsActive||x.IsClosed;
                Listele();
            }

            btnProductionDeman.Enabled = AktifKartlariGoster;
        }

        protected override void ProductionDemand()
        {
            var planlanmisMalzemeKalemleri = new List<PlanlanmisMalzemeKalemleri>();

            var mibL = new List<BaseHareketEntity>();

            var entities = HareketRowsSelected.GetSelectedRows().Cast<KapasiteIhtiyacBilgileriL>().OrderBy(x=>x.MakinaId).ToList();

            if (entities.Count == 0)
            {
                Messages.KartSecmemeUyariMesaji();
                return;
            }
            
            entities.ForEach(x =>
            {
                var pmk = CreatePMK(x);

                var list = GetAnySingleOrListBll.ListPlanlanmisMalzemeKalemleri(y => y.MakinaId == pmk.MakinaId);

                pmk.Sira = list.Count() == 0 ? 1 : list.Max(y => y.Sira) + 1;
                pmk.PlanTarihi =list.Count()==0?DateTime.Now: list.Max(y => y.TamamlanmaTarihi);
                pmk.TamamlanmaTarihi = TarihHesapla(x, pmk.PlanTarihi);

                planlanmisMalzemeKalemleri.Add(pmk);

                InstanceBaseHareketEntityBll<PlanlanmisMalzemeKalemleri, PlanlanmisMalzemeKalemleriBll>
                    .InsertEntities(planlanmisMalzemeKalemleri.Cast<BaseHareketEntity>().ToList());

                planlanmisMalzemeKalemleri.Clear();

                x.PlanlananMiktar =x.PlanlananMiktar+ x.Kalan;
                x.Kalan = x.NetIhtiyac - x.PlanlananMiktar > 0 ? x.NetIhtiyac - x.PlanlananMiktar : 0;
                x.IsActive = x.Kalan > 0;
                x.Planlandi = true;


                var mib = GetAnySingleOrListBll.GetSaleItemL(y => y.Id == x.DemandItemId);

                if (mib != null)
                {
                    mib.FirstPlanedDate =list.Count()!=0? list.Min(y=>y.PlanTarihi):pmk.PlanTarihi;
                    mib.FirstComletedDate = list.Count() != 0 ? list.Min(y => y.TamamlanmaTarihi) : pmk.TamamlanmaTarihi;
                    mibL.Add(mib);
                }

                InstanceBaseHareketEntityBll<SalesItems, SalesItemsBll>.UpdateEntities(mibL);

                mibL.Clear();

            });

            Messages.BilgiMesaji("Seçili Kalemler başarılı Bir Şekilde Üretim Planına Eklenmiştir.");

            ((KapasiteIhtiyacBilgileriBll)Bll).Update(entities.Cast<BaseHareketEntity>().ToList());

            HareketRowsSelected.ClearSelection();
            Listele();
            mibL.Clear();
                #region MalzemeIhtiyacBilgileri
                entities.ForEach(x =>
                {
                    var mib = GetAnySingleOrListBll.GetMalzemeIhtiyacBilgileri(y => y.Id == x.MalzemeIhtiyacBilgiId);
                    mib.PlanlananMiktar = x.PlanlananMiktar;
                    mibL.Add(mib);
                    InstanceBaseHareketEntityBll<MalzemeIhtiyacBilgileri, MalzemeIhtiyacBilgileriBll>
                        .UpdateEntities(mibL);
                    mibL.Clear();
                });

                #endregion

                
        }

        private PlanlanmisMalzemeKalemleriL CreatePMK(KapasiteIhtiyacBilgileriL entity)
        {
            var item = new PlanlanmisMalzemeKalemleriL
            {
                KapasiteIhtiyacKalemId=entity.Id,
                MrpBilgileriId = entity.MrpBilgileriId,
                MalzemeIhtiyacBilgiId = entity.MalzemeIhtiyacBilgiId,
                ReceteId = entity.ReceteId,
                BagliOlduguAnaReceteId = entity.BagliOlduguAnaReceteId,
                BagliOlduguUstReceteId = entity.BagliOlduguUstReceteId,
                StokId = entity.StokId,
                BirimId = entity.BirimId,
                IhtiyacTarihi = entity.IhtiyacTarihi,
                DepoId = entity.DepoId,
                IstasyonId=entity.IstasyonId,
                OperasyonId = entity.OperasyonId,
                MakinaId = entity.MakinaId,
                PlanlananMiktar = entity.Kalan,
                ReceteSeviyesi = entity.ReceteSeviyesi,
                OperasyonSeviyesi = entity.OperasyonSeviyesi,
                OperasyonSuresi = entity.OperasyonSuresi,
                DemandId=entity.DemandId,
                DemandCode=entity.DemandCode,
                CurrentId = entity.CurrentId,
                CurrentName = entity.CurrentName,
                UserId = entity.UserId,
                PersonelId = entity.PersonelId,
                PlanTarihi = Convert.ToDateTime(entity.TavsiyeEdilenUretimBaslamaTarihi),
                TamamlanmaTarihi = entity.IhtiyacTarihi,
                //PlanTarihi=DateTime.Now,
            };
            //var saat = DateTime.Now.Hour;
            //item.PlanlandigiTarih = item.IhtiyacTarihi.AddHours((double)-(saat+item.PlanlananMiktar*Convert.ToDecimal( item?.OperasyonSuresi)));
            return item;
        }

        private void Navigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            var entity = Tablo.GetRow<KapasiteIhtiyacBilgileriL>(false);

            if (e.Button == insUpNavigator.Navigator.Buttons.Append) { }
            //HareketEkle();
            else if (e.Button == insUpNavigator.Navigator.Buttons.Remove)
            {
                if (entity.Planlandi)
                {
                    Messages.BilgiMesaji("Seçili Kayıt Kapasite Planına Alınmıştır. Silinemez.");
                    return;
                }
                HareketSil();
            }

            if (e.Button == insUpNavigator.Navigator.Buttons.Append || e.Button == insUpNavigator.Navigator.Buttons.Remove)
                e.Handled = true;
        }

        private void HareketSil()
        {
            var entities = HareketRowsSelected.GetSelectedRows().Cast<KapasiteIhtiyacBilgileriL>().ToList();
            //var entity = Tablo.GetRow<KapasiteIhtiyacBilgileriL>(false);
            if (entities.Where(x=>!x.Planlandi).Count() == 0) return;

            if (entities.Any(x => x.Planlandi))
                Messages.UyariMesaji("Seçili Kayıtlar arasında Üretim Planına Alınmış Satırlar Var. Plana Alınmış Satırlar Silinmeyecektir !");

            var result=((KapasiteIhtiyacBilgileriBll)Bll).Delete(entities.Where(x=>!x.Planlandi).Cast<BaseHareketEntity>().ToList());

            if (result)
            {
                var mibL = new List<BaseHareketEntity>();
                entities.ForEach(x =>
                {
                    var mib = GetAnySingleOrListBll.GetMalzemeIhtiyacBilgileri(y => y.Id == x.MalzemeIhtiyacBilgiId);
                    mib.PlanlananMiktar = 0;
                    mib.Planlandi = false;
                    mibL.Add(mib);
                    x.Delete = true;
                });
                InstanceBaseHareketEntityBll<MalzemeIhtiyacBilgileri, MalzemeIhtiyacBilgileriBll>
                .UpdateEntities(mibL);

                Messages.BilgiMesaji("Seçili Kayıtlar Silindi.");

                HareketRowsSelected.ClearSelection();
            }
            else
                Messages.UyariMesaji("Seçili Kayıt Silinemedi!");

            Tablo.RefreshDataSource();
        }

        private List<long> ListelenecekKayitlar()
        {
            var listedisiTutulacakKayitlar = new List<long>();
            var entities=((KapasiteIhtiyacBilgileriBll)Bll).List(_filter).toBindingList<KapasiteIhtiyacBilgileriL>();

            if (entities == null) return null;

            foreach (var item in entities)
            {
                var receteMakineBilgileri = GetAnySingleOrListBll.GetRecete(x => x.StokId == item.StokId && x.Varsayılan)
                    ?.ReceteOperasyonMakinaBilgileri;

                if (receteMakineBilgileri == null) continue;

                if (receteMakineBilgileri.Any(x => x.MakinaId == _makineId))
                    listedisiTutulacakKayitlar.Add(item.StokId);
            }
            return listedisiTutulacakKayitlar;
        }

        protected override void ShowEditForm(long id){}

        protected override void EntityDelete()
        {
            //base.EntityDelete();
            HareketSil();
        }

        private DateTime TarihHesapla(KapasiteIhtiyacBilgileriL entity, DateTime baslamaTarihi)
        {
            entity.PlanlandigiTarih = baslamaTarihi;
            entity.TahminiTeslimTarihi = baslamaTarihi;
            DaysOfWeek enumGun = entity.PlanlandigiTarih.DayOfWeek.GetEnumOfDayOfWeek();
            entity.KapasiteIhtiyaci = entity.OperasyonSuresi * entity.Kalan;

            var vardiyaId = GetAnySingleOrListBll.SingleIstasyon(x=>x.Id==entity.IstasyonId)?.VardiyaId;

            if (vardiyaId <1)
            {
                Messages.UyariMesaji($"{entity.IstasyonKodu} Kodlu İstasyonu, Bir Vardiya Sistemine Bağlanmadığı İçin, {entity.StokAdi} Malzemesi Plan Tarihi Hesaplanamaz!");
                return DateTime.Now;
            }

            IEnumerable<VardiyaBilgileriLastVersion> vardiya = GetAnySingleOrListBll
                    .SingleVardiya(x=>x.Id==vardiyaId).VardiyaBilgileriLastVersion.ToList().Where(x => x.Gun == enumGun);

            while (vardiya.Count() == 0)
            {
                entity.PlanlandigiTarih= entity.PlanlandigiTarih.AddDays(1);
                enumGun = entity.PlanlandigiTarih.DayOfWeek.GetEnumOfDayOfWeek();
                vardiya = GetAnySingleOrListBll
                    .SingleVardiya(x=>x.Id==vardiyaId).VardiyaBilgileriLastVersion.ToList().Where(x => x.Gun == enumGun);
            }

            TimeSpan birinciVardiyaBaslangicSaati = vardiya.Where(x => x.KacinciVardiya == 1).FirstOrDefault().MesaiBaslamaSaati;
            int vardiyaSayisi = vardiya.Max(x => x.KacinciVardiya);
            TimeSpan vardiyaBitisSaati = vardiya.Where(x => x.KacinciVardiya == vardiyaSayisi).FirstOrDefault().MesaiBitisSaati;
            var timeSpan = new TimeSpan(baslamaTarihi.Hour, baslamaTarihi.Minute, 0);

            if (timeSpan < birinciVardiyaBaslangicSaati || timeSpan > vardiyaBitisSaati)
            {
                entity.PlanlandigiTarih = entity.PlanlandigiTarih.ChangeTime(birinciVardiyaBaslangicSaati.Hours, birinciVardiyaBaslangicSaati.Minutes, 0, 0);
                //Tablo.FocusedColumn = colPlanlandigiTarih;
                //tablo.SetColumnError(colPlanlandigiTarih, "Lütfen vardiya Saatleri Arasında Bir Değer Giriniz.");
                //return;
            }
            int vardiyaKapasitesiFarki;
            var fark = entity.PlanlandigiTarih.TimeOfDay.Subtract(birinciVardiyaBaslangicSaati).TotalMinutes;
            int vardiyaKapasitesi = Convert.ToInt32(vardiya.Sum(x => x.Kapasite) - (int)fark);

            vardiyaKapasitesiFarki = (int)entity.KapasiteIhtiyaci - vardiyaKapasitesi;

            if (entity.KapasiteIhtiyaci <= vardiyaKapasitesi)
            {
                entity.TahminiTeslimTarihi = baslamaTarihi.AddMinutes((double)entity.KapasiteIhtiyaci);
            }
            else
            {
                while (vardiyaKapasitesiFarki > 0)
                {
                    entity.TahminiTeslimTarihi = entity.TahminiTeslimTarihi.AddDays(1);
                    enumGun = entity.TahminiTeslimTarihi.DayOfWeek.GetEnumOfDayOfWeek();
                   vardiya= GetAnySingleOrListBll.SingleVardiya(x=>x.Id==vardiyaId)?
                        .VardiyaBilgileriLastVersion.ToList().Where(x => x.Gun == enumGun);

                    vardiyaKapasitesiFarki = vardiyaKapasitesiFarki - (int)vardiya.Sum(x => x.Kapasite);
                }

                vardiyaKapasitesiFarki = (int)vardiya.Sum(x => x.Kapasite) + vardiyaKapasitesiFarki;
                birinciVardiyaBaslangicSaati = vardiya.Where(x => x.Gun == enumGun && x.KacinciVardiya == 1).FirstOrDefault().MesaiBaslamaSaati;
                TimeSpan span = TimeSpan.FromMinutes(vardiyaKapasitesiFarki);
                var time = birinciVardiyaBaslangicSaati.Add(span);
                entity.TahminiTeslimTarihi = entity.TahminiTeslimTarihi.ChangeTime(time.Hours, time.Minutes, 0, 0);
            }

            entity.Update = entity.Insert ? false : true;
            tablo.RefreshDataSource();
            return entity.TahminiTeslimTarihi;
        }

    }
}
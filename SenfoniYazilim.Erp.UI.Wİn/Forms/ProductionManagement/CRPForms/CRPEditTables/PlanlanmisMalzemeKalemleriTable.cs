using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.General.CRP;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Dto.CRPDto;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.UI.Wİn.Forms.MrpForms;
using System.Linq;
using System.Collections.Generic;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Common.Enums;
using System;
using SenfoniYazilim.Erp.Model.Entities.CRP;
using System.Linq.Expressions;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Common.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Bll.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ProductionManagement.CRPForms.CRPEditTables
{
    public partial class PlanlanmisMalzemeKalemleriTable : BaseTablo
    {
        private Expression<Func<PlanlanmisMalzemeKalemleriL, bool>> _filtre ;
        private List<MalzemeIhtiyacBilgileriL> _mib;

        public PlanlanmisMalzemeKalemleriTable()
        {
            InitializeComponent();

            Bll = new PlanlanmisMalzemeKalemleriBll();
            Tablo = tablo;

            EventsLoad();
            panelButtons.Visible = true;
            HareketRowsSelected = new SelectRowFunctionsBaseHareketEntity(Tablo);
        }

        protected internal override void Listele()
        {
            if (OwnerForm.Id < 0)
            {
                Tablo.GridControl.DataSource = ((PlanlanmisMalzemeKalemleriBll)Bll).List(null).toBindingList<PlanlanmisMalzemeKalemleriL>();
            }
            else if (!TableValueChanged)
            {
                //Tablo.GridControl.DataSource = ((PlanlanmisMalzemeKalemleriBll)Bll).List(x=>x.MakinaId==OwnerForm.Id).toBindingList<PlanlanmisMalzemeKalemleriL>();
                _filtre = x => x.MakinaId == OwnerForm.Id;
                Tablo.RefreshDataSource<PlanlanmisMalzemeKalemleriL>(_filtre);
            }
            else
            {
                var pmkL = Tablo.GetRow<PlanlanmisMalzemeKalemleriL>(false);
                _filtre = x => x.MakinaId == OwnerForm.Id;
                var source=Tablo.RefreshDataSource<PlanlanmisMalzemeKalemleriL>( _filtre);
            }
        }

        protected override void HareketEkle()
        {
            var source = tablo.DataController.ListSource;
            var makine = ((MalzemeIhtiyacPlanlamaEditForm)OwnerForm).mrpMakinaBilgileriTable
                .Tablo.GetRow<MrpMakinaBilgileriL>(false);//.DataController.ListSource.Cast<MrpMakinaBilgileriL>();
            var entities = ShowListForms<KapasiteIhtiyacListForm>.ShowDialogHareketListForm(null, true, true, makine.MakinaId).EntityListConvert<KapasiteIhtiyacBilgileriL>();

            if (entities == null) return;
            foreach (var entity in entities)
            {
                var row = new PlanlanmisMalzemeKalemleriL
                {
                    MakinaId = OwnerForm.Id,
                    MrpBilgileriId = entity.MrpBilgileriId,
                    MalzemeIhtiyacBilgiId = entity.MalzemeIhtiyacBilgiId,
                    ReceteId = entity.ReceteId,
                    BagliOlduguAnaReceteId = entity.BagliOlduguAnaReceteId,
                    BagliOlduguUstReceteId = entity.BagliOlduguUstReceteId,
                    StokId = entity.StokId,
                    StokKodu = entity.StokKodu,
                    StokAdi = entity.StokAdi,
                    BirimId = entity.BirimId,
                    BirimAdi = entity.BirimAdi,
                    IhtiyacTarihi = entity.IhtiyacTarihi,
                    DepoId = entity.DepoId,
                    DepoKodu = entity.DepoKodu,
                    DepoAdi = entity.DepoAdi,
                    OperasyonId = makine.OperasyonId,
                    OperasyonAdi = makine.OperasyonAdi,
                    IstasyonId = makine.IstasyonId,
                    IstasyonKodu = makine.IstasyonKodu,
                    IstasyonAdi = makine.IstasyonAdi,
                    MakinaKodu = makine.MakinaKodu,
                    MakinaAdi = makine.MakinaAdi,
                    PlanlananMiktar = entity.Kalan,
                    ReceteSeviyesi = entity.ReceteSeviyesi,
                    OperasyonSeviyesi = entity.OperasyonSeviyesi,
                    OperasyonSuresi = entity.OperasyonSuresi,
                    CurrentId = entity.CurrentId,
                    CurrentName = entity.CurrentName,
                    UserId = entity.UserId,
                    PersonelId = entity.PersonelId,
                    DemandId = OwnerForm.Id,
                    DemandCode = entity.DemandCode,
                    Insert = true
                };
                row.KapasiteIhtiyaci = row.OperasyonSuresi * row.PlanlananMiktar;
                row.TamamlanmaTarihi = row.IhtiyacTarihi.AddMinutes((double)-row.KapasiteIhtiyaci);
                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colStokKodu;

            ButtonEnabledDurum(true);
        }

        protected override void HareketSil()
        {
            //base.HareketSil();
            var deletedEntities = new List<BaseHareketEntity>();
            var updatedCapacityRequestItems = new List<BaseHareketEntity>();

            var entity = HareketRowsSelected.GetSelectedRows().Cast<PlanlanmisMalzemeKalemleriL>().Where(x=>!x.PlanKesinlesti).ToList();
            if (entity.Count() == 0) return;
            entity.ForEach(x =>
            {
                x.Delete = true;
                if (!x.Insert)
                    deletedEntities.Add(x);
            });
            if (((PlanlanmisMalzemeKalemleriBll)Bll).Delete(deletedEntities))
                deletedEntities.Cast<PlanlanmisMalzemeKalemleri>().ToList().ForEach(x =>
                {
                    var item = GetAnySingleOrListBll.GetKapasiteIhtiyacBilgileri(y => y.Id == x.KapasiteIhtiyacKalemId);
                    item.PlanlananMiktar = item.PlanlananMiktar - x.PlanlananMiktar;
                    item.Planlandi = item.PlanlananMiktar > 0;
                    item.IsActive = item.IsActive == false ? true : true;
                    updatedCapacityRequestItems.Add(item);
                });
            InstanceBaseHareketEntityBll<KapasiteIhtiyacBilgileri, KapasiteIhtiyacBilgileriBll>
                .UpdateEntities(updatedCapacityRequestItems);
            HareketRowsSelected.ClearSelection();
            Sirala();
        }

        private void Sirala()
        {
            var updatedEntities = new List<BaseHareketEntity>();
            var insertEntities = new List<BaseHareketEntity>();

            var source = Tablo.DataController.ListSource.Cast<PlanlanmisMalzemeKalemleriL>().Where(x=>!x.Delete).OrderBy(x => x.Sira).ToList();
            int sira = 1;
            source.ForEach(x =>
            {
                x.Sira = sira;
                sira++;
                x.Update = x.Insert ? false : true;
                if (x.Update)
                    updatedEntities.Add(x);
                else if (x.Insert)
                    insertEntities.Add(x);

            });
            ((PlanlanmisMalzemeKalemleriBll)Bll).Update(updatedEntities);
            ((PlanlanmisMalzemeKalemleriBll)Bll).Insert(insertEntities);
            TableValueChanged = false;
            Listele();
        }

        protected internal bool PlanKesinlestir()
        {
            var isEmriList = new List<BaseHareketEntity>();
            var entities = HareketRowsSelected.GetSelectedRows().Cast<PlanlanmisMalzemeKalemleriL>().
                Where(x => !x.PlanKesinlesti).ToList();

            if (entities.Count == 0) return false;

            using (var bll = new WorkOrdersBll())
            {
                //var currentEntity = new BaseEntity();
                //var id = bll.List(null).Max(x => x.Id);
                entities.ForEach(x =>
                {
                    var isEmri = CreateIE(x);
                    isEmri.Kod = bll.BaseYeniKodVer("IEM",y=>y.Kod);
                    //isEmri.Id = id + 1;
                    //x.IsEmriId = isEmri.Id;
                    x.IsEmriKodu = isEmri.Kod;
                    x.PlanKesinlesti = true;
                    x.IsEmriDurumu = IsEmriDurumu.IsEmriOlusturuldu;
                    bll.InsertSingle(isEmri);
                    var workOrder = GetAnySingleOrListBll.GetWorkOrder(y => y.Kod == isEmri.Kod);
                    _mib = GetAnySingleOrListBll.ListMalzemeIhtiyacBilgileri(y => y.MrpBilgileriId == x.MrpBilgileriId && y.BagliOlduguUstReceteId == x.ReceteId && y.StokId != x.StokId).ToList();
                    CreateWOMI(_mib, workOrder);
                    isEmriList.Add(isEmri);
                });


               // var result =bll.Insert(isEmriList);
                ((PlanlanmisMalzemeKalemleriBll)Bll).Update(entities.Cast<BaseHareketEntity>().ToList());
            }
            HareketRowsSelected.ClearSelection();
            return true;
        }
        
        protected internal void Analiz()
        {
            var source = Tablo.RefreshDataSource<PlanlanmisMalzemeKalemleriL>(x => x.MakinaId == OwnerForm.Id);

            if (source.Count == 0) return;
            PlanlanmisMalzemeKalemleriL previousItem=new PlanlanmisMalzemeKalemleriL();
            foreach (var item in source)
            {
                if (item.Sira == 1)
                    TarihHesapla(item, item.PlanTarihi);
                else
                    TarihHesapla(item,previousItem.TamamlanmaTarihi);

                previousItem = item;
            }
            //for (int i = 0; i < source.Count; i++)
            //{
            //    //source = Tablo.DataController.ListSource.Cast<PlanlanmisMalzemeKalemleriL>().Where(x => x.MakinaId == OwnerForm.Id).ToList();
            //    if (i == 0)
            //        TarihHesapla(source[i], source[i].PlanTarihi);
            //    else
            //        TarihHesapla(source[i], source[i - 1].TamamlanmaTarihi);

            //    //Tablo.RefreshData();
            //    //Tablo.RefreshDataSource<PlanlanmisMalzemeKalemleriL>(_filtre);
            //}
            ButtonEnabledDurum(true);
        }

        protected override void AsagiTasi()
        {
            //base.AsagiTasi();
           // var source = Tablo.DataController.ListSource.Cast<PlanlanmisMalzemeKalemleriL>().ToList();
            var entity = Tablo.GetRow<PlanlanmisMalzemeKalemleriL>();
            var rowHandle = Tablo.FocusedRowHandle;
            var nextEntity = (PlanlanmisMalzemeKalemleriL)Tablo.GetRow(rowHandle + 1);
            if (entity == null || entity.Sira == 0 || nextEntity == null || nextEntity.Sira == 0) return;
            entity.Sira = nextEntity.Sira;
            entity.Update = entity.Insert ? false : true;
            nextEntity.Sira = nextEntity.Sira - 1;
            nextEntity.Update = nextEntity.Insert ? false : true;
            Tablo.RefreshDataSource(_filtre);
            Tablo.SortInfo.ClearAndAddRange(new[] { new GridColumnSortInfo(colSira, DevExpress.Data.ColumnSortOrder.Ascending) });

            ButtonEnabledDurum(true);
        }

        protected override void YukariTasi()
        {
            //base.YukariTasi();
            //var source = Tablo.DataController.ListSource.Cast<PlanlanmisMalzemeKalemleriL>().ToList();
            var entity = Tablo.GetRow<PlanlanmisMalzemeKalemleriL>();
            var rowHandle = Tablo.FocusedRowHandle;
            var previousEntity = (PlanlanmisMalzemeKalemleriL)Tablo.GetRow(rowHandle -1);
            if (entity == null || entity.Sira == 0 || previousEntity == null || previousEntity.Sira == 0) return;
            entity.Sira = previousEntity.Sira;
            entity.Update = entity.Insert ? false : true;
            previousEntity.Sira = previousEntity.Sira + 1;
            previousEntity.Update = previousEntity.Insert ? false : true;
            Tablo.RefreshDataSource<PlanlanmisMalzemeKalemleriL>(_filtre);
            Tablo.SortInfo.ClearAndAddRange(new[] { new GridColumnSortInfo(colSira, DevExpress.Data.ColumnSortOrder.Ascending) });
            ButtonEnabledDurum(true);
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!_isLoaded) return;
            var entity = Tablo.GetRow<PlanlanmisMalzemeKalemleriL>(false);
            if (entity == null) return;

            if (e.Column == colPlanlandigiTarih)
            {
                TarihHesapla(entity, entity.PlanTarihi);
                
            }
            base.Tablo_CellValueChanged(sender, e);
            //Tablo.RefreshData();
        }
        
        private void TarihHesapla(PlanlanmisMalzemeKalemleriL entity,DateTime baslamaTarihi)
        {
            entity.PlanTarihi = baslamaTarihi;
            entity.TamamlanmaTarihi = baslamaTarihi;
            DaysOfWeek enumGun = baslamaTarihi.DayOfWeek.GetEnumOfDayOfWeek();
            entity.KapasiteIhtiyaci = entity.OperasyonSuresi * entity.Kalan;

            if (((MalzemeIhtiyacPlanlamaEditForm)OwnerForm).VardiyaBilgileri == null)
            {
                Messages.UyariMesaji($"{entity.IstasyonKodu} Kodlu İstasyonu, Bir Vardiya Sistemine Bağlanmadığı İçin, {entity.StokAdi} Malzemesi Plan Tarihi Hesaplanamaz!");
            }
            IEnumerable<VardiyaBilgileriLastVersion> vardiya = ((MalzemeIhtiyacPlanlamaEditForm)OwnerForm).VardiyaBilgileri.Where(x => x.Gun == enumGun);

            if (vardiya.Count() == 0)
            {
                Messages.HataMesaji("Girmiş olduğunuz Tatil Günüdür. Lütfen Uygun Bir Tarih Giriniz");
                Tablo.FocusedColumn = colPlanlandigiTarih;
                return;
            }

            TimeSpan birinciVardiyaBaslangicSaati = vardiya.Where(x => x.KacinciVardiya == 1).FirstOrDefault().MesaiBaslamaSaati;
            int vardiyaSayisi = vardiya.Max(x => x.KacinciVardiya);
            TimeSpan vardiyaBitisSaati = vardiya.Where(x => x.KacinciVardiya == vardiyaSayisi).FirstOrDefault().MesaiBitisSaati;
            var timeSpan = new TimeSpan(baslamaTarihi.Hour, baslamaTarihi.Minute, 0);

            if (timeSpan < birinciVardiyaBaslangicSaati || timeSpan > vardiyaBitisSaati)
            {
                entity.PlanTarihi = entity.PlanTarihi.ChangeTime(birinciVardiyaBaslangicSaati.Hours, birinciVardiyaBaslangicSaati.Minutes, 0, 0);
                //Tablo.FocusedColumn = colPlanlandigiTarih;
                //tablo.SetColumnError(colPlanlandigiTarih, "Lütfen vardiya Saatleri Arasında Bir Değer Giriniz.");
                //return;
            }
            int vardiyaKapasitesiFarki;
            var fark = entity.PlanTarihi.TimeOfDay.Subtract(birinciVardiyaBaslangicSaati).TotalMinutes;
            int vardiyaKapasitesi = Convert.ToInt32(vardiya.Sum(x => x.Kapasite) - (int)fark);

            vardiyaKapasitesiFarki = (int)entity.KapasiteIhtiyaci - vardiyaKapasitesi;

            if (entity.KapasiteIhtiyaci <= vardiyaKapasitesi)
            {
                entity.TamamlanmaTarihi = baslamaTarihi.AddMinutes((double)entity.KapasiteIhtiyaci);
            }
            else
            {
                while (vardiyaKapasitesiFarki > 0)
                {
                    entity.TamamlanmaTarihi = entity.TamamlanmaTarihi.AddDays(1);
                    enumGun = entity.TamamlanmaTarihi.DayOfWeek.GetEnumOfDayOfWeek();
                    vardiya = ((MalzemeIhtiyacPlanlamaEditForm)OwnerForm).VardiyaBilgileri.Where(x => x.Gun == enumGun);
                    vardiyaKapasitesiFarki = vardiyaKapasitesiFarki - (int)vardiya.Sum(x => x.Kapasite);
                }

                vardiyaKapasitesiFarki = (int)vardiya.Sum(x => x.Kapasite) + vardiyaKapasitesiFarki;
                birinciVardiyaBaslangicSaati = vardiya.Where(x => x.Gun == enumGun && x.KacinciVardiya == 1).FirstOrDefault().MesaiBaslamaSaati;
                TimeSpan span = TimeSpan.FromMinutes(vardiyaKapasitesiFarki);
                var time = birinciVardiyaBaslangicSaati.Add(span);
                entity.TamamlanmaTarihi = entity.TamamlanmaTarihi.ChangeTime(time.Hours, time.Minutes, 0, 0);
            }

           entity.Update = entity.Insert ? false : true;
           tablo.RefreshDataSource(_filtre);
        }

        private WorkOrders CreateIE(PlanlanmisMalzemeKalemleriL entity)
        {
            var currentEntity = new WorkOrders
            {
                MalzemeIhtiyacBilgiId = entity.MalzemeIhtiyacBilgiId,
                ReceteId = entity.ReceteId,
                BagliOlduguAnaReceteId = entity.BagliOlduguAnaReceteId,
                BagliOlduguUstReceteId = entity.BagliOlduguUstReceteId,
                StokId = entity.StokId,
                BirimId = entity.BirimId,
                IhtiyacTarihi = entity.IhtiyacTarihi,
                PlanlandigiTarih = entity.PlanTarihi,
                DepoId = entity.DepoId,
                IstasyonId = entity.IstasyonId,
                OperasyonId = entity.OperasyonId,
                MakinaId = entity.MakinaId,
                IsEmriMiktari = entity.PlanlananMiktar,
                UserId = entity.UserId,
                IslemTarihi=DateTime.Now,
                KayitTarihi=DateTime.Now
            };

            return currentEntity;
        }

        private void CreateWOMI(List<MalzemeIhtiyacBilgileriL> list,WorkOrdersL workOrder)
        {
            var womi = new List<BaseHareketEntity>();
            list.ForEach(x =>
            {
                var row = new WorkOrderMaterialItems
                {
                    OwnerFormId = workOrder.Id,
                    MalzemeIhtiyacBilgileriId = x.Id,
                    MrpBilgileriId = x.MrpBilgileriId,
                    BagliOlduguReceteId=x.BagliOlduguUstReceteId,
                    MaterialId = x.StokId,
                    UnitId = x.BirimId,
                    WarehouseId =(long) x.DepoId,
                    UnitQty=x.BirimIhtiyac,
                    WastageQty=x.FireMiktarı
                };
                womi.Add(row);
            });
            var result=InstanceBaseHareketEntityBll<WorkOrderMaterialItems, WorkOrderMaterialItemsBll>.InsertEntities(womi);
        }
    }
}

using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Forms.ReceteForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Show;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Linq;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using SenfoniYazilim.Erp.Common.Functions;
using System.Collections;
using System.Collections.Generic;
using SenfoniYazilim.Erp.UI.Wİn.Forms.SaleWayBillForms;
using SenfoniYazilim.Erp.Model.Dto.SalesDto;
using DevExpress.XtraBars;
using SenfoniYazilim.Erp.Model.ProductionMangmentDto.MrpDto;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.MrpEditFormTable
{
    public partial class MrpBilgileriTable : BaseTablo
    {
        private bool _runRowStyleEvent=true;
        private MrpCreatingMethod _mrpMethod;

        public MrpBilgileriTable()
        {
            InitializeComponent();

            Bll = new MrpBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            ShowItems = new BarItem[] { btnKartDuzenle };
        }

        protected internal override void Listele()
        {
            tablo.GridControl.DataSource = ((MrpBilgileriBll)Bll).List(x => x.MrpId == OwnerForm.Id).toBindingList<MrpBilgileriL>();
        }

        protected override void HareketEkle()
        {
            _mrpMethod = ((MrpEditForm)OwnerForm).txtMrpCreatingMethod.Text.GetEnum<MrpCreatingMethod>();

            var source = Tablo.DataController.ListSource;

            var entities = _mrpMethod == MrpCreatingMethod.ChooseMaterial ? GetMaterial(source)
                        : _mrpMethod == MrpCreatingMethod.ChooseOrderItem ? GetOrderItems(source) : null;
                        //: _mrpMethod == MrpCreatingMethod.ChooseSaleGuess ? GetSalesGuessItems(source) 
                        //: _mrpMethod == MrpCreatingMethod.ChooseMinStockQty ? GetMinStockItems(source):  null;

            if (entities == null) return;

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            tablo.FocusedColumn = colMiktar;

            ButtonEnabledDurum(true);

        }

        protected override void OpenEntity()
        {
            var entity = Tablo.GetRow<MrpBilgileriL>(false);
            if (entity == null) return;
            var result=ShowEditForms<ReceteEditForm>.ShowDialogForm(entity.ReceteId,true);
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            if (e.FocusedColumn == colStokKodu)
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemStokKodu, colReceteId,colStokAdi);
            
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            var entity = tablo.GetRow<MrpBilgileriL>();

            if (e.Column == colBaslangicTarihi)
            {
                entity.BitisTarihi = entity.BaslangicTarihi.AddDays(10);
                insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
                tablo.FocusedColumn = colBitisTarihi;
            }               
            base.Tablo_CellValueChanged(sender, e);
        }

        protected internal override void SutunGizleGoster()
        {
            colMrpCreatingMethod.Visible = ((MrpEditForm)OwnerForm).tglDurum.IsOn;
        }

        protected override void Tablo_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;

            if (e.RowHandle >= 0)
            {
                var entity = View.GetRow<MrpBilgileriL>(e.RowHandle);
                if (!entity.IsTakenToProcess) return;
                //string priority = View.GetRowCellDisplayText(e.RowHandle, View.Columns["IsTakenToProcess"]);
                e.Appearance.BackColor = Color.FromArgb(150, Color.LightCoral);
                e.Appearance.BackColor2 = Color.White;
            }
        }

        private DateTime BitisTarihi(DateTime baslamaTarihi,int eklenecekGunSayisi)
        {
            var _bitisTarihi=new DateTime();
            int toplamTatilSayisi=0;

            for (int i = 1; i <= eklenecekGunSayisi; i++)
            {
                if(baslamaTarihi.AddDays(i).DayOfWeek==DayOfWeek.Sunday)
                {
                    toplamTatilSayisi++;
                }
            }
            _bitisTarihi = baslamaTarihi.AddDays(toplamTatilSayisi + eklenecekGunSayisi);
            return _bitisTarihi;
        }

        private List<MrpBilgileriL> GetMaterial(IList source)
        {
            if (source == null) return null;

            ListeDisiTutulacakKayitlar?.Clear();

            ListeDisiTutulacakKayitlar = source.Cast<MrpBilgileriL>().Where(x => !x.Delete).Select(x =>(long) x.ReceteId).ToList();

            var entities = ShowListForms<ReceteListForm>.ShowDialogListForm(KartTuru.Recete, true)?.EntityListConvert<ReceteL>().ToList();

            if (entities == null) return null;

            foreach (var entity in entities)
            {
                var storageStockQty = Convert.ToDecimal(Erp.Bll.Functions.GetAnySingleOrListBll.SingleWarehouseStock(entity.Id, entity.MalzemeDepoId)?.Quantity);

                var row = new MrpBilgileriL
                {
                    MrpId = OwnerForm.Id,
                    ReceteId=entity.Id,
                    UserId = AnaForm.KullaniciId,
                    //CurrentId = entityStk.CurrentId,
                    //PersonelId = entityStk.PlasiyerId,
                    DemandStatu = DemandStatus.General,//entityStk.DemandStatus,
                    //DemandId = entityStk.DemandId,
                    DemandCode = ((MrpBilgileriBll)Bll).BaseYeniKodVer("MLT",x=>x.DemandCode,x=>x.DemandCode.Contains("MLT")),
                    //DemandInformationId = entityStk.Id,
                    StokId = entity.StokId,
                    StokKodu = entity.StokKodu,
                    StokAdi = entity.StokAdi,
                    Miktar = 1,
                    BaslangicTarihi = DateTime.Now,
                    BitisTarihi =DateTime.Now.AddDays(10) ,
                    MrpCreatingMethod = ((MrpEditForm)OwnerForm).txtMrpCreatingMethod.Text.GetEnum<MrpCreatingMethod>(),
                    Insert = true
                };
                source.Add(row);
            }
            return source.Cast<MrpBilgileriL>().ToList();
        }

        private List<MrpBilgileriL> GetOrderItems(IList source)
        {
            if (source == null) return null;

            ListeDisiTutulacakKayitlar?.Clear();

            ListeDisiTutulacakKayitlar = source.Cast<MrpBilgileriL>().Where(x => !x.Delete).Select(x => x.DemandInformationId).ToList();

            var entities = ShowListForms<SalesItemsListForm>.ShowDialogHareketListForm(ListeDisiTutulacakKayitlar, true,true,MrpCreatingMethod.ChooseOrderItem)?.EntityListConvert<SalesItemsL>().ToList();

            if (entities == null) return null;

            foreach (var entity in entities)
            {
                var storageStockQty = Convert.ToDecimal(Erp.Bll.Functions.GetAnySingleOrListBll.SingleWarehouseStock(entity.MaterialId, entity.DepoId)?.Quantity);

                var row = new MrpBilgileriL
                {
                    MrpId = OwnerForm.Id,
                    UserId = AnaForm.KullaniciId,
                    CurrentId = entity.CompanySalesId,
                    //PersonelId = entity.D,
                    DemandStatu = DemandStatus.OrderDeman,//entityStk.DemandStatus,
                    DemandId = entity.SalesId,
                    DemanItemId=entity.Id,
                    DemandCode = entity.SaleCode,
                    DemandInformationId =Convert.ToInt64( entity.Id),
                    StokId = entity.MaterialId,
                    StokKodu = entity.MaterialCode,
                    StokAdi = entity.MaterialName,
                    Miktar = entity.SalesQty,
                    BaslangicTarihi =entity.DemandedDate!=null?Convert.ToDateTime(entity.DemandedDate):DateTime.Now,
                    BitisTarihi =entity.DeliveryDate!=null?Convert.ToDateTime( entity.DeliveryDate):DateTime.Now.AddDays(10),
                    MrpCreatingMethod = ((MrpEditForm)OwnerForm).txtMrpCreatingMethod.Text.GetEnum<MrpCreatingMethod>(),
                    Insert = true
                };
                var recete = Erp.Bll.Functions.GetAnySingleOrListBll.ListRecete(x => x.StokId == row.StokId);
                if (recete.Count() == 0)
                {
                    Messages.BilgiMesaji(row.StokKodu + " Kodlu Malzemeye Ait Recete Bulunamadı");
                    continue;
                }
                row.ReceteId = recete.Where(x => x.Varsayılan).FirstOrDefault().Id;
                source.Add(row);
            }
            return source.Cast<MrpBilgileriL>().ToList();
        }
    }
}

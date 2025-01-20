using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Common.Functions;
using DevExpress.XtraGrid.Views.Base;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.GenelEditFormTable
{
    public partial class VardiyaBilgileriTable : BaseTablo
    {
        public VardiyaBilgileriTable()
        {
            InitializeComponent();

            Bll = new VardiyaBilgileriLastVersionBll();
            Tablo = tablo;
            EventsLoad();

            repositoryImageComboDayOfWeek.Items.AddEnum<DaysOfWeek>();
        }
        protected internal override void Listele()
        {
            Tablo.GridControl.DataSource = ((VardiyaBilgileriLastVersionBll)Bll).List(x => x.VardiyaId == OwnerForm.Id).toBindingList<VardiyaBilgileriLastVersionL>();
        }
        protected override void HareketEkle()
        {
            //if (HatalıGiriş()) return;

            var source = tablo.DataController.ListSource;
            var row = new VardiyaBilgileriLastVersionL
            {
                VardiyaId = OwnerForm.Id,
                BirimSure = UnitOfDate.Minute,
                Insert = true
            };

            source.Add(row);

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colGun;

            ButtonEnabledDurum(true);
        }
        protected internal override bool HatalıGiriş()
        {
            if (!TableValueChanged) return false;
            if (tablo.HasColumnErrors) tablo.ClearColumnErrors();
            var source = Tablo.DataController.ListSource.Cast<VardiyaBilgileriLastVersionL>();

            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                var entitiy = tablo.GetRow<VardiyaBilgileriLastVersionL>(i);
                if (source.Where(x => x.Vardiya == entitiy.Vardiya && x.Gun == entitiy.Gun).Count() > 1)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.SetColumnError(colGun, "Lütfen Yeni Bir Değer Giriniz yada Satırı Siliniz .");
                    Messages.HataMesaji("Lütfen Yeni Bir Değer Giriniz yada Satırı Siliniz .");
                    return true;
                }
                if (entitiy.Vardiya == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colKacinciVardiya;
                    tablo.SetColumnError(colKacinciVardiya, "Vardiya Alanına Geçerli Bir Değer Giriniz .");
                }
                if (entitiy.MesaiBaslamaSaati == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colMesaiBaslamaSaati;
                    tablo.SetColumnError(colMesaiBaslamaSaati, "Mesai Başlama Saati Alanına Geçerli Bir Değer Giriniz .");
                }

                if (entitiy.MesaiBitisSaati == null)
                {
                    tablo.FocusedRowHandle = i;
                    tablo.FocusedColumn = colMesaiBitisSaati;
                    tablo.SetColumnError(colMesaiBitisSaati, "Mesai Bitiş Saati Alanına Geçerli Bir Değer Giriniz .");
                }

                if (!tablo.HasColumnErrors) continue;

                Messages.TabloEksikBilgiMesaji($"{tablo.ViewCaption} Tablosu");
                return true;
            }

            return false;
        }
        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);

            var entity = tablo.GetRow<VardiyaBilgileriLastVersionL>();
            if (entity == null) return;

            if (e.Column == colMesaiBaslamaSaati || e.Column == colMesaiBitisSaati || e.Column == colMolaSuresi || e.Column == colBirimSure)
                entity.Kapasite=CalculateCapacityAsMinuteForDaily(entity);
        }

        private decimal CalculateCapacityAsMinuteForDaily(VardiyaBilgileriLastVersionL entity)
        {
            if (entity.MesaiBaslamaSaati == null || entity.MesaiBitisSaati == null) return 0;

            var minuteOfTimeSpan =Convert.ToDecimal( entity.MesaiBitisSaati.TotalHours - entity.MesaiBaslamaSaati.TotalHours);//Math.Abs((entity.MesaiBaslamaSaati - entity.MesaiBitisSaati).Minutes);
            var minuteFromHourOfTimeSpan = minuteOfTimeSpan>0? minuteOfTimeSpan:(24-Math.Abs(minuteOfTimeSpan));
            var freeTime = entity.MolaSuresi;
            var totalWorkingDuration =minuteFromHourOfTimeSpan*60 - freeTime;

            return totalWorkingDuration; 
        }
    }
}

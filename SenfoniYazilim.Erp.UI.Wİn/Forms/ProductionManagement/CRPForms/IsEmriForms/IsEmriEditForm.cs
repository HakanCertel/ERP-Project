using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.Bll.General.CRP;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Dto.CRPDto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using SenfoniYazilim.Erp.Bll.Functions;
using SenfoniYazilim.Erp.Model.Entities.CRP;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.ProductionManagement.CRPForms.IsEmriForms
{
    public partial class IsEmriEditForm : BaseEditForm
    {
        private WorkOrdersL _workOrderL;
        private List<MalzemeIhtiyacBilgileriL> _mib;

        public IsEmriEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new IsEmriBll();
            BaseKartTuru = KartTuru.Cari;
            EventsLoad();
            HideItems = new DevExpress.XtraBars.BarItem[] { btnSil };
        }
        public override void Yukle()
        {
            OldEntity = new BaseEntity(); //BaseIslemTuru == IslemTuru.EntityInsert ? new IsEmri() : new IsEmri();
            CurrentEntity = new BaseEntity();
            NesneyiKontrollereBagla();
            TabloYukle();

            txtIslemTarihi.EditValue = DateTime.Now;

        }
        protected override void NesneyiKontrollereBagla()
        {
            txtIsEmriKodu.Text = _workOrderL?.Kod;
            txtIsEmriKodu.Id =Convert.ToInt64( _workOrderL?.Id);
            //txtDepoKodu.Text = _workOrder?.;
            txtDepoKodu.Id = _workOrderL?.DepoId;
            //txtDepoAdi.Text = _workOrder?.DepoAdi;
            txtToplamIsEmriMiktari.EditValue = _workOrderL?.IsEmriMiktari;
            txtUretilenMiktar.EditValue = _workOrderL?.UretilenMiktar;
            txtKalanMiktar.EditValue = _workOrderL?.Kalan;
        }
        protected override void TabloYukle()
        {
            workOrderMaterialTable.OwnerForm = this;
            workOrderMaterialTable.Yukle();
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is MyButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtIsEmriKodu)
                {
                    var isEmriL = new WorkOrdersL();
                    _workOrderL= (WorkOrdersL)sec.Sec(txtIsEmriKodu, isEmriL);

                    workOrderMaterialTable._workOrder=_workOrderL;
                    workOrderMaterialTable.Yukle();
                    NesneyiKontrollereBagla();
                }
                else if (sender == txtDepoKodu)
                {
                    sec.Sec(txtDepoKodu, txtDepoAdi);
                }
            }
           
        }
        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            //base.Control_EditValueChanged(sender, e);
            if (!IsLoaded) return;
            if (sender == txtKalanMiktar)
            {
                var entities = workOrderMaterialTable.Tablo.DataController.ListSource.Cast<MalzemeIhtiyacBilgileriL>().ToList();
                entities.ForEach(x =>
                {
                    x.NetIhtiyac = (decimal)txtKalanMiktar.EditValue * x.BirimIhtiyac;
                });
            }
        }
    }
}
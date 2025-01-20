using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Bll.Interfaces;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.RezervasyonForms
{
    public partial class RezervasyonEditForm : BaseEditForm
    {
        private IBaseEntity _oldEntity;

        public RezervasyonEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new RezervasyonBilgileriBll();
            BaseKartTuru = KartTuru.Rezerve;
            EventsLoad();
        }
        public override void Yukle()
        {
             _oldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new RezervasyonBilgileriL() : ((RezervasyonBilgileriBll)Bll).Single(x => x.Id == Id).EntityCovert<RezervasyonBilgileriL>(false, true);
            NesneyiKontrollereBagla();
        }
        protected override void NesneyiKontrollereBagla()
        {
            var entity = (RezervasyonBilgileriL)_oldEntity;
            Id = entity.Id;
            txtGrup.Text = entity.GrupAdi;
            txtGrup.Id =Convert.ToInt64( entity.GrupId);
            txtStokKodu.Id = entity.MaterialId;
            txtStokKodu.Text = entity.MaterialCode;
            txtStokAdi.Text = entity.MaterialName;
            txtDepoAdi.Id = entity.WarehouseId;
            txtDepoAdi.Text = entity.WarehouseName;
            txtRezervBirim.Text = entity.Birim;
            txtRezervMiktar.EditValue = entity.RezervedQty;
            txtAciklama.Text = entity.Description;

        }
        protected override bool Kaydet(bool kapanis)
        {
            if (!((IBaseHareketGenelBll)Bll).Insert(NesneOlustur()))
            {
                Messages.HataMesaji($"{Text} Formundaki Kayıt Eklenemedi");
                return false;
            }
            return true;
        }
        
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtAltGrup)
                    sec.Sec(txtAltGrup, KartTuru.Rezerve);
                else if (sender == txtStokKodu)
                {
                    if (txtDepoAdi == null) { Messages.BilgiMesaji("Lütfen Önce Depo Seçiniz ."); txtDepoAdi.Focus(); return; }
                    sec.Sec(txtStokKodu, txtStokAdi);
                    RezerveMiktarHesapla();
                }

                else if (sender == txtDepoAdi)
                    sec.Sec(txtDepoAdi, KartTuru.Depo);
            }
        }
        private List< BaseHareketEntity> NesneOlustur()
        {
            var entity = new RezervasyonBilgileriL
            {
                UserId = AnaForm.KullaniciId,
                GrupAdi = txtGrup.Text,
                GrupId=Convert.ToInt64(txtAltGrup.Id),
                WarehouseId= Convert.ToInt64(txtDepoAdi.Id),
                RezervedQty=(int)txtRezervMiktar.EditValue,
                MaterialId= Convert.ToInt64(txtStokKodu.Id),
                //Birim=txtRezervBirim.Text,
            };
            var list = new List<RezervasyonBilgileri>();

            list.Add(entity);

            var insert = list.Cast<BaseHareketEntity>().ToList();

            return insert;
        }
        private void RezerveMiktarHesapla()
        {
            var entity =(RezervasyonBilgileriL)((RezervasyonBilgileriBll)Bll).Single(x => x.MaterialId == txtStokKodu.Id);

            if (entity == null) return;

            txtKullanilabilirMiktar.EditValue=Convert.ToDecimal(entity.TotalMaterialQty - entity.TotalRezervedQty);
            txtKullanilabilirBirim.Text = entity.Birim;
            txtRezervBirim.Text = entity.Birim;
        }
        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e){}
    }
}
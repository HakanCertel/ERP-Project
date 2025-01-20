using System;
using System.Collections.Generic;
using System.Linq;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.YardimciTabloEntity;
using System.Linq.Expressions;
using SenfoniYazilim.Erp.Bll.Functions;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.PaymentMethodForms
{
    public partial class PaymentMethodEditForm : BaseEditForm
    {
        protected internal List<Language> _source;
        protected internal Expression<Func<PaymentMethodItems, bool>> filter=null;

        public PaymentMethodEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
           
            EventsLoad();
        }
        public override void Yukle()
        {
            OldEntity = new BaseEntity();
            CurrentEntity = new BaseEntity();
            _source = new List<Language>();
            //var addedItem = new Language
            //{
            //    Id = 0,
            //    LanguageCode = "All",
            //    LanguageDescription = "Show All"
            //};
            //_source.Add(addedItem);
            _source.AddRange( GetAnySingleOrListBll.ListLanguages().ToList());
            
            txtLanguage.Properties.DataSource = _source;
            txtLanguage.Properties.ValueMember = "LanguageCode";
            txtLanguage.Properties.DisplayMember = "LanguageDescription";
            txtLanguage.ItemIndex = 0;
            TabloYukle();
        }
        protected override void GuncelNesneOlustur()
        {
            ButonEnabledDurumu();
        }
        protected internal override void ButonEnabledDurumu()
        {
            if (!IsLoaded) return;
            Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, CurrentEntity, paymentMethodEditFormTable.TableValueChanged);
        }
        protected override bool EntityInsert()
        {
            //if (!paymentMethodEditFormTable.HatalıGiriş()) return false;
            return paymentMethodEditFormTable.Kaydet();
        }

        protected override bool EntityUpdate()
        {
            if (!paymentMethodEditFormTable.HatalıGiriş()) return false;
            return paymentMethodEditFormTable.Kaydet();
        }
        protected override void TabloYukle()
        {

            paymentMethodEditFormTable.OwnerForm = this;
            paymentMethodEditFormTable.Yukle();
           
        }
        protected override void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;
            //if (sender is MyLookUpEdit)
            //{
            //    var hasPaymentThisLanguage = GetEntityOrListOfAnyTableFunction.AnyPaymentMethodS(x => x.Language.LanguageCode == _source[txtLanguage.ItemIndex].LanguageCode);
            //    if (txtLanguage.ItemIndex == 0||hasPaymentThisLanguage==null)
            //        filter = null;
            //    else
            //    {
            //        filter = x => x.Language.LanguageCode == _source[txtLanguage.ItemIndex].LanguageCode;
            //        paymentMethodEditFormTable.Listele();
            //    }
            //}
        }
    }
}
﻿using SenfoniYazilim.Erp.Bll.General;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Show;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.IlceForms
{
    public partial class IlceListForm : BaseListForm
    {
        private readonly long _ilId;
        private readonly string _ilAdi;

        public IlceListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new IlceBll();
            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Ilce;
            //FormShow = new ShowEditForms<OkulEditForm>();
            Navigator = longNavigator.Navigator;
            Text = Text + $" - ( {_ilAdi} )";// bu ifade bir edit form açılırken formun başlığına parantez içinde il adını yazmaya yarar
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IlceBll)Bll).List(x=>x.Durum==AktifKartlariGoster&&x.IlId==_ilId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<IlceEditForm>.ShowDialogForm(KartTuru.Ilce,id,_ilId,_ilAdi);
            ShowEditFormDefault(result);
        }
    }
}
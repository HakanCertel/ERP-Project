using System.Collections.Generic;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.UserControl.Base;
using DevExpress.XtraGrid.Views.Base;
using SenfoniYazilim.Erp.Bll.YardimciFormTablo;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.Model.Entities;
using SenfoniYazilim.Erp.Bll.General;
using System.ComponentModel;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.YardımciTablolar.GenelTablolar.DefinationsForms
{
    public partial class DefinationAndFeatureEditTable : BaseTablo
    {
        private KartTuru kartTuru;
        private Material material;
        private List<FeatureL> features = new List<FeatureL>();
        private BindingList<DefinationAndFeatureItems> list;

        public DefinationAndFeatureEditTable()
        {
            InitializeComponent();
            Bll = new DefinationsBll();
            Tablo = tablo;
            EventsLoad();
            insUpNavigator.Navigator.Buttons.Append.Visible = false;
            insUpNavigator.Navigator.Buttons.Remove.Visible = false;
        }
        protected internal override void Listele()
        {
            
            kartTuru = ((DefinationAndFeaturesEditForm)OwnerForm)._kartTuru;
            material= ((DefinationAndFeaturesEditForm)OwnerForm)._material;

            list=((DefinationsBll)Bll).DefinationAndFeatureList(x => x.KartTuru == kartTuru).toBindingList<DefinationAndFeatureItems>();

            if (material != null)
            {
                var feature1 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x=>x.Id==material.Feature1Id);
                features.Add(feature1);
                var feature2 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature2Id);
                features.Add(feature2);
                var feature3 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature3Id);
                features.Add(feature3);
                var feature4 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature4Id);
                features.Add(feature4);
                var feature5 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature5Id);
                features.Add(feature5);
                var feature6 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature6Id);
                features.Add(feature6);
                var feature7 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature7Id);
                features.Add(feature7);
                var feature8 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature8Id);
                features.Add(feature8);
                var feature9 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature9Id);
                features.Add(feature9);
                var feature10 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature10Id);
                features.Add(feature10);
                var feature11 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature11Id);
                features.Add(feature11);
                var feature12 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature12Id);
                features.Add(feature12);
                var feature13 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature13Id);
                features.Add(feature13);
                var feature14 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature14Id);
                features.Add(feature14);
                var feature15 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature15Id);
                features.Add(feature15);
                var feature16 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature16Id);
                features.Add(feature16);
                var feature17 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature17Id);
                features.Add(feature17);
                var feature18 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature18Id);
                features.Add(feature18);
                var feature19 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature19Id);
                features.Add(feature19);
                var feature20 = Erp.Bll.Functions.GetAnySingleOrListBll.GetFeatures(x => x.Id == material.Feature20Id);
                features.Add(feature20);
            }
            for (int i = 0; i < list.Count; i++)
            {
                list[i].FeatureCode = features[i]?.Code;
                list[i].FeatureId = features[i]?.Id;
                list[i].FeatureDescription = features[i]?.Description;
            }
            Tablo.GridControl.DataSource = list;
            Tablo.FilterActiveRows();
        }

        protected override void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            base.Tablo_FocusedColumnChanged(sender, e);

            var entity = Tablo.GetRow<DefinationAndFeatureItems>(false);
            if (entity == null) return;

            if (e.FocusedColumn == colFeatureDescription)
            {
                e.FocusedColumn.Sec(tablo, insUpNavigator.Navigator, repositoryItemButtonEditFeature, colFeatureId,colDefinationId,colFeatureDescription);
            }

        }
        protected internal override bool Kaydet()
        {
            if (list == null) return true;

            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0 && list[i] != null)
                    material.Feature1Id = list[i].FeatureId;
                else if (i == 1 && list[i] != null)
                    material.Feature2Id = list[i].FeatureId;
                else if (i == 2 && list[i] != null)
                    material.Feature3Id = list[i].FeatureId;
                else if (i == 3 && list[i] != null)
                    material.Feature4Id = list[i].FeatureId;
                else if (i == 4 && list[i] != null)
                    material.Feature5Id = list[i].FeatureId;
                else if (i == 5 && list[i] != null)
                    material.Feature6Id = list[i].FeatureId;
                else if (i == 6 && list[i] != null)
                    material.Feature7Id = list[i].FeatureId;
                else if (i == 7 && list[i] != null)
                    material.Feature8Id = list[i].FeatureId;
                else if (i == 8 && list[i] != null)
                    material.Feature9Id = list[i].FeatureId;
                else if (i == 9 && list[i] != null)
                    material.Feature10Id = list[i].FeatureId;
                else if (i == 10 && list[i] != null)
                    material.Feature11Id = list[i].FeatureId;
                else if (i == 11&& list[i] != null)
                    material.Feature12Id = list[i].FeatureId;
                else if (i == 12 && list[i] != null)
                    material.Feature13Id = list[i].FeatureId;
                else if (i == 13 && list[i] != null)
                    material.Feature14Id = list[i].FeatureId;
                else if (i == 14 && list[i] != null)
                    material.Feature15Id = list[i].FeatureId;
                else if (i == 15 && list[i] != null)
                    material.Feature16Id = list[i].FeatureId;
                else if (i == 16 && list[i] != null)
                    material.Feature17Id = list[i].FeatureId;
                else if (i == 17 && list[i] != null)
                    material.Feature18Id = list[i].FeatureId;
                else if (i == 18 && list[i] != null)
                    material.Feature19Id = list[i].FeatureId;
                else if (i == 19 && list[i] != null)
                    material.Feature20Id = list[i].FeatureId;
            }
            using (var bll=new MaterialBll())
            {
                 TableValueChanged=! bll.Update(material);
                return !TableValueChanged;
            }
            //return base.Kaydet();
            
        }
    }
}

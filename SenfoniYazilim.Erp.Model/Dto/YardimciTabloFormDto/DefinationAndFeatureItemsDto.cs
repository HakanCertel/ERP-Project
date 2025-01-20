using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto.YardimciTabloFormDto
{
    [NotMapped]
    public class DefinationAndFeatureItems:BaseHareketEntity,IBaseHareketEntity
    {
        public int DefinationId { get; set; }
        public string DefinationCode { get; set; }
        public string DefinationDescription { get; set; }
        public int? FeatureId { get; set; }
        public string FeatureCode { get; set; }
        public string FeatureDescription { get; set; }
        public KartTuru KartTuru { get; set; }
        public bool IsActiveFeature { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}

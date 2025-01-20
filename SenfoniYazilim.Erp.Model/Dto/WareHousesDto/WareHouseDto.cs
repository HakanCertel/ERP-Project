using SenfoniYazilim.Erp.Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Dto
{
    [NotMapped]
    public class WareHouseS : WareHouse
    {
        public string BranchName { get; set; }        
    }
}

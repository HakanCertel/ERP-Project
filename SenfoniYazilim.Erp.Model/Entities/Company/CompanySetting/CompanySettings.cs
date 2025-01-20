using SenfoniYazilim.Erp.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Model.Entities.Company.CompanySetting
{
    public class CompanySettings:BaseEntity
    {
        public int BreakDownCount { get; set; }
        public string BreakDownMainDescription { get; set; }
        public string BreakDownMainSpaceValue { get; set; }
        public string BreakDownOneDescription { get; set; }
        public string BreakDownOneSpaceValue { get; set; }
        public string BreakDownTwoDescription { get; set; }
        public string BreakDownTwoSpaceValue { get; set; }
        public string BreakDownThreeDescription { get; set; }
        public string BreakDownThreeSpaceValue { get; set; }
    }
}

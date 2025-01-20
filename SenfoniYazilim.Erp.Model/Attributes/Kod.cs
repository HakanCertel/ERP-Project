using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenfoniYazilim.Erp.Model.Attributes
{
    public class Kod:Attribute
    {
        public string Description { get;}
        public string ControlName { get;}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="description"></param>
        /// <param name="controlName"></param>

        public Kod(string description,string controlName)
        {
            Description = description;
            ControlName = controlName;
        }
    }
}

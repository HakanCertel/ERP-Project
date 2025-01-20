using System;

namespace SenfoniYazilim.Erp.Model.Attributes
{
    public class ZorunluAlan:Attribute
    {
        public string Description { get; }
        public string ControlName { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="description"></param>
        /// <param name="controlName"></param>
        public ZorunluAlan(string description, string controlName)
        {
            Description = description;
            ControlName = controlName;
        }

    }
}

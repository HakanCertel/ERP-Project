using SenfoniYazilim.Erp.Model.Attributes;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenfoniYazilim.Erp.Model.Entities.Base
{
    public class BaseEntity:IBaseEntity
    {
        [Column(Order =0),Key,DatabaseGenerated(DatabaseGeneratedOption.None)]//Key ifadesi bu alanın key olduğunu belirtmek için kullanılır. 
        public long Id { get; set; }
        [Column(Order =1),Required,StringLength(20),Kod("Kod","txtKod"),ZorunluAlan("Kod","txtKod")]
        public virtual  string Kod { get; set; }

        public object EntityListConvert<T>(bool v1, bool v2)
        {
            throw new NotImplementedException();
        }
    }
}

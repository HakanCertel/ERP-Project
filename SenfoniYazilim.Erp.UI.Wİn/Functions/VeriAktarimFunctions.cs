using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace SenfoniYazilim.Erp.UI.Wİn.Functions
{
    public static  class VeriAktarimFunctions
    {
        
        public static  IEnumerable<object>  VeriDoldur(this DataTable table,object entity)
        {
            List<object> list = new List<object>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var _entity = table.Columns.Colonlar(entity, table.Rows[i]);
                list.Add(_entity);                
            }

            return list.ToList();
        }
        public static object Converts(this object value,PropertyInfo property)
        {
            if (property.PropertyType == typeof(long))
            {
                value = Convert.ToInt64(value);
                return value;
            }
            else if (property.PropertyType == typeof(long?))
            {
                value = Convert.ToInt64(value);
                return value;
            }
            else if (property.PropertyType == typeof(int))
            {
                value = Convert.ToInt32(value);
                return value;
            }
            else if (property.PropertyType == typeof(int?))
            {
                value = Convert.ToInt32(value);
                return value;
            }
            else if (property.PropertyType == typeof(decimal))
            {
                value = Convert.ToDecimal(value);
                return value;
            }
            else if (property.PropertyType == typeof(double))
            {
                value = Convert.ToDouble(value);
                return value;
            }
            else if (property.PropertyType == typeof(string))
            {
                value = Convert.ToString(value);
                return value;
            }
            else if (property.PropertyType == typeof(DateTime))
            {
                value = Convert.ToDateTime(value);
                return value;
            }
            else if (property.PropertyType == typeof(byte))
            {
                value = Convert.ToByte(value);
                return value;
            }
            else if (property.PropertyType == typeof(byte[]))
            {
                var dizi = Convert.GetTypeCode(typeof(byte[]));
                value = Convert.ChangeType(value,dizi);
                return value;
            }
            else if (property.PropertyType == typeof(bool))
            {
                value = Convert.ToBoolean(value);
                return value;
            }
            else if (property.PropertyType.IsEnum)
            {
                var enumm = property.PropertyType.GetEnumValues();
                foreach (var item in enumm)
                {
                    var sd = item.ToString();
                    var ggg = value.ToString();
                    if (sd == ggg) 
                        return item;
                }

            }
            return null;
        }

        public static object Colonlar(this DataColumnCollection columns ,object entity,DataRow row)
        {
            var _entity = new object();
            for (int i = 0; i < columns.Count; i++)
            {
                var hedefProp = entity.GetType().GetProperties();
                foreach (var property in hedefProp)
                {
                    if (property.PropertyType.Namespace == "System.Collections.Generic") continue;
                    var item = row[i].ToString();
                    if (property.Name == columns[i].ColumnName)
                    {
                        var nn = row[i].Converts(property);
                        property.SetValue(entity, row[i].Converts(property));
                    }

                }
            }
            _entity = entity;
            return _entity;
        }
        
    }
}

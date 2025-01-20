using SenfoniYazilim.Erp.UI.Wİn.Interfaces;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Drawing;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    [ToolboxItem(true)] 
    public class MyButtonEdit:ButtonEdit,IStatusBarKisaYol
    {
        

        public MyButtonEdit()
        {
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
        }
        public override bool EnterMoveNextControl { get; set; } = true; 
        public string StatusBarAciklama { get; set; }
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; }

        #region Events

        private long? _id;
        [Browsable(false)]// bu attribute Id propertimizi derleme işleminden sonra gösterilip gösterilmemesini belirler...
        public long? Id
        {
            get => _id;// burada => işareti return anlamına gelmektedir....
            set
            {
                var oldValue = _id;
                var newValue = value;
                if (oldValue == newValue) return;

                _id = value;
                IdChanged(this, new IdChangedEventArgs(oldValue, newValue));//IdChanged Event i iki değişken talep etmektedir
                //birincisi sender ,yani MyButtonEdit kontrolümüz, bunu this ile ifade ederiz. ikincisi IdChangedEventArgs dır.
                EnabledChanged(this, EventArgs.Empty);
            } 
           
        }
        
        public event EventHandler<IdChangedEventArgs> IdChanged=delegate { };//burada delegate demezsek yukarıdaki IdChanged event imiz
        //null bir değer döndermesi halinde programımız hata verecektir...
        public event EventHandler EnabledChanged = delegate { };

        #endregion
    }

    public class IdChangedEventArgs:EventArgs
    {
        public IdChangedEventArgs(long? oldValue,long? newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public long? OldValue { get; }
        public long? NewValue { get; }
    }
}

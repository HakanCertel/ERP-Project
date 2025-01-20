using DevExpress.XtraDataLayout;
using DevExpress.XtraLayout;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.XtraLayout.Utils;

namespace SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyDataLayoutControl:DataLayoutControl//herhangi bir control e ait referensa ulaşılamazsa eğer , form üzerinde kontrol sürüklenip 
        //form üzerine bırakıldığında kontrole ait referenslar otomatik olarak tanımlanacaktır, DataLayoutControl böyle bir kontroldür..
    {
        public MyDataLayoutControl()
        {
            OptionsFocus.EnableAutoTabOrder = false;//LayOut üzrinde bizim istediğimiz sıraya göre kontrollerin sıralanmasını istiyorsak, bu metodu false yapmalıyız..
                                                    //yani artık kendi vereceğimiz index düzenine göre tab yaptıkca kontroller arasında dolaşacağız..
        }
        protected override LayoutControlImplementor CreateILayoutControlImplementorCore()
        {
            return new MyLayoutControlImplementor(this);
        }
        
    }

    internal class MyLayoutControlImplementor : LayoutControlImplementor
    {
        public MyLayoutControlImplementor(ILayoutControlOwner owner) : base(owner)
        {
        }
        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            var item = base.CreateLayoutItem(parent);
            item.AppearanceItemCaption.ForeColor = Color.Maroon;
           // item.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 0, 0);
            return item;
        }
        public override LayoutGroup CreateLayoutGroup(LayoutGroup parent)
        {
            var grp = base.CreateLayoutGroup(parent);
            grp.LayoutMode = LayoutMode.Table;
                 
            grp.OptionsTableLayoutGroup.ColumnDefinitions[0].SizeType = SizeType.Absolute;
            grp.OptionsTableLayoutGroup.ColumnDefinitions[0].Width = 200;
            grp.OptionsTableLayoutGroup.ColumnDefinitions[1].SizeType = SizeType.Percent;
            grp.OptionsTableLayoutGroup.ColumnDefinitions[1].Width = 100;
            grp.OptionsTableLayoutGroup.ColumnDefinitions.Add(new ColumnDefinition { SizeType = SizeType.Absolute, Width = 99 });

            grp.OptionsTableLayoutGroup.RowDefinitions.Clear();

            for (int i = 0; i < 9; i++)
            {
                grp.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = SizeType.Absolute,
                    Height = 24
                });

                if (i + 1 != 9) continue;
                grp.OptionsTableLayoutGroup.RowDefinitions.Add(new RowDefinition
                {
                    SizeType = SizeType.Percent,
                    Height = 100
                });
            }
            
            return grp;
        }
    }
}

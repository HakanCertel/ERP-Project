using SenfoniYazilim.Erp.Bll.Base;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Data.Contexts;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Show
{
    public class ShowListForms<TForm> where TForm: BaseListForm
    {
        public static void ShowListForm(KartTuru kartTuru)//kartturu yetki kontrolü yapılırken kullanılmak üzere parametre olarak tanımlanmmıştır
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return;

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;
            //frm.ListeDisiTutulacakKayitlar = new List<long>();
            frm.Yukle();
            frm.Show();
        }

        public static void ShowListForm(KartTuru kartTuru,params object[] prm)//kartturu yetki kontrolü yapılırken kullanılmak üzere parametre olarak tanımlanmmıştır
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return;

            var frm = (TForm)Activator.CreateInstance(typeof(TForm),prm);
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }
        public static void ShowHareketListForm(KartTuru kartTuru)//kartturu yetki kontrolü yapılırken kullanılmak üzere parametre olarak tanımlanmmıştır
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return;

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;
            frm.Yukle();
            frm.IsBaseHareketEntity = true;
            frm.HareketRowsSelected = new SelectRowFunctionsBaseHareketEntity(frm.Tablo);
            //frm.HareketRowsSelected?.ClearSelection();
            frm.Show();

        }
        public static BaseEntity ShowDialogListForm(KartTuru kartTuru, long? seciliGelecekId, params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm),prm))
            {
                frm.SeciliGelecekId = seciliGelecekId;
                frm.Yukle();
                frm.HideItems = new DevExpress.XtraBars.BarItem[] {};
                if(!frm.IsDisposed)
                    frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntity : null;
            }
        }
        public static BaseEntity ShowDialogListForm(KartTuru kartTuru, long? seciliGelecekId,IList<long> liste, params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = liste;
                frm.SeciliGelecekId = seciliGelecekId;
                frm.Yukle();

                if (!frm.IsDisposed)
                    frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntity : null;
            }
        }

        public static void ShowDialogListForm()
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.AktifPasifButonGoster = true;
                frm.Yukle();
                frm.ShowDialog();
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru,IList<long> listeDisiTutulacakKayitlar,bool multiSelect,params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
                frm.MultiSelect = multiSelect;
                frm.Yukle();

                frm.RowSelect = new Functions.SelectRowFunctions(frm.Tablo);
                if (frm.EklenebilecekEntityVar)
                    frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }
        
        public static IEnumerable<IBaseEntity> ShowDialogListForm(IList<long> listeDisiTutulacakKayitlar, bool multiSelect, params object[] prm)
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
                frm.MultiSelect = multiSelect;
                frm.Yukle();

                frm.RowSelect = new Functions.SelectRowFunctions(frm.Tablo);
                if (frm.EklenebilecekEntityVar)
                    frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }

        public static bool ShowDialogListForm(bool uretimSonuKaydimi,IList<long> listeDisiTutulacakKayitlar, bool multiSelect, params object[] prm)
        {
            //if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return false;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
                frm.MultiSelect = multiSelect;
                frm.Yukle();

                frm.RowSelect = new Functions.SelectRowFunctions(frm.Tablo);
                if (frm.EklenebilecekEntityVar)
                    frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? true : false;
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru, bool multiSelect, params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {               
                frm.MultiSelect = multiSelect;
                frm.Yukle();

                frm.RowSelect = new Functions.SelectRowFunctions(frm.Tablo);

                frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }

        public static BaseHareketEntity ShowDialogHareketListForm(KartTuru kartTuru, int? seciliGelecekId, params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.IsBaseHareketEntity = true;
                frm.SeciliGelecekHareketId = seciliGelecekId;
                frm.Yukle();

                if (!frm.IsDisposed)
                    frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedHareketEntity : null;
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogHareketListForm(IList<long> listeDisiTutulacakKayitlar,bool multiSelect,bool isHareket,params object[] prm)
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
                frm.MultiSelect = multiSelect;
                frm.IsBaseHareketEntity = isHareket;
                frm.EklenebilecekEntityVar = true;
                frm.Yukle();
                frm.HareketRowsSelected = new SelectRowFunctionsBaseHareketEntity(frm.Tablo);
                if (frm.EklenebilecekEntityVar)
                    frm.ShowDialog();
               
                return frm.DialogResult == DialogResult.OK ? frm.HareketSelectedEntities : null;
            }
            //using (var frm = (TForm)Activator.CreateInstance(typeof(TForm),prm))
            //{
            //    frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
            //    frm.Yukle();
            //    frm.EklenebilecekEntityVar = true;
            //    if (frm.EklenebilecekEntityVar)
            //        frm.ShowDialog();
            //    var entity = frm.HareketRowsSelected.GetSelectedRows();
            //    return frm.HareketRowsSelected.GetSelectedRows();
            //    //return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            //}
        }

        // internal static void ShowListForm(object ılce, long ıd, string ılAdi)
        //{
        //  throw new NotImplementedException();
        //}

        //internal static void ShowListForm(object okul)
        //{
        //    throw new NotImplementedException();
        //}
    }
    public class ShowVeriAktarListForms<TForm, T, TBll> where TForm : BaseListForm where T : BaseEntity, new() where TBll : BaseGenelBll<T>, new()
    {
        public static void ShowDialogListForm(KartTuru kartTuru, Expression<Func<T, bool>> filter, params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return ;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                using (var blll = (TBll)Activator.CreateInstance(typeof(TBll)))
                {
                    frm.bll = blll;

                    frm.SendEntities = blll.List(filter).Cast<object>().ToList();
                }

                frm.TypeofEntity = typeof(T);
                frm.TypeofBll = typeof(TBll);
                frm.Yukle();

                if (!frm.IsDisposed)
                    frm.ShowDialog();
            }
        }
    }
    public class ShowVeriAktarEditForms<TForm, T, TBll> where TForm : BaseListForm where T : BaseHareketEntity, new() where TBll : BaseHareketBll<T, SenfoniErpContext>, new()
    {
        public static void ShowDialogListForm(KartTuru kartTuru, Expression<Func<T, bool>> filter, params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return ;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                using (var blll = (TBll)Activator.CreateInstance(typeof(TBll)))
                {
                    frm.bll = blll;
                    var list = blll.List(filter, x => x).ToList();
                    frm.SendEntities =blll.List(filter,x=>x).ToList().Cast<object>().ToList();
                }

                frm.TypeofEntity = typeof(T);
                frm.TypeofBll = typeof(TBll);
                frm.Yukle();

                if (!frm.IsDisposed)
                    frm.ShowDialog();
            }
        }
    }

}

using DevExpress.XtraSplashScreen;
using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using SenfoniYazilim.Erp.UI.Wİn.GeneralForms;
using SenfoniYazilim.Erp.UI.Wİn.Show.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Show
{
    public class ShowEditForms<TForm> : IBaseFormShow where TForm : BaseEditForm
    {
        public static long ShowForm(KartTuru kartTuru,long id)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return 0;

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
            frm.Id = id;
            frm.MdiParent = Form.ActiveForm;
            frm.Yukle();
            frm.Show();
            return id;
        }
        public long ShowDialogForm(KartTuru kartTuru, long id)
        {
            if (!GeneralFunctions.EditFormYetkiKontrolu(id, kartTuru)) return 0;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();

                return frm.RefreshYapilacak ? frm.Id : 0;
            }
        }

        public static long ShowDialogForm(KartTuru kartTuru, long id, int itemId)
        {
            if (!GeneralFunctions.EditFormYetkiKontrolu(id, kartTuru)) return 0;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.SelectedItemId = itemId;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak ? frm.Id : 0;
            }
        }

        public static bool ShowDialogForm(params object[] prm)
        {
            //Yetki Kontrolü

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();
                return frm.DialogResult == DialogResult.OK;
            }
        }

        public static bool ShowDialogForm(KartTuru kartTuru, params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return false;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();
                return frm.DialogResult == DialogResult.OK;
            }
        }
        public static void ShowDialogForm(KartTuru kartTuru)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.BaseIslemTuru = IslemTuru.EntityUpdate;
                frm.Yukle();
                frm.ShowDialog();
            }
        }
        public static void ShowDialogForm()
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.Yukle();
                frm.ShowDialog();
            }
        }
        
        public static bool ShowDialogForm(IslemTuru islemTuru, params object[] prm)
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.BaseIslemTuru = islemTuru;
                frm.Yukle();
                frm.ShowDialog();

                return frm.RefreshYapilacak;
            }
        }
        public static bool ShowDialogForm(IslemTuru islemTuru, IList<BaseHareketEntity> selectedEntities, params object[] prm)
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.BaseIslemTuru = islemTuru;
                frm.SelectedEntities = selectedEntities;
                frm.Yukle();
                frm.ShowDialog();

                return frm.RefreshYapilacak;
            }
        }
        public static bool ShowDialogForm(IslemTuru islemTuru, KartTuru kartTuru,IList<BaseHareketEntity> selectedEntities, params object[] prm)
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.BaseIslemTuru = islemTuru;
                frm.DataSourceCardType = kartTuru;
                frm.SelectedEntities = selectedEntities;
                frm.Yukle();
                frm.ShowDialog();

                return frm.RefreshYapilacak;
            }
        }
        public static long ShowDialogForm(KartTuru kartTuru, long id, params object[] prm)
        {
            //Yetki Kontrolü
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak ? frm.Id : 0;
            }
        }
        public static long ShowDialogForm(long id, params object[] prm)
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYapilacak ? frm.Id : 0;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// bu metod DönemListForm da DonemParametreEditForm u açmak için kullanılacaktır ve ilgili edit form
        /// bir dönem id parametresi almaktadır. bunun için id değeri null gönderilip parametreye ise ilgili
        /// donem Id gönderilecektir...
        /// 
        /// Aynı Metod KurumBilgileriEditForm u görüntülemek için AnaForm da da kullanılmıştır.
        /// <param name="prm"></param>
        public static void ShowDialogForm(long? id, params object[] prm)
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                if (id != null)
                    frm.Id = (long)id;
                frm.Yukle();
                frm.ShowDialog();
            }
        }

        public static T ShowDialogEditForm<T>(params object[] prm) where T : IBaseEntity
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();
                frm.ShowDialog();
                return (T)frm.ReturnEntity();
            }

        }
        public static IEnumerable<T> ShowDialogEditForm<T>(KartTuru kartTuru, long id, params object[] prm) where T : IBaseEntity
        {

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.BaseIslemTuru = id > 0 ? IslemTuru.EntityUpdate : IslemTuru.EntityInsert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return (IEnumerable<T>)frm.ReturnEntities();
            }

        }



        /*
Bu fonksiyon Reçete Form u için Hazırlanmıştır..

*/
        //public static void ShowDialogForm(KartTuru kartTuru,int id)
        //{
        //    //Yetki Kontrolü

        //    using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
        //    {
        //        frm.BaseIslemTuru = IslemTuru.EntityInsert;
        //        frm.Yukle();
        //        frm.ShowDialog();
        //    }
        //}
    }
}
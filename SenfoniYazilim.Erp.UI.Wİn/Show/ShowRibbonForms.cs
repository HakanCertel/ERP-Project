﻿using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Show
{
    public class ShowRibbonForms<TForm> where TForm:RibbonForm
    {
        public static void ShowForm(bool dialog, params object[] prm)
        {
            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);

            if (dialog)
                using (frm)
                    frm.ShowDialog();
            else
                frm.Show();
        }

        public static long ShowDialogForm(KartTuru kartTuru,params object[] prm)
        {
            if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return 0;

            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);

            using (frm)
            {
                frm.ShowDialog();
                return frm.DialogResult == DialogResult.OK ? (long)frm.Tag : 0;
            }
        }
    }
}

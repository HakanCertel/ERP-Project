using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SenfoniYazilim.Erp.Model.Dto;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Functions
{
    public static class FilterFunctions
    {
        public static Expression<Func<T,bool>> Filter<T>(bool aktifKartlariGoster) where T : BaseEntityDurum
        {
            return x => x.Durum == aktifKartlariGoster;
        }

        public static Expression<Func<T,bool>> Filter<T>(long id) where T : BaseEntity
        {
            return x => x.Id == id;
        }
        public static List<T> FiltreleDataSource<T>(this T entity, bool anaMibAl, GridView tablo, Expression<Func<T, bool>> filter) where T : IBaseHareketEntity
        {
            var source = tablo.DataController.ListSource.AsQueryable().Cast<T>();

            //if (!source.Any(filter)) return null;

            var filtreleneceklerList = source.Where(filter).ToList();
            if (anaMibAl)
                filtreleneceklerList.Add(entity);

            tablo.CustomRowFilter += Tablo_CustomRowFilter;
            tablo.RefreshData();
            tablo.CustomRowFilter -= Tablo_CustomRowFilter;

            void Tablo_CustomRowFilter(object sender, RowFilterEventArgs e)
            {
                var enty = source.ToList()[e.ListSourceRow];

                if (enty == null) return;

                if (!filtreleneceklerList.Contains(enty) || enty.Delete)
                {
                    e.Visible = false;
                    e.Handled = true;
                }
            }
            return filtreleneceklerList;
        }

        public static List<T> RefreshDataSource<T>(this GridView tablo, Expression<Func<T, bool>> filter) where T : IBaseHareketEntity
        {
            var source = tablo.DataController.ListSource.AsQueryable().Cast<T>();

            var filtreleneceklerList = source.Where(filter).ToList();

            tablo.CustomRowFilter += Tablo_CustomRowFilter;
            tablo.RefreshData();
            tablo.CustomRowFilter -= Tablo_CustomRowFilter;

            void Tablo_CustomRowFilter(object sender, RowFilterEventArgs e)
            {
                var enty = source.ToList()[e.ListSourceRow];

                if (enty == null) return;

                if (!filtreleneceklerList.Contains(enty) || enty.Delete)
                {
                    e.Visible = false;
                    e.Handled = true;
                }
            }
            return filtreleneceklerList;
        }

        public static void FiltreleDataSource<T>(this GridView tablo, List<T> list) where T : IBaseEntity
        {
            var source = tablo.DataController.ListSource.AsQueryable().Cast<T>();

            tablo.CustomRowFilter += Tablo_CustomRowFilter;
            tablo.RefreshData();
            tablo.CustomRowFilter -= Tablo_CustomRowFilter;

            void Tablo_CustomRowFilter(object sender, RowFilterEventArgs e)
            {
                var enty = source.ToList()[e.ListSourceRow];

                if (enty == null || list == null) return;

                if (!list.ToList().Contains(enty))
                {
                    e.Visible = false;
                    e.Handled = true;
                }
            }
        }
        public static List<T> FiltreleDataSource<T>(this GridView tablo, Expression<Func<T, bool>> filter) where T : IBaseEntity
        {
            var source = tablo.DataController.ListSource.AsQueryable().Cast<T>();

            if (!source.Any(filter)) return null;

            var filtreleneceklerList = source.Where(filter).ToList();

            tablo.CustomRowFilter += Tablo_CustomRowFilter;
            tablo.RefreshData();
            tablo.CustomRowFilter -= Tablo_CustomRowFilter;

            void Tablo_CustomRowFilter(object sender, RowFilterEventArgs e)
            {
                var enty = source.ToList()[e.ListSourceRow];

                if (enty == null) return;

                if (!filtreleneceklerList.Contains(enty))
                {
                    e.Visible = false;
                    e.Handled = true;
                }
            }

            return filtreleneceklerList;
        }
        public static void FiltreTemizleDataSource<T>(this GridView tablo) where T : BaseHareketEntity
        {
            var source = tablo.DataController.ListSource.Cast<T>().ToList();
            //var rowHandle = tablo.FocusedRowHandle;
            tablo.CustomRowFilter += Tablo_CustomRowFilter;
            tablo.RefreshData();
            tablo.CustomRowFilter -= Tablo_CustomRowFilter;
            tablo.RowFocus(0);

            void Tablo_CustomRowFilter(object sender, RowFilterEventArgs e)
            {
                for (int i = 0; i < source.Count; i++)
                {
                    var entity = source[e.ListSourceRow];
                    if (e.Visible) return;
                    e.Visible = true;
                    e.Handled = true;
                }
            }
        }
        public static void RefreshDataSource(this GridView tablo)
        {
            var source = tablo.DataController.ListSource.Cast<IBaseHareketEntity>().ToList();
            if (!source.Any(x => x.Delete)) return;
            var rowHandle = tablo.FocusedRowHandle;

            tablo.CustomRowFilter += Tablo_CustomRowFilter;
            tablo.RefreshData();
            tablo.CustomRowFilter -= Tablo_CustomRowFilter;
            tablo.RowFocus(rowHandle);

            void Tablo_CustomRowFilter(object sender, RowFilterEventArgs e)
            {
                var entity = source[e.ListSourceRow];
                if (entity == null) return;

                if (!entity.Delete) return;

                e.Visible = false;
                e.Handled = true;
            }
        }
        public static void FilterActiveRows(this GridView tablo)
        {
            var source = tablo.DataController.ListSource.Cast<BaseHareketEntity>().ToList();
            if (!source.Any(x => x.IsActive)) return;
            var rowHandle = tablo.FocusedRowHandle;

            tablo.CustomRowFilter += Tablo_CustomRowFilter;
            tablo.RefreshData();
            tablo.CustomRowFilter -= Tablo_CustomRowFilter;
            tablo.RowFocus(rowHandle);

            void Tablo_CustomRowFilter(object sender, RowFilterEventArgs e)
            {
                var entity = source[e.ListSourceRow];
                if (entity == null) return;

                if (entity.IsActive) return;

                e.Visible = false;
                e.Handled = true;
            }
        }
        public static List<MalzemeIhtiyacBilgileriL> FilterDataSourceCompositeBased(this MalzemeIhtiyacBilgileriL mib, GridView tablo)
        {
            var mrpBilgileriId = mib.MrpBilgileriId;
            var list = new List<MalzemeIhtiyacBilgileriL>();
            var stokId = mib.StokId;

            Cursor.Current = Cursors.WaitCursor;

            var yigin = new StackFunction(50, 500);

            void ListeleDoldur(MalzemeIhtiyacBilgileriL row,  int mrpBilgiId)
            {
                var mrpReceteBilgileri = row.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(false, tablo, x => x.MrpBilgileriId == row.MrpBilgileriId && x.BagliOlduguUstReceteStokKodu == row.StokKodu);

                if (mrpReceteBilgileri == null) return;
                list.AddRange(mrpReceteBilgileri);

                foreach (var mrpMib in mrpReceteBilgileri)
                {
                    if (mrpMib.OperasyonSeviyesi > 0) continue;

                    if (mrpMib.Uretim&& mrpMib.StokKodu!=row.StokKodu)
                    {
                        yigin.PushEntity(mrpMib);
                        yigin.PushIndex();
                    }
                }

                while (!yigin.EmptyIndex())
                {
                    yigin.PopIndex();
                    var altEntity = (MalzemeIhtiyacBilgileriL)yigin.PopEntity();
                    if (altEntity == null) continue;
                    ListeleDoldur(altEntity,  mrpBilgiId);
                }
            }

            var source = mib.FiltreleDataSource<MalzemeIhtiyacBilgileriL>(true, tablo, x => x.MrpBilgileriId == mib.MrpBilgileriId && x.BagliOlduguUstReceteStokKodu == mib.StokKodu);
            var anaRow = mib;

            if (source == null || source.Count <= 0) return null;

            list.AddRange(source);
            foreach (var rowMib in source)
            {
                if (rowMib.OperasyonSeviyesi > 0) continue;

                if (rowMib.Uretim && rowMib.StokKodu != anaRow.StokKodu)
                {
                    ListeleDoldur(rowMib, mrpBilgileriId);
                }
            }

            Cursor.Current = Cursors.Default;
            return list;
        }

    }
}

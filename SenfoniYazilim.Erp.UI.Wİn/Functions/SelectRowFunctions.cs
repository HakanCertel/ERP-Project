using SenfoniYazilim.Erp.Model.Entities.Base;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SenfoniYazilim.Erp.UI.Wİn.Functions
{
    public class SelectRowFunctions
    {
        private GridView _tablo;
        private GridColumn _column;
        private readonly IList<BaseEntity> _selectedRows;
        private RepositoryItemCheckEdit _checkEdit;

        public SelectRowFunctions(GridView tablo)
        {
            _tablo = tablo;
            _selectedRows = new List<BaseEntity>();
            //_checkEdit = new RepositoryItemCheckEdit();

            RemoveEvents();
            AddEvents(tablo);
        }

        private void Update()
        {
            _tablo.BeginUpdate();
            _tablo.EndUpdate();
        }

        private void SelectRow(int rowHandle, bool select)
        {
            if (IsRowSelected(rowHandle) == select) return;
            
            var row = _tablo.GetRow<BaseEntity>(rowHandle);

            if (select)
                _selectedRows.Add(row);
            else
                _selectedRows.Remove(row);

            Update();
        }
        private void AddEvents(GridView tablo)
        {
            if (tablo == null) return;

            _selectedRows.Clear();
            _tablo = tablo;

            _checkEdit = (RepositoryItemCheckEdit)_tablo.GridControl.RepositoryItems.Add("CheckEdit");
            _column = _tablo.Columns.Add();
            _column.OptionsColumn.AllowSort = DefaultBoolean.False;
            _column.Visible = true;
            _column.VisibleIndex = 0;
            _column.FieldName = "Secim";
            _column.OptionsColumn.ShowCaption = false;
            _column.OptionsColumn.AllowSize = false;
            _column.OptionsColumn.AllowEdit = false;
            _column.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            _column.OptionsColumn.FixedWidth = true;
            _column.Width = 35;
            _column.ColumnEdit = _checkEdit;
            _tablo.FocusedColumn = _column;

            if (_tablo is BandedGridView bView)
            {
                bView.Bands["bndSecim"].Visible = true;
                bView.Bands["bndSecim"].VisibleIndex = 0;
                bView.Bands["bndSecim"].Columns.Add((BandedGridColumn)_column);
            }

            _tablo.Click += Tablo_Click;
            _tablo.DoubleClick += Tablo_DoubleClick;
            _tablo.CustomDrawColumnHeader += Tablo_CustomDrawColumnHeader;
            _tablo.CustomUnboundColumnData += Tablo_CustomUnboundColumnData;
            _tablo.KeyDown += Tablo_KeyDown;
            _tablo.RowStyle += Tablo_RowStyle;
        }


        private void RemoveEvents()
        {
            if (_tablo == null) return;
            _column?.Dispose();

            if (_checkEdit != null)
            {
                _tablo.GridControl.RepositoryItems.Remove(_checkEdit);

                _checkEdit.Dispose();
            }

            _tablo.Click -= Tablo_Click;
            _tablo.DoubleClick -= Tablo_DoubleClick;
            _tablo.CustomDrawColumnHeader -= Tablo_CustomDrawColumnHeader;
            _tablo.CustomUnboundColumnData -= Tablo_CustomUnboundColumnData;
            _tablo.KeyDown -= Tablo_KeyDown;
            _tablo.RowStyle -= Tablo_RowStyle;

            _tablo = null;
        }

        private void CheckBoxEkle(GraphicsCache cache, Rectangle r, bool check)
        {
            var info = (CheckEditViewInfo)_checkEdit.CreateViewInfo();
            var painter = (CheckEditPainter)_checkEdit.CreatePainter();
            if (info == null) return;
            info.EditValue = check;
            info.Bounds = r;
            info.CalcViewInfo(cache.Graphics);
            var arg = new ControlGraphicsInfoArgs(info, cache, r);
            painter?.Draw(arg);
        }
        public int SelectedRowCount => _selectedRows.Count;
        
        public IList<BaseEntity> GetSelectedRows()
        {
            return _selectedRows;
        }

        public int GetSelectedRowIndex(BaseEntity row)
        {
            return _selectedRows.IndexOf(row);
        }

        public bool IsRowSelected(int rowHandle)
        {
            var row = (BaseEntity)_tablo.GetRow(rowHandle);
            //row1=(BaseEntity)_tablo.GetRow(rowHandle);

            return GetSelectedRowIndex(row) > -1;
        }

        public void SelectAll()
        {
            _selectedRows.Clear();

            for (int i = 0; i < _tablo.DataRowCount; i++)
            _selectedRows.Add(_tablo.GetRow<BaseEntity>(i));

            Update();
        }       
       
        public void ClearSelection()
        {
            _selectedRows.Clear();
            Update();
        }       

        public void RowSelection(int rowHandle)
        {
            if (!_tablo.IsDataRow(rowHandle)) return;

            SelectRow(rowHandle, !IsRowSelected(rowHandle));
        }        

        private void Tablo_Click(object sender, EventArgs e)
        {
            var point = _tablo.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = _tablo.CalcHitInfo(point);//maousen tıklandığı yer ile ilgili bilgi dönderir..

            if (info.Column == _column)
            {
                if (info.InColumn)//tıklanılan yerin kolonun başlığı olup olmadığını dönderir
                {
                    //Başlık çubuğuna tıklandığında eğer bütün satırlar seçili ise seçimleri kaldır, yoksa hepsini seç
                    if (SelectedRowCount == _tablo.DataRowCount)
                        ClearSelection();
                    else
                        SelectAll();
                }
                else if (info.InRowCell)//tıklanan o kolona ait bir hücre ise aşağıdaki fonksiyonu çaılştır.
                    RowSelection(info.RowHandle);
            }
            //else if (info.InRow)//tabloda seçili olan alan row ise ilgili row un check baox ını seçili hale getir.
            //    RowSelection(info.RowHandle);
        }
        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            RowSelection(_tablo.FocusedRowHandle);
        }

        private void Tablo_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != _column) return;

            e.Info.InnerElements.Clear();// bu ilgili kolonumuz ile ilgili kolon başlığındaki bütün elementleri,buton vb gibi, temizlenmesini yani görünür olmaktan çıkarmamızı sağlıyor.
            e.Painter.DrawObject(e.Info);
            CheckBoxEkle(e.Cache,e.Bounds,SelectedRowCount==_tablo.DataRowCount);
            e.Handled = true;
        }
        private void Tablo_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column != _column) return;
            e.Value = IsRowSelected(_tablo.GetRowHandle(e.ListSourceRowIndex));
        }

        private void Tablo_KeyDown(object sender,KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space) return;
            RowSelection(_tablo.FocusedRowHandle);
        }

        private void Tablo_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (!IsRowSelected(e.RowHandle)) return;
            e.Appearance.BackColor = SystemColors.Highlight;
            e.Appearance.ForeColor = SystemColors.HighlightText;
        }
    }
    public class SelectRowFunctionsBaseHareketEntity
    {
        private GridView _tablo;
        private GridColumn _column;
        private readonly IList<BaseHareketEntity> _selectedRows;
        private RepositoryItemCheckEdit _checkEdit;

        public SelectRowFunctionsBaseHareketEntity(GridView tablo)
        {
            _tablo = tablo;
            _selectedRows = new List<BaseHareketEntity>();
            //_checkEdit = new RepositoryItemCheckEdit();

            RemoveEvents();
            AddEvents(tablo);
        }

        private void Update()
        {
            _tablo.BeginUpdate();
            _tablo.EndUpdate();
        }

        private void SelectRow(int rowHandle, bool select)
        {
            if (IsRowSelected(rowHandle) == select) return;

            var row = _tablo.GetRow<BaseHareketEntity>(rowHandle);

            if (select)
                _selectedRows.Add(row);
            else
                _selectedRows.Remove(row);

            Update();
        }
        private void AddEvents(GridView tablo)
        {
            if (tablo == null) return;

            _selectedRows.Clear();
            _tablo = tablo;

            _checkEdit = (RepositoryItemCheckEdit)_tablo.GridControl.RepositoryItems.Add("CheckEdit");
            _column = _tablo.Columns.Add();
            _column.OptionsColumn.AllowSort = DefaultBoolean.False;
            _column.Visible = true;
            _column.VisibleIndex = 0;
            _column.FieldName = "Secim";
            _column.OptionsColumn.ShowCaption = false;
            _column.OptionsColumn.AllowSize = false;
            _column.OptionsColumn.AllowEdit = false;
            _column.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            _column.OptionsColumn.FixedWidth = true;
            _column.Width = 35;
            _column.ColumnEdit = _checkEdit;
            _tablo.FocusedColumn = _column;

            if (_tablo is BandedGridView bView)
            {
                bView.Bands["bndSecim"].Visible = true;
                bView.Bands["bndSecim"].VisibleIndex = 0;
                bView.Bands["bndSecim"].Columns.Add((BandedGridColumn)_column);
            }

            _tablo.Click += Tablo_Click;
            _tablo.DoubleClick += Tablo_DoubleClick;
            _tablo.CustomDrawColumnHeader += Tablo_CustomDrawColumnHeader;
            _tablo.CustomUnboundColumnData += Tablo_CustomUnboundColumnData;
            _tablo.KeyDown += Tablo_KeyDown;
            _tablo.RowStyle += Tablo_RowStyle;
        }


        private void RemoveEvents()
        {
            if (_tablo == null) return;
            _column?.Dispose();

            if (_checkEdit != null)
            {
                _tablo.GridControl.RepositoryItems.Remove(_checkEdit);

                _checkEdit.Dispose();
            }

            _tablo.Click -= Tablo_Click;
            _tablo.DoubleClick -= Tablo_DoubleClick;
            _tablo.CustomDrawColumnHeader -= Tablo_CustomDrawColumnHeader;
            _tablo.CustomUnboundColumnData -= Tablo_CustomUnboundColumnData;
            _tablo.KeyDown -= Tablo_KeyDown;
            _tablo.RowStyle -= Tablo_RowStyle;

            _tablo = null;
        }

        private void CheckBoxEkle(GraphicsCache cache, Rectangle r, bool check)
        {
            var info = (CheckEditViewInfo)_checkEdit.CreateViewInfo();
            var painter = (CheckEditPainter)_checkEdit.CreatePainter();
            if (info == null) return;
            info.EditValue = check;
            info.Bounds = r;
            info.CalcViewInfo(cache.Graphics);
            var arg = new ControlGraphicsInfoArgs(info, cache, r);
            painter?.Draw(arg);
        }
        public int SelectedRowCount => _selectedRows.Count;

        public IList<BaseHareketEntity> GetSelectedRows()
        {
            return _selectedRows;
        }

        public int GetSelectedRowIndex(BaseHareketEntity row)
        {
            return _selectedRows.IndexOf(row);
        }

        public bool IsRowSelected(int rowHandle)
        {
            var row = (BaseHareketEntity)_tablo.GetRow(rowHandle);
            //row1=(BaseEntity)_tablo.GetRow(rowHandle);

            return GetSelectedRowIndex(row) > -1;
        }

        public void SelectAll()
        {
            _selectedRows.Clear();

            for (int i = 0; i < _tablo.DataRowCount; i++)
                _selectedRows.Add(_tablo.GetRow<BaseHareketEntity>(i));

            Update();
        }

        public void ClearSelection()
        {
            _selectedRows.Clear();
            Update();
        }

        public void RowSelection(int rowHandle)
        {
            if (!_tablo.IsDataRow(rowHandle)) return;

            SelectRow(rowHandle, !IsRowSelected(rowHandle));
        }

        private void Tablo_Click(object sender, EventArgs e)
        {
            var point = _tablo.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo info = _tablo.CalcHitInfo(point);//maousen tıklandığı yer ile ilgili bilgi dönderir..

            if (info.Column == _column)
            {
                if (info.InColumn)//tıklanılan yerin kolonun başlığı olup olmadığını dönderir
                {
                    //Başlık çubuğuna tıklandığında eğer bütün satırlar seçili ise seçimleri kaldır, yoksa hepsini seç
                    if (SelectedRowCount == _tablo.DataRowCount)
                        ClearSelection();
                    else
                        SelectAll();
                }
                else if (info.InRowCell)//tıklanan o kolona ait bir hücre ise aşağıdaki fonksiyonu çaılştır.
                    RowSelection(info.RowHandle);
            }
            //else if (info.InRow)//tabloda seçili olan alan row ise ilgili row un check baox ını seçili hale getir.
            //    RowSelection(info.RowHandle);
        }
        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            //RowSelection(_tablo.FocusedRowHandle);
        }

        private void Tablo_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column != _column) return;

            e.Info.InnerElements.Clear();// bu ilgili kolonumuz ile ilgili kolon başlığındaki bütün elementleri,buton vb gibi, temizlenmesini yani görünür olmaktan çıkarmamızı sağlıyor.
            e.Painter.DrawObject(e.Info);
            CheckBoxEkle(e.Cache, e.Bounds, SelectedRowCount == _tablo.DataRowCount);
            e.Handled = true;
        }
        private void Tablo_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column != _column) return;
            e.Value = IsRowSelected(_tablo.GetRowHandle(e.ListSourceRowIndex));
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space) return;
            RowSelection(_tablo.FocusedRowHandle);
        }

        private void Tablo_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (!IsRowSelected(e.RowHandle)) return;
            e.Appearance.BackColor = SystemColors.Highlight;
            e.Appearance.ForeColor = SystemColors.HighlightText;
        }
    }
}

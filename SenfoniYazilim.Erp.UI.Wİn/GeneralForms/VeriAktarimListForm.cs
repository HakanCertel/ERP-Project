using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SenfoniYazilim.Erp.UI.Wİn.Forms.BaseForms;
using SenfoniYazilim.Erp.UI.Wİn.Forms.UserControls.Controls;
using System.IO;
using ExcelDataReader;
using SenfoniYazilim.Erp.UI.Wİn.Functions;
using System.Collections.Generic;
using SenfoniYazilim.Erp.Model.Entities.Base;
using SenfoniYazilim.Erp.Model.Entities.Base.Interfaces;
using System.Linq;
using System.Reflection;
using SenfoniYazilim.Erp.Bll.Functions.Converts;
using SenfoniYazilim.Erp.Model.Entities;

namespace SenfoniYazilim.Erp.UI.Wİn.GeneralForms
{
    public partial class VeriAktarimListForm : BaseListForm
    {
        
        DataTableCollection tableCollection;
        IEnumerable<object> list=new List<object>() ;
        object _filter;
        public VeriAktarimListForm(params object[] prm)
        {
            InitializeComponent();
            //_list = prm[0];
            _filter = prm[0];
            HideItems = new DevExpress.XtraBars.BarItem[] {barDelete,barDeleteAciklama,barDuzelt,barDuzeltAciklama,barEnter,
                        barEnterAciklama,barFiltrele,barFiltreleAciklama,barGonder,barGonderAciklama,barKolonlar,barKolonlarAciklama,
                         barYazdir,barYazdirAciklama,barYeni,barYeniAciklama,btnAktifPasifKartlar,btnBagliKarlar,btnYeni,btnYazdir,btnSil,btnGonder,btnDuzelt};
            foreach (var control in panelControl.Controls)
            {
                switch (control)
                {
                    case MyButtonEdit btn:
                        btn.Click += Btn_Click; ;
                        btn.EditValueChanged += Btn_EditValueChanged;
                        break;
                    case MySimpleButton btn:
                        btn.Click += Btn_Click;
                        break;
                    case ComboBoxEdit edt:
                        edt.SelectedValueChanged += ComboEdt_SelectedValueChanged;
                        break;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (sender ==txtDosyaAdi)
                DosyaYukle();
            else if (sender ==txtKaydet)
                Kaydet((List<object>)list);
        }

        private void Btn_EditValueChanged(object sender, EventArgs e)
        {
            if (sender == txtDosyaAdi)
                txtWorkSheet.SelectedItem = null; ;
        }
        private void ComboEdt_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sender == txtWorkSheet)
            {
                if(txtWorkSheet.SelectedItem==null)
                    Tablo.GridControl.DataSource = null;
                else
                {
                    Tablo.GridControl.DataSource = null;
                    TabloDoldur();
                }
                    
            }

        }
        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            Navigator = longNavigator1.Navigator;
        }
        private void DosyaYukle()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDosyaAdi.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            txtWorkSheet.Properties.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                txtWorkSheet.Properties.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }
        private void TabloDoldur()
        {
            
            Cursor.Current = Cursors.WaitCursor;

            DataTable dt = tableCollection[txtWorkSheet.SelectedItem.ToString()];
            List<string> columnNames = new List<string>();
            for (int i = 0; i <dt.Columns.Count ; i++)
            {
                columnNames.Add(dt.Columns[i].ColumnName);
            }
            ((List<object>)list).Clear();

            object _entity;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                using (var nesne = new Nesne())
                {
                    
                    var entityy = nesne.Uret(TypeofEntity);
                    var entity = Convert.ChangeType(entityy, TypeofEntity);
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        var hedefProp = entity.GetType().GetProperties();
                        foreach (var property in hedefProp)
                        {
                            if (property.PropertyType.Namespace == "System.Collections.Generic") continue;
                            var row = dt.Rows[i][j];
                            var lkh = columnNames.Contains(property.Name);
                            //if (property.Name == dt.Columns[property.Name].ColumnName)
                                property.SetValue(entity, columnNames.Contains(property.Name) ? dt.Rows[i][property.Name].Converts(property):null);
                            
                        }
                    }
                    _entity = entity;
                }
             
                ((List<object>)list).Add(_entity); 
            }

            Cursor.Current = Cursors.Default;

            Tablo.GridControl.DataSource = list;
            
        }

        private void Kaydet(List<object> list)
        {
            int kayitSyisi = 0;
            var blltype = TypeofBll.Assembly.GetType("StokBll");
            var blltypes = TypeofBll.Assembly.GetTypes();
            List<object> kayitEdilenList = new List<object>();
            foreach (var item in blltypes)
            {
                if (item.Name == TypeofBll.Name)
                {
                    int x = 0;
                    var ci = item.GetConstructors();
                    foreach (var c in ci)
                    {
                        
                        if (c.GetParameters().Length == 0)
                        {
                            object reflectOb = new object();
                            reflectOb = ci[x].Invoke(null);

                            foreach (var m in item.GetMethods())
                            {
                                Cursor.Current = Cursors.WaitCursor;

                                if(m.Name.CompareTo("Insert") == 0|| m.Name.CompareTo("Update") == 0)
                                    Insert(reflectOb, m);
                                Cursor.Current = Cursors.Default;

                                //MessageBox.Show($"{kayitSyisi} Adet Kayıt Oluşturuldu .");
                                //break;
                            }
                        }
                    }
                    break;
                }
            }
            Tablo.GridControl.DataSource = kayitEdilenList;
            Tablo.ViewCaption = "Veri Tabanına Aktarılan Kayıtlar";
        }
        private void Insert(object reflectOb, MethodInfo m) 
        {
            int kayitSyisi = 0;
            List<object> kayitEdilenList = new List<object>();
            
            void Kaydet(IBaseEntity currentEntity,IBaseEntity oldEntity)
            {
                if (oldEntity == null)
                {
                    object[] baseEntity = new object[1];

                    baseEntity[0] = currentEntity;
                    var sdlfkj = m.Invoke(reflectOb, baseEntity);
                    kayitEdilenList.Add(currentEntity);
                }
                else
                {
                    object[] baseEntity = new object[2];

                    baseEntity[1] = currentEntity;
                    baseEntity[0] =oldEntity;

                    var sdlfkj = m.Invoke(reflectOb, baseEntity);
                    kayitEdilenList.Add(currentEntity);
                }
               
            }

            if (typeof(BaseEntityDurum) == TypeofEntity.BaseType)
            {
                var entities = list.ToList().Cast<BaseEntityDurum>().ToList();
                var sendEntitiess = SendEntities.Cast<BaseEntityDurum>().Select(y => y.Id).ToList();

                var insertList = entities.Where(y => !sendEntitiess.Contains(y.Id)).ToList();
                var updateList = entities.Where(y => sendEntitiess.Contains(y.Id)).ToList();
                if (m.Name.CompareTo("Insert") == 0)
                    insertList.ForEach(x =>{ Kaydet(x,null); });
                if (m.Name.CompareTo("Update") == 0&&m.GetParameters().Length<3)
                    updateList.ForEach(x => 
                    {
                        var oldEntity = SendEntities.Cast<BaseEntityDurum>().Where(y => y.Id == x.Id).FirstOrDefault().EntityCovert<Recete>();
                        Kaydet(x,oldEntity);
                    });
            }
            else if (typeof(BaseEntity) == TypeofEntity.BaseType)
            {
                var entities = list.ToList().Cast<BaseEntityDurum>().ToList();
                var sendEntitiess = SendEntities.Cast<BaseEntityDurum>().Select(y => y.Id).ToList();

                var insertList = entities.Where(y => !sendEntitiess.Contains(y.Id)).ToList();
                var updateList = entities.Where(y => sendEntitiess.Contains(y.Id)).ToList();
                if (m.Name.CompareTo("Insert") == 0) { }
                    //insertList.ForEach(x => { Kaydet(x); });
                else if (m.Name.CompareTo("Update") == 0) { }
                    //updateList.ForEach(x => { Kaydet(x); });
            }
            else if (typeof(BaseHareketEntity) == TypeofEntity.BaseType)
            {
                var entities = list.ToList().Cast<BaseHareketEntity>().ToList();
                var sendEntitiess = SendEntities.Cast<BaseHareketEntity>().Select(y => y.Id).ToList();

                var insertList = entities.Where(y => !sendEntitiess.Contains(y.Id)).ToList();
                var updateList = entities.Where(y => sendEntitiess.Contains(y.Id)).ToList();

                object[] baseEntity = new object[1];

                if (m.Name.CompareTo("Update") == 0)
                    baseEntity[0] = updateList;
                else if (m.Name.CompareTo("Insert") == 0)
                    baseEntity[0] = insertList;
                if (baseEntity == null) return;

                var dlfksdf=m.Invoke(reflectOb, baseEntity);

            }

            //MessageBox.Show($"{kayitSyisi} Adet Kayıt Oluşturuldu .");
        }
        private void Guncelle(List<object> list)
        {
            int kayitSyisi = 0;
            var blltype = TypeofBll.Assembly.GetType("StokBll");
            var blltypes = TypeofBll.Assembly.GetTypes();
            List<object> kayitEdilenList = new List<object>();
            foreach (var item in blltypes)
            {
                if (item.Name == TypeofBll.Name)
                {
                    int x = 0;
                    var ci = item.GetConstructors();
                    foreach (var c in ci)
                    {

                        if (c.GetParameters().Length == 0)
                        {
                            object reflectOb = new object();
                            reflectOb = ci[x].Invoke(null);

                            foreach (var m in item.GetMethods())
                            {
                                Cursor.Current = Cursors.WaitCursor;

                                if (m.Name.CompareTo("Update") == 0)
                                {
                                    void Update(IBaseEntity entity)
                                    {
                                        object[] baseEntity = new object[1];
                                        baseEntity[0] = entity;
                                        m.Invoke(reflectOb, baseEntity);
                                        kayitSyisi++;
                                        kayitEdilenList.Add(entity);
                                    }
                                    if (typeof(BaseEntityDurum) == TypeofEntity.BaseType)
                                    {
                                        var entities = list.ToList().Cast<BaseEntityDurum>().ToList();
                                        var sendEntities = SendEntities.Cast<BaseEntityDurum>().ToList();
                                        entities.Select(y => y.Id).ToList().Except(sendEntities.Select(y => y.Id)).ToList().ForEach(y =>
                                        {
                                            var nesss = entities.Where(z => z.Id == y).Select(z => z).FirstOrDefault();
                                            Update(nesss);
                                        });
                                    }
                                    else if (typeof(BaseEntity) == TypeofEntity.BaseType)
                                    {
                                        var entities = list.ToList().Cast<BaseEntity>().ToList();
                                        var sendEntities = SendEntities.Cast<BaseEntity>().ToList();
                                        entities.Select(y => y.Id).ToList().Except(sendEntities.Select(y => y.Id)).ToList().ForEach(y =>
                                        {
                                            var nesss = entities.Where(z => z.Id == y).Select(z => z).FirstOrDefault();
                                            Update(nesss);
                                        });
                                    }
                                    else if (typeof(BaseHareketEntity) == TypeofEntity.BaseType)
                                    {
                                        var entities = list.ToList().Cast<BaseHareketEntity>().ToList();
                                        var sendEntities = SendEntities.Cast<BaseHareketEntity>().ToList();
                                        entities.Select(y => y.Id).ToList().Except(sendEntities.Select(y => y.Id)).ToList().ForEach(y =>
                                        {
                                            var nesss = entities.Where(z => z.Id == y).Select(z => z).FirstOrDefault();
                                            kayitEdilenList.Add(nesss);
                                            kayitSyisi++;
                                        });
                                        object[] baseEntity = new object[1];
                                        baseEntity[0] = kayitEdilenList.Cast<BaseHareketEntity>().ToList();
                                        m.Invoke(reflectOb, baseEntity);

                                    }

                                    Cursor.Current = Cursors.Default;

                                    MessageBox.Show($"{kayitSyisi} Adet Kayıt Oluşturuldu .");
                                    break;
                                }
                            }
                        }
                    }
                    break;
                }
            }
            Tablo.GridControl.DataSource = kayitEdilenList;
            Tablo.ViewCaption = "Veri Tabanına Aktarılan Kayıtlar";
        }
    }

    public class Nesne:IDisposable
    {    

        public object Uret(Type type)
        {
            object nesne = Activator.CreateInstance(type);
            return nesne;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

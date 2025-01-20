using SenfoniYazilim.Erp.Common.Enums;
using SenfoniYazilim.Erp.Common.Message;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace SenfoniYazilim.Erp.UI.Wİn.Functions
{
    public static class FileFunctions
    {
        public static void FormSablonKaydet(this string sablonAdi,int left,int top,int width,int height, FormWindowState windowstate)
        {
            try
            {
                if(!Directory.Exists(Application.StartupPath +@"\Şablon Dosyaları"))
                    Directory.CreateDirectory(Application.StartupPath + @"\Şablon Dosyaları");

                var setting = new XmlWriterSettings { Indent = true };
                var writer = XmlWriter.Create(Application.StartupPath + $@"\Şablon Dosyaları\{sablonAdi}_location.xml", setting);
                writer.WriteStartDocument();
                writer.WriteComment("Abc Yazılım Tarafından oluşturuldu.");
                writer.WriteStartElement("Tablo");
                writer.WriteStartElement("Location");
                writer.WriteAttributeString("left", left.ToString());
                writer.WriteAttributeString("top", top.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("FormSize");
                if(windowstate==FormWindowState.Maximized)
                {
                    writer.WriteAttributeString("width","-1");
                    writer.WriteAttributeString("height", "-1");
                }
                else
                {
                    writer.WriteAttributeString("width", width.ToString());
                    writer.WriteAttributeString("height", height.ToString());
                }

                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();// bununla xml dosyası oluşturulmuş oldu.
                writer.Close();
            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }
        }

        public static void FormSablonYukle(this string sablonAdi,XtraForm frm)
        {
            var list = new List<string>();

            try
            {
                if (File.Exists(Application.StartupPath + $@"\Şablon Dosyaları\{ sablonAdi}_location.xml"))
                {
                    var reader = XmlReader.Create(Application.StartupPath + $@"\Şablon Dosyaları\{sablonAdi}_location.xml");

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Location")
                        {
                            list.Add(reader.GetAttribute(0));
                            list.Add(reader.GetAttribute(1));
                        }

                        else if (reader.NodeType == XmlNodeType.Element && reader.Name == "FormSize")
                        {
                            list.Add(reader.GetAttribute(0));
                            list.Add(reader.GetAttribute(1));
                        }
                    }

                    reader.Close();
                    reader.Dispose();
                }

            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }

            if (list.Count <= 0) return;

            frm.Location = new System.Drawing.Point(int.Parse(list[0]), int.Parse(list[1]));

            if (list[2] == "-1" && list[3] == "-1")
                frm.WindowState = FormWindowState.Maximized;
            else
                frm.Size = new System.Drawing.Size(int.Parse(list[2]), int.Parse(list[3]));

        }

        public static void TabloSablonKaydet(this GridView tablo,string sablonAdi)
        {
            try
            {
                tablo.ClearColumnsFilter();//bu kodla bazen tablo kolonlarına uygulanmış olan filtreler olabilmektedir ve bu şablonlar
                                           // tablolarımız her açılıp kapandığında kaydedileceği için kolonun filtreli birşekilde şablona 
                                           //kaydedilmemesini istiyoruz,buyüzden tablo filtrelerini temizliyoruz.
                if (!Directory.Exists(Application.StartupPath + @"\Şablon Dosyaları"))
                    Directory.CreateDirectory(Application.StartupPath + @"\Şablon Dosyaları");

                tablo.SaveLayoutToXml(Application.StartupPath + $@"\Şablon Dosyaları\{sablonAdi}.xml");
            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }
        }

        public static void TabloSablonYukle(this GridView tablo,string sablonAdi)
        {
            try
            {
                if(File.Exists(Application.StartupPath + $@"\Şablon Dosyaları\{ sablonAdi}.xml"))
                    tablo.RestoreLayoutFromXml(Application.StartupPath + $@"\Şablon Dosyaları\{ sablonAdi}.xml");
            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
            }
        }

        public static void TabloDisariAktar(this GridView tablo,DosyaTuru dosyaTuru,string dosyaFormati,string excelSayfaAdi = null)
        {
            if (Messages.TabloExporMesaj(dosyaFormati) != DialogResult.Yes) return;

            if (!Directory.Exists(Application.StartupPath + @"\Temp"))
                Directory.CreateDirectory(Application.StartupPath + @"\Temp");

            var dosyaAdi = Guid.NewGuid().ToString();
            var filePath = $@"{Application.StartupPath}\Temp\{dosyaAdi}";

            switch (dosyaTuru)
            {
                case DosyaTuru.ExcelStandart:
                    {
                        var opt = new XlsxExportOptionsEx
                        {
                            ExportType = DevExpress.Export.ExportType.Default,
                            SheetName = excelSayfaAdi,
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".Xlsx";
                        tablo.ExportToXlsx(filePath, opt);
                    }
                    break;
                case DosyaTuru.ExcelFormatli:
                    {
                        var opt = new XlsxExportOptionsEx
                        {
                            ExportType = DevExpress.Export.ExportType.WYSIWYG,
                            SheetName = excelSayfaAdi,
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".Xlsx";
                        tablo.ExportToXlsx(filePath, opt);
                    }
                    break;
                case DosyaTuru.ExcelFormatsiz:
                    {
                        var opt = new CsvExportOptionsEx
                        {
                            ExportType = DevExpress.Export.ExportType.WYSIWYG,
                            TextExportMode = TextExportMode.Text
                        };

                        filePath = filePath + ".Csv";
                        tablo.ExportToCsv(filePath, opt);
                    }
                    break;
                case DosyaTuru.WordDosyası:
                    {
                        filePath = filePath + ".Rtf";
                        tablo.ExportToRtf(filePath);
                    }
                    break;
                case DosyaTuru.PdfDosyası:
                    {
                        filePath = filePath + ".Pdf";
                        tablo.ExportToPdf(filePath);
                    }
                    break;
                case DosyaTuru.TxtDosyası:
                    {
                        var opt = new TextExportOptions {TextExportMode = TextExportMode.Text};

                        filePath = filePath + ".Txt";
                        tablo.ExportToText(filePath, opt);
                    }
                    break;
            }

            if (!File.Exists(filePath))
            {
                Messages.HataMesaji("Tablo Verileri Dosyaya Aktarılamadı");
            }

            Process.Start(filePath);
        }
    }
}

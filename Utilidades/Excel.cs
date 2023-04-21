using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFExploraSP.Utilidades
{
    public class Excel
    {
        #region Constructor

        public Excel() { }

        public Excel(string path) 
        {
            _rutaOrigen = path;
        }

        #endregion

        #region Propiedades

        private string _rutaOrigen = string.Empty;

        private string _rutaDestino = string.Empty;

        private List<string> _hojas = new List<string>();

        private int _rowCell = 1;

        private int _columnCell = 1;

        public string RutaExcel 
        {
            set { _rutaOrigen = value; }
            get { return _rutaOrigen; }
        }
        
        private IExcelDataReader excelReader = null;

        private FileStream stream = null;

        #endregion

        #region Metodos

        private void abrirExcel()
        {
            try
            {
                if (File.Exists(_rutaOrigen))
                {

                    stream = File.Open(_rutaOrigen, FileMode.Open, FileAccess.Read);

                    switch (System.IO.Path.GetExtension(_rutaOrigen))
                    {
                        case ".xls":
                            excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                            break;
                        case ".xlsx":
                            excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception e) { }
        }

        private void cerrarExcel()
        {
            try
            {
                stream = null;
                if (excelReader != null)
                {
                    excelReader.Dispose();
                    excelReader.Close();
                    excelReader = null;
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                GC.Collect();
            }
        }

        public List<string> listadoHojas()
        {
            List<string> list = new List<string>();
            abrirExcel();

            cerrarExcel();
            return list;
        }

        public DataTable obtenerDatos(string hoja)
        {
            DataTable tbl = new DataTable();
            abrirExcel();

            cerrarExcel();
            return tbl;
        }

        #endregion

        //public void generarExcel(DataTable tbl)
        //{
        //    RowCell = 1;

        //    int columns = tbl.Columns.Count, rows = tbl.Rows.Count;
        //    Msg = string.Empty;
        //    ExcelPackage exl = new ExcelPackage();
        //    exl.Workbook.Worksheets.Add(Hoja);
        //    ExcelWorksheet sheet = exl.Workbook.Worksheets[1];

        //    if (tbl != null)
        //    {
        //        ColumnCell = 1;
        //        for (int i = 0; i < columns; i++)
        //        {
        //            string aa = tbl.Columns[i].ColumnName;
        //            sheet.Cells[RowCell, ColumnCell].Value = aa;
        //            sheet.Column(ColumnCell).AutoFit();
        //            ColumnCell++;
        //        }

        //        RowCell++;

        //        foreach (DataRow it in tbl.Rows)
        //        {
        //            ColumnCell = 1;
        //            for (int a = 0; a < columns; a++)
        //            {
        //                string tt = it[a].ToString();
        //                sheet.Cells[RowCell, ColumnCell].Value = tt;
        //                ColumnCell++;
        //            }

        //            RowCell++;
        //        }
        //    }

        //    if (!Directory.Exists(Path))
        //    {
        //        Directory.CreateDirectory(Path);
        //    }
        //    exl.SaveAs(new FileInfo(Path + Nombre + ".xlsx"));

        //}

        

        


        public IEnumerable<List<object>> GetRow(int columns)
        {
            bool flag = false;
            while (excelReader.Read())
            {
                List<object> vals = new List<object>();
                if (flag)
                {
                    for (int i = 0; i < columns; i++)
                    {
                        vals.Add(excelReader[i]);
                    }
                    yield return vals;
                }
                flag = true;
            }
        }

        
    }

}

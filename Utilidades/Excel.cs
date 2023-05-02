using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel; // Para archivos de Excel 2007 o posteriores
// using NPOI.HSSF.UserModel; // Para archivos de Excel anteriores a 2007
using NPOI.SS.Util;
using System.IO;
using NPOI.HSSF.UserModel;
using System.Reflection.Metadata;

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
        

        #endregion

        #region Metodos

        public List<string> listadoHojas()
        {
            List<string> list = new List<string>();
            // Crea un objeto FileStream del archivo
            using (var fileStream = new FileStream(_rutaOrigen, FileMode.Open, FileAccess.Read))
            {
                IWorkbook workbook = new HSSFWorkbook();
                if (File.Exists(_rutaOrigen))
                {
                    switch (Path.GetExtension(_rutaOrigen))
                    {
                        case ".xls":
                            workbook = new HSSFWorkbook(fileStream); // Para archivos de Excel anteriores a 2007
                            break;
                        case ".xlsx":
                            workbook = new XSSFWorkbook(fileStream); // Para archivos de Excel 2007 o posteriores
                            break;
                        default:
                            break;
                    }
                }
                
                // Obtiene el número total de hojas de trabajo en el archivo
                int numSheets = workbook.NumberOfSheets;

                // Itera sobre todas las hojas de trabajo del archivo y obtiene sus nombres
                for (int i = 0; i < numSheets; i++)
                {
                    string sheetName = workbook.GetSheetName(i);
                    list.Add(sheetName);
                }
            }
            return list;
        }

        public DataTable obtenerDatos(string hoja)
        {
            DataTable tbl = new DataTable();
            // Crea un objeto FileStream del archivo
            using (var fileStream = new FileStream(_rutaOrigen, FileMode.Open, FileAccess.Read))
            {
                IWorkbook workbook = new HSSFWorkbook();
                if (File.Exists(_rutaOrigen))
                {
                    switch (Path.GetExtension(_rutaOrigen))
                    {
                        case ".xls":
                            workbook = new HSSFWorkbook(fileStream); // Para archivos de Excel anteriores a 2007
                            break;
                        case ".xlsx":
                            workbook = new XSSFWorkbook(fileStream); // Para archivos de Excel 2007 o posteriores
                            break;
                        default:
                            break;
                    }
                }

                ISheet worksheet = workbook.GetSheet(hoja);

                // Itera sobre las filas y las columnas de la hoja de trabajo
                for (int row = worksheet.FirstRowNum; row <= worksheet.LastRowNum; row++)
                {
                    IRow currentRow = worksheet.GetRow(row);

                    if (row == 0)
                    {
                        for (int col = currentRow.FirstCellNum; col < currentRow.LastCellNum; col++)
                        {
                            // Obtiene el valor de la celda actual
                            ICell currentCell = currentRow.GetCell(col);
                            tbl.Columns.Add(currentCell == null ? "Column"+col.ToString() : currentCell.ToString());
                        }
                    }
                    else {
                        DataRow dRow = tbl.NewRow();
                        for (int col = currentRow.FirstCellNum; col < currentRow.LastCellNum; col++)
                        {
                            // Obtiene el valor de la celda actual
                            ICell currentCell = currentRow.GetCell(col);
                            dRow[col] = currentCell == null ? "" : currentCell.ToString();
                        }
                        tbl.Rows.Add(dRow);
                    }
                }
            }
            return tbl;
        }

        #endregion

    


        
    }

}

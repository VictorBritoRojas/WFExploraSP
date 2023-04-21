using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFExploraSP.Logica
{
    public class GenerarScript
    {

        #region Propiedades

        public int Columnas { set; get; }

        #endregion

        #region Metodos

        public IEnumerable<string> replicarQuery(string query, System.Data.DataTable tbl)
        {
            if (tbl == null)
                yield break;

            if(tbl.Rows.Count>0)
                yield break;


            foreach (System.Data.DataRow row in tbl.Rows) 
            {
                for (int it = 0; it < tbl.Columns.Count; it++)
                {
                    query = query.Replace("{" + it + "}", row[it].ToString());
                }
                yield return query;
            }
        }

        #endregion

    }
}

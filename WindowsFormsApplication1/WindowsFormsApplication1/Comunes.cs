using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Comunes
    {
        public void cargaCombo(ComboBox cbo, DataSet ds, String tabla, String col)
        {
            DataTable tabResul;

            cbo.Items.Clear();
            //La columna 'col' es la que tiene los datos que se agregarán al combo.
            tabResul = ds.Tables[tabla];
            foreach (DataRow fila in tabResul.Rows)
                if (!cbo.Items.Contains(fila[col].ToString().Trim()))
                    cbo.Items.Add(fila[col].ToString().Trim());
        }
    }

}

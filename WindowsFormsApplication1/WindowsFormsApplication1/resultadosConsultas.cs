using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class resultadosConsultas : Form
    {
        GestorBDT.GestorBD GestorBD;
        DataSet dsConsultas = new DataSet();
        String cadSql;

        public resultadosConsultas()
        {
            InitializeComponent();
        }

        private void btConsultaA_Click(object sender, EventArgs e)
        {
            cadSql = "SELECT cl.nombrec FROM T4factura f, T4cliente cl WHERE f.idCliente = cl.idCliente "+
                     "GROUP BY cl.nombrec HAVING SUM(saldoactual) < (SUM(montototal)*.10)";
            llenaGrid(cadSql);
        }

        private void btConsultaB_Click(object sender, EventArgs e)
        {
            cadSql = "SELECT nombreC, nombre FROM T4cliente cl, T4factura f, T4cadena cad, T4credito cre "+
                     "WHERE EXTRACT(MONTH FROM f.fechacompra) != 3 AND f.idCliente = cl.idCliente "+
                     "AND cl.idCliente = cre.idcliente AND cre.idcadena = cad.idcadena GROUP BY nombreC, nombre";
            llenaGrid(cadSql);
        }

        private void btConsultaC_Click(object sender, EventArgs e)
        {
            cadSql = "SELECT nombre, nombreSuc, SUM(f.montoTotal) FROM T4cadena ca, T4sucursal s, T4factura f "+
                     "WHERE ca.idCadena = s.idCadena AND s.idsucursal = f.idsucursal  AND EXTRACT(MONTH FROM f.fechacompra) = 7 "+
                     "HAVING SUM(f.montoTotal) < 50000 GROUP BY nombre, s.nombresuc ORDER BY nombre";
            llenaGrid(cadSql);
        }

        private void btConsultaD_Click(object sender, EventArgs e)
        {
            cadSql = "SELECT nombre, domicilio FROM t4cadena ca, t4sucursal s WHERE s.idCadena = ca.idCadena "+
                     "GROUP BY nombre, domicilio HAVING COUNT(ca.nombre) >= ALL(SELECT COUNT(nombre) "+
                     "FROM T4cadena ca, T4sucursal s WHERE ca.idCadena = s.idcadena GROUP BY nombre)";
            llenaGrid(cadSql);
        }

        private void llenaGrid(String cadSql)
        {
            GestorBD = new GestorBDT.GestorBD("MSDAORA", "bd16", "tregui", "oracle");
            dsConsultas.Clear();
            GestorBD.consBD(cadSql, "Cons", dsConsultas);
            dataGridView1.DataSource = dsConsultas.Tables["Cons"];
        }
    }
}

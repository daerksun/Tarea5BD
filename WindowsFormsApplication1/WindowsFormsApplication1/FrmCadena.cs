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
    public partial class FrmCadena : Form
    {
        GestorBDT.GestorBD GestorBD;
        DataSet dsClientes = new DataSet(), dsCompras = new DataSet(), dsCliente = new DataSet();
        const int OK = 1;
        Comunes com = new Comunes();
        String cadSql;

        public FrmCadena()
        {
            InitializeComponent();
        }

        private void FrmCadena_Load(object sender, EventArgs e)
        {
            GestorBD = new GestorBDT.GestorBD("MSDAORA", "bd16", "tregui", "oracle");
            cadSql = "SELECT nombreC FROM T4cliente";
            GestorBD.consBD(cadSql, "Client", dsClientes);
            dataGridView1.DataSource = dsClientes.Tables["Client"];
            com.cargaCombo(cbClientes , dsClientes, "Client", "nombreC");
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            btConsulta.Enabled = true;
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            int idCl = idCliente(cbClientes.SelectedText);
            GestorBD = new GestorBDT.GestorBD("MSDAORA", "bd16", "tregui", "oracle");
            cadSql = "SELECT f.fechaCompra, pro.nombreP FROM T4producto pro, T4fact_prod fp, T4factura f WHERE "+ 
                     "pro.idproducto = fp.idproducto AND fp.folio = f.folio AND "+
                     "f.idCliente = " + idCl + " AND f.fechaCompra >= '" + dtFecha.Text + "'";
            GestorBD.consBD(cadSql, "Compras", dsCompras);
            dataGridView1.DataSource = dsCompras.Tables["Compras"];
        }

        private int idCliente(String Nom)
        {
            DataRow fi;
            int resp;
            GestorBD = new GestorBDT.GestorBD("MSDAORA", "bd16", "tregui", "oracle");
            cadSql = "";
            GestorBD.consBD(cadSql, "id", dsCliente);
            fi= dsCompras.Tables["id"].Rows[0];
            resp = (Int32)fi["idCliente"].ToString();

        }
    }
}

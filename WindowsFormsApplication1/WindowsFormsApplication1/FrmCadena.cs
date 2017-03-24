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
        DataSet dsClientes = new DataSet(), dsCompras = new DataSet(), dsCliente = new DataSet(), dsRellena = new DataSet(), uno = new DataSet(), dos = new DataSet(), tres = new DataSet();
        Comunes com = new Comunes();
        String cadSql;

        public FrmCadena()
        {
            InitializeComponent();
            dtFecha.CustomFormat = "dd-MM-yy";
        }

        private void FrmCadena_Load(object sender, EventArgs e)
        {
            GestorBD = new GestorBDT.GestorBD("MSDAORA", "bd16", "tregui", "oracle");
            cadSql = "SELECT nombreC FROM T4cliente";
            GestorBD.consBD(cadSql, "Client", dsClientes);
            com.cargaCombo(cbClientes , dsClientes, "Client", "nombreC");
          
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            btConsulta.Enabled = true;
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            DataRow fi;
            int idCl = idCliente(cbClientes.SelectedItem.ToString());
            double montot, numPag, montp;
            GestorBD = new GestorBDT.GestorBD("MSDAORA", "bd16", "tregui", "oracle");
            cadSql = "SELECT f.fechaCompra, pro.nombreP FROM T4producto pro, T4fact_prod fp, T4factura f WHERE "+ 
                     "pro.idproducto = fp.idproducto AND fp.folio = f.folio AND "+
                     "f.idCliente = "+ idCl +" AND f.fechaCompra >= '" + dtFecha.Text + "'";
            GestorBD.consBD(cadSql, "Compras", dsCompras);
            dataGridView1.DataSource = dsCompras.Tables["Compras"];
            
            cadSql = "SELECT sum(montototal) AS Suma FROM T4factura WHERE idCliente = "+idCl;
            montot = rellenaLabel(lbMontoTotal, cadSql, "monto", uno);

            cadSql = "select count(folio) from t4pago where folio in (select folio from t4factura where idcliente = " + idCl + ")";
            numPag = rellenaLabel(lbNumPagos, cadSql, "folio", dos);

            cadSql = "select sum(montop) from t4pago where folio in (select folio from t4factura where idcliente = " + idCl + ")";
            montp = rellenaLabel(lbMontoPagos, cadSql, "summon", tres);

            lbSaldoAct.Text = "" + (montot - montp);


        }

        private double rellenaLabel(Label lb, String cadSql, String tab, DataSet dt) {
            DataRow fi;
            double resp;
            GestorBD = new GestorBDT.GestorBD("MSDAORA", "bd16", "tregui", "oracle");
            GestorBD.consBD(cadSql, tab, dt);
            fi = dt.Tables[tab].Rows[0];
            resp = Convert.ToDouble(fi[0].ToString());
            lb.Text = ""+resp;
            return resp;
        }
        private int idCliente(String Nom) {
          DataRow fi;
          int resp;
          GestorBD = new GestorBDT.GestorBD("MSDAORA", "bd16", "tregui", "oracle");
          cadSql = "SELECT idCliente from T4Cliente where nombreC = '"+ Nom + "'";
          GestorBD.consBD(cadSql, "id", dsCliente);
          fi = dsCliente.Tables["id"].Rows[0];
          resp = int.Parse(fi[0].ToString());
          return resp;
        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
}

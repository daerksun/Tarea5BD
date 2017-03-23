using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
  public partial class FrmFunciones : Form {
    public FrmFunciones() {
      InitializeComponent();
    }

    OleDbConnection cnOracle;
    GestorBDT.GestorBD GestorBD;
    DataSet dsGeneral = new DataSet();
    const int OK = 1;
    Comunes com = new Comunes();
    String cadSql;

    private void funciones_Load(object sender, EventArgs e) {
      GestorBD = new GestorBDT.GestorBD("MSDAORA", "bd16", "tregui", "oracle");
      cadSql = "SELECT nombreSuc FROM T4Sucursal";
      GestorBD.consBD(cadSql, "Suc", dsGeneral);
      com.cargaCombo(cbSucursales, dsGeneral, "Suc", "nombreSuc");

      cadSql = "SELECT nombreP FROM T4producto";
      dsGeneral.Clear();
      GestorBD.consBD(cadSql, "Prods", dsGeneral);
      com.cargaCombo(cbProductos, dsGeneral, "Prods", "nombreP");

    }

    //Ejecución de función
    private void btCons1_Click(object sender, EventArgs e) {

      if (cbSucursales.SelectedIndex > -1) {
        //Variables
        String nomSuc = cbSucursales.SelectedItem.ToString();
        String nomCad;
        int res;
        OleDbCommand cmd;
        OleDbParameter param;
        DataRow dr;

        //Obtiene el nombre
        cadSql = "SELECT nombre FROM T4cadena cad, T4sucursal s WHERE cad.idcadena = s.idcadena AND s.nombreSuc = '" + nomSuc + "'";
        dsGeneral.Clear();
        GestorBD.consBD(cadSql, "NomCad", dsGeneral);
        dr = dsGeneral.Tables["NomCad"].Rows[0];
        nomCad = dr[0].ToString();

        //Conexión
        cnOracle = new OleDbConnection("Provider=MSDAORA; Data Source=oracle;" +
          "User ID=bd16;Password=tregui");
        cnOracle.Open();
        cmd = new OleDbCommand();
        cmd.Connection = cnOracle;

        //Llamada a la función
        cmd.CommandText = "T4tiposArt";
        cmd.CommandType = CommandType.StoredProcedure;

        //Parámetros de salida
        param = new OleDbParameter("RETURN_VALUE", OleDbType.Integer, 4,
           ParameterDirection.ReturnValue, false, 4, 0, "CantArts", DataRowVersion.Current, 0);
        cmd.Parameters.Add(param);

        //Parametros de entrada
        param = new OleDbParameter("nombre", nomCad);
        cmd.Parameters.Add(param);
        param = new OleDbParameter("nombreSuc", nomSuc);
        cmd.Parameters.Add(param);

        //Ejecución
        try {
          cmd.ExecuteNonQuery();
          res = Convert.ToInt16(cmd.Parameters["RETURN_VALUE"].Value);
          MessageBox.Show("Cadena: " + nomCad + "\n" + "Sucursal: " + nomSuc + "\n" + "Cantidad de artículos: " + res);
        } catch (OleDbException error) {
          MessageBox.Show(error.Message);
        }
        cnOracle.Close();
      } else
        MessageBox.Show("No se seleccionó sucursal");       
    }

    private void button1_Click(object sender, EventArgs e) {
      this.Close();
    }

    //Ejecucíón de procedimiento almacenado
    private void BTProc_Click(object sender, EventArgs e) {

      if (cbSucursales.SelectedIndex > -1 || tbMonto.Text != "") {
        String nomProd; double monto;
        OleDbCommand cmd;
        OleDbParameter param;

        //Conexión a la BD.
        cnOracle = new OleDbConnection("Provider=MSDAORA; Data Source=oracle;" +
          "User ID=BD16;Password=tregui");
        cnOracle.Open();
        cmd = new OleDbCommand();
        cmd.Connection = cnOracle;

        //Llamado al procedimiento
        cmd.CommandText = "T4NumEmpresas";
        cmd.CommandType = CommandType.StoredProcedure;

        //Parámetros
        //Entrada
        nomProd = cbProductos.SelectedItem.ToString();
        monto = Double.Parse(tbMonto.Text);
        param = new OleDbParameter("nomP", nomProd);
        cmd.Parameters.Add(param);
        param = new OleDbParameter("monto", monto);
        cmd.Parameters.Add(param);

        //Salida
        param = new OleDbParameter("nombre", OleDbType.VarChar);
        cmd.Parameters.Add(param);
        param = new OleDbParameter("cant", OleDbType.Double,
          8, ParameterDirection.Output, false, 4, 0, "cantidad", DataRowVersion.Current, 0);
        cmd.Parameters.Add(param);


        //Procedimiento
        try {
          cmd.ExecuteNonQuery();
          int cant;
          String cadena;
          //Recuperar valores
          cant = Convert.ToInt16(cmd.Parameters["monto"].Value);
          cadena = cmd.Parameters["nombre"].Value.ToString();
          MessageBox.Show("Cantidad de cadenas con " + nomProd + " menor a " + monto.ToString() + ": " + cant +
            "\nSe puede encontrar en: " + cadena);

        } catch (OleDbException error) {
          MessageBox.Show(error.Message);
        }

        cnOracle.Close();
      }
      else
        MessageBox.Show("Faltan datos"); 
    }
  }
}

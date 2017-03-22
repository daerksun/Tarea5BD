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
    DataSet dsSucs = new DataSet();
    const int OK = 1;
    Comunes com = new Comunes();
    String cadSql;

    private void funciones_Load(object sender, EventArgs e) {
      GestorBD = new GestorBDT.GestorBD("MSDAORA", "bd16", "tregui", "oracle");
      cadSql = "SELECT nombreSuc FROM T4Sucursal";
      GestorBD.consBD(cadSql, "Suc", dsSucs);
      com.cargaCombo(cbSucursales, dsSucs, "Suc", "nombreSuc");
    }

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
        dsSucs.Clear();
        GestorBD.consBD(cadSql, "NomCad", dsSucs);
        dr = dsSucs.Tables["NomCad"].Rows[0];
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
      } else {
        
      }

      
    }
  }
}

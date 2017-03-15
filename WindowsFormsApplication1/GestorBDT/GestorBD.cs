using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorBDT {
  public partial class GestorBD : Component {
    public GestorBD() {
      InitializeComponent();                                                                                                                                                                                                                                                                                                                                                                                
    }

    public GestorBD(IContainer container) {
      container.Add(this);

      InitializeComponent();
    }

    /* Esta clase contiene rutinas para consultar, dar de alta, dar de baja y cambiar la
       información de una BD de Oracle. Con esta clase se crea una biblioteca .dll para
       que pueda ser usada en cualquier aplicación de Visual C#.
       Nota: 
       Para poder conectarse a una BD de otro DBMS, basta con cambiar los parámetros
       en el constructor del objeto de conexión. Hay que darlos según el DBMS en cuestión.
    */

    //=====================================================================
    //Definición de los objetos de ADO.Net para la manipulación de la BD.
    OleDbDataAdapter odaCons= new OleDbDataAdapter();
    OleDbDataAdapter odaAct= new OleDbDataAdapter();
    private const int OK= 1;
    //Puede definirse como Property.
    public OleDbConnection conex= new OleDbConnection();

    //Constructor: establece la conexión a una BD Oracle o Access.
    public GestorBD(String prov, String user, String pass, String ds) {
      conex = new OleDbConnection("Provider=" + prov + ";" +
        "User ID=" + user + ";Password=" + pass + ";Data Source=" + ds + ";");
    }

    //Constructor: establece la conexión a una BD SQL Server.
    public GestorBD(String prov, String server, String user, String pass, String db) {
      conex = new OleDbConnection("Provider=" + prov + ";Data Source=" + server +
        ";User ID=" + user + ";Password=" + pass + ";Initial catalog=" + db + ";");
    }
    /* =====================================================================
       Ejecuta una consulta sobre la BD. La consulta se da como parámetro,
       Parámetros de entrada: la consulta y el nombre de la tabla resultante.
       Parámetro de salida: el DataSet generado.
     */
    public void consBD(String cadSql, String tabla, System.Data.DataSet dsCons) {
      try
      {
        odaCons.SelectCommand =
          new OleDbCommand(cadSql, conex); //Define la consulta.

        if (!dsCons.Tables.Contains(tabla))
        {      //Establece el
          dsCons.Tables.Add(tabla);               //nombre de la tabla resultante.
          odaCons.FillSchema(dsCons, SchemaType.Source, tabla);
        }
        dsCons.Clear();                //Borra resultados anteriores.
        odaCons.Fill(dsCons, tabla);   //Ejecuta la consulta.
      }
      catch (OleDbException err)
      {
        Console.WriteLine(err.Message);
      }
    }

    //=====================================================================
    //Efectúa una inserción de datos en una tabla de la BD.
    //La instrucción de inserción se da como parámetro.
    //La rutina regresa OK o un código, si hubo error.
    public int altaBD(String cadSql) {
      int cant, result;

      try
      {
        odaAct.InsertCommand =
          new OleDbCommand(cadSql, conex);   //Define la inserción.

        conex.Open();
        cant = odaAct.InsertCommand.ExecuteNonQuery();   //La ejecuta.
        result = OK;
      }
      catch (OleDbException err)
      {
        Console.WriteLine(err.Message);
        result = err.ErrorCode;
      }
      conex.Close();
      return result;
    }

    public int bajaBD(String cadSql) {
      int cant, result;

      try
      {
        odaAct.DeleteCommand =
          new OleDbCommand(cadSql, conex);   //Define la inserción.

        conex.Open();
        cant = odaAct.DeleteCommand.ExecuteNonQuery();   //La ejecuta.
        result = OK;
      }
      catch (OleDbException err)
      {
        Console.WriteLine(err.Message);
        result = err.ErrorCode;
      }
      conex.Close();
      return result;
    }

    public int cambiaBD(String cadSql) {
      int cant, result;

      try
      {
        odaAct.UpdateCommand =
          new OleDbCommand(cadSql, conex);   //Define la inserción.

        conex.Open();
        cant = odaAct.UpdateCommand.ExecuteNonQuery();   //La ejecuta.
        result = OK;
      }
      catch (OleDbException err)
      {
        Console.WriteLine(err.Message);
        result = err.ErrorCode;
      }
      conex.Close();
      return result;
    }
  }
}

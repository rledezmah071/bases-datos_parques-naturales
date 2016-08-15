using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows.Forms;

namespace ProyectoFinal
{
   public class Controlador
    {
            OracleConnection databaseConnection = new OracleConnection("Data Source= DESKTOP-BQICPNQ;User Id=PARQUENATURAL;Password=root;");

        //Area
        //
        public void insertaArea(string identificacion, string nombre, string extension)
        {
            databaseConnection.Open();
            OracleCommand command = new OracleCommand("insert into tablaprueba values('"+identificacion+"','"+nombre+ "','"+extension+"')",databaseConnection);
            command.ExecuteNonQuery();
            databaseConnection.Close();
        }

                
    }
}

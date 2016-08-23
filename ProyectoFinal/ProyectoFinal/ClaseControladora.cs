using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows.Forms;
using System.Data;

namespace ProyectoFinal
{
    public class Controlador
    {
        OracleConnection databaseConnection = new OracleConnection("Data Source= MARIA-HP;User Id=parquenatural;Password=pepe;");

        //Area
        //
        public void insertaArea(string identificacion, string nombre, string extension)
        {
            databaseConnection.Open();
            OracleCommand command = new OracleCommand("insert into tablaprueba values('" + identificacion + "','" + nombre + "','" + extension + "')", databaseConnection);
            command.ExecuteNonQuery();
            databaseConnection.Close();
        }

        //Alojamiento
        public void insertaAlojamiento(int idAlojamiento, string v_categoria, int capacidad, int cod_parque)
        {

            OracleCommand cmd = new OracleCommand("insertaAloja", databaseConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("alojamiento", OracleDbType.Int64).Value = idAlojamiento;
            cmd.Parameters.Add("a_categoria", OracleDbType.Varchar2).Value = v_categoria;
            cmd.Parameters.Add("a_capacidad", OracleDbType.Int64).Value = capacidad;
            cmd.Parameters.Add("idParque", OracleDbType.Int64).Value = cod_parque;
            databaseConnection.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            databaseConnection.Close();
        }
        public void actualizaCategoria(int idAlojamiento, string v_categoria)
        {

            using (OracleConnection connection = new OracleConnection("Data Source= MARIA-HP;User Id=PARQUENATURAL;Password=pepe;"))
            {

                
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connection;
                cmd.CommandText = "dmlAlojamiento.updCateg";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.BindByName = true;
                cmd.Parameters.Add("alojamiento", OracleDbType.Int64).Value = idAlojamiento;
                cmd.Parameters.Add("a_categoria", OracleDbType.Varchar2).Value = v_categoria;
                try {
                    connection.Open();
                    OracleTransaction transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    cmd.Transaction = transaction;                    
                    cmd.ExecuteNonQuery();
                    transaction.Commit();    
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Exception:{0}", ex.ToString());
                }
                connection.Close();
            }
        }
    }
}

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

        /* Para ver el Data Source es con este comando, dentor del sql developer
            select SYS_CONTEXT('USERENV', 'HOST', 15) host_name from dual;
        */

        OracleConnection databaseConnection = new OracleConnection("Data Source=DESKTOP-55UT6S1;User Id=parquenaturalv02;Password=clave;");
        //Area
        //
        public void insertaArea(string identificacion, string nombre, string extension)
        { 
            
            databaseConnection.Open();
            OracleCommand command = new OracleCommand("insert into area values('" + identificacion + "','" + nombre + "','" + extension + "')", databaseConnection);
            command.ExecuteNonQuery();
            databaseConnection.Close();
        }

        //Alojamiento
        public void insertaAlojamiento(Int64 idAlojamiento, string v_categoria, Int64 capacidad, Int64 cod_parque)
        {
    
                try
                {

                databaseConnection.Open();
                OracleCommand cmd = new OracleCommand("DMLALOJAMIENTO.INSERTAALOJA");
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.BindByName = true;
                cmd.Parameters.Add("alojamiento", OracleDbType.Int64).Value = idAlojamiento;
                cmd.Parameters.Add("a_categoria", OracleDbType.Varchar2).Value = v_categoria;
                cmd.Parameters.Add("a_capacidad", OracleDbType.Int64).Value = capacidad;
                cmd.Parameters.Add("idParque", OracleDbType.Int64).Value = cod_parque;
                OracleTransaction transaction = databaseConnection.BeginTransaction(IsolationLevel.ReadCommitted);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception:{0}", ex.ToString());
                }
                databaseConnection.Close();
            
        }
        public void actualizaCategoria(Int64 idAlojamiento, string v_categoria)
        {
            try
            {
                databaseConnection.Open();
                OracleCommand cmd = new OracleCommand("DMLALOJAMIENTO.UPDCATEG", databaseConnection);
                //cmd.CommandText = "dmlAlojamiento.updCateg";
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.BindByName = true;
                //cmd.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                cmd.Parameters.Add("alojamiento", OracleDbType.Int64).Value = idAlojamiento;
                cmd.Parameters.Add("a_categoria", OracleDbType.Varchar2).Value = v_categoria;
                OracleTransaction transaction = databaseConnection.BeginTransaction(IsolationLevel.ReadCommitted);
                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                databaseConnection.Close();
            
            }catch (Exception ex)
                {
                    Console.WriteLine("Exception:{0}", ex.ToString());
                }
                databaseConnection.Close();
            }






      //  public void eliminarAlojamiento(Int64 idAlojamiento)
        //{
          //  try
           // {
             //   databaseConnection.Open();
               // OracleCommand cmd = new OracleCommand("DMLALOJAMIENTO.DELALOJA", databaseConnection);
                //cmd.CommandText = "DMLALOJAMIENTO.DELALOJA";
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.BindByName = true;
                //cmd.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                //cmd.Parameters.Add("alojamiento1", OracleDbType.Int64).Value = idAlojamiento;
                //OracleTransaction transaction = databaseConnection.BeginTransaction(IsolationLevel.ReadCommitted);
                //cmd.Transaction = transaction;
                //cmd.ExecuteNonQuery();
                //transaction.Commit();
                //databaseConnection.Close();
            //}
           // catch (Exception ex)
            //{
              //  Console.WriteLine("Exception:{0}", ex.ToString());
            //}
            //databaseConnection.Close();
        //}
    }
}



    


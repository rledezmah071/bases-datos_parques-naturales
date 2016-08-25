using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{

    public partial class TablaAlojamiento : Form
    {
        //OracleConnection databaseConnection = new OracleConnection("Data Source=MARIA-HP User Id=parquenatural;Password=pepe;");
        Controlador controlador = new Controlador();
        public TablaAlojamiento()
        {
            
            InitializeComponent();
            FillCombo();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonLimpiaAlojamiento_Click(object sender, EventArgs e)
        {
            aloCategoria.Clear();
            aloID.Clear();
            aloCapacidad.Clear();
            aloComboBoxParque.Text = "";

        }

        private void buttonGuardaAlojamiento_Click(object sender, EventArgs e)
        {
          
            Int64 capacidad= Int64.Parse(aloCapacidad.Text.ToString());
            Int64 codigoParque= Int64.Parse(aloComboBoxParque.Text.ToString());
            Int64 id = Int64.Parse(aloID.Text.ToString());
            controlador.insertaAlojamiento(id,aloCategoria.ToString(),capacidad,codigoParque);
            
        }

        private void aloCapacidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void aloCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonActualizarAlojamiento_Click(object sender, EventArgs e)
        {

            Int64 id = Int64.Parse(aloID.Text);
            controlador.actualizaCategoria(id, aloCategoria.Text);
        }

        private void buttonEliminaAlojamiento_Click(object sender, EventArgs e)
        {
            //Int64 id = Int64.Parse(aloID.Text);
            //controlador.eliminarAlojamiento(id);
        }

        private void ComboBoxAlojamiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aloID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAlojamientoVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador MenuAdministrador = new MenuAdministrador();
            MenuAdministrador.ShowDialog();
        }

        private void aloComboBoxParque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TablaAlojamiento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ALOJAMIENTO' table. You can move, or remove it, as needed.
            this.aLOJAMIENTOTableAdapter.Fill(this.dataSet1.ALOJAMIENTO);

        }



        void FillCombo()
        {

            //**RECUERDEN CAMBIAR EL DATA SOURCE, Jeje
            OracleConnection databaseConnection = new OracleConnection("Data Source=MARIA-HP;User Id=parquenatural;Password=pepe;");
            string query = "select id_parque from ALOJAMIENTO";
            OracleCommand cmd = new OracleCommand(query, databaseConnection);
            OracleDataReader myReader;
     
            try
            {
                databaseConnection.Open();
                myReader = cmd.ExecuteReader();  //exception due to this line

                while (myReader.Read())
                {

    
                     // string sIdParque = myReader.GetString(3);
                    //aloComboBoxParque.Items.Add(sIdParque);

                    aloComboBoxParque.Items.Add(myReader.GetInt64(myReader.GetOrdinal("id_parque")));
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
    }


  }












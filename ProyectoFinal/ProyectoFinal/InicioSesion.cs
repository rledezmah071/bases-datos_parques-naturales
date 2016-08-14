using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;




namespace ProyectoFinal
{
    public partial class InicioSesion : Form
    {

        OracleConnection DatabaseConnection = new OracleConnection();
       

        public InicioSesion()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {

            this.Hide();
            MenuAdministrador MenuAdministrador = new MenuAdministrador();
            MenuAdministrador.ShowDialog();
            
       }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void buttonComunidadVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

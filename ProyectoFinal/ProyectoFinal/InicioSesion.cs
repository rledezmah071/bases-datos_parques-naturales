using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace ProyectoFinal
{
    public partial class InicioSesion : Form
    {
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
            MenuAdministrador MenuAdministrador = new MenuAdministrador();
           


            MenuAdministrador.ShowDialog();
            this.Close();

            /* MenuGestor MenuGestor = new MenuGestor();
             MenuGestor.ShowDialog();*/



        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        
    }
}

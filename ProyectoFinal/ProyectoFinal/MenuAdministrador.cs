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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void admconsultar_Click(object sender, EventArgs e)
        {

        }

        private void buttonMenuAdmVolver_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonMenuAdmVolver_Click_1(object sender, EventArgs e)
        {
            InicioSesion InicioSesion = new InicioSesion();
            InicioSesion.ShowDialog();
            
            
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonOrganismo_Click(object sender, EventArgs e)
        {
            TablaOrganismo Organismo = new TablaOrganismo();
            Organismo.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void admExcursion_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void admAlojamiento_Click(object sender, EventArgs e)
        {
            TablaAlojamiento TablaAlojamiento = new TablaAlojamiento();
            TablaAlojamiento.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

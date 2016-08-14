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
    public partial class MenuGestor : Form
    {
        public MenuGestor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioSesion InicioSesion = new InicioSesion();

            InicioSesion.ShowDialog();
        }

        private void admConsultar_Click(object sender, EventArgs e)
        {

        }

        private void MenuGestor_Load(object sender, EventArgs e)
        {

        }

        private void buttonMenuAdmVolver_Click(object sender, EventArgs e)
        {
            InicioSesion InicioSesion = new InicioSesion();
            InicioSesion.ShowDialog();
        }

        private void admComboBoxConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

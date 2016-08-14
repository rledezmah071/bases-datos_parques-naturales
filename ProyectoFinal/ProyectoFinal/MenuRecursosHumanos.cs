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
    public partial class MenuRecursosHumanos : Form
    {
        public MenuRecursosHumanos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void GestVisit_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuRecursosHumanos_Load(object sender, EventArgs e)
        {

        }

        private void buttonMenuAdmVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesion InicioSesion = new InicioSesion();
            InicioSesion.ShowDialog();
        }

        private void rhPersonal_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablaPersonal TablaPersonal = new TablaPersonal();
            TablaPersonal.ShowDialog();
        }

        private void rhTipoPersonal_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablaTipoDePersonal TablaTipoDePersonal = new TablaTipoDePersonal();
            TablaTipoDePersonal.ShowDialog();
        }
    }
}

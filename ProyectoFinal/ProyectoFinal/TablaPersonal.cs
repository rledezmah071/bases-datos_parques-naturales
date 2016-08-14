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
    public partial class TablaPersonal : Form
    {
        public TablaPersonal()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void TablaPersonal_Load(object sender, EventArgs e)
        {

        }

        private void buttonPersonalVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador MenuAdministrador = new MenuAdministrador();
            MenuAdministrador.ShowDialog();
        }

        private void buttonLimpiaPersonal_Click(object sender, EventArgs e)
        {
            perscomboBox1TipoPersonal.Text = "";
            persComboBoxCodigoParque.Text = "";
            perscomboBoxProyecto.Text = "";
            persFecha.Clear();
            persID.Clear();
            persNombre.Clear();
            persSalario.Clear();
            persTelCasa.Clear();
            persTelMovil.Clear();
        }
    }
}

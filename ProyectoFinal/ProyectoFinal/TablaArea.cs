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
    public partial class TablaArea : Form
    {
        public TablaArea()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void TablaArea_Load(object sender, EventArgs e)
        {

        }

        private void buttonAreaVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador MenuAdministrador = new MenuAdministrador();
            MenuAdministrador.ShowDialog();
        }

        private void buttonLimpiaArea_Click(object sender, EventArgs e)
        {
            areaCapacidad.Clear();
            areaCategoria.Clear();
            areaID.Clear();
        }
    }
}

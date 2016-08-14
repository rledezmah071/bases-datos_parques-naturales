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
    public partial class TablaOrganismo : Form
    {
        public TablaOrganismo()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Organismo_Load(object sender, EventArgs e)
        {

        }




        private void buttonLimpiaOrganismo1_Click(object sender, EventArgs e)
        {
            orgDireccion.Clear();
            orgID.Clear();
            orgNombre.Clear();
        }

        private void buttonOrganismoVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador MenuAdministrador = new MenuAdministrador();
            MenuAdministrador.ShowDialog();
        }
    }
}

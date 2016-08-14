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
    public partial class TablaProyectos : Form
    {
        public TablaProyectos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void TablaProyectos_Load(object sender, EventArgs e)
        {

        }

        private void buttonProyectosVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador MenuAdministrador = new MenuAdministrador();
            MenuAdministrador.ShowDialog();
        }
    }
}

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
    public partial class TablaVisitantes : Form
    {
        public TablaVisitantes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void TablaVisitantes_Load(object sender, EventArgs e)
        {

        }

        private void buttonVisitantesVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador MenuAdministrador = new MenuAdministrador();
            MenuAdministrador.ShowDialog();
        }

        private void buttonLimpiaVisitantes_Click(object sender, EventArgs e)
        {
            visComboBoxCodAlojamiento.Text = "";
            visDNI.Clear();
            visDomicilio.Clear();
            visID.Clear();
            visNombre.Clear();
            visProfesion.Clear();
        }
    }
}

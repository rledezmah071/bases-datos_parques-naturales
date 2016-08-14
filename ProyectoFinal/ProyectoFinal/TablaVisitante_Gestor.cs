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
    public partial class TablaVisitante_Gestor : Form
    {
        public TablaVisitante_Gestor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonVisitantesGVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuGestor MenuGestor = new MenuGestor();
            MenuGestor.ShowDialog();
        }

        private void buttonLimpiaVisitantesG_Click(object sender, EventArgs e)
        {
            visgComboBoxCodAlojamiento.Text = "";
            visgDNI.Clear();
            visgDomicilio.Clear();
            visgID.Clear();
            visgNombre.Clear();
            visgProfesion.Clear();
            
        }
    }
}

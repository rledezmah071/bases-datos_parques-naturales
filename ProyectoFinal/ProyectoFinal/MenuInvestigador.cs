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
    public partial class MenuInvestigador : Form
    {
        public MenuInvestigador()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MenuInvestigador_Load(object sender, EventArgs e)
        {

        }

        private void admComboBoxConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void admConsultar_Click(object sender, EventArgs e)
        {
            InicioSesion InicioSesion = new InicioSesion();
            InicioSesion.ShowDialog();
            
        }
    }
}

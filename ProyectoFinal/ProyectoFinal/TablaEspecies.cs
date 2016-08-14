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
    public partial class TablaEspecies : Form
    {
        public TablaEspecies()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void TablaEspecies_Load(object sender, EventArgs e)
        {

        }

        private void buttonEspeciesVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador MenuAdministrador = new MenuAdministrador();
            MenuAdministrador.ShowDialog();
        }

        private void buttonLimpiaEspecies_Click(object sender, EventArgs e)
        {
            espFloracion.Clear();
            espID.Clear();
            espNombreCientifico.Clear();
            espNombreVulgar.Clear();
            espNumeroIndividuos.Clear();
            espPeriodoCelo.Clear();
            espPeriodoFloracion.Clear();
            EspTipoAlimentacion.Clear();
            espTipoEspecie.Clear();
            espTipoMineral.Clear();

                
        }
    }
}

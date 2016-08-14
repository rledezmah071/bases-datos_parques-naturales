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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void admconsultar_Click(object sender, EventArgs e)
        {

        }

        private void buttonMenuAdmVolver_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonMenuAdmVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesion InicioSesion = new InicioSesion();
            InicioSesion.ShowDialog();
            
            
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablaEspecies TablaEspecies = new TablaEspecies();
            TablaEspecies.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablaParquesNaturales TablaParquesNaturales = new TablaParquesNaturales();
            TablaParquesNaturales.ShowDialog();
        }

        private void buttonOrganismo_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablaOrganismo Organismo = new TablaOrganismo();
            Organismo.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TablaInvestigadores TablaInvestigadores = new TablaInvestigadores();
            TablaInvestigadores.ShowDialog();
        }

        private void admExcursion_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablaExcursion TablaExcursion = new TablaExcursion();
            TablaExcursion.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablaPersonal TablaPersonal = new TablaPersonal();
            TablaPersonal.ShowDialog();
        }

        private void admAlojamiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablaAlojamiento TablaAlojamiento = new TablaAlojamiento();
            TablaAlojamiento.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablaArea TablaArea = new TablaArea();
            TablaArea.ShowDialog();
        }

        private void admComunidadAutonoma_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablaComunidadAutonoma TablaComunidadAutonoma = new TablaComunidadAutonoma();
            TablaComunidadAutonoma.ShowDialog();
        }

        private void admProyecto_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablaProyectos TablaProyectos = new TablaProyectos();
            TablaProyectos.ShowDialog();
        }

        private void admTipoPersonal_Click(object sender, EventArgs e)
        {
            
        }

        private void admVisitante_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablaVisitantes TablaVisitantes = new TablaVisitantes();
            TablaVisitantes.ShowDialog();
        }

        private void admTipoPersonal_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TablaTipoDePersonal TablaTipoDePersonal = new TablaTipoDePersonal();
            TablaTipoDePersonal.ShowDialog();
        }
    }
}

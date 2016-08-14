using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;




namespace ProyectoFinal
{
    public partial class InicioSesion : Form
    {

        OracleConnection DatabaseConnection = new OracleConnection();
       

        public InicioSesion()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("admin") && (textBox2.Text == ("clave")))
            {
                this.Hide();
                MenuAdministrador MenuAdministrador = new MenuAdministrador();
                MenuAdministrador.ShowDialog();


            }
            else if (textBox1.Text == ("admin2") && (textBox2.Text == ("clave2")))
            {
                this.Hide();
                MenuGestor MenuGestor = new MenuGestor();
                MenuGestor.ShowDialog();


            }
            else if (textBox1.Text == ("admin3") && (textBox2.Text == ("clave3")))
            {
                this.Hide();
                MenuInvestigador MenuInvestigador = new MenuInvestigador();
                MenuInvestigador.ShowDialog();

            }
            else if (textBox1.Text == ("admin4") && (textBox2.Text == ("clave4")))
            {
                this.Hide();
                MenuRecursosHumanos MenuRecursosHumanos = new MenuRecursosHumanos();
                MenuRecursosHumanos.ShowDialog();
            }
            else if (textBox1.Text == ("admin5") && (textBox2.Text == ("clave5")))
            {
                this.Hide();
                TablaAlojamiento TablaAlojamiento = new TablaAlojamiento();
                TablaAlojamiento.ShowDialog();
            }
            else if (textBox1.Text == ("admin6") && (textBox2.Text == ("clave6")))
            {
                this.Hide();
                TablaArea TablaArea = new TablaArea();
                TablaArea.ShowDialog();
            }
            else if (textBox1.Text == ("admin7") && (textBox2.Text == ("clave7")))
            {
                this.Hide();
                TablaComunidadAutonoma TablaComunidadAutonoma = new TablaComunidadAutonoma();
                TablaComunidadAutonoma.ShowDialog();
            }
            else if (textBox1.Text == ("admin8") && (textBox2.Text == ("clave8")))
            {
                this.Hide();
                TablaEspecies TablaEspecies = new TablaEspecies();
                TablaEspecies.ShowDialog();
            }
            else if (textBox1.Text == ("admin9") && (textBox2.Text == ("clave9")))
            {
                this.Hide();
                TablaExcursion TablaExcursion = new TablaExcursion();
                TablaExcursion.ShowDialog();
            }
            else if (textBox1.Text == ("admin10") && (textBox2.Text == ("clave10")))
            {
                this.Hide();
                TablaInvestigadores TablaInvestigadores = new TablaInvestigadores();
                TablaInvestigadores.ShowDialog();
            }
            else if (textBox1.Text == ("admin11") && (textBox2.Text == ("clave11")))
            {
                this.Hide();
                TablaOrganismo TablaOrganismo = new TablaOrganismo();
                TablaOrganismo.ShowDialog();
            }
            else if (textBox1.Text == ("admin12") && (textBox2.Text == ("clave12")))
            {
                this.Hide();
                TablaParquesNaturales TablaParquesNaturales = new TablaParquesNaturales();
                TablaParquesNaturales.ShowDialog();
            }
            else if (textBox1.Text == ("admin13") && (textBox2.Text == ("clave13")))
            {
                this.Hide();
                TablaPersonal TablaPersonal = new TablaPersonal();
                TablaPersonal.ShowDialog();
            }
            else if (textBox1.Text == ("admin14") && (textBox2.Text == ("clave14")))
            {
                this.Hide();
                TablaProyectos TablaProyectos = new TablaProyectos();
                TablaProyectos.ShowDialog();
            }
            else if (textBox1.Text == ("admin15") && (textBox2.Text == ("clave15")))
            {
                this.Hide();
                TablaTipoDePersonal TablaTipoDePersonal = new TablaTipoDePersonal();
                TablaTipoDePersonal.ShowDialog();
            }
            else if (textBox1.Text == ("admin16") && (textBox2.Text == ("clave16")))
            {
                this.Hide();
                TablaVisitantes TablaVisitantes = new TablaVisitantes();
                TablaVisitantes.ShowDialog();
            }
            else { MessageBox.Show("Usuario o contraseña incorrectos", "Error!"); }
               
       }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

      
    }
}

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

        private void buttonComunidadVolver_Click(object sender, EventArgs e)
        {

            Application.Exit();
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
            else {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Error!");
            }

        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            BotonInvisible BotonInvisible = new BotonInvisible();
            BotonInvisible.ShowDialog();
            BotonInvisible.Visible = false;

        }
    }


}

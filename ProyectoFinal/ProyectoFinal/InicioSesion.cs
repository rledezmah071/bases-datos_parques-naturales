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
using System.Data.OleDb;




namespace ProyectoFinal
{
    public partial class InicioSesion : Form
    {


        public InicioSesion()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void textoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }



        private void buttonIngresar_Click(object sender, EventArgs e)
        {

            if (textoUsuario.Text == ("admin") && (textoContraseña.Text == ("clave")))
            {
                this.Hide();
                MenuAdministrador MenuAdministrador = new MenuAdministrador();
                MenuAdministrador.ShowDialog();


            }
            else if (textoUsuario.Text == ("admin2") && (textoContraseña.Text == ("clave2")))
            {
                this.Hide();
                MenuGestor MenuGestor = new MenuGestor();
                MenuGestor.ShowDialog();


            }
            else if (textoUsuario.Text == ("admin3") && (textoContraseña.Text == ("clave3")))
            {
                this.Hide();
                MenuInvestigador MenuInvestigador = new MenuInvestigador();
                MenuInvestigador.ShowDialog();

            }
            else if (textoUsuario.Text == ("admin4") && (textoContraseña.Text == ("clave4")))
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





        private void label4_Click(object sender, EventArgs e)
        {
            BotonInvisible BotonInvisible = new BotonInvisible();
            BotonInvisible.ShowDialog();
            BotonInvisible.Visible = false;
        }

        private void textoContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (textoUsuario.Text == ("admin") && (textoContraseña.Text == ("clave")))
                {
                    this.Hide();
                    MenuAdministrador MenuAdministrador = new MenuAdministrador();
                    MenuAdministrador.ShowDialog();


                }
                else if (textoUsuario.Text == ("admin2") && (textoContraseña.Text == ("clave2")))
                {
                    this.Hide();
                    MenuGestor MenuGestor = new MenuGestor();
                    MenuGestor.ShowDialog();


                }
                else if (textoUsuario.Text == ("admin3") && (textoContraseña.Text == ("clave3")))
                {
                    this.Hide();
                    MenuInvestigador MenuInvestigador = new MenuInvestigador();
                    MenuInvestigador.ShowDialog();

                }
                else if (textoUsuario.Text == ("admin4") && (textoContraseña.Text == ("clave4")))
                {

                    this.Hide();
                    MenuRecursosHumanos MenuRecursosHumanos = new MenuRecursosHumanos();
                    MenuRecursosHumanos.ShowDialog();
                }
                else {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Error!");
                }


            }
        }


        private void textoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textoContraseña.Focus();
            }
        }
    }


}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class TablaArea : Form
    {

        Controlador controlador = new Controlador();

        public TablaArea()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void TablaArea_Load(object sender, EventArgs e)
        {

        }

        private void buttonAreaVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador MenuAdministrador = new MenuAdministrador();
            MenuAdministrador.ShowDialog();
        }

        private void buttonLimpiaArea_Click(object sender, EventArgs e)
        {
            areaExtension.Clear();
            areaNombre.Clear();
            areaID.Clear();
        }

        private void buttonGuardaArea_Click(object sender, EventArgs e)
        {
            string idArea = areaID.Text;
            string nombreArea = areaNombre.Text;
            string extensionArea = areaExtension.Text;
            controlador.insertaArea(idArea,nombreArea,extensionArea);
            areaExtension.Clear();
            areaNombre.Clear();
            areaID.Clear();
            MessageBox.Show("Registro guardado", "");

        }

        private void buttonActualizarArea_Click(object sender, EventArgs e)
        {
           
        }
    }
}

﻿using System;
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
    public partial class TablaInvestigadores : Form
    {
        public TablaInvestigadores()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void TablaInvestigadores_Load(object sender, EventArgs e)
        {

        }


        private void buttonInvestigadorVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador MenuAdministrador = new MenuAdministrador();
            MenuAdministrador.ShowDialog();
        }

        private void buttonLimpiaInvestigador_Click(object sender, EventArgs e)
        {
            invID.Clear();
            invNombre.Clear();
            invTelefono.Clear();
            invTitulo.Clear();
            invApellido.Clear();
        }
    }
}

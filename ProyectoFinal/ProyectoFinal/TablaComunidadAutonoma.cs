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
    public partial class TablaComunidadAutonoma : Form
    {
        public TablaComunidadAutonoma()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void TablaComunidadAutonoma_Load(object sender, EventArgs e)
        {

        }

        private void buttonComunidadVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador MenuAdministrador = new MenuAdministrador();
            MenuAdministrador.ShowDialog();
        }

        private void buttonLimpiaComunidadAutonoma_Click(object sender, EventArgs e)
        {
            comID.Clear();
            comNombre.Clear();
            comNumero.Clear();
            comSuperficieDeclarada.Clear();
            comComboBoxOrganismo.Text = "";
        }
    }
}

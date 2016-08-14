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
    public partial class MenuGestor : Form
    {
        public MenuGestor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MenuGestor_Load(object sender, EventArgs e)
        {

        }

        private void buttonMenuAdmVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesion InicioSesion = new InicioSesion();
            InicioSesion.ShowDialog();
        }

        private void GestorBtnVisitantes_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablaVisitante_Gestor TablaVisitante_Gestor = new TablaVisitante_Gestor();
            TablaVisitante_Gestor.ShowDialog();
        }
    }
}

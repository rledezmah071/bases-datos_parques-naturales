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
    public partial class TablaTipoDePersonal : Form
    {
        public TablaTipoDePersonal()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void TipoDePersonal_Load(object sender, EventArgs e)
        {
            this.Hide();
            TablaTipoDePersonal TablaTipoDePersonal = new TablaTipoDePersonal();
            TablaTipoDePersonal.ShowDialog();
        }
    }
}

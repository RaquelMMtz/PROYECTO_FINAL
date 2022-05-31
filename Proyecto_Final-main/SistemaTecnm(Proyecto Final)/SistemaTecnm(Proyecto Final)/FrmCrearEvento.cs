using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTecnm_Proyecto_Final_
{
    public partial class FrmCrearEvento : Form
    {
        public FrmCrearEvento()
        {
            InitializeComponent();
        }

        private void FrmCrearEvento_Load(object sender, EventArgs e)
        {

        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmCalendario frm = new FrmCalendario();

            frm.Show();
        }

        private void btnVerificacion2_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmVerificacion frm = new FrmVerificacion();

            frm.Show();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

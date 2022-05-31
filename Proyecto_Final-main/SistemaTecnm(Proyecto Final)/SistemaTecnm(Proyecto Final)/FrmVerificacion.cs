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
    public partial class FrmVerificacion : Form
    {
        public FrmVerificacion()
        {
            InitializeComponent();
        }

        private void btnEvento2_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmCrearEvento frm = new FrmCrearEvento();

            frm.Show();
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalendario2_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmCalendario frm = new FrmCalendario();

            frm.Show();
        }
    }
}

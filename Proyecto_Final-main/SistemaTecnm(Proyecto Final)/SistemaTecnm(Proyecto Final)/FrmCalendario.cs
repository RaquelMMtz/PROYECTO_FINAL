using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTecnm_Proyecto_Final_
{
    public partial class FrmCalendario : Form
    {
        int month, year;
        public FrmCalendario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmCrearEvento frm = new FrmCrearEvento();

            frm.Show();
        }

        private void btnVerificacion_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmVerificacion frm = new FrmVerificacion();

            frm.Show();
        }

        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            displaDays();
        }
        private void displaDays()

        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            String nombremes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbmes.Text = nombremes + " "  + year;
            DateTime iniciodelmes = new DateTime(year, month, 1);
            int dias = DateTime.DaysInMonth(year, month);
            int diasdesemana = Convert.ToInt32(iniciodelmes.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < diasdesemana; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                ucdias.dias(i);
                DayContainer.Controls.Add(ucdias);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            month--;
            String nombremes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbmes.Text = nombremes + " " + year;
            DateTime iniciodelmes = new DateTime(year, month, 1);
            int dias = DateTime.DaysInMonth(year, month);
            int diasdesemana = Convert.ToInt32(iniciodelmes.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < diasdesemana; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                ucdias.dias(i);
                DayContainer.Controls.Add(ucdias);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            month++;
            String nombremes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbmes.Text = nombremes + " " + year;
            DateTime iniciodelmes = new DateTime(year, month, 1);
            int dias = DateTime.DaysInMonth(year, month);
            int diasdesemana = Convert.ToInt32(iniciodelmes.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < diasdesemana; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                DayContainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                ucdias.dias(i);
                DayContainer.Controls.Add(ucdias);
            }
        }
    }
}

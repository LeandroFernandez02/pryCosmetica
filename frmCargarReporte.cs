using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCosmetica
{
    public partial class frmCargarReporte : Form
    {
        public frmCargarReporte()
        {
            InitializeComponent();
            OcultarGroupBox();
        }

        private void OcultarGroupBox()
        {
            gbInasistencia.Visible = false;
            gbAmonestaciones.Visible = false;
            gbSuspensión.Visible = false;
            gbEvaluaciónDesempeño.Visible = false;
        }

        private void btnInasistencia_Click_1(object sender, EventArgs e)
        {
            OcultarGroupBox();
            gbInasistencia.Visible = true;
        }

        private void btnAmonestaciones_Click_1(object sender, EventArgs e)
        {
            OcultarGroupBox();
            gbAmonestaciones.Visible = true;
        }

        private void btnSuspensiones_Click_1(object sender, EventArgs e)
        {
            OcultarGroupBox();
            gbSuspensión.Visible = true;
        }

        private void btnEvaluaciónDesempeño_Click_1(object sender, EventArgs e)
        {
            OcultarGroupBox();
            gbEvaluaciónDesempeño.Visible = true;
        }
    }
}

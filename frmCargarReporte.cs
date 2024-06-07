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
            mrcInasistencia.Visible = false;
            mrcAmonestación.Visible = false;
            mrcSuspensión.Visible = false;
            mrcEvaluaciónDesempeño.Visible = false;
            mrcDespido.Visible = false;
        }

        private void btnInasistencia_Click(object sender, EventArgs e)
        {
            OcultarGroupBox();
            mrcInasistencia.Visible = true;
        }

        private void btnAmonestaciones_Click(object sender, EventArgs e)
        {
            OcultarGroupBox();
            mrcAmonestación.Visible = true;
        }

        private void btnSuspensiones_Click(object sender, EventArgs e)
        {
            OcultarGroupBox();
            mrcSuspensión.Visible = true;
        }

        private void btnEvaluaciónDesempeño_Click(object sender, EventArgs e)
        {
            OcultarGroupBox();
            mrcEvaluaciónDesempeño.Visible = true;
        }
        private void btnDespido_Click(object sender, EventArgs e)
        {
            OcultarGroupBox();
            mrcDespido.Visible = true;
        }
    }
}

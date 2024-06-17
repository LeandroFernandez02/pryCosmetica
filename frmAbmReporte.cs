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
    public partial class frmAbmReporte : Form
    {
        public frmAbmReporte(string tipoReporte)
        {
            InitializeComponent();
            MostrarGroupBox(tipoReporte);
        }

        private void MostrarGroupBox(string tipoReporte)
        {
            // Ocultar todos los GroupBox
            mrcInasistencia.Visible = false;
            mrcSuspensión.Visible = false;
            mrcEvaluaciónDesempeño.Visible = false;
            mrcAmonestación.Visible = false;

            // Mostrar el GroupBox correspondiente
            switch (tipoReporte)
            {
                case "Inasistencias":
                    mrcInasistencia.Visible = true;
                    break;
                case "Amonestaciones":
                    mrcAmonestación.Visible = true;
                    break;
                case "Suspensiones":
                    mrcSuspensión.Visible = true;
                    break;
                case "Evaluacion de Desempeño":
                    mrcEvaluaciónDesempeño.Visible = true;
                    break;
            }
        }
    }
}

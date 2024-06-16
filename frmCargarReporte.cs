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
            //OcultarGroupBox();
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

        private void txtNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra y no es una tecla de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra, cancela el evento
                e.Handled = true;
            }
        }

        private void txtNombreEvaluador_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra y no es una tecla de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra, cancela el evento
                e.Handled = true;
            }
        }

        private void txtCalificación_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es una tecla de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número, cancela el evento
                e.Handled = true;
            }
        }

        private void txtObservaciónEvaluación_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra y no es una tecla de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra, cancela el evento
                e.Handled = true;
            }
        }

        private void txtNombreSuspensión_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra y no es una tecla de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra, cancela el evento
                e.Handled = true;
            }
        }

        private void txtObservación_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra y no es una tecla de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra, cancela el evento
                e.Handled = true;
            }
        }

        private void txtDocumentoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es una tecla de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número, cancela el evento
                e.Handled = true;
            }
        }

        private void txtNombreInasistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra y no es una tecla de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra, cancela el evento
                e.Handled = true;
            }
        }

        private void txtMotivoInasistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra y no es una tecla de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra, cancela el evento
                e.Handled = true;
            }
        }

        private void txtNombreAmonestacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra y no es una tecla de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra, cancela el evento
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (mrcInasistencia.Visible)
            {
                txtNombreInasistencia.Clear();
                txtMotivoInasistencia.Clear();
            }

            if (mrcAmonestación.Visible)
            {
                txtNombreAmonestacion.Clear();
            }

            if (mrcSuspensión.Visible)
            {
                txtNombreSuspensión.Clear();
                txtObservación.Clear();
            }

            if (mrcEvaluaciónDesempeño.Visible)
            {
                txtNombreEmpleado.Clear();
                txtNombreEvaluador.Clear();
                txtCalificación.Clear();
                txtObservaciónEvaluación.Clear();
            }

            if (mrcDespido.Visible)
            {
                txtDocumentoEmpleado.Clear();
            }
        }
    }
}

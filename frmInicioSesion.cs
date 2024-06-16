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
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void timerCargaPrograma_Tick(object sender, EventArgs e)
        {
            
            timerCargaPrograma.Stop(); // Detiene el Timer
            ProgressBar progressBar1 = timerCargaPrograma.Tag as ProgressBar;
            if (progressBar1 != null)
            {
                this.Controls.Remove(progressBar1); // Elimina el ProgressBar del formulario
                progressBar1.Dispose(); // Libera los recursos del ProgressBar
            }
            

            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
            menuPrincipal.Show();
            this.Hide(); // Oculta el formulario actual           
        }



        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {                    
            timerCargaPrograma.Start(); // Inicia el Timer            
        }

        private void txtCuil_Click(object sender, EventArgs e)
        {
            txtCuil.Clear();
            txtCuil.ForeColor = Color.Black;
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.Clear();
            txtContraseña.ForeColor = Color.Black;
            txtContraseña.Font = new Font("Bahnschrift", 10f, FontStyle.Regular);
            txtContraseña.PasswordChar = '●';
        }

        private void txtCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es una tecla de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número, cancela el evento
                e.Handled = true;
            }
        }
    }
}

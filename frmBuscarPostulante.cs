using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace pryCosmetica
{
    public partial class frmBuscarPostulante : Form
    {
        public frmBuscarPostulante()
        {
            InitializeComponent();
        }

        private void cmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            sacarControl();
            int seleccion = cmbBusqueda.SelectedIndex;

            switch (seleccion)
            {
                case 0: //DNI
                    var txtDNI = new Guna.UI2.WinForms.Guna2TextBox();
                    txtDNI.BorderRadius = 10;
                    txtDNI.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
                    txtDNI.ForeColor = Color.Black;
                    txtDNI.BorderColor = Color.FromArgb(51, 0, 51);
                    txtDNI.Visible = true;
                    this.Controls.Add(txtDNI);
                    this.ResumeLayout(false);
                    this.PerformLayout();
                    txtDNI.BringToFront();
                    txtDNI.Refresh();

                    txtDNI.Location = new Point(266, 29);
                    txtDNI.Size = new Size(200, 36);

                    // Agregar el manejador del evento KeyPress
                    txtDNI.KeyPress += new KeyPressEventHandler(txtDNI_KeyPress);
                    break;

                case 1: //Nombre
                    var txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
                    txtNombre.BorderRadius = 10;
                    txtNombre.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
                    txtNombre.ForeColor = Color.Black;
                    txtNombre.BorderColor = Color.FromArgb(51, 0, 51);
                    txtNombre.Visible = true;
                    this.Controls.Add(txtNombre);
                    this.ResumeLayout(false);
                    this.PerformLayout();
                    txtNombre.BringToFront();
                    txtNombre.Refresh();

                    txtNombre.Location = new Point(266, 29);
                    txtNombre.Size = new Size(200, 36);

                    // Agregar el manejador del evento KeyPress
                    txtNombre.KeyPress += new KeyPressEventHandler(txtNombre_KeyPress);
                    break;

                case 2: //Telefono
                    var txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
                    txtTelefono.BorderRadius = 10;
                    txtTelefono.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
                    txtTelefono.ForeColor = Color.Black;
                    txtTelefono.BorderColor = Color.FromArgb(51, 0, 51);
                    txtTelefono.Visible = true;
                    this.Controls.Add(txtTelefono);
                    this.ResumeLayout(false);
                    this.PerformLayout();
                    txtTelefono.BringToFront();
                    txtTelefono.Refresh();

                    txtTelefono.Location = new Point(266, 29);
                    txtTelefono.Size = new Size(200, 36);

                    // Agregar el manejador del evento KeyPress
                    txtTelefono.KeyPress += new KeyPressEventHandler(txtTelefono_KeyPress);
                    break;

                case 3: //Area
                    var cmbArea = new Guna.UI2.WinForms.Guna2ComboBox();
                    cmbArea.BorderRadius = 10;
                    cmbArea.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
                    cmbArea.ForeColor = Color.Black;
                    cmbArea.BorderColor = Color.FromArgb(51, 0, 51);
                    cmbArea.Visible = true;
                    this.Controls.Add(cmbArea);
                    this.ResumeLayout(false);
                    this.PerformLayout();
                    cmbArea.BringToFront();
                    cmbArea.Refresh();

                    cmbArea.Location = new Point(266, 29);
                    cmbArea.Size = new Size(200, 36);
                    break;
            }
        }

        void sacarControl()
        {
            var controlsToRemove = new List<Control>();
            foreach (Control control in this.Controls)
            {
                if ((control is Guna.UI2.WinForms.Guna2TextBox ||
                     control is Guna.UI2.WinForms.Guna2ComboBox ||
                     control is Guna.UI2.WinForms.Guna2DateTimePicker) &&
                     control.Name != "cmbBusqueda") // Asegurarse de no eliminar el cmbFiltro
                {
                    controlsToRemove.Add(control);
                }
            }
            foreach (var control in controlsToRemove)
            {
                this.Controls.Remove(control);
                control.Dispose();
            }
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y la tecla de retroceso (Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y la tecla de retroceso (Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y la tecla de retroceso (Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    } 
}

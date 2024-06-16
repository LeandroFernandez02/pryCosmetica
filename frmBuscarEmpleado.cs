using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace pryCosmetica
{
    public partial class frmBuscarEmpleado : Form
    {                    
        public frmBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedItem != null)
            {
                string selectedValue = cmbFiltro.SelectedItem.ToString();

                limpiarControles();

                if (selectedValue == "Nombre")
                {
                    var txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
                    txtNombre.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
                    txtNombre.ForeColor = Color.Black;
                    txtNombre.BorderRadius = 10;
                    txtNombre.BorderColor = Color.FromArgb(51, 0, 51);
                    txtNombre.Visible = true;
                    this.Controls.Add(txtNombre);
                    this.ResumeLayout(false);
                    this.PerformLayout();
                    txtNombre.BringToFront();
                    txtNombre.Refresh();

                    // Ajustar ubicación y tamaño después de agregar el control
                    txtNombre.Location = new Point(297, 29);
                    txtNombre.Size = new Size(200, 36);

                    // Agregar el manejador del evento KeyPress
                    txtNombre.KeyPress += new KeyPressEventHandler(txtNombre_KeyPress);
                }
                else if (selectedValue == "CUIL")
                {
                    var txtDocumento = new Guna.UI2.WinForms.Guna2TextBox();
                    txtDocumento.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
                    txtDocumento.ForeColor = Color.Black;
                    txtDocumento.BorderRadius = 10;
                    txtDocumento.BorderColor = Color.FromArgb(51, 0, 51);
                    txtDocumento.Visible = true;
                    this.Controls.Add(txtDocumento);
                    this.ResumeLayout(false);
                    this.PerformLayout();
                    txtDocumento.BringToFront();
                    txtDocumento.Refresh();

                    // Ajustar ubicación y tamaño después de agregar el control
                    txtDocumento.Location = new Point(297, 29);
                    txtDocumento.Size = new Size(200, 36);

                    // Agregar el manejador del evento KeyPress
                    txtDocumento.KeyPress += new KeyPressEventHandler(txtDocumento_KeyPress);
                }
                else if (selectedValue == "Estado Civil")
                {
                    var cmbEstadoCivil = new Guna.UI2.WinForms.Guna2ComboBox();
                    cmbEstadoCivil.Location = new Point(297, 29);
                    cmbEstadoCivil.Size = new Size(200, 36);
                    cmbEstadoCivil.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
                    cmbEstadoCivil.ForeColor = Color.Black;
                    cmbEstadoCivil.BorderRadius = 10;
                    cmbEstadoCivil.BorderColor = Color.FromArgb(51, 0, 51);
                    cmbEstadoCivil.Visible = true;
                    this.Controls.Add(cmbEstadoCivil);
                    cmbEstadoCivil.BringToFront();
                    cmbEstadoCivil.Refresh();
                }
                else if (selectedValue == "Contrato")
                {
                    var cmbContrato = new Guna.UI2.WinForms.Guna2ComboBox();
                    cmbContrato.Location = new Point(297, 29);
                    cmbContrato.Size = new Size(200, 36);
                    cmbContrato.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
                    cmbContrato.ForeColor = Color.Black;
                    cmbContrato.BorderRadius = 10;
                    cmbContrato.BorderColor = Color.FromArgb(51, 0, 51);
                    cmbContrato.Visible = true;
                    this.Controls.Add(cmbContrato);
                    cmbContrato.BringToFront();
                    cmbContrato.Refresh();
                }
                else if (selectedValue == "Categoria")
                {
                    var cmbCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
                    cmbCategoria.Location = new Point(297, 29);
                    cmbCategoria.Size = new Size(200, 36);
                    cmbCategoria.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
                    cmbCategoria.ForeColor = Color.Black;
                    cmbCategoria.BorderRadius = 10;
                    cmbCategoria.BorderColor = Color.FromArgb(51, 0, 51);
                    cmbCategoria.Visible = true;
                    this.Controls.Add(cmbCategoria);
                    cmbCategoria.BringToFront();
                    cmbCategoria.Refresh();
                }
                else if (selectedValue == "Fecha de Ingreso")
                {
                    var dtpFechaIngresa = new Guna.UI2.WinForms.Guna2DateTimePicker();
                    dtpFechaIngresa.Location = new Point(297, 29);
                    dtpFechaIngresa.Size = new Size(224, 36);
                    dtpFechaIngresa.Font = new Font("Bahnschrift", 9f);
                    dtpFechaIngresa.BorderRadius = 10;
                    dtpFechaIngresa.FillColor = Color.FromArgb(51, 0, 51);
                    dtpFechaIngresa.ForeColor = Color.FromArgb(255, 255, 255);
                    dtpFechaIngresa.Visible = true;
                    this.Controls.Add(dtpFechaIngresa);
                    dtpFechaIngresa.BringToFront();
                    dtpFechaIngresa.Refresh();
                }
            }
        }

        void limpiarControles()
        {
            var controlsToRemove = new List<Control>();
            foreach (Control control in this.Controls)
            {
                if ((control is Guna.UI2.WinForms.Guna2TextBox ||
                     control is Guna.UI2.WinForms.Guna2ComboBox ||
                     control is Guna.UI2.WinForms.Guna2DateTimePicker) &&
                     control.Name != "cmbFiltro") // Asegurarse de no eliminar el cmbFiltro
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y la tecla de retroceso (Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y la tecla de retroceso (Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
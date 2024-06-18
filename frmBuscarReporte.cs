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
    public partial class frmBuscarReporte : Form
    {
        public frmBuscarReporte()
        {
            InitializeComponent();
        }
        #region ABM
        //  ABRIR FORMULARIO DENTRO DEL PRINCIPAL
        private Form formActivo = null;
        private void abrirFormHijo(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.Controls.Add(formHijo);
            this.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string tipoReporte = "";

            if (dgvInasistencia.Visible)
            {
                tipoReporte = "Inasistencias";
            }
            else if (dgvAmonestacion.Visible)
            {
                tipoReporte = "Amonestaciones";
            }
            else if (dgvSuspension.Visible)
            {
                tipoReporte = "Suspensiones";
            }
            else if (dgvEvaluacion.Visible)
            {
                tipoReporte = "Evaluacion de Desempeño";
            }
            else if (dgvDespido.Visible)
            {
                tipoReporte = "Despidos";
            }

            abrirFormHijo(new frmAbmReporte(tipoReporte));
        }
        #endregion


        private void cmbCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCondicion.SelectedItem != null)
            {
                string selectedValue = cmbCondicion.SelectedItem.ToString();

                limpiarControles();

                if (selectedValue == "CUIL")
                {
                    var txtCUIL = new Guna.UI2.WinForms.Guna2TextBox();
                    txtCUIL.ForeColor = Color.Black;
                    txtCUIL.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
                    txtCUIL.BorderRadius = 10;
                    txtCUIL.BorderColor = Color.Black;
                    txtCUIL.Visible = true;
                    this.Controls.Add(txtCUIL);
                    this.ResumeLayout(false);
                    this.PerformLayout();
                    txtCUIL.BringToFront();
                    txtCUIL.Refresh();

                    txtCUIL.Location = new Point(446, 51);
                    txtCUIL.Size = new Size(200, 36);

                    // Agregar el manejador del evento KeyPress
                    txtCUIL.KeyPress += new KeyPressEventHandler(txtCUIL_KeyPress);
                }
                else if (selectedValue == "Nombre")
                {
                    var txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
                    txtNombre.ForeColor = Color.Black;
                    txtNombre.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
                    txtNombre.BorderRadius = 10;
                    txtNombre.BorderColor = Color.Black;
                    txtNombre.Visible = true;
                    this.Controls.Add(txtNombre);
                    this.ResumeLayout(false);
                    this.PerformLayout();
                    txtNombre.BringToFront();
                    txtNombre.Refresh();

                    txtNombre.Location = new Point(446, 51);
                    txtNombre.Size = new Size(200, 36);

                    // Agregar el manejador del evento KeyPress
                    txtNombre.KeyPress += new KeyPressEventHandler(txtNombre_KeyPress);
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
                     control.Name != "cmbFiltro" && control.Name != "cmbCondicion") // Asegurarse de no eliminar el cmbFiltro
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

        private void txtCUIL_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y la tecla de retroceso (Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedItem != null)
            {
                string selectedValue = cmbFiltro.SelectedItem.ToString();

                limpiarControles();

                if (selectedValue == "Inasistencias")
                {
                    dgvEvaluacion.Visible = false;
                    dgvSuspension.Visible = false;
                    dgvAmonestacion.Visible = false;
                    dgvInasistencia.Visible = true;
                    dgvDespido.Visible = false;
                }
                else if (selectedValue == "Amonestaciones")
                {
                    dgvEvaluacion.Visible = false;
                    dgvSuspension.Visible = false;
                    dgvAmonestacion.Visible = true;
                    dgvInasistencia.Visible = false;
                    dgvDespido.Visible = false;
                }
                else if (selectedValue == "Suspensiones")
                {
                    dgvEvaluacion.Visible = false;
                    dgvSuspension.Visible = true;
                    dgvAmonestacion.Visible = false;
                    dgvInasistencia.Visible = false;
                    dgvDespido.Visible = false;
                }
                else if (selectedValue == "Evaluacion de Desempeño")
                {
                    dgvEvaluacion.Visible = true;
                    dgvSuspension.Visible = false;
                    dgvAmonestacion.Visible = false;
                    dgvInasistencia.Visible = false;
                    dgvDespido.Visible = false;
                }
                else if (selectedValue == "Despidos")
                {
                    dgvEvaluacion.Visible = false;
                    dgvSuspension.Visible = false;
                    dgvAmonestacion.Visible = false;
                    dgvInasistencia.Visible = false;
                    dgvDespido.Visible = true;
                }
            }
        }
    }
}

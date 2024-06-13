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

                if (selectedValue == "Nombre" || selectedValue == "Documento")
                {
                    crearTxt();
                }
                else if (selectedValue == "Estado Civil")
                {
                    crearCmb();
                }
                else if (selectedValue == "Contrato")
                {
                    crearCmb();
                }
                else if (selectedValue == "Categoria")
                {
                    crearCmb();
                }
                else if (selectedValue == "Fecha de Ingreso")
                {
                    crearDtp();
                }
            }
        }

        void crearCmb()
        {
            var cmb = new Guna.UI2.WinForms.Guna2ComboBox();
            cmb.Location = new Point(297, 29);
            cmb.Size = new Size(200, 36);
            cmb.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
            cmb.ForeColor = Color.Black;
            cmb.BorderRadius = 10;
            cmb.BorderColor = Color.FromArgb(51, 0, 51);
            cmb.Visible = true;
            this.Controls.Add(cmb);
            cmb.BringToFront();
            cmb.Refresh();
        }

        void crearTxt()
        {
            var txt = new Guna.UI2.WinForms.Guna2TextBox();
            txt.Location = new Point(297, 29);
            txt.Size = new Size(200, 36);
            txt.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
            txt.ForeColor = Color.Black;
            txt.BorderRadius = 10;
            txt.BorderColor = Color.FromArgb(51, 0, 51);
            txt.Visible = true;
            this.Controls.Add(txt);
            this.ResumeLayout(false);
            this.PerformLayout();
            txt.BringToFront();
            txt.Refresh();

            // Ajustar ubicación y tamaño después de agregar el control
            txt.Location = new Point(297, 29);
            txt.Size = new Size(200, 36);
        }

        void crearDtp()
        {
            var dtp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtp.Location = new Point(297, 29);
            dtp.Size = new Size(224, 36);
            dtp.Font = new Font("Bahnschrift", 9f);
            dtp.BorderRadius = 10;
            dtp.FillColor = Color.FromArgb(51, 0, 51);
            dtp.ForeColor = Color.FromArgb(255, 255, 255);
            dtp.Visible = true;
            this.Controls.Add(dtp);
            dtp.BringToFront();
            dtp.Refresh();
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
    }
}
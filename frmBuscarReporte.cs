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

        private void cmbCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCondicion.SelectedItem != null)
            {
                string selectedValue = cmbCondicion.SelectedItem.ToString();

                limpiarControles();

                if (selectedValue == "ID" || selectedValue == "Nombre" || selectedValue == "Documento")
                {
                    crearTxt();
                }
            }
        }
        
        void crearTxt()
        {
            var txt = new Guna.UI2.WinForms.Guna2TextBox();
            txt.Location = new Point(446, 51);
            txt.Size = new Size(200, 36);
            txt.ForeColor = Color.Black;
            txt.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
            txt.BorderRadius = 10;
            txt.BorderColor = Color.Black;
            txt.Visible = true;
            this.Controls.Add(txt);
            this.ResumeLayout(false);
            this.PerformLayout();
            txt.BringToFront();
            txt.Refresh();

            // Ajustar ubicación y tamaño después de agregar el control
            txt.Location = new Point(446, 51);
            txt.Size = new Size(200, 36);
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
    }
}

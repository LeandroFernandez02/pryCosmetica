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
                    crearTxt();
                    break;

                case 1: //Nombre
                    crearTxt();
                    break;

                case 2: //Correo
                    crearTxt();
                    break;

                case 3: //Telefono
                    crearTxt();
                    break;

                case 4: //Area
                    crearCmb();
                    break;
            }
        }
        void crearTxt()
        {
            var txt = new Guna.UI2.WinForms.Guna2TextBox();
            txt.Location = new Point(266, 29);
            txt.BorderRadius = 10;
            txt.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
            txt.ForeColor = Color.Black;
            txt.BorderColor = Color.FromArgb(51, 0, 51);
            txt.Visible = true;
            this.Controls.Add(txt);
            this.ResumeLayout(false);
            this.PerformLayout();
            txt.BringToFront();
            txt.Refresh();

            txt.Location = new Point(266, 29);
            txt.Size = new Size(200, 36);
        }
        void crearCmb()
        {
            var cmb = new Guna.UI2.WinForms.Guna2ComboBox();
            cmb.Location = new Point(266, 29);
            cmb.BorderRadius = 10;
            cmb.Font = new Font("Bahnschrift", 11.25f, FontStyle.Regular);
            cmb.ForeColor = Color.Black;
            cmb.BorderColor = Color.FromArgb(51, 0, 51);
            cmb.Visible = true;
            this.Controls.Add(cmb);
            this.ResumeLayout(false);
            this.PerformLayout();
            cmb.BringToFront();
            cmb.Refresh();

            cmb.Location = new Point(266, 29);
            cmb.Size = new Size(200, 36);
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
    } 
}

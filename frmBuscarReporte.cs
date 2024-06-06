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

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedItem != null)
            {
                string selectedValue = cmbFiltro.SelectedItem.ToString();

                limpiarControles();

                if (selectedValue == "Inasistencias")
                {
                    cmbCondicion.Visible = true;
                }
                else if (selectedValue == "Amonestaciones")
                {
                    cmbCondicion.Visible = true;
                }
                else if (selectedValue == "Suspenciones")
                {
                    cmbCondicion.Visible = true;
                }
                else if (selectedValue == "Evaluacion de Desempeño")
                {
                    cmbCondicion.Visible = true;
                }
            }
        }

        private void cmbCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCondicion.SelectedItem != null)
            {
                string selectedValue = cmbCondicion.SelectedItem.ToString();

                limpiarControles();

                if (selectedValue == "ID")
                {
                    crearTxt();
                }
                else if (selectedValue == "Nombre")
                {
                    crearTxt();
                }
                else if (selectedValue == "Documento")
                {
                    crearTxt();
                }
            }
        }

        Guna.UI2.WinForms.Guna2ComboBox cmb = new Guna.UI2.WinForms.Guna2ComboBox();
        void crearCmb()
        {
            cmb.Location = new Point(335, 58);
            cmb.Size = new Size(200, 36);
            cmb.Visible = true;
            this.Controls.Add(cmb);
            cmb.Focus();
        }

        Guna.UI2.WinForms.Guna2TextBox txt = new Guna.UI2.WinForms.Guna2TextBox();
        void crearTxt()
        {
            txt.Location = new Point(446, 51);
            txt.Size = new Size(200, 36);
            txt.Visible = true;
            this.Controls.Add(txt);
            txt.Focus();
        }

        Guna.UI2.WinForms.Guna2DateTimePicker dtp = new Guna.UI2.WinForms.Guna2DateTimePicker();
        void crearDtp()
        {
            dtp.Location = new Point(335, 58);
            dtp.Size = new Size(200, 36);
            dtp.Visible = true;
            this.Controls.Add(dtp);
            dtp.Focus();
        }
        void limpiarControles()
        {
            txt.Visible = false;
            cmb.Visible = false;
            cmb.Items.Clear();
            dtp.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Una vez que se aprete buscar, se deben cargar las columnas correspondientes a cada condicion. EJ: Amonestaciones, lleva tablas: ID - Empleado - Fecha - Motivo.
        }
    }
}

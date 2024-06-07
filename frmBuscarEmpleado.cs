using System;
using System.Drawing;
using System.Windows.Forms;

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
                    crearTxt();
                }
                else if (selectedValue == "Documento")
                {
                    crearTxt();
                }
                else if (selectedValue == "Estado Civil")
                {
                    crearCmb();
                    cmb.Items.Add("Soltero/a");
                    cmb.Items.Add("Casado/a");
                    cmb.Items.Add("Divorciado/a");
                    cmb.Items.Add("Viudo/a");
                }
                else if (selectedValue == "Contrato")
                {
                    crearCmb();                 
                    cmb.Items.Add("Contrato de pasantía");
                    cmb.Items.Add("Contrato de temporada");
                    cmb.Items.Add("Contrato por tiempo indeterminado");
                    cmb.Items.Add("Contrato por tiempo determinado");
                }
                else if (selectedValue == "Categoria")
                {
                    crearCmb();
                    cmb.Items.Add("Gerente");
                    cmb.Items.Add("Ejecutivo");
                    cmb.Items.Add("Asistente");
                }
                else if (selectedValue == "Fecha de Ingreso")
                {
                    crearDtp();
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
            txt.Location = new Point(335, 58);
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
    }
}
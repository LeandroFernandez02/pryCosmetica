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
    public partial class frmBuscarPostulante : Form
    {
        public frmBuscarPostulante()
        {
            InitializeComponent();
        }

        Guna.UI2.WinForms.Guna2TextBox txt = new Guna.UI2.WinForms.Guna2TextBox();
        Guna.UI2.WinForms.Guna2ComboBox cmb = new Guna.UI2.WinForms.Guna2ComboBox();

        private void cmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            sacarControl();
            int seleccion = cmbBusqueda.SelectedIndex;

            switch (seleccion)
            {
                case 0: //DNI
                    txt.Location = new Point(266, 29);
                    txt.Visible = true;
                    this.Controls.Add(txt);
                    break;

                case 1: //Nombre
                    txt.Location = new Point(266, 29);
                    txt.Visible = true;
                    this.Controls.Add(txt);
                    break;

                case 2: //Correo
                    txt.Location = new Point(266, 29);
                    txt.Visible = true;
                    this.Controls.Add(txt);
                    break;

                case 3: //Telefono
                    txt.Location = new Point(266, 29);
                    txt.Visible = true;
                    this.Controls.Add(txt);
                    break;

                case 4: //Area
                    cmb.Location = new Point(266, 29);
                    cmb.Size = txt.Size;
                    cmb.Visible = true;
                    this.Controls.Add(cmb);
                    cmb.Items.Add("Investigación y Desarrollo");
                    cmb.Items.Add("Marketing y Ventas");
                    cmb.Items.Add("Logística y Distribución");
                    cmb.Items.Add("Administración y Finanzas");
                    cmb.Items.Add("Recursos Humanos");
                    cmb.Items.Add("Legal");
                    break;
            }
        }

        void sacarControl()
        {
            txt.Visible = false;
            cmb.Visible = false;
            cmb.Items.Clear();
        }
    }
}

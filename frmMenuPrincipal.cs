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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

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
            pnlPrincipal.Controls.Add(formHijo);
            pnlPrincipal.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        // ABRIR Y OCULTAR SUBMENUS   

        private void ocultarSubMenu()
        {
            if (pnlSubMenuEmpleados.Visible == true)
            {
                pnlSubMenuEmpleados.Visible = false;
            }
            if (pnlSubMenuPostulante.Visible == true)
            {
                pnlSubMenuPostulante.Visible=false;
            }
        }
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuEmpleados);
            
        }

        private void btnPostulante_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuPostulante);
            
        }

        private void btnCargarEmpleado_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmCargarEmpleado());
            // codigo
            ocultarSubMenu();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmBuscarEmpleado());
            ocultarSubMenu();
        }

        private void btnReportarEmpleado_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmReportarEmpleado());
            ocultarSubMenu();
        }

        private void btnCargarPostulante_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmCargarPostulante());
            ocultarSubMenu();
        }

        private void btnBuscarPostulante_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmBuscarPostulante());
            ocultarSubMenu();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

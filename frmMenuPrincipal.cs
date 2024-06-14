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
            lblTitulo.Text = "Inicio";
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
            if(pnlSubMenuReportes.Visible == true)
            {
                pnlSubMenuReportes.Visible=false;
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
        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlSubMenuReportes);           
        }

        private void btnCargarEmpleado_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Cargar Empleado";
            abrirFormHijo(new frmCargarEmpleado());
            // codigo
            frmCargarEmpleado frm = new frmCargarEmpleado();
            ocultarSubMenu();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        { 
            lblTitulo.Text = "Buscar Empleados";
            abrirFormHijo(new frmBuscarEmpleado());
            ocultarSubMenu();
        }

        private void btnCargarPostulante_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Cargar Postulante";
            abrirFormHijo(new frmCargarPostulante());
            ocultarSubMenu();
        }

        private void btnBuscarPostulante_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Buscar Postulantes";
            abrirFormHijo(new frmBuscarPostulante());
            ocultarSubMenu();
        }
        private void btnCargarReporte_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Cargar Reporte";
            abrirFormHijo(new frmCargarReporte());
            ocultarSubMenu();
        }

        private void btnBuscarReporte_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Buscar Reportes";
            abrirFormHijo(new frmBuscarReporte());
            ocultarSubMenu();
        }

        private void pctLogo_Click(object sender, EventArgs e)
        {
            if (formActivo != null)
                formActivo.Close();
            lblTitulo.Text = "Inicio";
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

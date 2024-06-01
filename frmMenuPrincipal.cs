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

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmEmpleados());
        }

        private void btnPostulantes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmPostulantes());
        }
    }
}

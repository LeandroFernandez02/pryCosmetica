using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCosmetica
{
    public partial class frmCargarEmpleado : Form
    {
        public frmCargarEmpleado()
        {
            InitializeComponent();
        }

        public static string nombreEmpleado;
        public static string apellidoEmpleado;
        public static string cuil;
        public static string tipoDocumento;
        public static string numeroDocumentoEmpleado;
        public static string telefonoEmpleado;
        public static string estadoCivilEmpleado;
        public static string mailEmpleado;
        public static DateTime fechaNacimientoEmpleado;
        public static DateTime fechaIngresoEmpleado;
        public static string areaDeTrabajo;
        public static string tipoDeContrato;
        public static string categoria;
        public static string calle;
        public static string ciudad;
        public static string numeroCalle;
        public static string codPostal;
        public static string barrio;
        public static string filePath;

        private void btnCargarEmpleado_Click(object sender, EventArgs e)
        {
            nombreEmpleado = txtNombreEmpleado.Text;
            apellidoEmpleado = txtApellidoEmpleado.Text;
            cuil = txtILegajo.Text;
            estadoCivilEmpleado = lstEstadoCivil.SelectedItem.ToString();
            tipoDocumento = lstTipoDocumento.SelectedItem.ToString();
            numeroDocumentoEmpleado = txtNúmeroDocumento.Text;
            telefonoEmpleado = txtTeléfono.Text;
            mailEmpleado = txtMail.Text;
            fechaNacimientoEmpleado = dtpFechaNacimiento.Value;
            fechaIngresoEmpleado = dtpFechaIngreso.Value;
            areaDeTrabajo = lstAreaEmpleado.SelectedItem.ToString();
            tipoDeContrato = lstTipoContrato.SelectedItem.ToString();
            categoria = lstCategoría.SelectedItem.ToString();
            calle = lstCalle.SelectedItem.ToString();
            numeroCalle = txtNúmeroCalle.Text;
            ciudad = lstCiudad.SelectedItem.ToString();
            codPostal = txtCodPostal.Text;
            barrio = lstBarrio.SelectedItem.ToString();

            clsProcesosBD objProcesos = new clsProcesosBD();

            objProcesos.CargarEmpleado();

            objProcesos.CargarAreaEmpleado();
        }

        private void frmCargarEmpleado_Load(object sender, EventArgs e)
        {
            clsProcesosBD objProcesos = new clsProcesosBD();

            objProcesos.CargarTipoDocumento(lstTipoDocumento);
            objProcesos.CargarEstadoCivil(lstEstadoCivil);
            objProcesos.CargarCategoria(lstCategoría);
            objProcesos.CargarAreaDeTrabajo(lstAreaEmpleado);
            objProcesos.CargarTipoDeContrato(lstTipoContrato);
            objProcesos.CargarCalles(lstCalle);
            objProcesos.CargarCiudad(lstCiudad);
            objProcesos.CargarBarrio(lstBarrio);
        }
    }
}

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
    public partial class frmCargarPostulante : Form
    {
        public frmCargarPostulante()
        {
            InitializeComponent();
        }

        private void btnCargarCv_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Configurar propiedades del SaveFileDialog
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                // Obtener el directorio del ejecutable de la aplicación
                string executablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Construir la ruta relativa ../../CV
                string relativePath = Path.Combine(executablePath, @"..\..\CVpostulante");
                string initialDirectory = Path.GetFullPath(relativePath);

                // Verificar si la ruta existe, si no, crearla
                if (!Directory.Exists(initialDirectory))
                {
                    Directory.CreateDirectory(initialDirectory);
                    MessageBox.Show("La carpeta CV no existía y ha sido creada en: " + initialDirectory);
                }

                // Establecer la ruta inicial
                saveFileDialog.InitialDirectory = initialDirectory;

                // Mostrar el SaveFileDialog
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Aquí puedes manejar la ruta seleccionada
                    string filePath = saveFileDialog.FileName;
                    MessageBox.Show("El archivo será guardado en: " + filePath);
                }
            }
        }

        private void txtNombrePostulante_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra y no es una tecla de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra, cancela el evento
                e.Handled = true;
            }
        }

        private void txtApellidoPostulante_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es una letra y no es una tecla de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra, cancela el evento
                e.Handled = true;
            }
        }

        private void txtDNIPostulante_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es una tecla de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número, cancela el evento
                e.Handled = true;
            }
        }

        private void txtTeléfonoPostulante_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número y no es una tecla de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número, cancela el evento
                e.Handled = true;
            }
        }
    }
}

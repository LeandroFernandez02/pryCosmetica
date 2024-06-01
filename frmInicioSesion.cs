﻿using System;
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
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {           
            mrcInicioSesion.Visible = false;
            ProgressBar cargaPrograma = new ProgressBar();
            cargaPrograma.Style = ProgressBarStyle.Marquee;
            cargaPrograma.Location = new Point(mrcInicioSesion.Location.X, 267);
            cargaPrograma.Size=new Size(269, 20);   
            cargaPrograma.Visible = true;
            this.Controls.Add(cargaPrograma);

            timerCargaPrograma.Tag = cargaPrograma; // Almacena el ProgressBar en la propiedad Tag del Timer
            timerCargaPrograma.Start(); // Inicia el Timer
        }

        private void timerCargaPrograma_Tick(object sender, EventArgs e)
        {
            timerCargaPrograma.Stop(); // Detiene el Timer
            ProgressBar progressBar1 = timerCargaPrograma.Tag as ProgressBar;
            if (progressBar1 != null)
            {
                this.Controls.Remove(progressBar1); // Elimina el ProgressBar del formulario
                progressBar1.Dispose(); // Libera los recursos del ProgressBar
            }

            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
            menuPrincipal.Show();
            this.Hide(); // Oculta el formulario actual            
        }
    }
}

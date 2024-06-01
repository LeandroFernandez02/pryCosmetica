namespace pryCosmetica
{
    partial class frmInicioSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.mrcInicioSesion = new System.Windows.Forms.GroupBox();
            this.timerCargaPrograma = new System.Windows.Forms.Timer(this.components);
            this.mrcInicioSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(95, 131);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // mrcInicioSesion
            // 
            this.mrcInicioSesion.Controls.Add(this.label1);
            this.mrcInicioSesion.Controls.Add(this.btnIngresar);
            this.mrcInicioSesion.Controls.Add(this.label2);
            this.mrcInicioSesion.Controls.Add(this.textBox2);
            this.mrcInicioSesion.Controls.Add(this.textBox1);
            this.mrcInicioSesion.Location = new System.Drawing.Point(376, 178);
            this.mrcInicioSesion.Name = "mrcInicioSesion";
            this.mrcInicioSesion.Size = new System.Drawing.Size(269, 203);
            this.mrcInicioSesion.TabIndex = 5;
            this.mrcInicioSesion.TabStop = false;
            // 
            // timerCargaPrograma
            // 
            this.timerCargaPrograma.Interval = 2000;
            this.timerCargaPrograma.Tick += new System.EventHandler(this.timerCargaPrograma_Tick);
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 590);
            this.Controls.Add(this.mrcInicioSesion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1043, 629);
            this.MinimumSize = new System.Drawing.Size(1043, 629);
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.mrcInicioSesion.ResumeLayout(false);
            this.mrcInicioSesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox mrcInicioSesion;
        private System.Windows.Forms.Timer timerCargaPrograma;
    }
}
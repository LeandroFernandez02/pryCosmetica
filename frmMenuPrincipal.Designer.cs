namespace pryCosmetica
{
    partial class frmMenuPrincipal
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
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.ejemploToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemploToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemploToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemploToolStripMenuItem,
            this.ejemploToolStripMenuItem1,
            this.ejemploToolStripMenuItem2});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(1027, 24);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // ejemploToolStripMenuItem
            // 
            this.ejemploToolStripMenuItem.Name = "ejemploToolStripMenuItem";
            this.ejemploToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ejemploToolStripMenuItem.Text = "Ejemplo";
            this.ejemploToolStripMenuItem.Click += new System.EventHandler(this.ejemploToolStripMenuItem_Click);
            // 
            // ejemploToolStripMenuItem1
            // 
            this.ejemploToolStripMenuItem1.Name = "ejemploToolStripMenuItem1";
            this.ejemploToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.ejemploToolStripMenuItem1.Text = "Ejemplo";
            this.ejemploToolStripMenuItem1.Click += new System.EventHandler(this.ejemploToolStripMenuItem1_Click);
            // 
            // ejemploToolStripMenuItem2
            // 
            this.ejemploToolStripMenuItem2.Name = "ejemploToolStripMenuItem2";
            this.ejemploToolStripMenuItem2.Size = new System.Drawing.Size(62, 20);
            this.ejemploToolStripMenuItem2.Text = "Ejemplo";
            this.ejemploToolStripMenuItem2.Click += new System.EventHandler(this.ejemploToolStripMenuItem2_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 24);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1027, 566);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 590);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.mnsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnsMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1043, 629);
            this.MinimumSize = new System.Drawing.Size(1043, 629);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem ejemploToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemploToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ejemploToolStripMenuItem2;
        private System.Windows.Forms.Panel pnlPrincipal;
    }
}
﻿namespace pryCosmetica
{
    partial class frmCargarPostulante
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
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.mrcDatosContacto = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblCV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCargarCV = new Guna.UI2.WinForms.Guna2Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTeléfonoPostulante = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.mrcDatosPersonales = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbArea = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNIPostulante = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellidoPostulante = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombrePostulante = new Guna.UI2.WinForms.Guna2TextBox();
            this.mrcDatosContacto.SuspendLayout();
            this.mrcDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 12;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(605, 481);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 45);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 12;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(147, 481);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 45);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            // 
            // mrcDatosContacto
            // 
            this.mrcDatosContacto.BorderRadius = 22;
            this.mrcDatosContacto.Controls.Add(this.lblCV);
            this.mrcDatosContacto.Controls.Add(this.btnCargarCV);
            this.mrcDatosContacto.Controls.Add(this.lblTelefono);
            this.mrcDatosContacto.Controls.Add(this.txtTeléfonoPostulante);
            this.mrcDatosContacto.Controls.Add(this.lblCorreo);
            this.mrcDatosContacto.Controls.Add(this.txtCorreo);
            this.mrcDatosContacto.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.mrcDatosContacto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mrcDatosContacto.ForeColor = System.Drawing.Color.White;
            this.mrcDatosContacto.Location = new System.Drawing.Point(148, 256);
            this.mrcDatosContacto.Name = "mrcDatosContacto";
            this.mrcDatosContacto.Size = new System.Drawing.Size(637, 178);
            this.mrcDatosContacto.TabIndex = 12;
            this.mrcDatosContacto.Text = "Datos de Contacto";
            // 
            // lblCV
            // 
            this.lblCV.BackColor = System.Drawing.Color.Transparent;
            this.lblCV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCV.Location = new System.Drawing.Point(427, 74);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(138, 22);
            this.lblCV.TabIndex = 5;
            this.lblCV.Text = "Adjuntar Curriculum:";
            // 
            // btnCargarCV
            // 
            this.btnCargarCV.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarCV.BorderRadius = 12;
            this.btnCargarCV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCargarCV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCargarCV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCargarCV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCargarCV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.btnCargarCV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCargarCV.ForeColor = System.Drawing.Color.White;
            this.btnCargarCV.Location = new System.Drawing.Point(406, 106);
            this.btnCargarCV.Name = "btnCargarCV";
            this.btnCargarCV.Size = new System.Drawing.Size(180, 45);
            this.btnCargarCV.TabIndex = 4;
            this.btnCargarCV.Text = "Cargar CV";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.lblTelefono.Location = new System.Drawing.Point(25, 124);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 21);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTeléfonoPostulante
            // 
            this.txtTeléfonoPostulante.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.txtTeléfonoPostulante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTeléfonoPostulante.DefaultText = "";
            this.txtTeléfonoPostulante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTeléfonoPostulante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTeléfonoPostulante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTeléfonoPostulante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTeléfonoPostulante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTeléfonoPostulante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTeléfonoPostulante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTeléfonoPostulante.Location = new System.Drawing.Point(114, 115);
            this.txtTeléfonoPostulante.Name = "txtTeléfonoPostulante";
            this.txtTeléfonoPostulante.PasswordChar = '\0';
            this.txtTeléfonoPostulante.PlaceholderText = "";
            this.txtTeléfonoPostulante.SelectedText = "";
            this.txtTeléfonoPostulante.Size = new System.Drawing.Size(193, 36);
            this.txtTeléfonoPostulante.TabIndex = 2;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.lblCorreo.Location = new System.Drawing.Point(25, 69);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(61, 21);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.DefaultText = "";
            this.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreo.Location = new System.Drawing.Point(114, 60);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PlaceholderText = "";
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.Size = new System.Drawing.Size(193, 36);
            this.txtCorreo.TabIndex = 0;
            // 
            // mrcDatosPersonales
            // 
            this.mrcDatosPersonales.BorderRadius = 22;
            this.mrcDatosPersonales.Controls.Add(this.lblArea);
            this.mrcDatosPersonales.Controls.Add(this.cmbArea);
            this.mrcDatosPersonales.Controls.Add(this.lblDNI);
            this.mrcDatosPersonales.Controls.Add(this.txtDNIPostulante);
            this.mrcDatosPersonales.Controls.Add(this.lblApellido);
            this.mrcDatosPersonales.Controls.Add(this.txtApellidoPostulante);
            this.mrcDatosPersonales.Controls.Add(this.lblNombre);
            this.mrcDatosPersonales.Controls.Add(this.txtNombrePostulante);
            this.mrcDatosPersonales.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.mrcDatosPersonales.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mrcDatosPersonales.ForeColor = System.Drawing.Color.White;
            this.mrcDatosPersonales.Location = new System.Drawing.Point(148, 18);
            this.mrcDatosPersonales.Name = "mrcDatosPersonales";
            this.mrcDatosPersonales.Size = new System.Drawing.Size(637, 178);
            this.mrcDatosPersonales.TabIndex = 10;
            this.mrcDatosPersonales.Text = "Datos Personales";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.lblArea.Location = new System.Drawing.Point(347, 123);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(45, 21);
            this.lblArea.TabIndex = 7;
            this.lblArea.Text = "Area:";
            // 
            // cmbArea
            // 
            this.cmbArea.BackColor = System.Drawing.Color.Transparent;
            this.cmbArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.cmbArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbArea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbArea.ItemHeight = 30;
            this.cmbArea.Items.AddRange(new object[] {
            "Investigación y Desarrollo",
            "Marketing y Ventas",
            "Logística y Distribución",
            "Administración y Finanzas",
            "Recursos Humanos",
            "Legal"});
            this.cmbArea.Location = new System.Drawing.Point(406, 115);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(193, 36);
            this.cmbArea.TabIndex = 6;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.lblDNI.Location = new System.Drawing.Point(347, 69);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(40, 21);
            this.lblDNI.TabIndex = 5;
            this.lblDNI.Text = "DNI:";
            // 
            // txtDNIPostulante
            // 
            this.txtDNIPostulante.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.txtDNIPostulante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDNIPostulante.DefaultText = "";
            this.txtDNIPostulante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDNIPostulante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDNIPostulante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDNIPostulante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDNIPostulante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDNIPostulante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDNIPostulante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDNIPostulante.Location = new System.Drawing.Point(406, 60);
            this.txtDNIPostulante.Name = "txtDNIPostulante";
            this.txtDNIPostulante.PasswordChar = '\0';
            this.txtDNIPostulante.PlaceholderText = "";
            this.txtDNIPostulante.SelectedText = "";
            this.txtDNIPostulante.Size = new System.Drawing.Size(193, 36);
            this.txtDNIPostulante.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.lblApellido.Location = new System.Drawing.Point(25, 124);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 21);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellidoPostulante
            // 
            this.txtApellidoPostulante.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.txtApellidoPostulante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidoPostulante.DefaultText = "";
            this.txtApellidoPostulante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidoPostulante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidoPostulante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoPostulante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidoPostulante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoPostulante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellidoPostulante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidoPostulante.Location = new System.Drawing.Point(114, 115);
            this.txtApellidoPostulante.Name = "txtApellidoPostulante";
            this.txtApellidoPostulante.PasswordChar = '\0';
            this.txtApellidoPostulante.PlaceholderText = "";
            this.txtApellidoPostulante.SelectedText = "";
            this.txtApellidoPostulante.Size = new System.Drawing.Size(193, 36);
            this.txtApellidoPostulante.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.lblNombre.Location = new System.Drawing.Point(25, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 21);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombrePostulante
            // 
            this.txtNombrePostulante.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.txtNombrePostulante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombrePostulante.DefaultText = "";
            this.txtNombrePostulante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombrePostulante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombrePostulante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombrePostulante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombrePostulante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombrePostulante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombrePostulante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombrePostulante.Location = new System.Drawing.Point(114, 60);
            this.txtNombrePostulante.Name = "txtNombrePostulante";
            this.txtNombrePostulante.PasswordChar = '\0';
            this.txtNombrePostulante.PlaceholderText = "";
            this.txtNombrePostulante.SelectedText = "";
            this.txtNombrePostulante.Size = new System.Drawing.Size(193, 36);
            this.txtNombrePostulante.TabIndex = 0;
            // 
            // frmCargarPostulante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 545);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.mrcDatosContacto);
            this.Controls.Add(this.mrcDatosPersonales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCargarPostulante";
            this.Text = "frmCargarPostulante";
            this.mrcDatosContacto.ResumeLayout(false);
            this.mrcDatosContacto.PerformLayout();
            this.mrcDatosPersonales.ResumeLayout(false);
            this.mrcDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2GroupBox mrcDatosContacto;
        private Guna.UI2.WinForms.Guna2Button btnCargarCV;
        private System.Windows.Forms.Label lblTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtTeléfonoPostulante;
        private System.Windows.Forms.Label lblCorreo;
        private Guna.UI2.WinForms.Guna2TextBox txtCorreo;
        private Guna.UI2.WinForms.Guna2GroupBox mrcDatosPersonales;
        private System.Windows.Forms.Label lblArea;
        private Guna.UI2.WinForms.Guna2ComboBox cmbArea;
        private System.Windows.Forms.Label lblDNI;
        private Guna.UI2.WinForms.Guna2TextBox txtDNIPostulante;
        private System.Windows.Forms.Label lblApellido;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidoPostulante;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtNombrePostulante;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCV;
    }
}
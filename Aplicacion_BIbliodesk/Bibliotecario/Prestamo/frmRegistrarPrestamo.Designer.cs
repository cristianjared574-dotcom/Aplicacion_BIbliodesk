namespace Aplicacion_BIbliodesk.Bibliotecario.Prestamo
{
    partial class frmRegistrarPrestamo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTelefonoUsuario = new System.Windows.Forms.Label();
            this.lblCorreoUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblAutorLibro = new System.Windows.Forms.Label();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.lblClaveEjemplar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.dtpPrestamo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarPrestamo = new System.Windows.Forms.Button();
            this.picBuscarUsuario = new FontAwesome.Sharp.IconPictureBox();
            this.picBuscarLibro = new FontAwesome.Sharp.IconPictureBox();
            this.ToolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardarPrestamo);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(185, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 472);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(24, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1098, 379);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Registrar prestamo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Usuario";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.picBuscarUsuario);
            this.groupBox5.Controls.Add(this.txtIdUsuario);
            this.groupBox5.Controls.Add(this.lblTelefonoUsuario);
            this.groupBox5.Controls.Add(this.lblCorreoUsuario);
            this.groupBox5.Controls.Add(this.lblNombreUsuario);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(6, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(334, 267);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // lblTelefonoUsuario
            // 
            this.lblTelefonoUsuario.AutoSize = true;
            this.lblTelefonoUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoUsuario.Location = new System.Drawing.Point(11, 224);
            this.lblTelefonoUsuario.Name = "lblTelefonoUsuario";
            this.lblTelefonoUsuario.Size = new System.Drawing.Size(80, 21);
            this.lblTelefonoUsuario.TabIndex = 17;
            this.lblTelefonoUsuario.Text = "Telefono";
            // 
            // lblCorreoUsuario
            // 
            this.lblCorreoUsuario.AutoSize = true;
            this.lblCorreoUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoUsuario.Location = new System.Drawing.Point(11, 179);
            this.lblCorreoUsuario.Name = "lblCorreoUsuario";
            this.lblCorreoUsuario.Size = new System.Drawing.Size(72, 21);
            this.lblCorreoUsuario.TabIndex = 16;
            this.lblCorreoUsuario.Text = "Correo:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(11, 132);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(82, 21);
            this.lblNombreUsuario.TabIndex = 15;
            this.lblNombreUsuario.Text = "Nombre:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 19);
            this.label14.TabIndex = 14;
            this.label14.Text = "Datos encontrados:";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdUsuario.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(25, 46);
            this.txtIdUsuario.Multiline = true;
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(259, 28);
            this.txtIdUsuario.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 19);
            this.label17.TabIndex = 12;
            this.label17.Text = "ID Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(406, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 326);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del libro";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.picBuscarLibro);
            this.groupBox6.Controls.Add(this.lblAutorLibro);
            this.groupBox6.Controls.Add(this.lblNombreLibro);
            this.groupBox6.Controls.Add(this.lblClaveEjemplar);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtTituloLibro);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(6, 31);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(326, 267);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            // 
            // lblAutorLibro
            // 
            this.lblAutorLibro.AutoSize = true;
            this.lblAutorLibro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorLibro.Location = new System.Drawing.Point(16, 230);
            this.lblAutorLibro.Name = "lblAutorLibro";
            this.lblAutorLibro.Size = new System.Drawing.Size(61, 21);
            this.lblAutorLibro.TabIndex = 17;
            this.lblAutorLibro.Text = "Autor:";
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLibro.Location = new System.Drawing.Point(16, 174);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(54, 21);
            this.lblNombreLibro.TabIndex = 16;
            this.lblNombreLibro.Text = "Libro:";
            // 
            // lblClaveEjemplar
            // 
            this.lblClaveEjemplar.AutoSize = true;
            this.lblClaveEjemplar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveEjemplar.Location = new System.Drawing.Point(16, 125);
            this.lblClaveEjemplar.Name = "lblClaveEjemplar";
            this.lblClaveEjemplar.Size = new System.Drawing.Size(174, 21);
            this.lblClaveEjemplar.TabIndex = 15;
            this.lblClaveEjemplar.Text = "Clave del ejemplar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Datos encontrados:";
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTituloLibro.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloLibro.Location = new System.Drawing.Point(19, 46);
            this.txtTituloLibro.Multiline = true;
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(259, 28);
            this.txtTituloLibro.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ttulo del libro";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(774, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 326);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fechas de prestamos";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtpDevolucion);
            this.groupBox7.Controls.Add(this.dtpPrestamo);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Location = new System.Drawing.Point(6, 31);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(293, 267);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.CustomFormat = "dd MMMM yyyy";
            this.dtpDevolucion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDevolucion.Location = new System.Drawing.Point(10, 174);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(240, 28);
            this.dtpDevolucion.TabIndex = 8;
            // 
            // dtpPrestamo
            // 
            this.dtpPrestamo.CustomFormat = "dd MMMM yyyy";
            this.dtpPrestamo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPrestamo.Location = new System.Drawing.Point(10, 65);
            this.dtpPrestamo.Name = "dtpPrestamo";
            this.dtpPrestamo.Size = new System.Drawing.Size(240, 28);
            this.dtpPrestamo.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de devolución";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Fecha de prestamo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(540, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(190, 48);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarPrestamo
            // 
            this.btnGuardarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGuardarPrestamo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPrestamo.Location = new System.Drawing.Point(338, 413);
            this.btnGuardarPrestamo.Name = "btnGuardarPrestamo";
            this.btnGuardarPrestamo.Size = new System.Drawing.Size(190, 48);
            this.btnGuardarPrestamo.TabIndex = 6;
            this.btnGuardarPrestamo.Text = "Guardar préstamo";
            this.btnGuardarPrestamo.UseVisualStyleBackColor = false;
            // 
            // picBuscarUsuario
            // 
            this.picBuscarUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picBuscarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBuscarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBuscarUsuario.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.picBuscarUsuario.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBuscarUsuario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.picBuscarUsuario.IconSize = 25;
            this.picBuscarUsuario.Location = new System.Drawing.Point(277, 46);
            this.picBuscarUsuario.Name = "picBuscarUsuario";
            this.picBuscarUsuario.Size = new System.Drawing.Size(24, 28);
            this.picBuscarUsuario.TabIndex = 18;
            this.picBuscarUsuario.TabStop = false;
            this.picBuscarUsuario.Click += new System.EventHandler(this.picBuscarUsuario_Click);
            this.picBuscarUsuario.MouseHover += new System.EventHandler(this.picBuscarUsuario_MouseHover);
            // 
            // picBuscarLibro
            // 
            this.picBuscarLibro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picBuscarLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBuscarLibro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBuscarLibro.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.picBuscarLibro.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picBuscarLibro.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.picBuscarLibro.IconSize = 24;
            this.picBuscarLibro.Location = new System.Drawing.Point(270, 46);
            this.picBuscarLibro.Name = "picBuscarLibro";
            this.picBuscarLibro.Size = new System.Drawing.Size(24, 28);
            this.picBuscarLibro.TabIndex = 19;
            this.picBuscarLibro.TabStop = false;
            this.picBuscarLibro.Click += new System.EventHandler(this.picBuscarLibro_Click);
            this.picBuscarLibro.MouseHover += new System.EventHandler(this.picBuscarLibro_MouseHover);
            // 
            // frmRegistrarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1511, 552);
            this.Controls.Add(this.panel1);
            this.Name = "frmRegistrarPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrestamoBiblio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscarLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarPrestamo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTelefonoUsuario;
        private System.Windows.Forms.Label lblCorreoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblAutorLibro;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.Label lblClaveEjemplar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.DateTimePicker dtpPrestamo;
        private FontAwesome.Sharp.IconPictureBox picBuscarUsuario;
        private FontAwesome.Sharp.IconPictureBox picBuscarLibro;
        private System.Windows.Forms.ToolTip ToolTipAyuda;
    }
}
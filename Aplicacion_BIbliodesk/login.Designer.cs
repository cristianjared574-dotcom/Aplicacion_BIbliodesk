namespace Aplicacion_BIbliodesk
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panelFondo = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbLgo = new System.Windows.Forms.PictureBox();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnLeerPantalla = new System.Windows.Forms.Button();
            this.btnContraste = new System.Windows.Forms.Button();
            this.panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLgo)).BeginInit();
            this.panelFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            this.panelFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFondo.Controls.Add(this.lblSubtitulo);
            this.panelFondo.Controls.Add(this.lblTitulo);
            this.panelFondo.Controls.Add(this.pbLgo);
            this.panelFondo.Controls.Add(this.panelFormulario);
            this.panelFondo.Location = new System.Drawing.Point(543, 166);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(879, 751);
            this.panelFondo.TabIndex = 0;
            this.panelFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFondo_Paint);
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(178, 128);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(415, 23);
            this.lblSubtitulo.TabIndex = 7;
            this.lblSubtitulo.Text = "Ingrese sus credenciales para acceder al sistema";
            this.lblSubtitulo.Click += new System.EventHandler(this.lblSubtitulo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitulo.Location = new System.Drawing.Point(163, 62);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(507, 53);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Bienvenido a Bibliodesk";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // pbLgo
            // 
            this.pbLgo.Image = ((System.Drawing.Image)(resources.GetObject("pbLgo.Image")));
            this.pbLgo.Location = new System.Drawing.Point(49, 38);
            this.pbLgo.Name = "pbLgo";
            this.pbLgo.Size = new System.Drawing.Size(100, 85);
            this.pbLgo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLgo.TabIndex = 5;
            this.pbLgo.TabStop = false;
            this.pbLgo.Click += new System.EventHandler(this.pbLgo_Click);
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormulario.Controls.Add(this.iconButton3);
            this.panelFormulario.Controls.Add(this.iconButton2);
            this.panelFormulario.Controls.Add(this.lblRol);
            this.panelFormulario.Controls.Add(this.lblContrasena);
            this.panelFormulario.Controls.Add(this.lblUsuario);
            this.panelFormulario.Controls.Add(this.iconButton1);
            this.panelFormulario.Controls.Add(this.cboRol);
            this.panelFormulario.Controls.Add(this.btnIniciarSesion);
            this.panelFormulario.Controls.Add(this.txtContrasena);
            this.panelFormulario.Controls.Add(this.txtUsuario);
            this.panelFormulario.Location = new System.Drawing.Point(149, 195);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(557, 533);
            this.panelFormulario.TabIndex = 0;
            this.panelFormulario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormulario_Paint);
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 40;
            this.iconButton3.Location = new System.Drawing.Point(60, 265);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(40, 48);
            this.iconButton3.TabIndex = 16;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(60, 149);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(40, 48);
            this.iconButton2.TabIndex = 15;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(117, 60);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(39, 19);
            this.lblRol.TabIndex = 14;
            this.lblRol.Text = "Rol:";
            this.lblRol.Click += new System.EventHandler(this.lblRol_Click);
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(106, 284);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(108, 19);
            this.lblContrasena.TabIndex = 13;
            this.lblContrasena.Text = "Contraseña:";
            this.lblContrasena.Click += new System.EventHandler(this.lblContrasena_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(106, 162);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(73, 19);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(60, 47);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(40, 48);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // cboRol
            // 
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(60, 104);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(443, 24);
            this.cboRol.TabIndex = 0;
            this.cboRol.SelectedIndexChanged += new System.EventHandler(this.cboRol_SelectedIndexChanged);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Maroon;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(196, 406);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(190, 48);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(60, 319);
            this.txtContrasena.Multiline = true;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(443, 34);
            this.txtContrasena.TabIndex = 2;
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(60, 203);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(443, 34);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // btnLeerPantalla
            // 
            this.btnLeerPantalla.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerPantalla.Location = new System.Drawing.Point(1438, 809);
            this.btnLeerPantalla.Name = "btnLeerPantalla";
            this.btnLeerPantalla.Size = new System.Drawing.Size(190, 48);
            this.btnLeerPantalla.TabIndex = 10;
            this.btnLeerPantalla.Text = "Leer pantalla";
            this.btnLeerPantalla.UseVisualStyleBackColor = true;
            this.btnLeerPantalla.Click += new System.EventHandler(this.btnLeerPantalla_Click);
            // 
            // btnContraste
            // 
            this.btnContraste.Location = new System.Drawing.Point(1438, 166);
            this.btnContraste.Name = "btnContraste";
            this.btnContraste.Size = new System.Drawing.Size(190, 48);
            this.btnContraste.TabIndex = 11;
            this.btnContraste.Text = "Contraste";
            this.btnContraste.UseVisualStyleBackColor = true;
            this.btnContraste.Click += new System.EventHandler(this.btnContraste_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1786, 1034);
            this.Controls.Add(this.btnContraste);
            this.Controls.Add(this.panelFondo);
            this.Controls.Add(this.btnLeerPantalla);
            this.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliodesk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_Load_1);
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLgo)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.PictureBox pbLgo;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label lblTitulo;
       
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnLeerPantalla;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Button btnContraste;
    }
}
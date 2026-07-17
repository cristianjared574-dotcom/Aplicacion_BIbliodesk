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
            this.panelFondo = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnReducir = new System.Windows.Forms.Button();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbocon = new System.Windows.Forms.ComboBox();
            this.cbouser = new System.Windows.Forms.ComboBox();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.iconButton4 = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFondo.AutoSize = true;
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            this.panelFondo.Controls.Add(this.button4);
            this.panelFondo.Controls.Add(this.btnReducir);
            this.panelFondo.Controls.Add(this.btnAumentar);
            this.panelFondo.Controls.Add(this.label2);
            this.panelFondo.Controls.Add(this.label1);
            this.panelFondo.Controls.Add(this.pictureBox2);
            this.panelFondo.Controls.Add(this.panelFormulario);
            this.panelFondo.Location = new System.Drawing.Point(354, 27);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(879, 751);
            this.panelFondo.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(686, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 48);
            this.button4.TabIndex = 10;
            this.button4.Text = "Leer pantalla";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnReducir
            // 
            this.btnReducir.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReducir.Location = new System.Drawing.Point(686, 71);
            this.btnReducir.Name = "btnReducir";
            this.btnReducir.Size = new System.Drawing.Size(190, 48);
            this.btnReducir.TabIndex = 9;
            this.btnReducir.Text = "A-";
            this.btnReducir.UseVisualStyleBackColor = true;
            // 
            // btnAumentar
            // 
            this.btnAumentar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentar.Location = new System.Drawing.Point(686, 17);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(190, 48);
            this.btnAumentar.TabIndex = 8;
            this.btnAumentar.Text = "A+";
            this.btnAumentar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese sus credenciales para acceder al sistema";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(165, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 53);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido a Bibliodesk";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(49, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 85);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormulario.Controls.Add(this.iconButton1);
            this.panelFormulario.Controls.Add(this.iconButton2);
            this.panelFormulario.Controls.Add(this.comboBox1);
            this.panelFormulario.Controls.Add(this.cbocon);
            this.panelFormulario.Controls.Add(this.cbouser);
            this.panelFormulario.Controls.Add(this.cboRol);
            this.panelFormulario.Controls.Add(this.iconButton4);
            this.panelFormulario.Controls.Add(this.txtContrasena);
            this.panelFormulario.Controls.Add(this.txtUsuario);
            this.panelFormulario.Location = new System.Drawing.Point(151, 191);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(557, 533);
            this.panelFormulario.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(22, 40);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 72);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(6, 107);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(75, 23);
            this.iconButton2.TabIndex = 0;
            this.iconButton2.Text = "iconButton2";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(443, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // cbocon
            // 
            this.cbocon.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocon.Location = new System.Drawing.Point(60, 286);
            this.cbocon.Name = "cbocon";
            this.cbocon.Size = new System.Drawing.Size(164, 27);
            this.cbocon.TabIndex = 10;
            this.cbocon.Text = "Contraseña:";
            // 
            // cbouser
            // 
            this.cbouser.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.cbouser.Location = new System.Drawing.Point(60, 168);
            this.cbouser.Name = "cbouser";
            this.cbouser.Size = new System.Drawing.Size(158, 29);
            this.cbouser.TabIndex = 9;
            this.cbouser.Text = "Usuario:";
            // 
            // cboRol
            // 
            this.cboRol.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.cboRol.Location = new System.Drawing.Point(60, 69);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(158, 29);
            this.cboRol.TabIndex = 6;
            this.cboRol.Text = "Rol:";
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Maroon;
            this.iconButton4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.Location = new System.Drawing.Point(194, 435);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(190, 48);
            this.iconButton4.TabIndex = 3;
            this.iconButton4.Text = "Iniciar Sesión";
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.button1_Click);
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
            // 
            // login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1533, 790);
            this.Controls.Add(this.panelFondo);
            this.Enabled = false;
            this.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliodesk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_Load_1);
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button iconButton4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.ComboBox cbouser;
        private System.Windows.Forms.ComboBox cbocon;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
       
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnReducir;
        private System.Windows.Forms.Button btnAumentar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}
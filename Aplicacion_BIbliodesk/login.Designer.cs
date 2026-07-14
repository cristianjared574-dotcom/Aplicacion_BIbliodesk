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
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cboRol = new FontAwesome.Sharp.IconButton();
            this.txtUsuario = new FontAwesome.Sharp.IconButton();
            this.txtContrasena = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.btnReducir = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.panelFondo.SuspendLayout();
            this.panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFondo.AutoSize = true;
            this.panelFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            this.panelFondo.Controls.Add(this.btnLeer);
            this.panelFondo.Controls.Add(this.btnReducir);
            this.panelFondo.Controls.Add(this.btnAumentar);
            this.panelFondo.Controls.Add(this.label2);
            this.panelFondo.Controls.Add(this.label1);
            this.panelFondo.Controls.Add(this.pictureBox2);
            this.panelFondo.Controls.Add(this.panelFormulario);
            this.panelFondo.Location = new System.Drawing.Point(354, 27);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(862, 751);
            this.panelFondo.TabIndex = 0;
            // 
            // panelFormulario
            // 
            this.panelFormulario.BackColor = System.Drawing.Color.White;
            this.panelFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormulario.Controls.Add(this.comboBox1);
            this.panelFormulario.Controls.Add(this.txtContrasena);
            this.panelFormulario.Controls.Add(this.txtUsuario);
            this.panelFormulario.Controls.Add(this.cboRol);
            this.panelFormulario.Controls.Add(this.button1);
            this.panelFormulario.Controls.Add(this.textBox3);
            this.panelFormulario.Controls.Add(this.textBox2);
            this.panelFormulario.Location = new System.Drawing.Point(151, 191);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(557, 533);
            this.panelFormulario.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(232, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 319);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(443, 34);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 203);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(443, 34);
            this.textBox2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(49, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 85);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // cboRol
            // 
            this.cboRol.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.cboRol.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cboRol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cboRol.Location = new System.Drawing.Point(60, 3);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(158, 63);
            this.cboRol.TabIndex = 6;
            this.cboRol.Text = "Rol:";
            this.cboRol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cboRol.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.txtUsuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtUsuario.Location = new System.Drawing.Point(60, 134);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(158, 63);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.Text = "Usuario:";
            this.txtUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtUsuario.UseVisualStyleBackColor = true;
            this.txtUsuario.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.txtContrasena.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtContrasena.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtContrasena.Location = new System.Drawing.Point(60, 250);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(158, 63);
            this.txtContrasena.TabIndex = 10;
            this.txtContrasena.Text = "Contraseña:";
            this.txtContrasena.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtContrasena.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(443, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(172, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido a Bibliodesk";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese sus credenciales para acceder al sistema";
            // 
            // btnAumentar
            // 
            this.btnAumentar.Location = new System.Drawing.Point(729, 38);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(75, 23);
            this.btnAumentar.TabIndex = 8;
            this.btnAumentar.Text = "A+";
            this.btnAumentar.UseVisualStyleBackColor = true;
            // 
            // btnReducir
            // 
            this.btnReducir.Location = new System.Drawing.Point(729, 88);
            this.btnReducir.Name = "btnReducir";
            this.btnReducir.Size = new System.Drawing.Size(75, 23);
            this.btnReducir.TabIndex = 9;
            this.btnReducir.Text = "A-";
            this.btnReducir.UseVisualStyleBackColor = true;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(707, 134);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(109, 23);
            this.btnLeer.TabIndex = 10;
            this.btnLeer.Text = "Leer pantalla";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.button4_Click);
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
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Panel panelFormulario;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton cboRol;
        private FontAwesome.Sharp.IconButton txtContrasena;
        private FontAwesome.Sharp.IconButton txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnReducir;
        private System.Windows.Forms.Button btnAumentar;
    }
}
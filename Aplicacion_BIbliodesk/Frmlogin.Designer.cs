namespace Aplicacion_BIbliodesk
{
    partial class Frmlogin
    {
        
        private System.ComponentModel.IContainer components = null;

       
        /// <param name="disposing"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            this.panelfondo = new System.Windows.Forms.Panel();
            this.btnLeerVoz = new System.Windows.Forms.Button();
            this.btnDisminuirTexto = new System.Windows.Forms.Button();
            this.btnAumentarTexto = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnIniciaSsesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.panelfondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelfondo
            // 
            this.panelfondo.BackColor = System.Drawing.Color.Beige;
            this.panelfondo.Controls.Add(this.btnLeerVoz);
            this.panelfondo.Controls.Add(this.btnDisminuirTexto);
            this.panelfondo.Controls.Add(this.btnAumentarTexto);
            this.panelfondo.Controls.Add(this.btnIniciaSsesion);
            this.panelfondo.Controls.Add(this.txtContrasena);
            this.panelfondo.Controls.Add(this.label3);
            this.panelfondo.Controls.Add(this.txtUsuario);
            this.panelfondo.Controls.Add(this.label2);
            this.panelfondo.Controls.Add(this.cboRol);
            this.panelfondo.Controls.Add(this.label1);
            this.panelfondo.Controls.Add(this.lblSubtitulo);
            this.panelfondo.Controls.Add(this.lblTitulo);
            this.panelfondo.Location = new System.Drawing.Point(100, 50);
            this.panelfondo.Name = "panelfondo";
            this.panelfondo.Size = new System.Drawing.Size(450, 350);
            this.panelfondo.TabIndex = 0;
            // 
            // btnLeerVoz
            // 
            this.btnLeerVoz.Location = new System.Drawing.Point(3, 16);
            this.btnLeerVoz.Name = "btnLeerVoz";
            this.btnLeerVoz.Size = new System.Drawing.Size(110, 30);
            this.btnLeerVoz.TabIndex = 1;
            this.btnLeerVoz.Text = "Leer Pantalla";
            this.btnLeerVoz.UseVisualStyleBackColor = true;
            // 
            // btnDisminuirTexto
            // 
            this.btnDisminuirTexto.Location = new System.Drawing.Point(400, 20);
            this.btnDisminuirTexto.Name = "btnDisminuirTexto";
            this.btnDisminuirTexto.Size = new System.Drawing.Size(40, 30);
            this.btnDisminuirTexto.TabIndex = 11;
            this.btnDisminuirTexto.Text = "A-";
            this.btnDisminuirTexto.UseVisualStyleBackColor = true;
            this.btnDisminuirTexto.Click += new System.EventHandler(this.btnDisminuirTexto_Click);
            // 
            // btnAumentarTexto
            // 
            this.btnAumentarTexto.Location = new System.Drawing.Point(350, 20);
            this.btnAumentarTexto.Name = "btnAumentarTexto";
            this.btnAumentarTexto.Size = new System.Drawing.Size(40, 30);
            this.btnAumentarTexto.TabIndex = 10;
            this.btnAumentarTexto.Text = "A+";
            this.btnAumentarTexto.UseVisualStyleBackColor = true;
            this.btnAumentarTexto.Click += new System.EventHandler(this.btnAumentarTexto_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(80, 245);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(250, 22);
            this.txtContrasena.TabIndex = 8;
            // 
            // btnIniciaSsesion
            // 
            this.btnIniciaSsesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnIniciaSsesion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciaSsesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciaSsesion.Location = new System.Drawing.Point(115, 293);
            this.btnIniciaSsesion.Name = "btnIniciaSsesion";
            this.btnIniciaSsesion.Size = new System.Drawing.Size(190, 48);
            this.btnIniciaSsesion.TabIndex = 9;
            this.btnIniciaSsesion.Text = "Iniciar Sesión";
            this.btnIniciaSsesion.UseVisualStyleBackColor = false;
            this.btnIniciaSsesion.Click += new System.EventHandler(this.btnIniciaSsesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(80, 185);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 22);
            this.txtUsuario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contrasena";
            // 
            // cboRol
            // 
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Items.AddRange(new object[] {
            "Administrador",
            "Bibliotecario"});
            this.cboRol.Location = new System.Drawing.Point(80, 125);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(250, 24);
            this.cboRol.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(46)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(110, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(256, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenido  a Bibliodesk";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(68, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(327, 17);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Ingese sus credenciales para acceder al sistema";
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(632, 403);
            this.Controls.Add(this.panelfondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ssgg";
            this.panelfondo.ResumeLayout(false);
            this.panelfondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelfondo;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnDisminuirTexto;
        private System.Windows.Forms.Button btnAumentarTexto;
        private System.Windows.Forms.Button btnLeerVoz;
        private System.Windows.Forms.Button btnIniciaSsesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}
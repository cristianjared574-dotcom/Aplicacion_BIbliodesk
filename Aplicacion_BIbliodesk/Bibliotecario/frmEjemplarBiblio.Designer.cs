namespace Aplicacion_BIbliodesk.Bibliotecario
{
    partial class frmEjemplarBiblio
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarEjemplar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbEstadoFisico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocalizacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.txtCodigoEjemplar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(490, 326);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(190, 48);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarEjemplar
            // 
            this.btnGuardarEjemplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGuardarEjemplar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEjemplar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEjemplar.Location = new System.Drawing.Point(183, 326);
            this.btnGuardarEjemplar.Name = "btnGuardarEjemplar";
            this.btnGuardarEjemplar.Size = new System.Drawing.Size(190, 48);
            this.btnGuardarEjemplar.TabIndex = 6;
            this.btnGuardarEjemplar.Text = "Guardar Ejemplar";
            this.btnGuardarEjemplar.UseVisualStyleBackColor = false;
            this.btnGuardarEjemplar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardarEjemplar);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(319, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ejemplar";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbEstadoFisico);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLocalizacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLibro);
            this.panel1.Controls.Add(this.txtCodigoEjemplar);
            this.panel1.Location = new System.Drawing.Point(119, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 267);
            this.panel1.TabIndex = 8;
            // 
            // cmbEstadoFisico
            // 
            this.cmbEstadoFisico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoFisico.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoFisico.FormattingEnabled = true;
            this.cmbEstadoFisico.Items.AddRange(new object[] {
            "BUENO",
            "REGULAR",
            "DAÑADO"});
            this.cmbEstadoFisico.Location = new System.Drawing.Point(256, 135);
            this.cmbEstadoFisico.Name = "cmbEstadoFisico";
            this.cmbEstadoFisico.Size = new System.Drawing.Size(240, 29);
            this.cmbEstadoFisico.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado físico: ";
            // 
            // txtLocalizacion
            // 
            this.txtLocalizacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalizacion.Location = new System.Drawing.Point(256, 198);
            this.txtLocalizacion.Name = "txtLocalizacion";
            this.txtLocalizacion.Size = new System.Drawing.Size(390, 28);
            this.txtLocalizacion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Ejemplar: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Libro: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Localización: ";
            // 
            // txtLibro
            // 
            this.txtLibro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibro.Location = new System.Drawing.Point(256, 77);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(390, 28);
            this.txtLibro.TabIndex = 3;
            // 
            // txtCodigoEjemplar
            // 
            this.txtCodigoEjemplar.BackColor = System.Drawing.Color.White;
            this.txtCodigoEjemplar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEjemplar.Location = new System.Drawing.Point(256, 17);
            this.txtCodigoEjemplar.Name = "txtCodigoEjemplar";
            this.txtCodigoEjemplar.ReadOnly = true;
            this.txtCodigoEjemplar.Size = new System.Drawing.Size(390, 28);
            this.txtCodigoEjemplar.TabIndex = 1;
            this.txtCodigoEjemplar.TabStop = false;
            // 
            // frmEjemplarBiblio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1511, 496);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEjemplarBiblio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ejemplar";
            this.Load += new System.EventHandler(this.frmEjemplarBiblio_Load);
            this.Click += new System.EventHandler(this.frmEjemplarBiblio_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarEjemplar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLocalizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.TextBox txtCodigoEjemplar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstadoFisico;
    }
}

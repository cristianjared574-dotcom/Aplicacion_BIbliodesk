using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Bibliotecario.AutorBibliotecario
{
    partial class frmAgregarAutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpAgregAutor;

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

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
            this.grpAgregAutor = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtnacionalidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAm = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.txtIdAutor = new System.Windows.Forms.TextBox();
            this.lblAP = new System.Windows.Forms.Label();
            this.lblAM = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.grpAgregAutor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAgregAutor
            // 
            this.grpAgregAutor.BackColor = System.Drawing.Color.White;
            this.grpAgregAutor.Controls.Add(this.btnCancelar);
            this.grpAgregAutor.Controls.Add(this.btnGuardar);
            this.grpAgregAutor.Controls.Add(this.panel1);
            this.grpAgregAutor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpAgregAutor.Location = new System.Drawing.Point(346, 23);
            this.grpAgregAutor.Name = "grpAgregAutor";
            this.grpAgregAutor.Size = new System.Drawing.Size(577, 431);
            this.grpAgregAutor.TabIndex = 0;
            this.grpAgregAutor.TabStop = false;
            this.grpAgregAutor.Text = "Agregar Autor";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(368, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(100, 370);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar Autor";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtnacionalidad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAm);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.txtAp);
            this.panel1.Controls.Add(this.txtIdAutor);
            this.panel1.Controls.Add(this.lblAP);
            this.panel1.Controls.Add(this.lblAM);
            this.panel1.Controls.Add(this.lblnombre);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(28, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 290);
            this.panel1.TabIndex = 17;
            // 
            // txtnacionalidad
            // 
            this.txtnacionalidad.Location = new System.Drawing.Point(173, 195);
            this.txtnacionalidad.Name = "txtnacionalidad";
            this.txtnacionalidad.Size = new System.Drawing.Size(300, 26);
            this.txtnacionalidad.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nacionalidad:";
            // 
            // txtAm
            // 
            this.txtAm.Location = new System.Drawing.Point(173, 143);
            this.txtAm.Name = "txtAm";
            this.txtAm.Size = new System.Drawing.Size(300, 26);
            this.txtAm.TabIndex = 7;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(76, 19);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID Autor:";
            this.lblId.Visible = false;
            // 
            // txtAp
            // 
            this.txtAp.Location = new System.Drawing.Point(173, 99);
            this.txtAp.Name = "txtAp";
            this.txtAp.Size = new System.Drawing.Size(300, 26);
            this.txtAp.TabIndex = 5;
            // 
            // txtIdAutor
            // 
            this.txtIdAutor.BackColor = System.Drawing.Color.White;
            this.txtIdAutor.Location = new System.Drawing.Point(173, 9);
            this.txtIdAutor.Name = "txtIdAutor";
            this.txtIdAutor.ReadOnly = true;
            this.txtIdAutor.Size = new System.Drawing.Size(300, 26);
            this.txtIdAutor.TabIndex = 1;
            this.txtIdAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdAutor.Visible = false;
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Location = new System.Drawing.Point(3, 104);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(141, 19);
            this.lblAP.TabIndex = 4;
            this.lblAP.Text = "Apellido Paterno:";
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Location = new System.Drawing.Point(3, 149);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(143, 19);
            this.lblAM.TabIndex = 6;
            this.lblAM.Text = "Apellido Materno:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(3, 59);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(76, 19);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(173, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(173, 238);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 27);
            this.cmbEstado.TabIndex = 13;
            // 
            // frmAgregarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1370, 504);
            this.Controls.Add(this.grpAgregAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAgregarAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Autor";
            this.grpAgregAutor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblId;
        private TextBox txtIdAutor;
        private Label lblnombre;
        private TextBox txtNombre;
        private Label lblAP;
        private TextBox txtAp;
        private Label lblAM;
        private Panel panel1;
        private TextBox txtAm;
        private TextBox txtnacionalidad;
        private Label label1;
        private ComboBox cmbEstado;
        private Label label2;
    }
}
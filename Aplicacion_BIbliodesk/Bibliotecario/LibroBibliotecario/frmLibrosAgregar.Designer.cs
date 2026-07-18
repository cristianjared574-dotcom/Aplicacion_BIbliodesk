using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Bibliotecario.LibroBibliotecario
{
    partial class frmLibrosAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpLibro;

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
            this.grpLibro = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtIdLibro = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.grpLibro.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLibro
            // 
            this.grpLibro.BackColor = System.Drawing.Color.White;
            this.grpLibro.Controls.Add(this.btnCancelar);
            this.grpLibro.Controls.Add(this.panel2);
            this.grpLibro.Controls.Add(this.panel1);
            this.grpLibro.Controls.Add(this.btnGuardar);
            this.grpLibro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLibro.Location = new System.Drawing.Point(148, 32);
            this.grpLibro.Name = "grpLibro";
            this.grpLibro.Size = new System.Drawing.Size(1074, 441);
            this.grpLibro.TabIndex = 0;
            this.grpLibro.TabStop = false;
            this.grpLibro.Text = "Agregar Libro";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(549, 361);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbLibro);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtstock);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(664, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 286);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Actualizacion Stock";
            // 
            // txtstock
            // 
            this.txtstock.BackColor = System.Drawing.Color.White;
            this.txtstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstock.Location = new System.Drawing.Point(137, 119);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(78, 26);
            this.txtstock.TabIndex = 8;
            this.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stock Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Libro:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbEditorial);
            this.panel1.Controls.Add(this.cmbCategoria);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.txtIdLibro);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.txtISBN);
            this.panel1.Controls.Add(this.lblEditorial);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.lblISBN);
            this.panel1.Location = new System.Drawing.Point(89, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 287);
            this.panel1.TabIndex = 17;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitulo.Location = new System.Drawing.Point(173, 189);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(300, 25);
            this.txtTitulo.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Estado:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(75, 19);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID Libro:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Location = new System.Drawing.Point(173, 231);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(300, 27);
            this.cmbEstado.TabIndex = 9;
            // 
            // txtIdLibro
            // 
            this.txtIdLibro.BackColor = System.Drawing.Color.White;
            this.txtIdLibro.Location = new System.Drawing.Point(173, 9);
            this.txtIdLibro.Name = "txtIdLibro";
            this.txtIdLibro.ReadOnly = true;
            this.txtIdLibro.Size = new System.Drawing.Size(300, 26);
            this.txtIdLibro.TabIndex = 1;
            this.txtIdLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(3, 195);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(58, 19);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Título:";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtISBN.Location = new System.Drawing.Point(173, 147);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(300, 25);
            this.txtISBN.TabIndex = 11;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(2, 60);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(78, 19);
            this.lblEditorial.TabIndex = 6;
            this.lblEditorial.Text = "Editorial:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(3, 113);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(89, 19);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(3, 150);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(54, 19);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "ISBN:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(333, 361);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar Libro";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Location = new System.Drawing.Point(173, 105);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(300, 27);
            this.cmbCategoria.TabIndex = 18;
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditorial.Location = new System.Drawing.Point(173, 60);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(300, 27);
            this.cmbEditorial.TabIndex = 19;
            // 
            // cmbLibro
            // 
            this.cmbLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibro.Location = new System.Drawing.Point(137, 51);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(130, 27);
            this.cmbLibro.TabIndex = 20;
            this.cmbLibro.SelectedIndexChanged += new System.EventHandler(this.cmbLibro_SelectedIndexChanged);
            // 
            // frmLibrosAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1370, 504);
            this.Controls.Add(this.grpLibro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLibrosAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Libro";
            this.grpLibro.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblId;
        private TextBox txtIdLibro;
        private Label lblISBN;
        private Label lblTitulo;
        private Label lblEditorial;
        private Label lblCategoria;
        private TextBox txtISBN;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox txtstock;
        private TextBox txtTitulo;
        private Label label3;
        private ComboBox cmbEstado;
        private Label label4;
        private ComboBox cmbEditorial;
        private ComboBox cmbCategoria;
        private ComboBox cmbLibro;
    }
}
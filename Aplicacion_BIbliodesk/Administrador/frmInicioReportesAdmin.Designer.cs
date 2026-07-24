namespace Aplicacion_BIbliodesk.Administrador
{
    partial class frmInicioReportesAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAutores = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPrestamos = new System.Windows.Forms.RadioButton();
            this.rbCategorias = new System.Windows.Forms.RadioButton();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgvReporte);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnGenerarReporte);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(140, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1175, 441);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes";
            // 
            // dgvReporte
            // 
            this.dgvReporte.AllowUserToAddRows = false;
            this.dgvReporte.AllowUserToDeleteRows = false;
            this.dgvReporte.AllowUserToResizeColumns = false;
            this.dgvReporte.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporte.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(161)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReporte.ColumnHeadersHeight = 45;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(110)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporte.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReporte.EnableHeadersVisualStyles = false;
            this.dgvReporte.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvReporte.Location = new System.Drawing.Point(433, 39);
            this.dgvReporte.MultiSelect = false;
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.ReadOnly = true;
            this.dgvReporte.RowHeadersVisible = false;
            this.dgvReporte.RowHeadersWidth = 51;
            this.dgvReporte.RowTemplate.Height = 34;
            this.dgvReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporte.Size = new System.Drawing.Size(725, 312);
            this.dgvReporte.TabIndex = 5;
            this.dgvReporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutores_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpHasta);
            this.panel1.Controls.Add(this.dtpDesde);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbAutores);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbPrestamos);
            this.panel1.Controls.Add(this.rbCategorias);
            this.panel1.Location = new System.Drawing.Point(44, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 312);
            this.panel1.TabIndex = 4;
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "dd MMMM yyyy";
            this.dtpHasta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(95, 259);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(240, 24);
            this.dtpHasta.TabIndex = 5;
            this.dtpHasta.Value = new System.DateTime(2026, 7, 23, 22, 38, 34, 0);
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dd MMMM yyyy";
            this.dtpDesde.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(95, 192);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(240, 24);
            this.dtpDesde.TabIndex = 4;
            this.dtpDesde.Value = new System.DateTime(2026, 7, 23, 22, 38, 43, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta";
            // 
            // rbAutores
            // 
            this.rbAutores.AutoSize = true;
            this.rbAutores.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAutores.Location = new System.Drawing.Point(33, 88);
            this.rbAutores.Margin = new System.Windows.Forms.Padding(4);
            this.rbAutores.Name = "rbAutores";
            this.rbAutores.Size = new System.Drawing.Size(156, 21);
            this.rbAutores.TabIndex = 2;
            this.rbAutores.TabStop = true;
            this.rbAutores.Text = "Historial de Autores";
            this.rbAutores.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rango de fechas";
            // 
            // rbPrestamos
            // 
            this.rbPrestamos.AutoSize = true;
            this.rbPrestamos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrestamos.Location = new System.Drawing.Point(33, 8);
            this.rbPrestamos.Margin = new System.Windows.Forms.Padding(4);
            this.rbPrestamos.Name = "rbPrestamos";
            this.rbPrestamos.Size = new System.Drawing.Size(176, 21);
            this.rbPrestamos.TabIndex = 0;
            this.rbPrestamos.TabStop = true;
            this.rbPrestamos.Text = "Historial de préstamos";
            this.rbPrestamos.UseVisualStyleBackColor = true;
            // 
            // rbCategorias
            // 
            this.rbCategorias.AutoSize = true;
            this.rbCategorias.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCategorias.Location = new System.Drawing.Point(33, 48);
            this.rbCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.rbCategorias.Name = "rbCategorias";
            this.rbCategorias.Size = new System.Drawing.Size(177, 21);
            this.rbCategorias.TabIndex = 1;
            this.rbCategorias.TabStop = true;
            this.rbCategorias.Text = "Historial de categorías";
            this.rbCategorias.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGenerarReporte.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(160, 372);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(190, 48);
            this.btnGenerarReporte.TabIndex = 1;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // frmInicioReportesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 496);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInicioReportesAdmin";
            this.Text = "Reportes";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAutores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPrestamos;
        private System.Windows.Forms.RadioButton rbCategorias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView dgvReporte;
    }
}

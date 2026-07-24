namespace Aplicacion_BIbliodesk
{
    partial class frmInicioEjemplaresBiblio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAgregarEjemplar = new System.Windows.Forms.Button();
            this.btnEditarEjemplar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarEjemplar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvEjemplares = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarEjemplar
            // 
            this.btnAgregarEjemplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAgregarEjemplar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEjemplar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarEjemplar.Location = new System.Drawing.Point(672, 103);
            this.btnAgregarEjemplar.Name = "btnAgregarEjemplar";
            this.btnAgregarEjemplar.Size = new System.Drawing.Size(190, 48);
            this.btnAgregarEjemplar.TabIndex = 1;
            this.btnAgregarEjemplar.Text = "Agregar Ejemplar";
            this.btnAgregarEjemplar.UseVisualStyleBackColor = false;
            this.btnAgregarEjemplar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditarEjemplar
            // 
            this.btnEditarEjemplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEditarEjemplar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEjemplar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarEjemplar.Location = new System.Drawing.Point(892, 103);
            this.btnEditarEjemplar.Name = "btnEditarEjemplar";
            this.btnEditarEjemplar.Size = new System.Drawing.Size(190, 48);
            this.btnEditarEjemplar.TabIndex = 2;
            this.btnEditarEjemplar.Text = "Editar Ejemplar";
            this.btnEditarEjemplar.UseVisualStyleBackColor = false;
            this.btnEditarEjemplar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Ejemplar:";
            // 
            // txtBuscarEjemplar
            // 
            this.txtBuscarEjemplar.Location = new System.Drawing.Point(239, 28);
            this.txtBuscarEjemplar.Name = "txtBuscarEjemplar";
            this.txtBuscarEjemplar.Size = new System.Drawing.Size(487, 22);
            this.txtBuscarEjemplar.TabIndex = 1;
            this.txtBuscarEjemplar.Click += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscarEjemplar.TextChanged += new System.EventHandler(this.txtBuscarEjemplar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscarEjemplar);
            this.panel1.Location = new System.Drawing.Point(54, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 65);
            this.panel1.TabIndex = 4;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 22;
            this.iconPictureBox1.Location = new System.Drawing.Point(703, 28);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(23, 22);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvEjemplares);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnAgregarEjemplar);
            this.panel2.Controls.Add(this.btnEditarEjemplar);
            this.panel2.Location = new System.Drawing.Point(191, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 472);
            this.panel2.TabIndex = 5;
            // 
            // dgvEjemplares
            // 
            this.dgvEjemplares.AllowUserToAddRows = false;
            this.dgvEjemplares.AllowUserToDeleteRows = false;
            this.dgvEjemplares.AllowUserToResizeColumns = false;
            this.dgvEjemplares.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvEjemplares.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEjemplares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEjemplares.BackgroundColor = System.Drawing.Color.White;
            this.dgvEjemplares.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(161)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEjemplares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEjemplares.ColumnHeadersHeight = 45;
            this.dgvEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(110)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEjemplares.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEjemplares.EnableHeadersVisualStyles = false;
            this.dgvEjemplares.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvEjemplares.Location = new System.Drawing.Point(54, 159);
            this.dgvEjemplares.Margin = new System.Windows.Forms.Padding(5);
            this.dgvEjemplares.MultiSelect = false;
            this.dgvEjemplares.Name = "dgvEjemplares";
            this.dgvEjemplares.ReadOnly = true;
            this.dgvEjemplares.RowHeadersVisible = false;
            this.dgvEjemplares.RowHeadersWidth = 51;
            this.dgvEjemplares.RowTemplate.Height = 34;
            this.dgvEjemplares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEjemplares.Size = new System.Drawing.Size(1028, 293);
            this.dgvEjemplares.TabIndex = 5;
            // 
            // frmInicioEjemplaresBiblio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1511, 496);
            this.Controls.Add(this.panel2);
            this.Name = "frmInicioEjemplaresBiblio";
            this.Text = "Inicio Ejemplares";
            this.Load += new System.EventHandler(this.frmInicioEjemplaresBiblio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplares)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAgregarEjemplar;
        private System.Windows.Forms.Button btnEditarEjemplar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarEjemplar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridView dgvEjemplares;
    }
}

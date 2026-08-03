namespace Aplicacion_BIbliodesk.Bibliotecario
{
    partial class categorias_biblo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.pnlContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.Add(this.dgvCategorias);
            this.pnlContenido.Controls.Add(this.btnAgregarCategoria);
            this.pnlContenido.Controls.Add(this.panel2);
            this.pnlContenido.Controls.Add(this.btnEditarCategoria);
            this.pnlContenido.Location = new System.Drawing.Point(247, 50);
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1146, 472);
            this.pnlContenido.TabIndex = 1;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.AllowUserToResizeColumns = false;
            this.dgvCategorias.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(161)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCategorias.ColumnHeadersHeight = 45;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(110)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorias.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCategorias.EnableHeadersVisualStyles = false;
            this.dgvCategorias.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvCategorias.Location = new System.Drawing.Point(60, 159);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 34;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(1028, 293);
            this.dgvCategorias.TabIndex = 6;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick_1);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(693, 102);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(189, 48);
            this.btnAgregarCategoria.TabIndex = 5;
            this.btnAgregarCategoria.Text = "Agregar categoría ";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.lblBuscar);
            this.panel2.Location = new System.Drawing.Point(60, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 65);
            this.panel2.TabIndex = 4;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 27;
            this.iconPictureBox1.Location = new System.Drawing.Point(671, 16);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(27, 28);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(211, 16);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(487, 28);
            this.txtBuscar.TabIndex = 0;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(24, 16);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(155, 19);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Buscar Categoría:";
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEditarCategoria.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnEditarCategoria.Location = new System.Drawing.Point(899, 102);
            this.btnEditarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(189, 48);
            this.btnEditarCategoria.TabIndex = 2;
            this.btnEditarCategoria.Text = "Editar categoría";
            this.btnEditarCategoria.UseVisualStyleBackColor = false;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click_1);
            // 
            // categorias_biblo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1511, 552);
            this.Controls.Add(this.pnlContenido);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "categorias_biblo";
            this.Text = "categorias_biblo";
            this.Load += new System.EventHandler(this.categorias_biblo_Load_1);
            this.pnlContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
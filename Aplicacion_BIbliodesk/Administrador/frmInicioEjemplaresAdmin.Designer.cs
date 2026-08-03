namespace Aplicacion_BIbliodesk.Administrador
{
    partial class frmInicioEjemplaresAdmin
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
            this.txtBuscarEjemplar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEjemplaresAdmin = new System.Windows.Forms.DataGridView();
            this.CLAVE_EJEMPLAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TÍTULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCALIZACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_FISICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISPONIBLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_EJEMPLAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplaresAdmin)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarEjemplar
            // 
            this.txtBuscarEjemplar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarEjemplar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEjemplar.Location = new System.Drawing.Point(229, 19);
            this.txtBuscarEjemplar.Name = "txtBuscarEjemplar";
            this.txtBuscarEjemplar.Size = new System.Drawing.Size(487, 32);
            this.txtBuscarEjemplar.TabIndex = 1;
            this.txtBuscarEjemplar.TextChanged += new System.EventHandler(this.txtBuscarEjemplar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Ejemplar:";
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnCambiarEstado.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCambiarEstado.Location = new System.Drawing.Point(898, 104);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(190, 48);
            this.btnCambiarEstado.TabIndex = 1;
            this.btnCambiarEstado.Text = "Cambiar Estado";
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvEjemplaresAdmin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCambiarEstado);
            this.panel1.Location = new System.Drawing.Point(211, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 472);
            this.panel1.TabIndex = 3;
            // 
            // dgvEjemplaresAdmin
            // 
            this.dgvEjemplaresAdmin.AllowUserToAddRows = false;
            this.dgvEjemplaresAdmin.AllowUserToDeleteRows = false;
            this.dgvEjemplaresAdmin.AllowUserToResizeColumns = false;
            this.dgvEjemplaresAdmin.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvEjemplaresAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEjemplaresAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEjemplaresAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dgvEjemplaresAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(161)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEjemplaresAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEjemplaresAdmin.ColumnHeadersHeight = 45;
            this.dgvEjemplaresAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEjemplaresAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLAVE_EJEMPLAR,
            this.TÍTULO,
            this.LOCALIZACION,
            this.ESTADO_FISICO,
            this.DISPONIBLE,
            this.ID_EJEMPLAR});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(110)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEjemplaresAdmin.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEjemplaresAdmin.EnableHeadersVisualStyles = false;
            this.dgvEjemplaresAdmin.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvEjemplaresAdmin.Location = new System.Drawing.Point(60, 168);
            this.dgvEjemplaresAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEjemplaresAdmin.MultiSelect = false;
            this.dgvEjemplaresAdmin.Name = "dgvEjemplaresAdmin";
            this.dgvEjemplaresAdmin.ReadOnly = true;
            this.dgvEjemplaresAdmin.RowHeadersVisible = false;
            this.dgvEjemplaresAdmin.RowHeadersWidth = 51;
            this.dgvEjemplaresAdmin.RowTemplate.Height = 34;
            this.dgvEjemplaresAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEjemplaresAdmin.Size = new System.Drawing.Size(1028, 293);
            this.dgvEjemplaresAdmin.TabIndex = 5;
            this.dgvEjemplaresAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEjemplaresAdmin_CellContentClick);
            // 
            // CLAVE_EJEMPLAR
            // 
            this.CLAVE_EJEMPLAR.DataPropertyName = "CLAVE_EJEMPLAR";
            this.CLAVE_EJEMPLAR.HeaderText = "Código Ejemplar";
            this.CLAVE_EJEMPLAR.MinimumWidth = 6;
            this.CLAVE_EJEMPLAR.Name = "CLAVE_EJEMPLAR";
            this.CLAVE_EJEMPLAR.ReadOnly = true;
            // 
            // TÍTULO
            // 
            this.TÍTULO.DataPropertyName = "TITULO";
            this.TÍTULO.HeaderText = "Libro";
            this.TÍTULO.MinimumWidth = 6;
            this.TÍTULO.Name = "TÍTULO";
            this.TÍTULO.ReadOnly = true;
            // 
            // LOCALIZACION
            // 
            this.LOCALIZACION.DataPropertyName = "LOCALIZACION";
            this.LOCALIZACION.HeaderText = "Localización";
            this.LOCALIZACION.MinimumWidth = 6;
            this.LOCALIZACION.Name = "LOCALIZACION";
            this.LOCALIZACION.ReadOnly = true;
            // 
            // ESTADO_FISICO
            // 
            this.ESTADO_FISICO.DataPropertyName = "ESTADO_FISICO";
            this.ESTADO_FISICO.HeaderText = "Estado físico";
            this.ESTADO_FISICO.MinimumWidth = 6;
            this.ESTADO_FISICO.Name = "ESTADO_FISICO";
            this.ESTADO_FISICO.ReadOnly = true;
            // 
            // DISPONIBLE
            // 
            this.DISPONIBLE.DataPropertyName = "DISPONIBLE";
            this.DISPONIBLE.HeaderText = "Disponible";
            this.DISPONIBLE.MinimumWidth = 6;
            this.DISPONIBLE.Name = "DISPONIBLE";
            this.DISPONIBLE.ReadOnly = true;
            // 
            // ID_EJEMPLAR
            // 
            this.ID_EJEMPLAR.DataPropertyName = "ID_EJEMPLAR";
            this.ID_EJEMPLAR.HeaderText = "Column1";
            this.ID_EJEMPLAR.MinimumWidth = 6;
            this.ID_EJEMPLAR.Name = "ID_EJEMPLAR";
            this.ID_EJEMPLAR.ReadOnly = true;
            this.ID_EJEMPLAR.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtBuscarEjemplar);
            this.panel2.Location = new System.Drawing.Point(60, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 65);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 20;
            this.iconPictureBox1.Location = new System.Drawing.Point(696, 19);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(20, 22);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // frmInicioEjemplaresAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1511, 496);
            this.Controls.Add(this.panel1);
            this.Name = "frmInicioEjemplaresAdmin";
            this.Text = "Inicio Ejemplares";
            this.Load += new System.EventHandler(this.frmInicioEjemplaresAdmin_Load);
            this.Click += new System.EventHandler(this.frmInicioEjemplaresAdmin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplaresAdmin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtBuscarEjemplar;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridView dgvEjemplaresAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLAVE_EJEMPLAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TÍTULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCALIZACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_FISICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISPONIBLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_EJEMPLAR;
    }
}

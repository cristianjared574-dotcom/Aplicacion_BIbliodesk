namespace Aplicacion_BIbliodesk.Administrador.PrestamoAdmin
{
    partial class frmPrestamoAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscarPrestamo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHistorialPrestamo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPrestamoAdmin = new System.Windows.Forms.DataGridView();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.txtBuscarPrestamo);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(59, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 65);
            this.panel1.TabIndex = 2;
            // 
            // txtBuscarPrestamo
            // 
            this.txtBuscarPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPrestamo.Location = new System.Drawing.Point(187, 20);
            this.txtBuscarPrestamo.Name = "txtBuscarPrestamo";
            this.txtBuscarPrestamo.Size = new System.Drawing.Size(487, 22);
            this.txtBuscarPrestamo.TabIndex = 2;
            this.txtBuscarPrestamo.TextChanged += new System.EventHandler(this.txtBuscarPrestamo_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.button2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(540, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(338, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar préstamo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar préstamo:";
            // 
            // btnHistorialPrestamo
            // 
            this.btnHistorialPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.btnHistorialPrestamo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialPrestamo.ForeColor = System.Drawing.Color.Black;
            this.btnHistorialPrestamo.Location = new System.Drawing.Point(853, 101);
            this.btnHistorialPrestamo.Name = "btnHistorialPrestamo";
            this.btnHistorialPrestamo.Size = new System.Drawing.Size(234, 48);
            this.btnHistorialPrestamo.TabIndex = 8;
            this.btnHistorialPrestamo.Text = "Ver historial de préstamo";
            this.btnHistorialPrestamo.UseVisualStyleBackColor = false;
            this.btnHistorialPrestamo.Click += new System.EventHandler(this.btnHistorialPrestamo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvPrestamoAdmin);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnHistorialPrestamo);
            this.panel2.Location = new System.Drawing.Point(183, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 472);
            this.panel2.TabIndex = 4;
            // 
            // dgvPrestamoAdmin
            // 
            this.dgvPrestamoAdmin.AllowUserToAddRows = false;
            this.dgvPrestamoAdmin.AllowUserToDeleteRows = false;
            this.dgvPrestamoAdmin.AllowUserToResizeColumns = false;
            this.dgvPrestamoAdmin.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvPrestamoAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrestamoAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamoAdmin.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrestamoAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(161)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamoAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrestamoAdmin.ColumnHeadersHeight = 45;
            this.dgvPrestamoAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(110)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamoAdmin.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrestamoAdmin.EnableHeadersVisualStyles = false;
            this.dgvPrestamoAdmin.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvPrestamoAdmin.Location = new System.Drawing.Point(59, 156);
            this.dgvPrestamoAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrestamoAdmin.MultiSelect = false;
            this.dgvPrestamoAdmin.Name = "dgvPrestamoAdmin";
            this.dgvPrestamoAdmin.ReadOnly = true;
            this.dgvPrestamoAdmin.RowHeadersVisible = false;
            this.dgvPrestamoAdmin.RowHeadersWidth = 51;
            this.dgvPrestamoAdmin.RowTemplate.Height = 34;
            this.dgvPrestamoAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamoAdmin.Size = new System.Drawing.Size(1028, 293);
            this.dgvPrestamoAdmin.TabIndex = 9;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 19;
            this.iconPictureBox1.Location = new System.Drawing.Point(655, 21);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(19, 21);
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            // 
            // frmPrestamoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 496);
            this.Controls.Add(this.panel2);
            this.Name = "frmPrestamoAdmin";
            this.Text = "frmPrestamoAdmin";
            this.Load += new System.EventHandler(this.frmPrestamoAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscarPrestamo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHistorialPrestamo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPrestamoAdmin;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
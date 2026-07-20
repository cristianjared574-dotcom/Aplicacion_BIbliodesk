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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscarPrestamo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHistorialPrestamo = new System.Windows.Forms.Button();
            this.dgvPrestamoAdmin = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoAdmin)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.btnHistorialPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnHistorialPrestamo.Location = new System.Drawing.Point(853, 101);
            this.btnHistorialPrestamo.Name = "btnHistorialPrestamo";
            this.btnHistorialPrestamo.Size = new System.Drawing.Size(234, 48);
            this.btnHistorialPrestamo.TabIndex = 8;
            this.btnHistorialPrestamo.Text = "Ver historial de préstamo";
            this.btnHistorialPrestamo.UseVisualStyleBackColor = false;
            this.btnHistorialPrestamo.Click += new System.EventHandler(this.btnHistorialPrestamo_Click);
            // 
            // dgvPrestamoAdmin
            // 
            this.dgvPrestamoAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamoAdmin.Location = new System.Drawing.Point(59, 167);
            this.dgvPrestamoAdmin.Name = "dgvPrestamoAdmin";
            this.dgvPrestamoAdmin.RowHeadersWidth = 51;
            this.dgvPrestamoAdmin.RowTemplate.Height = 24;
            this.dgvPrestamoAdmin.Size = new System.Drawing.Size(1028, 279);
            this.dgvPrestamoAdmin.TabIndex = 3;
            this.dgvPrestamoAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dgvPrestamoAdmin);
            this.panel2.Controls.Add(this.btnHistorialPrestamo);
            this.panel2.Location = new System.Drawing.Point(183, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 472);
            this.panel2.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoAdmin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscarPrestamo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPrestamoAdmin;
        private System.Windows.Forms.Button btnHistorialPrestamo;
        private System.Windows.Forms.Panel panel2;
    }
}
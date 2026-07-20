namespace Aplicacion_BIbliodesk.Bibliotecario.Prestamo
{
    partial class frmPrestamoBiblio
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscarPrestamoBiblio = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.btnRegistrarPrestamo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.txtBuscarPrestamoBiblio);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(60, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 65);
            this.panel1.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 22;
            this.iconPictureBox1.Location = new System.Drawing.Point(680, 26);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(23, 22);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtBuscarPrestamoBiblio
            // 
            this.txtBuscarPrestamoBiblio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPrestamoBiblio.Location = new System.Drawing.Point(181, 20);
            this.txtBuscarPrestamoBiblio.Multiline = true;
            this.txtBuscarPrestamoBiblio.Name = "txtBuscarPrestamoBiblio";
            this.txtBuscarPrestamoBiblio.Size = new System.Drawing.Size(487, 28);
            this.txtBuscarPrestamoBiblio.TabIndex = 2;
            this.txtBuscarPrestamoBiblio.TextChanged += new System.EventHandler(this.txtBuscarPrestamoBiblio_TextChanged);
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar préstamo:";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(60, 159);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.RowTemplate.Height = 24;
            this.dgvPrestamos.Size = new System.Drawing.Size(1028, 293);
            this.dgvPrestamos.TabIndex = 2;
            this.dgvPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRegistrarPrestamo
            // 
            this.btnRegistrarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnRegistrarPrestamo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPrestamo.Location = new System.Drawing.Point(898, 95);
            this.btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            this.btnRegistrarPrestamo.Size = new System.Drawing.Size(190, 48);
            this.btnRegistrarPrestamo.TabIndex = 7;
            this.btnRegistrarPrestamo.Text = "Registrar préstamo";
            this.btnRegistrarPrestamo.UseVisualStyleBackColor = false;
            this.btnRegistrarPrestamo.Click += new System.EventHandler(this.btnRegistrarPrestamo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRegistrarPrestamo);
            this.panel2.Controls.Add(this.dgvPrestamos);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(185, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 472);
            this.panel2.TabIndex = 8;
            // 
            // frmPrestamoBiblio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 552);
            this.Controls.Add(this.panel2);
            this.Name = "frmPrestamoBiblio";
            this.Text = "frmPrestamoBiblio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarPrestamoBiblio;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Button btnRegistrarPrestamo;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
namespace Aplicacion_BIbliodesk.Bibliotecario
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAgregarEjemplar = new System.Windows.Forms.Button();
            this.btnEditarEjemplar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarEjemplar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 265);
            this.dataGridView1.TabIndex = 3;
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
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnAgregarEjemplar);
            this.panel2.Controls.Add(this.btnEditarEjemplar);
            this.panel2.Location = new System.Drawing.Point(191, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 472);
            this.panel2.TabIndex = 5;
            // 
            // frmInicioEjemplaresBiblio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1511, 496);
            this.Controls.Add(this.panel2);
            this.Name = "frmInicioEjemplaresBiblio";
            this.Text = "Inicio Ejemplares";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAgregarEjemplar;
        private System.Windows.Forms.Button btnEditarEjemplar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarEjemplar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
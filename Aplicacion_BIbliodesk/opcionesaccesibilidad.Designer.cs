namespace Aplicacion_BIbliodesk
{
    partial class opcionesaccesibilidad
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
            this.cont = new System.Windows.Forms.Button();
            this.Zoom1 = new System.Windows.Forms.Button();
            this.zoom2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cont
            // 
            this.cont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cont.Location = new System.Drawing.Point(0, 0);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(190, 48);
            this.cont.TabIndex = 0;
            this.cont.Text = "contraste";
            this.cont.UseVisualStyleBackColor = false;
            this.cont.Click += new System.EventHandler(this.cont_Click);
            // 
            // Zoom1
            // 
            this.Zoom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Zoom1.Location = new System.Drawing.Point(0, 43);
            this.Zoom1.Name = "Zoom1";
            this.Zoom1.Size = new System.Drawing.Size(190, 48);
            this.Zoom1.TabIndex = 1;
            this.Zoom1.Text = "A+";
            this.Zoom1.UseVisualStyleBackColor = false;
            this.Zoom1.Click += new System.EventHandler(this.Zoom1_Click);
            // 
            // zoom2
            // 
            this.zoom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.zoom2.Location = new System.Drawing.Point(0, 88);
            this.zoom2.Name = "zoom2";
            this.zoom2.Size = new System.Drawing.Size(190, 48);
            this.zoom2.TabIndex = 2;
            this.zoom2.Text = "A-";
            this.zoom2.UseVisualStyleBackColor = false;
            this.zoom2.Click += new System.EventHandler(this.zoom2_Click);
            // 
            // opcionesaccesibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(189, 134);
            this.Controls.Add(this.zoom2);
            this.Controls.Add(this.Zoom1);
            this.Controls.Add(this.cont);
            this.Name = "opcionesaccesibilidad";
            this.Text = "opcionesaccesibilidad";
            this.Load += new System.EventHandler(this.opcionesaccesibilidad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cont;
        private System.Windows.Forms.Button Zoom1;
        private System.Windows.Forms.Button zoom2;
    }
}
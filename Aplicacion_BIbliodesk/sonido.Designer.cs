namespace Aplicacion_BIbliodesk
{
    partial class sonido
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
            this.btnaudio1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnaudio1
            // 
            this.btnaudio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnaudio1.Location = new System.Drawing.Point(0, -2);
            this.btnaudio1.Name = "btnaudio1";
            this.btnaudio1.Size = new System.Drawing.Size(190, 48);
            this.btnaudio1.TabIndex = 0;
            this.btnaudio1.Text = "Audio";
            this.btnaudio1.UseVisualStyleBackColor = false;
            this.btnaudio1.Click += new System.EventHandler(this.btnaudio1_Click);
            // 
            // sonido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 43);
            this.Controls.Add(this.btnaudio1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sonido";
            this.ShowInTaskbar = false;
            this.Text = "sonido";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnaudio1;
    }
}
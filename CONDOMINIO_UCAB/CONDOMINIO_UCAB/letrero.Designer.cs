namespace CONDOMINIO_UCAB
{
    partial class letrero
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
            this.icono = new System.Windows.Forms.Button();
            this.texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // icono
            // 
            this.icono.BackgroundImage = global::CONDOMINIO_UCAB.Properties.Resources.icono;
            this.icono.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.icono.FlatAppearance.BorderSize = 0;
            this.icono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.icono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.icono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icono.Location = new System.Drawing.Point(374, 87);
            this.icono.Name = "icono";
            this.icono.Size = new System.Drawing.Size(382, 415);
            this.icono.TabIndex = 1;
            this.icono.UseVisualStyleBackColor = true;
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Font = new System.Drawing.Font("Roboto Lt", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.Location = new System.Drawing.Point(367, 516);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(411, 42);
            this.texto.TabIndex = 2;
            this.texto.Text = "ADMINISTRADORA UCAB";
            // 
            // letrero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(181)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1194, 583);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.icono);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "letrero";
            this.Text = "ADMINISTRADORA UCAB";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.Resize += new System.EventHandler(this.inicio_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button icono;
        private System.Windows.Forms.Label texto;
    }
}
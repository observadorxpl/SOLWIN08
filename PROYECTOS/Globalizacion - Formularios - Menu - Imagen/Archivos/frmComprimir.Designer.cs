namespace POO.Archivos
{
    partial class frmComprimir
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
            this.btnComprimir = new System.Windows.Forms.Button();
            this.btnDescomprimir = new System.Windows.Forms.Button();
            this.txtComprimir = new System.Windows.Forms.TextBox();
            this.txtDescomprimir = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComprimir
            // 
            this.btnComprimir.Location = new System.Drawing.Point(512, 15);
            this.btnComprimir.Name = "btnComprimir";
            this.btnComprimir.Size = new System.Drawing.Size(117, 30);
            this.btnComprimir.TabIndex = 0;
            this.btnComprimir.Text = "Comprimir";
            this.btnComprimir.UseVisualStyleBackColor = true;
            this.btnComprimir.Click += new System.EventHandler(this.btnComprimir_Click);
            // 
            // btnDescomprimir
            // 
            this.btnDescomprimir.Location = new System.Drawing.Point(512, 52);
            this.btnDescomprimir.Name = "btnDescomprimir";
            this.btnDescomprimir.Size = new System.Drawing.Size(117, 30);
            this.btnDescomprimir.TabIndex = 1;
            this.btnDescomprimir.Text = "Descomprimir";
            this.btnDescomprimir.UseVisualStyleBackColor = true;
            this.btnDescomprimir.Click += new System.EventHandler(this.btnDescomprimir_Click);
            // 
            // txtComprimir
            // 
            this.txtComprimir.Location = new System.Drawing.Point(12, 21);
            this.txtComprimir.Name = "txtComprimir";
            this.txtComprimir.Size = new System.Drawing.Size(494, 20);
            this.txtComprimir.TabIndex = 2;
            // 
            // txtDescomprimir
            // 
            this.txtDescomprimir.Location = new System.Drawing.Point(12, 58);
            this.txtDescomprimir.Name = "txtDescomprimir";
            this.txtDescomprimir.Size = new System.Drawing.Size(494, 20);
            this.txtDescomprimir.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(512, 88);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(117, 30);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmComprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 138);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtDescomprimir);
            this.Controls.Add(this.txtComprimir);
            this.Controls.Add(this.btnDescomprimir);
            this.Controls.Add(this.btnComprimir);
            this.Name = "frmComprimir";
            this.Text = "frmComprimir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComprimir;
        private System.Windows.Forms.Button btnDescomprimir;
        private System.Windows.Forms.TextBox txtComprimir;
        private System.Windows.Forms.TextBox txtDescomprimir;
        private System.Windows.Forms.Button btnEnviar;
    }
}
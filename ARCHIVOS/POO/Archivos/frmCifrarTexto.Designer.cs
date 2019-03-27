namespace POO.Archivos
{
    partial class frmCifrarTexto
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
            this.txtTextoOriginal = new System.Windows.Forms.TextBox();
            this.txtTextoCifrado = new System.Windows.Forms.TextBox();
            this.txtTextoDescifrado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.btnDescifrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTextoOriginal
            // 
            this.txtTextoOriginal.Location = new System.Drawing.Point(12, 28);
            this.txtTextoOriginal.Multiline = true;
            this.txtTextoOriginal.Name = "txtTextoOriginal";
            this.txtTextoOriginal.Size = new System.Drawing.Size(815, 99);
            this.txtTextoOriginal.TabIndex = 0;
            // 
            // txtTextoCifrado
            // 
            this.txtTextoCifrado.Location = new System.Drawing.Point(12, 189);
            this.txtTextoCifrado.Multiline = true;
            this.txtTextoCifrado.Name = "txtTextoCifrado";
            this.txtTextoCifrado.Size = new System.Drawing.Size(815, 90);
            this.txtTextoCifrado.TabIndex = 0;
            // 
            // txtTextoDescifrado
            // 
            this.txtTextoDescifrado.Location = new System.Drawing.Point(12, 308);
            this.txtTextoDescifrado.Multiline = true;
            this.txtTextoDescifrado.Name = "txtTextoDescifrado";
            this.txtTextoDescifrado.Size = new System.Drawing.Size(815, 90);
            this.txtTextoDescifrado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Texto Cifrado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Texto Descifrado";
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(15, 135);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(117, 27);
            this.btnCifrar.TabIndex = 2;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // btnDescifrar
            // 
            this.btnDescifrar.Location = new System.Drawing.Point(138, 135);
            this.btnDescifrar.Name = "btnDescifrar";
            this.btnDescifrar.Size = new System.Drawing.Size(117, 27);
            this.btnDescifrar.TabIndex = 2;
            this.btnDescifrar.Text = "Descifrar";
            this.btnDescifrar.UseVisualStyleBackColor = true;
            this.btnDescifrar.Click += new System.EventHandler(this.btnDescifrar_Click);
            // 
            // frmCifrarTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 402);
            this.Controls.Add(this.btnDescifrar);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTextoDescifrado);
            this.Controls.Add(this.txtTextoCifrado);
            this.Controls.Add(this.txtTextoOriginal);
            this.Name = "frmCifrarTexto";
            this.Text = "frmCifrarTexto";
            this.Load += new System.EventHandler(this.frmCifrarTexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoOriginal;
        private System.Windows.Forms.TextBox txtTextoCifrado;
        private System.Windows.Forms.TextBox txtTextoDescifrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Button btnDescifrar;
    }
}
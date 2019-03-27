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
            this.txtTextoDescifrado = new System.Windows.Forms.TextBox();
            this.txtTextoCifrado = new System.Windows.Forms.TextBox();
            this.txtTextoOriginal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.btnDescifrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTextoDescifrado
            // 
            this.txtTextoDescifrado.Location = new System.Drawing.Point(27, 345);
            this.txtTextoDescifrado.Multiline = true;
            this.txtTextoDescifrado.Name = "txtTextoDescifrado";
            this.txtTextoDescifrado.Size = new System.Drawing.Size(847, 98);
            this.txtTextoDescifrado.TabIndex = 0;
            // 
            // txtTextoCifrado
            // 
            this.txtTextoCifrado.Location = new System.Drawing.Point(27, 214);
            this.txtTextoCifrado.Multiline = true;
            this.txtTextoCifrado.Name = "txtTextoCifrado";
            this.txtTextoCifrado.Size = new System.Drawing.Size(847, 98);
            this.txtTextoCifrado.TabIndex = 1;
            // 
            // txtTextoOriginal
            // 
            this.txtTextoOriginal.Location = new System.Drawing.Point(27, 49);
            this.txtTextoOriginal.Multiline = true;
            this.txtTextoOriginal.Name = "txtTextoOriginal";
            this.txtTextoOriginal.Size = new System.Drawing.Size(847, 98);
            this.txtTextoOriginal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texto Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto Cifrado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Texto Descifrado";
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(27, 153);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(99, 23);
            this.btnCifrar.TabIndex = 6;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // btnDescifrar
            // 
            this.btnDescifrar.Location = new System.Drawing.Point(132, 153);
            this.btnDescifrar.Name = "btnDescifrar";
            this.btnDescifrar.Size = new System.Drawing.Size(105, 23);
            this.btnDescifrar.TabIndex = 7;
            this.btnDescifrar.Text = "Descifrar";
            this.btnDescifrar.UseVisualStyleBackColor = true;
            this.btnDescifrar.Click += new System.EventHandler(this.btnDescifrar_Click);
            // 
            // frmCifrarTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 462);
            this.Controls.Add(this.btnDescifrar);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTextoOriginal);
            this.Controls.Add(this.txtTextoCifrado);
            this.Controls.Add(this.txtTextoDescifrado);
            this.Name = "frmCifrarTexto";
            this.Text = "frmCifrarTexto";
            this.Load += new System.EventHandler(this.frmCifrarTexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoDescifrado;
        private System.Windows.Forms.TextBox txtTextoCifrado;
        private System.Windows.Forms.TextBox txtTextoOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Button btnDescifrar;
    }
}
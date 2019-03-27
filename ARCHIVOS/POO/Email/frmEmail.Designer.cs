namespace POO.Email
{
    partial class frmEmail
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdjuntar = new System.Windows.Forms.TextBox();
            this.btnEnviarMensaje = new System.Windows.Forms.Button();
            this.btnFichero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARA";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(75, 12);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(422, 20);
            this.txtPara.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ASUNTO";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(75, 38);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(422, 20);
            this.txtAsunto.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "MENSAJE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(75, 64);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(422, 122);
            this.txtMensaje.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ADJUNTAR";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAdjuntar
            // 
            this.txtAdjuntar.Location = new System.Drawing.Point(75, 195);
            this.txtAdjuntar.Name = "txtAdjuntar";
            this.txtAdjuntar.Size = new System.Drawing.Size(344, 20);
            this.txtAdjuntar.TabIndex = 2;
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.Location = new System.Drawing.Point(78, 224);
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.Size = new System.Drawing.Size(116, 29);
            this.btnEnviarMensaje.TabIndex = 3;
            this.btnEnviarMensaje.Text = "Enviar Mensaje";
            this.btnEnviarMensaje.UseVisualStyleBackColor = true;
            this.btnEnviarMensaje.Click += new System.EventHandler(this.btnEnviarMensaje_Click);
            // 
            // btnFichero
            // 
            this.btnFichero.Location = new System.Drawing.Point(425, 192);
            this.btnFichero.Name = "btnFichero";
            this.btnFichero.Size = new System.Drawing.Size(72, 23);
            this.btnFichero.TabIndex = 3;
            this.btnFichero.Text = "Fichero";
            this.btnFichero.UseVisualStyleBackColor = true;
            this.btnFichero.Click += new System.EventHandler(this.btnFichero_Click);
            // 
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 265);
            this.Controls.Add(this.btnFichero);
            this.Controls.Add(this.btnEnviarMensaje);
            this.Controls.Add(this.txtAdjuntar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label1);
            this.Name = "frmEmail";
            this.Text = "frmEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdjuntar;
        private System.Windows.Forms.Button btnEnviarMensaje;
        private System.Windows.Forms.Button btnFichero;
    }
}
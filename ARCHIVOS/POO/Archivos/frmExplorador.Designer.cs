namespace POO.Archivos
{
    partial class frmExplorador
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
            this.cboDisco = new System.Windows.Forms.ComboBox();
            this.lstCarpetas = new System.Windows.Forms.ListBox();
            this.lstArchivos = new System.Windows.Forms.ListBox();
            this.pctImagen = new System.Windows.Forms.PictureBox();
            this.lbltamaño = new System.Windows.Forms.Label();
            this.lbldisponible = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDisco
            // 
            this.cboDisco.FormattingEnabled = true;
            this.cboDisco.Location = new System.Drawing.Point(12, 12);
            this.cboDisco.Name = "cboDisco";
            this.cboDisco.Size = new System.Drawing.Size(249, 21);
            this.cboDisco.TabIndex = 0;
            this.cboDisco.SelectedIndexChanged += new System.EventHandler(this.cboDisco_SelectedIndexChanged);
            // 
            // lstCarpetas
            // 
            this.lstCarpetas.FormattingEnabled = true;
            this.lstCarpetas.Location = new System.Drawing.Point(14, 40);
            this.lstCarpetas.Name = "lstCarpetas";
            this.lstCarpetas.Size = new System.Drawing.Size(247, 381);
            this.lstCarpetas.TabIndex = 1;
            this.lstCarpetas.SelectedIndexChanged += new System.EventHandler(this.lstCarpetas_SelectedIndexChanged);
            // 
            // lstArchivos
            // 
            this.lstArchivos.FormattingEnabled = true;
            this.lstArchivos.Location = new System.Drawing.Point(267, 40);
            this.lstArchivos.Name = "lstArchivos";
            this.lstArchivos.Size = new System.Drawing.Size(315, 381);
            this.lstArchivos.TabIndex = 1;
            this.lstArchivos.SelectedIndexChanged += new System.EventHandler(this.lstArchivos_SelectedIndexChanged);
            this.lstArchivos.DoubleClick += new System.EventHandler(this.lstArchivos_DoubleClick);
            // 
            // pctImagen
            // 
            this.pctImagen.Location = new System.Drawing.Point(588, 40);
            this.pctImagen.Name = "pctImagen";
            this.pctImagen.Size = new System.Drawing.Size(463, 377);
            this.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagen.TabIndex = 2;
            this.pctImagen.TabStop = false;
            // 
            // lbltamaño
            // 
            this.lbltamaño.AutoSize = true;
            this.lbltamaño.Location = new System.Drawing.Point(284, 15);
            this.lbltamaño.Name = "lbltamaño";
            this.lbltamaño.Size = new System.Drawing.Size(46, 13);
            this.lbltamaño.TabIndex = 3;
            this.lbltamaño.Text = "Tamaño";
            // 
            // lbldisponible
            // 
            this.lbldisponible.AutoSize = true;
            this.lbldisponible.Location = new System.Drawing.Point(452, 15);
            this.lbldisponible.Name = "lbldisponible";
            this.lbldisponible.Size = new System.Drawing.Size(56, 13);
            this.lbldisponible.TabIndex = 3;
            this.lbldisponible.Text = "Disponible";
            // 
            // frmExplorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 429);
            this.Controls.Add(this.lbldisponible);
            this.Controls.Add(this.lbltamaño);
            this.Controls.Add(this.pctImagen);
            this.Controls.Add(this.lstArchivos);
            this.Controls.Add(this.lstCarpetas);
            this.Controls.Add(this.cboDisco);
            this.Name = "frmExplorador";
            this.Text = "frmExplorador";
            this.Load += new System.EventHandler(this.frmExplorador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDisco;
        private System.Windows.Forms.ListBox lstCarpetas;
        private System.Windows.Forms.ListBox lstArchivos;
        private System.Windows.Forms.PictureBox pctImagen;
        private System.Windows.Forms.Label lbltamaño;
        private System.Windows.Forms.Label lbldisponible;
    }
}
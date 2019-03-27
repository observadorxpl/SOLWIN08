namespace POO.Colecciones
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
            this.lblTamaño = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDisco
            // 
            this.cboDisco.FormattingEnabled = true;
            this.cboDisco.Location = new System.Drawing.Point(23, 19);
            this.cboDisco.Name = "cboDisco";
            this.cboDisco.Size = new System.Drawing.Size(235, 21);
            this.cboDisco.TabIndex = 0;
            this.cboDisco.SelectedIndexChanged += new System.EventHandler(this.cboDisco_SelectedIndexChanged);
            // 
            // lstCarpetas
            // 
            this.lstCarpetas.FormattingEnabled = true;
            this.lstCarpetas.Location = new System.Drawing.Point(23, 52);
            this.lstCarpetas.Name = "lstCarpetas";
            this.lstCarpetas.Size = new System.Drawing.Size(235, 381);
            this.lstCarpetas.TabIndex = 1;
            this.lstCarpetas.SelectedIndexChanged += new System.EventHandler(this.lstCarpetas_SelectedIndexChanged);
            // 
            // lstArchivos
            // 
            this.lstArchivos.FormattingEnabled = true;
            this.lstArchivos.Location = new System.Drawing.Point(264, 52);
            this.lstArchivos.Name = "lstArchivos";
            this.lstArchivos.Size = new System.Drawing.Size(235, 381);
            this.lstArchivos.TabIndex = 2;
            this.lstArchivos.SelectedIndexChanged += new System.EventHandler(this.lstArchivos_SelectedIndexChanged);
            this.lstArchivos.DoubleClick += new System.EventHandler(this.lstArchivos_DoubleClick);
            // 
            // pctImagen
            // 
            this.pctImagen.Location = new System.Drawing.Point(505, 52);
            this.pctImagen.Name = "pctImagen";
            this.pctImagen.Size = new System.Drawing.Size(476, 381);
            this.pctImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagen.TabIndex = 4;
            this.pctImagen.TabStop = false;
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Location = new System.Drawing.Point(264, 22);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(46, 13);
            this.lblTamaño.TabIndex = 5;
            this.lblTamaño.Text = "Tamaño";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Location = new System.Drawing.Point(502, 22);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(56, 13);
            this.lblDisponible.TabIndex = 6;
            this.lblDisponible.Text = "Disponible";
            // 
            // frmExplorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 463);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.lblTamaño);
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
        private System.Windows.Forms.Label lblTamaño;
        private System.Windows.Forms.Label lblDisponible;
    }
}
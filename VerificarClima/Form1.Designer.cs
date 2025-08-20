namespace VerificarClima {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pibStatus = new System.Windows.Forms.PictureBox();
            this.lblDiaHoje = new System.Windows.Forms.Label();
            this.txbTemp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(156, 50);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Verificador De Temperatura";
            // 
            // pibStatus
            // 
            this.pibStatus.Location = new System.Drawing.Point(160, 129);
            this.pibStatus.Name = "pibStatus";
            this.pibStatus.Size = new System.Drawing.Size(201, 168);
            this.pibStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibStatus.TabIndex = 2;
            this.pibStatus.TabStop = false;
            // 
            // lblDiaHoje
            // 
            this.lblDiaHoje.AutoSize = true;
            this.lblDiaHoje.Location = new System.Drawing.Point(198, 320);
            this.lblDiaHoje.Name = "lblDiaHoje";
            this.lblDiaHoje.Size = new System.Drawing.Size(0, 20);
            this.lblDiaHoje.TabIndex = 3;
            // 
            // txbTemp
            // 
            this.txbTemp.Location = new System.Drawing.Point(160, 86);
            this.txbTemp.Name = "txbTemp";
            this.txbTemp.Size = new System.Drawing.Size(201, 26);
            this.txbTemp.TabIndex = 4;
            this.txbTemp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTemp_KeyDown);
            this.txbTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTemp_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 359);
            this.Controls.Add(this.txbTemp);
            this.Controls.Add(this.lblDiaHoje);
            this.Controls.Add(this.pibStatus);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperatura";
            ((System.ComponentModel.ISupportInitialize)(this.pibStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pibStatus;
        private System.Windows.Forms.Label lblDiaHoje;
        private System.Windows.Forms.TextBox txbTemp;
    }
}


namespace sisgaapWF
{
    partial class Solicitudes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargarSA = new System.Windows.Forms.Button();
            this.btnCargarSP = new System.Windows.Forms.Button();
            this.gvSolicitudes = new System.Windows.Forms.DataGridView();
            this.btnRealizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarSA
            // 
            this.btnCargarSA.Location = new System.Drawing.Point(12, 3);
            this.btnCargarSA.Name = "btnCargarSA";
            this.btnCargarSA.Size = new System.Drawing.Size(198, 55);
            this.btnCargarSA.TabIndex = 0;
            this.btnCargarSA.Text = "Solicitudes de Abastecimiento";
            this.btnCargarSA.UseVisualStyleBackColor = true;
            this.btnCargarSA.Click += new System.EventHandler(this.btnCargarSA_Click);
            // 
            // btnCargarSP
            // 
            this.btnCargarSP.Location = new System.Drawing.Point(12, 58);
            this.btnCargarSP.Name = "btnCargarSP";
            this.btnCargarSP.Size = new System.Drawing.Size(198, 55);
            this.btnCargarSP.TabIndex = 1;
            this.btnCargarSP.Text = "Solicitudes de Producción";
            this.btnCargarSP.UseVisualStyleBackColor = true;
            this.btnCargarSP.Click += new System.EventHandler(this.btnCargarSP_Click);
            // 
            // gvSolicitudes
            // 
            this.gvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSolicitudes.Location = new System.Drawing.Point(0, 116);
            this.gvSolicitudes.Name = "gvSolicitudes";
            this.gvSolicitudes.RowHeadersWidth = 51;
            this.gvSolicitudes.RowTemplate.Height = 24;
            this.gvSolicitudes.Size = new System.Drawing.Size(983, 395);
            this.gvSolicitudes.TabIndex = 2;
            // 
            // btnRealizar
            // 
            this.btnRealizar.Location = new System.Drawing.Point(256, 3);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(164, 55);
            this.btnRealizar.TabIndex = 3;
            this.btnRealizar.Text = "Realizar Solicitud de Abastecimiento";
            this.btnRealizar.UseVisualStyleBackColor = true;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // Solicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 512);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.gvSolicitudes);
            this.Controls.Add(this.btnCargarSP);
            this.Controls.Add(this.btnCargarSA);
            this.Name = "Solicitudes";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvSolicitudes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarSA;
        private System.Windows.Forms.Button btnCargarSP;
        private System.Windows.Forms.DataGridView gvSolicitudes;
        private System.Windows.Forms.Button btnRealizar;
    }
}


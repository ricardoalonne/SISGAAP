
namespace sisgaapSystemWF
{
    partial class wmSystem
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
            this.Button_DocumentosSA = new System.Windows.Forms.Button();
            this.Button_DocumentosSP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_DocumentosSA
            // 
            this.Button_DocumentosSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_DocumentosSA.FlatAppearance.BorderSize = 0;
            this.Button_DocumentosSA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_DocumentosSA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_DocumentosSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DocumentosSA.Location = new System.Drawing.Point(12, 13);
            this.Button_DocumentosSA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_DocumentosSA.Name = "Button_DocumentosSA";
            this.Button_DocumentosSA.Size = new System.Drawing.Size(230, 43);
            this.Button_DocumentosSA.TabIndex = 6;
            this.Button_DocumentosSA.Text = "Documentos : Supervisor Almacen";
            this.Button_DocumentosSA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_DocumentosSA.UseVisualStyleBackColor = false;
            this.Button_DocumentosSA.Click += new System.EventHandler(this.Button_DocumentosSA_Click);
            // 
            // Button_DocumentosSP
            // 
            this.Button_DocumentosSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_DocumentosSP.FlatAppearance.BorderSize = 0;
            this.Button_DocumentosSP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_DocumentosSP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_DocumentosSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DocumentosSP.Location = new System.Drawing.Point(12, 64);
            this.Button_DocumentosSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_DocumentosSP.Name = "Button_DocumentosSP";
            this.Button_DocumentosSP.Size = new System.Drawing.Size(230, 43);
            this.Button_DocumentosSP.TabIndex = 7;
            this.Button_DocumentosSP.Text = "Documentos: Supervisor Producción";
            this.Button_DocumentosSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_DocumentosSP.UseVisualStyleBackColor = false;
            this.Button_DocumentosSP.Click += new System.EventHandler(this.Button_DocumentosSP_Click);
            // 
            // wmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 378);
            this.Controls.Add(this.Button_DocumentosSP);
            this.Controls.Add(this.Button_DocumentosSA);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "wmSystem";
            this.Text = "WAREHOUSE MANANGER";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_DocumentosSA;
        private System.Windows.Forms.Button Button_DocumentosSP;
    }
}



namespace sisgaapTestWF
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
            this.buttonSA = new System.Windows.Forms.Button();
            this.buttonSP = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.panel_Usuario = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSA
            // 
            this.buttonSA.BackColor = System.Drawing.Color.Gray;
            this.buttonSA.FlatAppearance.BorderSize = 0;
            this.buttonSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSA.ForeColor = System.Drawing.Color.White;
            this.buttonSA.Location = new System.Drawing.Point(0, 34);
            this.buttonSA.Name = "buttonSA";
            this.buttonSA.Size = new System.Drawing.Size(164, 30);
            this.buttonSA.TabIndex = 0;
            this.buttonSA.Text = "Supervisor de Almacen";
            this.buttonSA.UseVisualStyleBackColor = false;
            this.buttonSA.Click += new System.EventHandler(this.buttonSA_Click);
            // 
            // buttonSP
            // 
            this.buttonSP.BackColor = System.Drawing.Color.Gray;
            this.buttonSP.FlatAppearance.BorderSize = 0;
            this.buttonSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSP.ForeColor = System.Drawing.Color.White;
            this.buttonSP.Location = new System.Drawing.Point(173, 34);
            this.buttonSP.Name = "buttonSP";
            this.buttonSP.Size = new System.Drawing.Size(204, 30);
            this.buttonSP.TabIndex = 1;
            this.buttonSP.Text = "Supervisor de Producción";
            this.buttonSP.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.buttonCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 37);
            this.panel1.TabIndex = 2;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.ForeColor = System.Drawing.Color.White;
            this.buttonCerrar.Location = new System.Drawing.Point(921, 0);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(63, 37);
            this.buttonCerrar.TabIndex = 0;
            this.buttonCerrar.Text = "X";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            // 
            // panel_Usuario
            // 
            this.panel_Usuario.BackColor = System.Drawing.Color.White;
            this.panel_Usuario.Location = new System.Drawing.Point(0, 63);
            this.panel_Usuario.Name = "panel_Usuario";
            this.panel_Usuario.Size = new System.Drawing.Size(984, 498);
            this.panel_Usuario.TabIndex = 3;
            // 
            // wmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel_Usuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSP);
            this.Controls.Add(this.buttonSA);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "wmSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WAREHOUSE MANANGER";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSA;
        private System.Windows.Forms.Button buttonSP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Panel panel_Usuario;
    }
}


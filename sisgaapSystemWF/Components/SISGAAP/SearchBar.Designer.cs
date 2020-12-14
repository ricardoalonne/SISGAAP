
namespace sisgaapSystemWF.Components.SISGAAP
{
    partial class SearchBar
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBar));
            this.ComboBox_Filtro = new System.Windows.Forms.ComboBox();
            this.Panel_BarraBusqueda = new System.Windows.Forms.Panel();
            this.TextBox_Búsqueda = new System.Windows.Forms.TextBox();
            this.PictureBox_ImagenBuscar = new System.Windows.Forms.PictureBox();
            this.Button_Buscar = new System.Windows.Forms.Button();
            this.Panel_BarraBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ImagenBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox_Filtro
            // 
            this.ComboBox_Filtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Filtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ComboBox_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Filtro.FormattingEnabled = true;
            this.ComboBox_Filtro.Location = new System.Drawing.Point(444, 8);
            this.ComboBox_Filtro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_Filtro.Name = "ComboBox_Filtro";
            this.ComboBox_Filtro.Size = new System.Drawing.Size(150, 25);
            this.ComboBox_Filtro.TabIndex = 87;
            this.ComboBox_Filtro.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Filtro_SelectedIndexChanged);
            // 
            // Panel_BarraBusqueda
            // 
            this.Panel_BarraBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_BarraBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Panel_BarraBusqueda.Controls.Add(this.TextBox_Búsqueda);
            this.Panel_BarraBusqueda.Controls.Add(this.PictureBox_ImagenBuscar);
            this.Panel_BarraBusqueda.Controls.Add(this.Button_Buscar);
            this.Panel_BarraBusqueda.Location = new System.Drawing.Point(0, 0);
            this.Panel_BarraBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_BarraBusqueda.Name = "Panel_BarraBusqueda";
            this.Panel_BarraBusqueda.Size = new System.Drawing.Size(433, 40);
            this.Panel_BarraBusqueda.TabIndex = 86;
            // 
            // TextBox_Búsqueda
            // 
            this.TextBox_Búsqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Búsqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TextBox_Búsqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Búsqueda.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.TextBox_Búsqueda.ForeColor = System.Drawing.Color.Gray;
            this.TextBox_Búsqueda.Location = new System.Drawing.Point(57, 10);
            this.TextBox_Búsqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Búsqueda.Name = "TextBox_Búsqueda";
            this.TextBox_Búsqueda.Size = new System.Drawing.Size(320, 20);
            this.TextBox_Búsqueda.TabIndex = 82;
            // 
            // PictureBox_ImagenBuscar
            // 
            this.PictureBox_ImagenBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBox_ImagenBuscar.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_ImagenBuscar.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_ImagenBuscar.Image")));
            this.PictureBox_ImagenBuscar.Location = new System.Drawing.Point(1, 1);
            this.PictureBox_ImagenBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureBox_ImagenBuscar.Name = "PictureBox_ImagenBuscar";
            this.PictureBox_ImagenBuscar.Size = new System.Drawing.Size(49, 38);
            this.PictureBox_ImagenBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox_ImagenBuscar.TabIndex = 84;
            this.PictureBox_ImagenBuscar.TabStop = false;
            // 
            // Button_Buscar
            // 
            this.Button_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Buscar.FlatAppearance.BorderSize = 0;
            this.Button_Buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Buscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Buscar.ForeColor = System.Drawing.Color.White;
            this.Button_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Button_Buscar.Image")));
            this.Button_Buscar.Location = new System.Drawing.Point(383, 1);
            this.Button_Buscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Buscar.Name = "Button_Buscar";
            this.Button_Buscar.Size = new System.Drawing.Size(49, 38);
            this.Button_Buscar.TabIndex = 83;
            this.Button_Buscar.UseVisualStyleBackColor = false;
            this.Button_Buscar.Visible = false;
            this.Button_Buscar.Click += new System.EventHandler(this.Button_Buscar_Click);
            // 
            // SearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.ComboBox_Filtro);
            this.Controls.Add(this.Panel_BarraBusqueda);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchBar";
            this.Size = new System.Drawing.Size(600, 40);
            this.Load += new System.EventHandler(this.SearchBar_Load);
            this.BackColorChanged += new System.EventHandler(this.SearchBar_BackColorChanged);
            this.Panel_BarraBusqueda.ResumeLayout(false);
            this.Panel_BarraBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_ImagenBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_Filtro;
        private System.Windows.Forms.Panel Panel_BarraBusqueda;
        private System.Windows.Forms.TextBox TextBox_Búsqueda;
        private System.Windows.Forms.PictureBox PictureBox_ImagenBuscar;
        private System.Windows.Forms.Button Button_Buscar;
    }
}

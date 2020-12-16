
namespace sisgaapTestWF
{
    partial class SupervisorAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupervisorAlmacen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_actualizarSA = new System.Windows.Forms.Button();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.button_actualizarI = new System.Windows.Forms.Button();
            this.panel_SupervisorA = new System.Windows.Forms.Panel();
            this.DataGridView_VistaPrincipal = new System.Windows.Forms.DataGridView();
            this.Button_NuevaSolicitud = new System.Windows.Forms.Button();
            this.Panel_BarraBusqueda = new System.Windows.Forms.Panel();
            this.TextBox_Búsqueda = new System.Windows.Forms.TextBox();
            this.Button_Buscar = new System.Windows.Forms.Button();
            this.ComboBox_Filtro = new System.Windows.Forms.ComboBox();
            this.group_Busqueda = new System.Windows.Forms.GroupBox();
            this.panel_vista = new System.Windows.Forms.Panel();
            this.textBox_vista = new System.Windows.Forms.TextBox();
            this.button_visualizarSA = new System.Windows.Forms.Button();
            this.button_cerrarVista = new System.Windows.Forms.Button();
            this.panel_Menu.SuspendLayout();
            this.panel_SupervisorA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_VistaPrincipal)).BeginInit();
            this.Panel_BarraBusqueda.SuspendLayout();
            this.group_Busqueda.SuspendLayout();
            this.panel_vista.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_actualizarSA
            // 
            this.button_actualizarSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_actualizarSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_actualizarSA.ForeColor = System.Drawing.Color.White;
            this.button_actualizarSA.Image = ((System.Drawing.Image)(resources.GetObject("button_actualizarSA.Image")));
            this.button_actualizarSA.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_actualizarSA.Location = new System.Drawing.Point(0, 5);
            this.button_actualizarSA.Name = "button_actualizarSA";
            this.button_actualizarSA.Size = new System.Drawing.Size(111, 55);
            this.button_actualizarSA.TabIndex = 0;
            this.button_actualizarSA.Text = "Actualizar Solicitud Abastecimiento";
            this.button_actualizarSA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_actualizarSA.UseVisualStyleBackColor = false;
            this.button_actualizarSA.Click += new System.EventHandler(this.button_actualizarSA_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.Green;
            this.panel_Menu.Controls.Add(this.button_actualizarI);
            this.panel_Menu.Controls.Add(this.button_actualizarSA);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(111, 498);
            this.panel_Menu.TabIndex = 1;
            // 
            // button_actualizarI
            // 
            this.button_actualizarI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_actualizarI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_actualizarI.ForeColor = System.Drawing.Color.White;
            this.button_actualizarI.Image = ((System.Drawing.Image)(resources.GetObject("button_actualizarI.Image")));
            this.button_actualizarI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_actualizarI.Location = new System.Drawing.Point(0, 66);
            this.button_actualizarI.Name = "button_actualizarI";
            this.button_actualizarI.Size = new System.Drawing.Size(111, 55);
            this.button_actualizarI.TabIndex = 1;
            this.button_actualizarI.Text = "Actualizar Inventario";
            this.button_actualizarI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_actualizarI.UseVisualStyleBackColor = false;
            // 
            // panel_SupervisorA
            // 
            this.panel_SupervisorA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel_SupervisorA.Controls.Add(this.panel_vista);
            this.panel_SupervisorA.Controls.Add(this.group_Busqueda);
            this.panel_SupervisorA.Controls.Add(this.Button_NuevaSolicitud);
            this.panel_SupervisorA.Controls.Add(this.DataGridView_VistaPrincipal);
            this.panel_SupervisorA.Controls.Add(this.button_visualizarSA);
            this.panel_SupervisorA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SupervisorA.Location = new System.Drawing.Point(111, 0);
            this.panel_SupervisorA.Name = "panel_SupervisorA";
            this.panel_SupervisorA.Size = new System.Drawing.Size(873, 498);
            this.panel_SupervisorA.TabIndex = 2;
            this.panel_SupervisorA.Visible = false;
            // 
            // DataGridView_VistaPrincipal
            // 
            this.DataGridView_VistaPrincipal.AllowUserToResizeRows = false;
            this.DataGridView_VistaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_VistaPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_VistaPrincipal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.DataGridView_VistaPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_VistaPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_VistaPrincipal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_VistaPrincipal.ColumnHeadersHeight = 35;
            this.DataGridView_VistaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_VistaPrincipal.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_VistaPrincipal.EnableHeadersVisualStyles = false;
            this.DataGridView_VistaPrincipal.GridColor = System.Drawing.Color.Silver;
            this.DataGridView_VistaPrincipal.Location = new System.Drawing.Point(18, 174);
            this.DataGridView_VistaPrincipal.Name = "DataGridView_VistaPrincipal";
            this.DataGridView_VistaPrincipal.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_VistaPrincipal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_VistaPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_VistaPrincipal.Size = new System.Drawing.Size(843, 312);
            this.DataGridView_VistaPrincipal.TabIndex = 3;
            // 
            // Button_NuevaSolicitud
            // 
            this.Button_NuevaSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_NuevaSolicitud.FlatAppearance.BorderSize = 0;
            this.Button_NuevaSolicitud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_NuevaSolicitud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_NuevaSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_NuevaSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("Button_NuevaSolicitud.Image")));
            this.Button_NuevaSolicitud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_NuevaSolicitud.Location = new System.Drawing.Point(527, 126);
            this.Button_NuevaSolicitud.Name = "Button_NuevaSolicitud";
            this.Button_NuevaSolicitud.Size = new System.Drawing.Size(196, 33);
            this.Button_NuevaSolicitud.TabIndex = 5;
            this.Button_NuevaSolicitud.Text = "Solicitud Abastecimiento";
            this.Button_NuevaSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_NuevaSolicitud.UseVisualStyleBackColor = false;
            // 
            // Panel_BarraBusqueda
            // 
            this.Panel_BarraBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_BarraBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Panel_BarraBusqueda.Controls.Add(this.TextBox_Búsqueda);
            this.Panel_BarraBusqueda.Controls.Add(this.Button_Buscar);
            this.Panel_BarraBusqueda.Location = new System.Drawing.Point(18, 25);
            this.Panel_BarraBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel_BarraBusqueda.Name = "Panel_BarraBusqueda";
            this.Panel_BarraBusqueda.Size = new System.Drawing.Size(433, 40);
            this.Panel_BarraBusqueda.TabIndex = 87;
            // 
            // TextBox_Búsqueda
            // 
            this.TextBox_Búsqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Búsqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TextBox_Búsqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Búsqueda.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.TextBox_Búsqueda.ForeColor = System.Drawing.Color.Gray;
            this.TextBox_Búsqueda.Location = new System.Drawing.Point(14, 9);
            this.TextBox_Búsqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Búsqueda.Name = "TextBox_Búsqueda";
            this.TextBox_Búsqueda.Size = new System.Drawing.Size(320, 20);
            this.TextBox_Búsqueda.TabIndex = 82;
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
            this.Button_Buscar.Click += new System.EventHandler(this.Button_Buscar_Click);
            // 
            // ComboBox_Filtro
            // 
            this.ComboBox_Filtro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Filtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ComboBox_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_Filtro.FormattingEnabled = true;
            this.ComboBox_Filtro.Location = new System.Drawing.Point(467, 32);
            this.ComboBox_Filtro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_Filtro.Name = "ComboBox_Filtro";
            this.ComboBox_Filtro.Size = new System.Drawing.Size(150, 26);
            this.ComboBox_Filtro.TabIndex = 88;
            this.ComboBox_Filtro.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Filtro_SelectedIndexChanged);
            // 
            // group_Busqueda
            // 
            this.group_Busqueda.Controls.Add(this.Panel_BarraBusqueda);
            this.group_Busqueda.Controls.Add(this.ComboBox_Filtro);
            this.group_Busqueda.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_Busqueda.Location = new System.Drawing.Point(6, 25);
            this.group_Busqueda.Name = "group_Busqueda";
            this.group_Busqueda.Size = new System.Drawing.Size(641, 72);
            this.group_Busqueda.TabIndex = 89;
            this.group_Busqueda.TabStop = false;
            this.group_Busqueda.Text = "Búsqueda de Solicitudes de Abastecimientos";
            // 
            // panel_vista
            // 
            this.panel_vista.Controls.Add(this.button_cerrarVista);
            this.panel_vista.Controls.Add(this.textBox_vista);
            this.panel_vista.Location = new System.Drawing.Point(3, 3);
            this.panel_vista.Name = "panel_vista";
            this.panel_vista.Size = new System.Drawing.Size(709, 372);
            this.panel_vista.TabIndex = 90;
            this.panel_vista.Visible = false;
            // 
            // textBox_vista
            // 
            this.textBox_vista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_vista.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_vista.Location = new System.Drawing.Point(17, 21);
            this.textBox_vista.Multiline = true;
            this.textBox_vista.Name = "textBox_vista";
            this.textBox_vista.Size = new System.Drawing.Size(671, 309);
            this.textBox_vista.TabIndex = 0;
            // 
            // button_visualizarSA
            // 
            this.button_visualizarSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_visualizarSA.FlatAppearance.BorderSize = 0;
            this.button_visualizarSA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_visualizarSA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_visualizarSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_visualizarSA.Image = ((System.Drawing.Image)(resources.GetObject("button_visualizarSA.Image")));
            this.button_visualizarSA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_visualizarSA.Location = new System.Drawing.Point(312, 126);
            this.button_visualizarSA.Name = "button_visualizarSA";
            this.button_visualizarSA.Size = new System.Drawing.Size(196, 33);
            this.button_visualizarSA.TabIndex = 91;
            this.button_visualizarSA.Text = "Visualizar Solicitud";
            this.button_visualizarSA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_visualizarSA.UseVisualStyleBackColor = false;
            this.button_visualizarSA.Click += new System.EventHandler(this.button_visualizarSA_Click);
            // 
            // button_cerrarVista
            // 
            this.button_cerrarVista.BackColor = System.Drawing.Color.Green;
            this.button_cerrarVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cerrarVista.ForeColor = System.Drawing.Color.White;
            this.button_cerrarVista.Location = new System.Drawing.Point(584, 336);
            this.button_cerrarVista.Name = "button_cerrarVista";
            this.button_cerrarVista.Size = new System.Drawing.Size(104, 33);
            this.button_cerrarVista.TabIndex = 1;
            this.button_cerrarVista.Text = "Cerrar";
            this.button_cerrarVista.UseVisualStyleBackColor = false;
            this.button_cerrarVista.Click += new System.EventHandler(this.button_cerrarVista_Click);
            // 
            // SupervisorAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(984, 498);
            this.Controls.Add(this.panel_SupervisorA);
            this.Controls.Add(this.panel_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupervisorAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupervisorAlmacen";
            this.panel_Menu.ResumeLayout(false);
            this.panel_SupervisorA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_VistaPrincipal)).EndInit();
            this.Panel_BarraBusqueda.ResumeLayout(false);
            this.Panel_BarraBusqueda.PerformLayout();
            this.group_Busqueda.ResumeLayout(false);
            this.panel_vista.ResumeLayout(false);
            this.panel_vista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_actualizarSA;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button button_actualizarI;
        private System.Windows.Forms.Panel panel_SupervisorA;
        private System.Windows.Forms.DataGridView DataGridView_VistaPrincipal;
        private System.Windows.Forms.Button Button_NuevaSolicitud;
        private System.Windows.Forms.Panel Panel_BarraBusqueda;
        private System.Windows.Forms.TextBox TextBox_Búsqueda;
        private System.Windows.Forms.Button Button_Buscar;
        private System.Windows.Forms.GroupBox group_Busqueda;
        private System.Windows.Forms.ComboBox ComboBox_Filtro;
        private System.Windows.Forms.Panel panel_vista;
        private System.Windows.Forms.TextBox textBox_vista;
        private System.Windows.Forms.Button button_visualizarSA;
        private System.Windows.Forms.Button button_cerrarVista;
    }
}
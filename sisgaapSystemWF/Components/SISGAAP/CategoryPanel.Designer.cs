
using System.ComponentModel;

namespace sisgaapSystemWF.Components.SISGAAP
{
    partial class CategoryPanel
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
            this.Label_CategoryName = new System.Windows.Forms.Label();
            this.TableLayoutPanel_SeparatorTop = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox_SeparatorTop = new System.Windows.Forms.PictureBox();
            this.Panel_Container = new System.Windows.Forms.Panel();
            this.TableLayoutPanel_SeparatorBottom = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBox_SeparatorBottom = new System.Windows.Forms.PictureBox();
            this.TableLayoutPanel_SeparatorTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SeparatorTop)).BeginInit();
            this.TableLayoutPanel_SeparatorBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SeparatorBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_CategoryName
            // 
            this.Label_CategoryName.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_CategoryName.Location = new System.Drawing.Point(0, 0);
            this.Label_CategoryName.Name = "Label_CategoryName";
            this.Label_CategoryName.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.Label_CategoryName.Size = new System.Drawing.Size(360, 26);
            this.Label_CategoryName.TabIndex = 1;
            this.Label_CategoryName.Text = "Category name";
            // 
            // TableLayoutPanel_SeparatorTop
            // 
            this.TableLayoutPanel_SeparatorTop.ColumnCount = 1;
            this.TableLayoutPanel_SeparatorTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_SeparatorTop.Controls.Add(this.PictureBox_SeparatorTop, 0, 0);
            this.TableLayoutPanel_SeparatorTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanel_SeparatorTop.Location = new System.Drawing.Point(0, 26);
            this.TableLayoutPanel_SeparatorTop.Name = "TableLayoutPanel_SeparatorTop";
            this.TableLayoutPanel_SeparatorTop.RowCount = 1;
            this.TableLayoutPanel_SeparatorTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_SeparatorTop.Size = new System.Drawing.Size(360, 7);
            this.TableLayoutPanel_SeparatorTop.TabIndex = 4;
            // 
            // PictureBox_SeparatorTop
            // 
            this.PictureBox_SeparatorTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox_SeparatorTop.BackColor = System.Drawing.Color.Black;
            this.PictureBox_SeparatorTop.Location = new System.Drawing.Point(3, 3);
            this.PictureBox_SeparatorTop.Name = "PictureBox_SeparatorTop";
            this.PictureBox_SeparatorTop.Size = new System.Drawing.Size(354, 1);
            this.PictureBox_SeparatorTop.TabIndex = 0;
            this.PictureBox_SeparatorTop.TabStop = false;
            // 
            // Panel_Container
            // 
            this.Panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Container.Location = new System.Drawing.Point(0, 33);
            this.Panel_Container.Name = "Panel_Container";
            this.Panel_Container.Size = new System.Drawing.Size(360, 332);
            this.Panel_Container.TabIndex = 5;
            // 
            // TableLayoutPanel_SeparatorBottom
            // 
            this.TableLayoutPanel_SeparatorBottom.ColumnCount = 1;
            this.TableLayoutPanel_SeparatorBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_SeparatorBottom.Controls.Add(this.PictureBox_SeparatorBottom, 0, 0);
            this.TableLayoutPanel_SeparatorBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanel_SeparatorBottom.Location = new System.Drawing.Point(0, 358);
            this.TableLayoutPanel_SeparatorBottom.Name = "TableLayoutPanel_SeparatorBottom";
            this.TableLayoutPanel_SeparatorBottom.RowCount = 1;
            this.TableLayoutPanel_SeparatorBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel_SeparatorBottom.Size = new System.Drawing.Size(360, 7);
            this.TableLayoutPanel_SeparatorBottom.TabIndex = 6;
            // 
            // PictureBox_SeparatorBottom
            // 
            this.PictureBox_SeparatorBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox_SeparatorBottom.BackColor = System.Drawing.Color.Black;
            this.PictureBox_SeparatorBottom.Location = new System.Drawing.Point(3, 3);
            this.PictureBox_SeparatorBottom.Name = "PictureBox_SeparatorBottom";
            this.PictureBox_SeparatorBottom.Size = new System.Drawing.Size(354, 1);
            this.PictureBox_SeparatorBottom.TabIndex = 0;
            this.PictureBox_SeparatorBottom.TabStop = false;
            // 
            // CategoryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TableLayoutPanel_SeparatorBottom);
            this.Controls.Add(this.Panel_Container);
            this.Controls.Add(this.TableLayoutPanel_SeparatorTop);
            this.Controls.Add(this.Label_CategoryName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CategoryPanel";
            this.Size = new System.Drawing.Size(360, 365);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CategoryPanel_Paint);
            this.TableLayoutPanel_SeparatorTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SeparatorTop)).EndInit();
            this.TableLayoutPanel_SeparatorBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SeparatorBottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_CategoryName;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_SeparatorTop;
        private System.Windows.Forms.PictureBox PictureBox_SeparatorTop;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_SeparatorBottom;
        private System.Windows.Forms.PictureBox PictureBox_SeparatorBottom;

        public System.Windows.Forms.Panel Panel_Container;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.Design;

namespace sisgaapSystemWF.Components.SISGAAP
{
    [Designer(typeof(myControlDesigner))]
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class CategoryPanel : UserControl
    {
        public CategoryPanel(){
            InitializeComponent();
        }

        private void CategoryPanel_Paint(object sender, PaintEventArgs e){
            /*Pen p = new Pen(Color.Red); // Esto puede venir de una variable si necesitas un color cambiante
            e.Graphics.DrawRectangle(p, this.Left - 1, this.Top - 1, this.Width + 1, this.Height + 1);*/
        }
        
        //BORDERCOLOR
        const int WM_NCPAINT = 0x85;
        const uint RDW_INVALIDATE = 0x1;
        const uint RDW_IUPDATENOW = 0x100;
        const uint RDW_FRAME = 0x400;
        [DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32.dll")]
        static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, uint flags);
        Color borderColor = Color.Black;

        [
        Category("Appearance"),
        Description("El color del borde del componente."),
        Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)
        ]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                    RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
            }
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCPAINT &&
                BorderStyle == System.Windows.Forms.BorderStyle.FixedSingle)
            {
                var hdc = GetWindowDC(this.Handle);
                using (var g = Graphics.FromHdcInternal(hdc))
                using (var p = new Pen(BorderColor))
                    g.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1));
                ReleaseDC(this.Handle, hdc);
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                   RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
        }
    }

    class myControlDesigner : ParentControlDesigner
    {

        public override void Initialize(IComponent component)
        {

            base.Initialize(component);

            CategoryPanel myPanel = component as CategoryPanel;
            this.EnableDesignMode(myPanel.Panel_Container, "Panel_Container");

        }

    }
}

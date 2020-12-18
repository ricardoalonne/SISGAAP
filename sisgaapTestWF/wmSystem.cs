using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisgaapTestWF
{
    public partial class wmSystem : Form
    {
        public wmSystem()
        {
            InitializeComponent();
        }

        private void buttonSA_Click(object sender, EventArgs e)
        {
            SupervisorAlmacen sa = new SupervisorAlmacen();
            AbrirFormInPanel(sa);
        }
        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panel_Usuario.Controls.Count > 0) this.panel_Usuario.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel_Usuario.Controls.Add(fh);
            this.panel_Usuario.Tag = fh;
            fh.Show();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

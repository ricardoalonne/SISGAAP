using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sisgaapCore;
using sisgaapCoreWF.Controllers;

namespace sisgaapWF
{
    public partial class Solicitudes : Form
    {
        public Solicitudes()
        {
            InitializeComponent();
        }

        SolicitudAbastecimientoCtr objSA_Ctr = new SolicitudAbastecimientoCtr();
        SolicitudProduccionCtr objSP_Ctr = new SolicitudProduccionCtr();

        private void btnCargarSA_Click(object sender, EventArgs e)
        {
            gvSolicitudes.DataSource= objSA_Ctr.ListarSolicitudesAbastecimiento();
        }

        private void btnCargarSP_Click(object sender, EventArgs e)
        {
            gvSolicitudes.DataSource = objSP_Ctr.ListarSolicitudesProduccion();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            RealizarSolicitudes R = new RealizarSolicitudes();
            R.Show();
            Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using sisgaapSystemWF.Views.Documentos;

namespace sisgaapSystemWF
{
    public partial class wmSystem : Form
    {
        public wmSystem()
        {
            InitializeComponent();
        }

        private Documentos documentos;

        private void Button_DocumentosSA_Click(object sender, EventArgs e){
            documentos = new Documentos("Solicitud","Abastecimiento");
            documentos.Show();
        }

        private void Button_DocumentosSP_Click(object sender, EventArgs e){
            documentos = new Documentos("Solicitud", "Produccion");
            documentos.Show();
        }

        private void Button_VisualizarDocumento_Click(object sender, EventArgs e){
            VisualizarDocumento vdoc = new VisualizarDocumento();
            vdoc.Show();
        }
    }
}

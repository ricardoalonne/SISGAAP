using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisgaapSystemWF.Views.Documentos
{
    public partial class Documentos : Form
    {
        public Documentos()
        {
            InitializeComponent();
        }

        private string tipo, subtipo;
        private bool ajustesActivate;

        public Documentos(string tipo, string subtipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.subtipo = subtipo;
        }

        private void Documentos_Load(object sender, EventArgs e){
            switch (tipo) {
                case "Solicitud": {
                        RadioButton_Ordenes.Visible = RadioButton_Documentos.Visible = false;
                        RadioButton_Ordenes.Checked = RadioButton_Documentos.Checked = RadioButton_Ajustes.Checked = false;
                        RadioButton_Ajustes.Visible = false; // temporal
                        RadioButton_Solicitudes.Checked = true;
                        Solicitud_Solicitudes.Tipo = subtipo;
                    } break;
                default: break;
            }

        }


        //----------------------------------------------------------------------------------------------------------

       
    }
}

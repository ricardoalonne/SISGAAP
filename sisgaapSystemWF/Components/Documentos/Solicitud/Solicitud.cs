using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wmCoreWF;

namespace sisgaapSystemWF.Components.Documentos.Solicitud
{
    public partial class Solicitud : UserControl
    {
        public Solicitud()
        {
            InitializeComponent();
        }

        string tipo = "";

        public string Tipo{
            set {
                tipo = value;
                switch (tipo) {
                    case "Abastecimiento": {
                            RadioButton_Principal.Visible = RadioButton_Merma.Visible = RadioButton_Produccion.Visible = false;
                            RadioButton_Principal.Checked = RadioButton_Merma.Checked = RadioButton_Produccion.Checked = false;
                            RadioButton_Abastecimiento.Checked = true;
                            Button_NuevaSolicitud.Text = "Solicitud Abastecimiento"; 
                            SearchBar_BarraBusqueda.MessageSearchBox = "Buscar en todas las Solicitudes de Abastecimiento";
                        } break;
                    case "Produccion": {
                            RadioButton_Principal.Visible = RadioButton_Merma.Visible = RadioButton_Abastecimiento.Visible = false;
                            Button_NuevaSolicitud.Text = "Solicitud Producción";
                            SearchBar_BarraBusqueda.MessageSearchBox = "Buscar en todas las Solicitudes de Produccion";
                            RadioButton_Principal.Checked = RadioButton_Merma.Checked = RadioButton_Abastecimiento.Checked = false;
                            RadioButton_Produccion.Checked = true;
                        } break;
                    default: break;
                }
            }
            get => tipo;
        }

        private void Solicitud_Load(object sender, EventArgs e){
            SearchBar_BarraBusqueda.DataGridView(DataGridView_VistaPrincipal);
            SearchBar_BarraBusqueda.LoadItemsFilter(new string [] { "Asunto","Redactor","Emisión","Entrega", "Estado" });
        }

        private void Button_RefrescarTabla_Click(object sender, EventArgs e){
            DataGridView_VistaPrincipal.Refresh();
        }

        private void Button_ExportarExcelDB_Click(object sender, EventArgs e){

        }

        private void Button_CargarExcelBD_Click(object sender, EventArgs e){
            MSExceltoSQLServer file = new MSExceltoSQLServer();
            file.ViewData("SOLICITUD");
        }
    }
}

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
using sisgaapCoreWF.Controllers;
using sisgaapCore.Entities;
using sisgaapCore;
using sisgaapSystemWF.Views.Documentos;

namespace sisgaapSystemWF.Components.Documentos.Solicitud
{
    public partial class Solicitud : UserControl
    {
        public Solicitud()
        {
            InitializeComponent();
        }

        SolicitudAbastecimientoCtr SActr = new SolicitudAbastecimientoCtr();
        DetalleSolicitudAbastecimiento DetalleSA = new DetalleSolicitudAbastecimiento();
        DetalleSolicitudAbastecimientoCtr DetalleSA_Ctr = new DetalleSolicitudAbastecimientoCtr();
        SolicitudAbastecimiento SA = new SolicitudAbastecimiento();
        string tipo = "";

        public string Tipo{
            set {
                tipo = value;
                searchInSolicitud_BarraBusqueda.SearchIn = tipo;
                switch (tipo) {
                    case "Abastecimiento": {
                            RadioButton_Principal.Visible = RadioButton_Merma.Visible = RadioButton_Produccion.Visible = false;
                            RadioButton_Principal.Checked = RadioButton_Merma.Checked = RadioButton_Produccion.Checked = false;
                            RadioButton_Abastecimiento.Checked = true;
                            Button_NuevaSolicitud.Text = "Solicitud Abastecimiento";
                            searchInSolicitud_BarraBusqueda.MessageSearchBox = "Buscar en todas las Solicitudes de Abastecimiento";
                            CargarListaSolicitudAbastecimiento();
                        } break;
                    case "Produccion": {
                            RadioButton_Principal.Visible = RadioButton_Merma.Visible = RadioButton_Abastecimiento.Visible = false;
                            Button_NuevaSolicitud.Text = "Solicitud Producción";
                            searchInSolicitud_BarraBusqueda.MessageSearchBox = "Buscar en todas las Solicitudes de Produccion";
                            RadioButton_Principal.Checked = RadioButton_Merma.Checked = RadioButton_Abastecimiento.Checked = false;
                            RadioButton_Produccion.Checked = true;
                        } break;
                    default: break;
                }
            }
            get => tipo;
        }

        private void Solicitud_Load(object sender, EventArgs e){
            searchInSolicitud_BarraBusqueda.DataGridView(DataGridView_VistaPrincipal);
            searchInSolicitud_BarraBusqueda.LoadItemsFilter(new string [] { "Asunto","Redactor","Emision","Entrega", "Estado" });
        }

        private void Button_RefrescarTabla_Click(object sender, EventArgs e){
            CargarListaSolicitudAbastecimiento();
            DataGridView_VistaPrincipal.Refresh();
        }

        private void Button_ExportarExcelDB_Click(object sender, EventArgs e){

        }

        private void Button_CargarExcelBD_Click(object sender, EventArgs e){
            MSExceltoSQLServer file = new MSExceltoSQLServer();
            file.ViewData("SOLICITUD");
        }

        private void Button_VerSolicitud_Click(object sender, EventArgs e) {
            DataGridView_VistaPrincipal.Select();
            if (DataGridView_VistaPrincipal.SelectedRows.Count > 0){
                string codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();
                string asunto = DataGridView_VistaPrincipal.CurrentRow.Cells["Asunto"].Value.ToString();
                string redactor = DataGridView_VistaPrincipal.CurrentRow.Cells["Redactor"].Value.ToString();
                string fechaEmision = DateTime.Parse(DataGridView_VistaPrincipal.CurrentRow.Cells["Emision"].Value.ToString()).ToShortDateString();
                string fechaEntrega = DateTime.Parse(DataGridView_VistaPrincipal.CurrentRow.Cells["Entrega"].Value.ToString()).ToShortDateString();
                DetalleSA.codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();
                int count = DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows.Count;
                string detalle = string.Format("{0,-15} {1,-30} {2,-10} {3,-10} {4,4}", "Codigo", "Nombre", "Marca", "Modelo", "Cantidad") + "\r\n";
                for (int i = 0; i < count; i++){
                    detalle += "\r\n" + string.Format("{0,-15} {1,-30} {2,-10} {3,-10} {4,4}", DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows[i][0].ToString(), DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows[i][1].ToString(), DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows[i][2].ToString(),
                        DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows[i][3].ToString(), DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows[i][4].ToString());
                }

                VisualizarDocumento visualizarDocumento = new VisualizarDocumento();
                visualizarDocumento.DocumentFont = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                visualizarDocumento.DocumentName = asunto;
                visualizarDocumento.Landscape = true;
                visualizarDocumento.Documento = "Codigo de Solicitud:" + codigoSolicitud + "\r\n" +
                                     "Asunto de la Solicitud: " + asunto + "\r\n" +
                                     "Redactor: " + redactor + "\r\n\n" +
                                     "Fecha Emisión: " + fechaEmision + "     " + "Fecha Entrega: " + fechaEntrega + "\r\n" + "\r\n" +
                                     detalle
                                     ;
                visualizarDocumento.Show();
            }
        }

        private void Button_EliminarSolicitud_Click(object sender, EventArgs e){
            /*DetalleSA.codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();
            SA.codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();
            DetalleSA_Ctr.EliminarAllDetalleSA(DetalleSA);
            SActr.EliminarSA(SA);
            CargarListaSolicitudAbastecimiento();*/
        }

        //----------------------------------------------------------------------------------------------------------------
        private void CargarListaSolicitudAbastecimiento(){
            DataGridView_VistaPrincipal.DataSource = SActr.ListarSolicitudesAbastecimiento();
            DataGridView_VistaPrincipal.Columns[0].Visible = false;
            DataGridView_VistaPrincipal.Refresh();
        }
        /*
private void CargarListaDetalleSolicitudAbastecimiento(){
   DetalleSA.codigoSolicitud = SA.codigoSolicitud;
   dataGridView_detalleSA.DataSource = DetalleSA_Ctr.Detalle_SA_datatable(DetalleSA);
}*/

    }
}

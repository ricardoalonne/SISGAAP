using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sisgaapCoreWF.Controllers;
using System.Data.SqlClient;
using sisgaapCore.Entities;
using sisgaapCore;
using System.Runtime.InteropServices;


namespace sisgaapTestWF
{
    public partial class SupervisorAlmacen : Form
    {
        SqlDataReader dr;
        public SupervisorAlmacen()
        {
            InitializeComponent();
        }

        #region Trayendo Datos de Clases
        SolicitudAbastecimientoCtr SActr = new SolicitudAbastecimientoCtr();
        DetalleSolicitudAbastecimiento DetalleSA = new DetalleSolicitudAbastecimiento();
        DetalleSolicitudAbastecimientoCtr DetalleSA_Ctr = new DetalleSolicitudAbastecimientoCtr();
        SolicitudAbastecimiento SA = new SolicitudAbastecimiento();
        RepuestoCtr repuesto_ctr = new RepuestoCtr();
        Repuesto repuesto = new Repuesto();
        SqlCommand cmd;
        #endregion

        #region Movimiento del Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel_comando_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region pantalla principal de Solicitud Abastecimiento

        //BOTÓN PARA PODER ABRIR E INTERACTUAR CON TODA LA SOLICITUD ABASTECIMIENTO
        private void button_actualizarSA_Click(object sender, EventArgs e)
        {

            if (panel_SupervisorA.Visible == true) { panel_SupervisorA.Visible = false; panel_vista.Visible = false; panel_registro.Visible = false; }
            else
            {
                panel_SupervisorA.Visible = true; CargarListaSolicitudAbastecimiento(); panel_vista.Visible = false;
                ComboBox_Filtro.Items.Add("Asunto");
                ComboBox_Filtro.Items.Add("Redactor");
                ComboBox_Filtro.Items.Add("Emision");
                ComboBox_Filtro.Items.Add("Entrega");
                ComboBox_Filtro.Items.Add("Estado");
                panel_registro.Visible = false;
                panel_Solicitud.Visible = true;
                panel_Detalle_Solicitud.Visible = false;
            }
        }
        private void Button_Buscar_Click(object sender, EventArgs e)
        {
            cargarBusqueda();
        }
        //ELIMINAR TODA LA SOLICITUD Y DETALLES DE ABASTECIMIENTO
        private void button_eliminar_solicitud_Click(object sender, EventArgs e)
        {
            DetalleSA.codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();
            SA.codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();
            DetalleSA_Ctr.EliminarAllDetalleSA(DetalleSA);
            SActr.EliminarSA(SA);
            CargarListaSolicitudAbastecimiento();
        }
        //BOTÓN PARA GUARDAR LA MODIFICACIÓN QUE SE HAGA EN EL DATAGRIDVIEW 
        private void button_guardar_tabla_Click(object sender, EventArgs e)
        {
            bool correcto = true;
            string letra = "";
            for (int i = 0; i < DataGridView_VistaPrincipal.CurrentRow.Cells["Asunto"].Value.ToString().Length; i++)
            {
                correcto = char.IsLetter(textBox_cantidad_detalle_sa.Text.Trim()[i]);
                if (!correcto)
                {
                    letra += DataGridView_VistaPrincipal.CurrentRow.Cells["Asunto"].Value.ToString().Trim()[i].ToString();
                }
            }
            if (letra.Length > 0)
            {
                MessageBox.Show("ERROR!! Se ingresó números en celda de Letras");
                return;
            }

            SA.codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Codigo"].Value.ToString();
            SA.asunto = DataGridView_VistaPrincipal.CurrentRow.Cells["Asunto"].Value.ToString();
            //SA.fechaEntrega =DateTime.Parse( DataGridView_VistaPrincipal.CurrentRow.Cells["Entrega"].Value.ToString());
            SActr.GuardarSA(SA);
            msj(SA);
            CargarListaSolicitudAbastecimiento();
        }
        //VISUALIZAR LOS DATOS DE UNA SOLICITUD Y DETALLE ABASTECIMIENTO EN UN TEXTBOX
        private void button_visualizarSA_Click(object sender, EventArgs e)
        {
            panel_vista.Visible = true;
            panel_SupervisorA.Visible = false;
            if (DataGridView_VistaPrincipal.SelectedRows.Count > 0)
            {

                string fechaEmision = DateTime.Parse(DataGridView_VistaPrincipal.CurrentRow.Cells["Emision"].Value.ToString()).ToShortDateString();
                string fechaEntrega = DateTime.Parse(DataGridView_VistaPrincipal.CurrentRow.Cells["Entrega"].Value.ToString()).ToShortDateString();
                DetalleSA.codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();
                int count = DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows.Count;
                string detalle = string.Format("{0,-15} {1,-30} {2,-10} {3,-10} {4,4}", "Codigo", "Nombre", "Marca", "Modelo", "Cantidad") + "\r\n";
                for (int i = 0; i < count; i++)
                {
                    detalle += "\r\n" + string.Format("{0,-15} {1,-30} {2,-10} {3,-10} {4,4}", DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows[i][0].ToString(), DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows[i][1].ToString(), DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows[i][2].ToString(),
                        DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows[i][3].ToString(), DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows[i][4].ToString());
                }
                textBox_vista.Text = "El código de solicitud es:" + DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString() + "\r\n\n" +
                                     "De asunto es: " + DataGridView_VistaPrincipal.CurrentRow.Cells["Asunto"].Value.ToString() + "\r\n\n\n\n" +
                                     "Redactor: " + DataGridView_VistaPrincipal.CurrentRow.Cells["Redactor"].Value.ToString() + "\r\n\n\n\n\n\n\n" +
                                     "Fecha Emisión: " + fechaEmision + "     " + "Fecha Entrega: " + fechaEntrega + "\r\n" + "\r\n" +
                                     detalle
                                     ;
            }
        }
        //BOTÓN PARA PODER MODIFICAR LA SOLICITUD DE ABASTECIMIENTO
        private void button_modificar_solicitud_Click(object sender, EventArgs e)
        {
            //button_CancelarTodo.Visible = false;
            panel_SupervisorA.Visible = false;
            panel_registro.Visible = true;
            button_actualizar.Visible = true;
            button_CancelarTodo.Visible = false;
            SA.codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();
            SActr.CargarSA(SA);
            textBox_redactor.Text = SA.redactor;
            textBox_descripcion.Text = SA.descripcion;
            textBox_asunto.Text = SA.asunto;
            textBox_observacion.Text = SA.observacion;
            dateTime_SA.Value = SA.fechaEntrega;
            CargarListaDetalleSolicitudAbastecimiento();
        }
        //BOTÓN PARA REGISTRAR UNA NUEVA SOLICITUD DE ABASTECIMIENTO
        private void Button_NuevaSolicitud_Click(object sender, EventArgs e)
        {
            panel_SupervisorA.Visible = false;
            panel_registro.Visible = true;
            button_Continuar.Visible = true;
            button_CancelarTodo.Visible = true;
            textBox_redactor.Text = labelnombre.Text + " " + labelapellido.Text;
        }
        #endregion

        #region Visualizar Datagridview
        private void CargarListaSolicitudAbastecimiento()
        {
            DataGridView_VistaPrincipal.DataSource = SActr.ListarSolicitudesAbastecimiento();
            DataGridView_VistaPrincipal.Columns[0].Visible = false;
            DataGridView_VistaPrincipal.Columns[3].ReadOnly = true;
            DataGridView_VistaPrincipal.Columns[4].ReadOnly = true;
            DataGridView_VistaPrincipal.Columns[5].ReadOnly = true;
        }

        private void CargarListaDetalleSolicitudAbastecimiento()
        {
            DetalleSA.codigoSolicitud = SA.codigoSolicitud;
            dataGridView_detalleSA.DataSource = DetalleSA_Ctr.Detalle_SA_datatable(DetalleSA);
            dataGridView_detalleSA.Columns[0].Visible = false;
            dataGridView_detalleSA.Columns[0].ReadOnly = true;
            dataGridView_detalleSA.Columns[1].ReadOnly = true;
            dataGridView_detalleSA.Columns[2].ReadOnly = true;
            dataGridView_detalleSA.Columns[3].ReadOnly = true;
            dataGridView_detalleSA.Columns[4].ReadOnly = true;
        }
        private void CargarListaDeRepuesto()
        {
            dataGridView_repuestos.DataSource = repuesto_ctr.ListarTodosRepuestos();
          //  dataGridView_detalleSA.Columns[0].Visible = false;
            dataGridView_detalleSA.Columns[0].ReadOnly = true;
            dataGridView_detalleSA.Columns[1].ReadOnly = true;
            dataGridView_detalleSA.Columns[2].ReadOnly = true;
            dataGridView_detalleSA.Columns[3].ReadOnly = true;
            dataGridView_detalleSA.Columns[4].ReadOnly = true;
        }
        #endregion

        #region Botones comunes
        private void cargarBusqueda()
        {
            var listaConsultas = SActr.ConsultaSolicitudAbastecimiento(ComboBox_Filtro.Text, TextBox_Búsqueda.Text);
            DataGridView_VistaPrincipal.DataSource = listaConsultas;
        }
        private void button_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void cargarBusquedaRepuesto()
        {
            var listaConsultas = repuesto_ctr.ConsultaRepuesto(comboBox_busqueda_repuesto.Text, textBox_codigo_Repuesto.Text);
            DataGridView_VistaPrincipal.DataSource = listaConsultas;
        }
        #endregion

        #region Mensajes
        public void msj(SolicitudAbastecimiento p)
        {
            switch (p.error)
            {
                case 1:
                    MessageBox.Show("ERROR! fecha Invalida!!");
                    break;
                case 2:
                    MessageBox.Show("ERROR! Descripción supero los 50 caracteres!!");
                    break;
                case 3:
                    MessageBox.Show("ERROR! Asunto supero los 50 caracteres!!");
                    break;
                case 4:
                    MessageBox.Show("EERROR! observación supero los 50 caracteres!!");
                    break;
                case 5:
                    MessageBox.Show("EERROR! Redactor tiene números!!");
                    break;
                case 77:
                    MessageBox.Show("REGISTRO EXITOSO!!");
                    textBox_asunto.Clear();
                    textBox_redactor.Clear();
                    textBox_descripcion.Clear();
                    panel_Solicitud.Visible = false;
                    panel_Detalle_Solicitud.Visible = true;
                    button_Registrar.Visible = true;
                    button_Continuar.Visible = false;
                    break;
                case 88:
                    MessageBox.Show("ACTUALIZACIÓN EXITOSO!!");
                    textBox_asunto.Clear();
                    textBox_redactor.Clear();
                    textBox_descripcion.Clear();
                    panel_Solicitud.Visible = false;
                    panel_Detalle_Solicitud.Visible = true;
                    button_actualizar_todo.Visible = true;
                    button_actualizar.Visible = false;
                    break;
                case 99:
                    MessageBox.Show("ACTUALIZACIÓN EXITOSO!!");
                    break;
            }
        }

        public void msj1(DetalleSolicitudAbastecimiento p)
        {
            switch (p.error)
            {
                case 1:
                    MessageBox.Show("ERROR! cantidad invalidad!!");
                    break;
                case 2:
                    MessageBox.Show("ERROR! Producto existente en el detalle!!");
                    break;
                case 77:
                    MessageBox.Show("REGISTRO EXITOSO!!");
                    textBox_codigo_Repuesto.Clear();
                    textBox_cantidad_detalle_sa.Clear();
                    break;
                case 88:
                    MessageBox.Show("Actualización EXITOSA!!");
                    textBox_codigo_Repuesto.Clear();
                    textBox_cantidad_detalle_sa.Clear();
                    break;
            }
        }
        #endregion

        #region boton de cerrar vista de datos
        private void button_cerrarVista_Click(object sender, EventArgs e)
        {
            panel_vista.Visible = false;
            panel_SupervisorA.Visible = true;
        }
        #endregion

        #region Botones para el registro y modificación de las solicitudes de abastecimiento

        //BOTÓN DE CERRAR LA PRIMERA VISTA DE CUANDO CREAS O ACTUALIZAS SOLICITUD DE ABASTECIMIENTO
        private void button_cancelar_Click(object sender, EventArgs e)
        {
            panel_registro.Visible = false;
            panel_SupervisorA.Visible = true;
            textBox_redactor.Clear();
            textBox_observacion.Clear();
            textBox_descripcion.Clear();
            
        }
        //BOTÓN QUE VA DE LA PRIMERA VISTA DE ACTUALIZAR A LA SEGUNDA ACTUALIZANDO LOS DATOS DE LA SOLICITUD ABASTEICMIENTO
        private void button_actualizar_Click(object sender, EventArgs e)
        {
            if (textBox_redactor.Text == "" || textBox_asunto.Text == "")
            {
                MessageBox.Show("ERROR!! ESPACIOS EN BLANCO!!");
                return;
            }
            SA.asunto = textBox_asunto.Text;
            SA.redactor = textBox_redactor.Text;
            SA.descripcion = textBox_descripcion.Text;
            SA.observacion = textBox_observacion.Text;
            SA.fechaEntrega = dateTime_SA.Value.Date;
            SActr.ActualizarSA(SA);
            msj(SA);
            CargarListaDetalleSolicitudAbastecimiento();
            CargarListaDeRepuesto();
        }
        //BOTÓN QUE VA DE LA PRIMERA VISTA DE REGISTRAR A LA SEGUNDA REGISTRANDO LOS DATOS DE LA SOLICITUD ABASTEICMIENTO
        private void button_Continuar_Click(object sender, EventArgs e)
        {
            if (textBox_redactor.Text == "" || textBox_asunto.Text == "")
            {
                MessageBox.Show("ERROR!! ESPACIOS EN BLANCO!!");
                return;
            }
            SA.asunto = textBox_asunto.Text;
            SA.redactor = textBox_redactor.Text;
            SA.descripcion = textBox_descripcion.Text;
            SA.observacion = textBox_observacion.Text;
            SA.fechaEntrega =dateTime_SA.Value;
            SActr.RegistrarSA(SA);
            msj(SA);
            SA.codigoSolicitud = SActr.TraerUltimoCodigoSA();
            CargarListaDetalleSolicitudAbastecimiento();
            CargarListaDeRepuesto();
        }

        //EN LA SEGUNDA VISTA DE REGISTRO O ACTUALIZACIÓN PARA AGREGAR DETALLES A LA SOLICITUD DE ABASTECIMIENTO
        private void button_agregar_detalleSA_Click(object sender, EventArgs e)
        {
            Repuesto objRepuesto = new Repuesto();
            RepuestoCtr objRepuestoCtr = new RepuestoCtr();
            bool correcto = true;
            /*if (textBox_cantidad_detalle_sa.Text == "" || textBox_codigo_Repuesto.Text == "")
            {
                MessageBox.Show("ERROR!! ESPACIOS EN BLANCO!!");
                return;
            }*/
            if (textBox_cantidad_detalle_sa.Text == "")
            {
                MessageBox.Show("ERROR!! ESPACIOS EN BLANCO!!");
                return;
            }
            objRepuesto.codigoRepuesto = dataGridView_repuestos.CurrentRow.Cells["Codigo"].Value.ToString();
            if (!objRepuestoCtr.ExistenciaRepuesto(objRepuesto))
            {
                MessageBox.Show("ERROR!! REPUESTO INEXISTENTE!!");
                return;
            }
            string letra = "";
            for (int i = 0; i < textBox_cantidad_detalle_sa.Text.Length; i++)
            {
                correcto = char.IsNumber(textBox_cantidad_detalle_sa.Text.Trim()[i]);
                if (!correcto)
                {
                    letra += textBox_cantidad_detalle_sa.Text.Trim()[i].ToString();
                }
            }
            if (letra.Length > 0)
            {
                MessageBox.Show("ERROR!! Se ingresó letras en la cantidad solicitada");
                return;
            }
            DetalleSA.codigoSolicitud = SA.codigoSolicitud;
            DetalleSA.codigoRepuesto = dataGridView_repuestos.CurrentRow.Cells["Codigo"].Value.ToString();
            DetalleSA.cantidadSolicitada = Int32.Parse(textBox_cantidad_detalle_sa.Text);
            DetalleSA_Ctr.RegistrarDetalleSA(DetalleSA);
            msj1(DetalleSA);
            CargarListaDetalleSolicitudAbastecimiento();
        }
        //´BOTÓN CUANDO SE MODIFICA ALGO EN EL DATAGRIDVIEW DE LOS DETALLES DE LA SOLICITUD ABASTECIMIENTO
        //ESTE PODRÁ MODIFICARLO
        private void button_GuardardetalleSA_Click(object sender, EventArgs e)
        {
            bool correcto = true;
            string letra = "";
            for (int i = 0; i < textBox_cantidad_detalle_sa.Text.Length; i++)
            {
                correcto = char.IsNumber(textBox_cantidad_detalle_sa.Text.Trim()[i]);
                if (!correcto)
                {
                    letra += textBox_cantidad_detalle_sa.Text.Trim()[i].ToString();
                }
            }
            if (letra.Length > 0)
            {
                MessageBox.Show("ERROR!! Se ingresó letras en la cantidad solicitada");
                return;
            }
            string letra2 = "";
            for (int i = 0; i < dataGridView_detalleSA.CurrentRow.Cells["Cantidad"].Value.ToString().Length; i++)
            {
                correcto = char.IsNumber(dataGridView_detalleSA.CurrentRow.Cells["Cantidad"].Value.ToString().Trim()[i]);
                if (!correcto)
                {
                    letra2 += dataGridView_detalleSA.CurrentRow.Cells["Cantidad"].Value.ToString().Trim()[i].ToString();
                }
            }
            if (letra2.Length > 0)
            {
                MessageBox.Show("ERROR!! Caracteres ingresados inválidos");
                return;
            }
            DetalleSA.codigoSolicitud = SA.codigoSolicitud;
            DetalleSA.codigoRepuesto = dataGridView_detalleSA.CurrentRow.Cells["Codigo"].Value.ToString();
            DetalleSA.cantidadSolicitada = Int32.Parse(dataGridView_detalleSA.CurrentRow.Cells["Cantidad"].Value.ToString());
            DetalleSA_Ctr.ActualizarDetalleSA(DetalleSA);
            msj1(DetalleSA);
            CargarListaDetalleSolicitudAbastecimiento();
        }
        //ELIMINAR EL DETALLE DE LA SOLICITUD ABASTECIMIENTO QUE ESTÉ AGREGADA
        private void button_EliminardetalleSA_Click(object sender, EventArgs e)
        {
            DetalleSA.codigoSolicitud = SA.codigoSolicitud;
            DetalleSA.codigoRepuesto = dataGridView_detalleSA.CurrentRow.Cells["Codigo"].Value.ToString();
            DetalleSA_Ctr.EliminarDetallesSA(DetalleSA);
            CargarListaDetalleSolicitudAbastecimiento();
        }
        //ELIMINAR TODA LA SOLICITUD ABASTECIMIENTO Y CON SUS DETALLES AGREGADOS
        private void button_CancelarTodo_Click(object sender, EventArgs e)
        {
            DetalleSA.codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();
            DetalleSA_Ctr.EliminarAllDetalleSA(DetalleSA);
            SActr.EliminarSA(SA);
            panel_Solicitud.Visible = true;
            panel_Detalle_Solicitud.Visible = false;
            panel_registro.Visible = false;
        }
        //FINALIZAR ACTUALIZACIÓN DE LA SOLICITUD Y DETALLE DE ABASTECIMIENTO
        private void button_actualizar_todo_Click(object sender, EventArgs e)
        {
            panel_registro.Visible = false;
            panel_SupervisorA.Visible = true;
        }
        //FINALIZAR REGISTRO DE LA SOLICITUD Y DETALLE DE ABASTECIMIENTO
        private void button_Registrar_Click(object sender, EventArgs e)
        {
            panel_registro.Visible = false;
            panel_SupervisorA.Visible = true;
            CargarListaSolicitudAbastecimiento();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            cargarBusquedaRepuesto();
        }
    }
}

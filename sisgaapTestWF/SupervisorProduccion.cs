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


namespace sisgaapTestWF
{
    public partial class SupervisorProduccion : Form
    {
        public SupervisorProduccion()
        {
            InitializeComponent();
            panel_Menu.BackColor = Color.FromArgb(125, Color.Black);
        }
        SqlDataReader dr;
        SolicitudAbastecimientoCtr SActr = new SolicitudAbastecimientoCtr();
        DetalleSolicitudAbastecimiento DetalleSA = new DetalleSolicitudAbastecimiento();
        DetalleSolicitudAbastecimientoCtr DetalleSA_Ctr = new DetalleSolicitudAbastecimientoCtr();
        SolicitudAbastecimiento SA = new SolicitudAbastecimiento();
        SolicitudProduccionCtr SPctr = new SolicitudProduccionCtr();
        DetalleSolicitudProduccion DetalleSP = new DetalleSolicitudProduccion();
        DetalleSolicitudProduccionCtr DetalleSP_Ctr = new DetalleSolicitudProduccionCtr();
        SolicitudProducción SP = new SolicitudProducción();
        SqlCommand cmd;
        private void button_actualizarSA_Click(object sender, EventArgs e)
        {

            if (panel_SupervisorA.Visible == true) { panel_SupervisorA.Visible = false; panel_vista.Visible = false; panel_registro.Visible = false;panel_agregar_detalle.Visible = false; }
            else
            {
                panel_SupervisorA.Visible = true; CargarListaSolicitudProduccion(); //panel_vista.Visible = false;
                ComboBox_Filtro.Items.Add("Asunto");
                ComboBox_Filtro.Items.Add("Redactor");
                ComboBox_Filtro.Items.Add("Emision");
                ComboBox_Filtro.Items.Add("Entrega");
                ComboBox_Filtro.Items.Add("Estado");
                //panel_registro.Visible = false;
               // panel_Solicitud.Visible = true;
                //panel_Detalle_Solicitud.Visible = false;
            }
        }
        private void CargarListaSolicitudProduccion()
        {
            DataGridView_VistaPrincipal.DataSource = SPctr.ListarSolicitudesProduccion();//SActr.ListarSolicitudesAbastecimiento();
            DataGridView_VistaPrincipal.Columns[0].Visible = false;
            DataGridView_VistaPrincipal.Columns[3].Visible = false;
        }

        private void Button_Buscar_Click(object sender, EventArgs e)
        {
            cargarBusqueda();
        }

        private void cargarBusqueda()
        {
            var listaConsultas = SPctr.ConsultaSolicitudProduccion(ComboBox_Filtro.Text, TextBox_Búsqueda.Text); //SActr.ConsultaSolicitudAbastecimiento(ComboBox_Filtro.Text, TextBox_Búsqueda.Text);
            DataGridView_VistaPrincipal.DataSource = listaConsultas;
        }

        private void ComboBox_Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_visualizarSA_Click(object sender, EventArgs e)
        {
            panel_vista.Visible = true;
            panel_SupervisorA.Visible = false;
            if (DataGridView_VistaPrincipal.SelectedRows.Count > 0)
            {
                string fechaE = DataGridView_VistaPrincipal.CurrentRow.Cells["Emision"].Value.ToString();
                string[] separador = fechaE.Split(' ');
                string fechaEt = DataGridView_VistaPrincipal.CurrentRow.Cells["Entrega"].Value.ToString();
                string[] separador1 = fechaEt.Split(' ');
                DetalleSP.codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();//DetalleSA.codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();
                //Repuesto,Nombre,Marca,Modelo,[Cantidad Solicitada],[Cantidad Sugerida],Costo
                int count = DetalleSP_Ctr.Detalles_SP_dataset(DetalleSP).Tables[0].Rows.Count;
                string detalle = string.Format("{0,-15} {1,-30} {2,-10} {3,-10} {4,20} {5,15} {6,13}", "Codigo", "Nombre", "Marca", "Modelo", "Solicitada","Sugerida","Costo") + "\r\n";
                for (int i = 0; i < count; i++)
                {
                    //detalle += "\r\n"+DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows[i][0].ToString() + "\t" + " | "+ DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows[i][1].ToString() +"\t"+" | "+ DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows[i][2].ToString();
                    detalle += "\r\n" + string.Format("{0,-15} {1,-30} {2,-10} {3,-10} {4,20} {5,15} {6,13}", DetalleSP_Ctr.Detalles_SP_dataset(DetalleSP).Tables[0].Rows[i][0].ToString(), DetalleSP_Ctr.Detalles_SP_dataset(DetalleSP).Tables[0].Rows[i][1].ToString(), DetalleSP_Ctr.Detalles_SP_dataset(DetalleSP).Tables[0].Rows[i][2].ToString(),
                        DetalleSP_Ctr.Detalles_SP_dataset(DetalleSP).Tables[0].Rows[i][3].ToString(), DetalleSP_Ctr.Detalles_SP_dataset(DetalleSP).Tables[0].Rows[i][4].ToString(), DetalleSP_Ctr.Detalles_SP_dataset(DetalleSP).Tables[0].Rows[i][5].ToString(), DetalleSP_Ctr.Detalles_SP_dataset(DetalleSP).Tables[0].Rows[i][6].ToString());
                }
                //string detalle = DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA).Tables[0].Rows[0];
                textBox_vista.Text = "El código de solicitud es:" + DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString() + "\r\n\n" +
                                     "De asunto es: " + DataGridView_VistaPrincipal.CurrentRow.Cells["Asunto"].Value.ToString() + "\r\n\n\n\n" +
                                     "Redactor: " + DataGridView_VistaPrincipal.CurrentRow.Cells["Redactor"].Value.ToString() + "\r\n\n\n\n\n\n\n" +
                                     "Fecha Emisión: " + separador[0] + "     " + "Fecha Entrega: " + separador1[0] + "\r\n" + "\r\n" +
                                     detalle
                                     ;
            }
        }

        private void button_cerrarVista_Click(object sender, EventArgs e)
        {
            panel_vista.Visible = false;
            panel_SupervisorA.Visible = true;
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            panel_registro.Visible = false;
        }

        private void button_Continuar_Click(object sender, EventArgs e)
        {
            SolicitudAbastecimientoCtr SActr = new SolicitudAbastecimientoCtr();
            
            if (textBox_redactor.Text == "" || textBox_asunto.Text == "")
            {
                MessageBox.Show("ERROR!! ESPACIOS EN BLANCO!!");
                return;
            }
            SA.codigoSolicitud = textBox_solicitud_abastecimiento.Text;
            if (!SActr.ExistenciaSolicitud(SA))
            {
                MessageBox.Show("ERROR!! SOLICITUD INEXISTENTE!!");
                return;
            }
            else if (SActr.ExisteSP_con_SA(SA))
            {
                MessageBox.Show("ERROR!! YA SE ELABORO UNA SOLICITUD DE PRODUCCIÓN CON EL CODIGO DE SOLICITUD ["+SA.codigoSolicitud+"]!!");
                return;
            }
            SP.asunto = textBox_asunto.Text;
            SP.redactor = textBox_redactor.Text;
            SP.descripcion = textBox_descripcion.Text;
            SP.observacion = textBox_observacion.Text;
            SP.fechaEntrega = dateTime_SA.Value;
            SPctr.RegistrarSP(SP);
            msj(SP);
            SP.codigoSolicitud = SPctr.TraerUltimoCodigoSP();
            CargarListaDetalleSolicitudAbastecimiento();
        }
        public void msj(SolicitudProducción p)
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
                    //button_Registrar.Visible = true;
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
            }
        }
        private void panel_registro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_CancelarTodo_Click(object sender, EventArgs e)
        {
           // DetalleSA.codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();
            DetalleSP.codigoSolicitud = SP.codigoSolicitud;
            DetalleSP_Ctr.EliminarAllDetalleSP(DetalleSP);
            SPctr.EliminarSP(SP);
            panel_Solicitud.Visible = true;
            panel_Detalle_Solicitud.Visible = false;
            panel_registro.Visible = false;
        }

        private void Button_NuevaSolicitud_Click(object sender, EventArgs e)
        {
            panel_SupervisorA.Visible = false;
            panel_registro.Visible = true;
            button_Continuar.Visible = true;
            button_CancelarTodo.Visible = true;
        }

        private void button_agregar_detalleSA_Click(object sender, EventArgs e)
        {
            //Repuesto objRepuesto = new Repuesto();
            /*RepuestoCtr objRepuestoCtr = new RepuestoCtr();
            bool correcto = true;
            if (textBox_cantidad_detalle_sa.Text == "" || textBox_codigo_Repuesto.Text == "")
            {
                MessageBox.Show("ERROR!! ESPACIOS EN BLANCO!!");
                return;
            }
            objRepuesto.codigoRepuesto = textBox_codigo_Repuesto.Text;
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
            */
            DetalleSA.codigoSolicitud = SA.codigoSolicitud;
            textBox_codigo_repuesto.Text = dataGridView_detalleSA.CurrentRow.Cells["Codigo"].Value.ToString();
            textBox_marca_repuesto.Text = dataGridView_detalleSA.CurrentRow.Cells["Marca"].Value.ToString();
            textBox_modelo_repuesto.Text = dataGridView_detalleSA.CurrentRow.Cells["Modelo"].Value.ToString();
            textBox_cantidad_detalle_sa.Text= dataGridView_detalleSA.CurrentRow.Cells["Cantidad"].Value.ToString();
            //DetalleSA.codigoRepuesto = textBox_codigo_Repuesto.Text;
            //DetalleSA.cantidadSolicitada = Int32.Parse(textBox_cantidad_detalle_sa.Text);
           // DetalleSA_Ctr.RegistrarDetalleSA(DetalleSA);
            //msj1(DetalleSP);
            panel_agregar_detalle.Visible = true;
            //CargarListaDetalleSolicitudAbastecimiento();
        }
        public void msj1(DetalleSolicitudProduccion p)
        {
            switch (p.error)
            {
                case 1:
                    MessageBox.Show("ERROR! cantidad invalidad!!");
                    break;
                case 2:
                    MessageBox.Show("ERROR! costo invalido!!");
                    break;
                case 3:
                    MessageBox.Show("ERROR! codigo de repuesto invalido!!");
                    break;
                case 77:
                    MessageBox.Show("REGISTRO EXITOSO!!");
                 //   textBox_codigo_Repuesto.Clear();
                    textBox_cantidad_detalle_sa.Clear();
                    break;
                case 88:
                    MessageBox.Show("Actualización EXITOSA!!");
                   // textBox_codigo_Repuesto.Clear();
                    textBox_cantidad_detalle_sa.Clear();
                    break;
            }
        }
        private void CargarListaDetalleSolicitudAbastecimiento()
        {
            DetalleSA.codigoSolicitud = SA.codigoSolicitud;
            dataGridView_detalleSA.DataSource = DetalleSA_Ctr.Detalle_SA_datatable(DetalleSA);
            dataGridView_detalleSA.Columns[0].Visible = false;
        }
        private void CargarListaDetalleSolicitudProduccion()
        {
            DetalleSP.codigoSolicitud = SP.codigoSolicitud;
            dataGridView_produccion.DataSource = DetalleSP_Ctr.Detalle_SP_datatable(DetalleSP);
            dataGridView_produccion.Columns[0].Visible = false;
        }
        private void cargarDetalles()
        {
            DetalleSA.codigoSolicitud = SA.codigoSolicitud;
            var listaDetalleSA = DetalleSA_Ctr.Detalles_SA_dataset(DetalleSA);
            DataGridView_VistaPrincipal.DataSource = listaDetalleSA;
            // viewDetalle.Columns[viewDetalle.Columns.Count - 1].Visible = false;
            // viewDetalle.Columns[0].Visible = false;
        }

        private void button_GuardardetalleSA_Click(object sender, EventArgs e)
        {
            bool correcto = true;
            //if (textBox_cantidad_detalle_sa.Text == "" || textBox_codigo_Repuesto.Text == "")
            //{
            //    MessageBox.Show("ERROR!! ESPACIOS EN BLANCO!!");
            //    return;
            //}
            string letra = ""; string letra2 = "";
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
                MessageBox.Show("ERROR!! Se ingresó letras o simbolos en la cantidad solicitada");
                return;
            }
            DetalleSP.codigoSolicitud = SP.codigoSolicitud;
            DetalleSP.codigoRepuesto = dataGridView_detalleSA.CurrentRow.Cells["Codigo"].Value.ToString();
            for (int i = 0; i < dataGridView_detalleSA.CurrentRow.Cells["Cantidad"].Value.ToString().Length; i++)
            {
                correcto = char.IsNumber(dataGridView_detalleSA.CurrentRow.Cells["Cantidad"].Value.ToString().Trim()[i]);
                if (!correcto)
                {
                    letra2 += textBox_cantidad_detalle_sa.Text.Trim()[i].ToString();
                }
            }
            if (letra2.Length > 0)
            {
                MessageBox.Show("ERROR!! Se ingresó letras o simbolos en la cantidad solicitada");
                return;
            }
            DetalleSP.cantidadSugerida = Int32.Parse(dataGridView_detalleSA.CurrentRow.Cells["Cantidad"].Value.ToString());
            DetalleSP_Ctr.ActualizarDetalleSP(DetalleSP);
            msj1(DetalleSP);
            CargarListaDetalleSolicitudAbastecimiento();
        }

        private void button_EliminardetalleSA_Click(object sender, EventArgs e)
        {
            DetalleSA.codigoSolicitud = SA.codigoSolicitud;
            DetalleSA_Ctr.EliminarAllDetalleSA(DetalleSA);
            CargarListaDetalleSolicitudAbastecimiento();
        }

        private void button_Registrar_Click(object sender, EventArgs e)
        {
            panel_registro.Visible = false;
            panel_SupervisorA.Visible = true;
        }

        private void button_modificar_solicitud_Click(object sender, EventArgs e)
        {
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

        }

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
            //msj(SA);
            CargarListaDetalleSolicitudAbastecimiento();
        }

        private void button_actualizar_todo_Click(object sender, EventArgs e)
        {
            panel_registro.Visible = false;
            panel_SupervisorA.Visible = true;
        }

        private void button_eliminar_solicitud_Click(object sender, EventArgs e)
        {
            DetalleSP.codigoSolicitud= DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();
            SP.codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();
            DetalleSP_Ctr.EliminarAllDetalleSP(DetalleSP);
            SPctr.EliminarSP(SP);
            CargarListaSolicitudProduccion();
            DetalleSA.codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();
            SA.codigoSolicitud = DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString();
            DetalleSA_Ctr.EliminarAllDetalleSA(DetalleSA);
            SActr.EliminarSA(SA);
            CargarListaSolicitudProduccion();
        }

        private void button_restablecer_Click(object sender, EventArgs e)
        {
            textBox_cantidad_sugerida.Text = "" + 0;
        }

        private void button_producir_todo_Click(object sender, EventArgs e)
        {
            textBox_cantidad_sugerida.Text = textBox_cantidad_detalle_sa.Text;
        }

        private void button_producir_Click(object sender, EventArgs e)
        {
            bool correcto = true;
            if (textBox_cantidad_sugerida.Text == "" || textBox_costo_producir.Text=="")
            {
                MessageBox.Show("ERROR!! ESPACIOS EN BLANCO!!");
                return;
            }
            string letra = "";
            for (int i = 0; i < textBox_cantidad_sugerida.Text.Length; i++)
            {
                correcto = char.IsNumber(textBox_cantidad_sugerida.Text.Trim()[i]);
                if (!correcto)
                {
                    letra += textBox_cantidad_sugerida.Text.Trim()[i].ToString();
                }
            }
            if (letra.Length > 0)
            {
                MessageBox.Show("ERROR!! Se ingresó letras en la cantidad sugerida");
                return;
            }
            string letra2 = "";
            for (int i = 0; i < textBox_costo_producir.Text.Length; i++)
            {
                correcto = char.IsNumber(textBox_costo_producir.Text.Trim()[i]);
                if (!correcto)
                {
                    letra2 += textBox_costo_producir.Text.Trim()[i].ToString();
                }
            }
            if (letra2.Length > 0)
            {
                MessageBox.Show("ERROR!! Se ingresó letras en costo");
                return;
            }
            DetalleSP.codigoSolicitud = SP.codigoSolicitud;
            DetalleSP.codigoRepuesto = textBox_codigo_repuesto.Text;
            DetalleSP.cantidadSugerida =Int32.Parse( textBox_cantidad_sugerida.Text);
            DetalleSP.costoUnitario = Double.Parse(textBox_costo_producir.Text);
            DetalleSP.Detalle_Solicitud_Abastecimiento_codigoSolicitud = dataGridView_detalleSA.CurrentRow.Cells["Solicitud"].Value.ToString();
            DetalleSP_Ctr.RegistrarDetalleSP(DetalleSP);
            msj1(DetalleSP);
            panel_agregar_detalle.Visible = false;
            CargarListaDetalleSolicitudAbastecimiento();
        }

        private void button_cancelar_produccion_Click(object sender, EventArgs e)
        {
            panel_agregar_detalle.Visible = false;
        }

        private void dataGridView_detalleSA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_registro.Visible = false;
            panel_SupervisorA.Visible = true;
        }

        private void button_continuar_detalle_Click(object sender, EventArgs e)
        {
            //panel_registro.Visible = false;
            panel_Detalle_Solicitud.Visible = false;
            panel_produccion.Visible = true;
            CargarListaDetalleSolicitudProduccion();
        }
    }
}

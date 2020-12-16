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
using sisgaapCore;

namespace sisgaapTestWF
{
    public partial class SupervisorAlmacen : Form
    {
        SqlDataReader dr;
        public SupervisorAlmacen()
        {
            
            InitializeComponent();
            panel_Menu.BackColor = Color.FromArgb(125, Color.Black);
        }
        SolicitudAbastecimientoCtr SActr = new SolicitudAbastecimientoCtr();
       // SolicitudProduccionCtr SPctr = new SolicitudProduccionCtr();
        private void button_actualizarSA_Click(object sender, EventArgs e)
        {

            if (panel_SupervisorA.Visible == true) { panel_SupervisorA.Visible = false; panel_vista.Visible = false; }
            else
            {
                panel_SupervisorA.Visible = true; CargarListaSolicitudAbastecimiento();// panel_vista.Visible = false;
                ComboBox_Filtro.Items.Add("Asunto");
                ComboBox_Filtro.Items.Add("Redactor");
                ComboBox_Filtro.Items.Add("Emision");
                ComboBox_Filtro.Items.Add("Entrega");
                ComboBox_Filtro.Items.Add("Estado");
            }
        }
        private void CargarListaSolicitudAbastecimiento()
        {
            DataGridView_VistaPrincipal.DataSource = SActr.ListarSolicitudesAbastecimiento();
        }

        private void Button_Buscar_Click(object sender, EventArgs e)
        {
            cargarBusqueda();
        }

        private void cargarBusqueda()
        {
                var listaConsultas = SActr.ConsultaSolicitudAbastecimiento(ComboBox_Filtro.Text, TextBox_Búsqueda.Text);
                DataGridView_VistaPrincipal.DataSource = listaConsultas;
        }

        private void ComboBox_Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button_visualizarSA_Click(object sender, EventArgs e)
        {
            panel_vista.Visible = true;
            if (DataGridView_VistaPrincipal.SelectedRows.Count > 0)
            {
                string fechaE = DataGridView_VistaPrincipal.CurrentRow.Cells["Emision"].Value.ToString();
                string[] separador = fechaE.Split(' ');
                string fechaEt = DataGridView_VistaPrincipal.CurrentRow.Cells["Entrega"].Value.ToString();
                string[] separador1 = fechaEt.Split(' ');
                textBox_vista.Text = "El código de solicitud es:" + DataGridView_VistaPrincipal.CurrentRow.Cells["Solicitud"].Value.ToString() + "\r\n\n" +
                                     "De asunto es: "+ DataGridView_VistaPrincipal.CurrentRow.Cells["Asunto"].Value.ToString()+ "\r\n\n\n\n" +
                                     "Redactor: " + DataGridView_VistaPrincipal.CurrentRow.Cells["Redactor"].Value.ToString() + "\r\n\n\n\n\n\n\n" +
                                     "Fecha Emisión: " + separador[0] + "       "+"Fecha Entrega"+ separador1[0]
                                     ;
            }
        }

        private void button_cerrarVista_Click(object sender, EventArgs e)
        {
            panel_vista.Visible = false;
        }
    }
}

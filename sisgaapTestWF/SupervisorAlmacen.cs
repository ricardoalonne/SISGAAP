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

            if (panel_SupervisorA.Visible == true) panel_SupervisorA.Visible = false;
            else { panel_SupervisorA.Visible = true; CargarListaSolicitudAbastecimiento();
                ComboBox_Filtro.Items.Add( "Asunto");
                ComboBox_Filtro.Items.Add("Redactor");
                //ComboBox_Filtro.Items.Add("Emision");
                //ComboBox_Filtro.Items.Add( "Entrega");
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
          /*  if (ComboBox_Filtro.Text == "Emision" || ComboBox_Filtro.Text == "Entrega")
            {
                var listaConsultas = SActr.ConsultaSolicitudAbastecimiento(ComboBox_Filtro.Text, date_S.Text);
                DataGridView_VistaPrincipal.DataSource = listaConsultas;
            }
            else
            {*/
                var listaConsultas = SActr.ConsultaSolicitudAbastecimiento(ComboBox_Filtro.Text, TextBox_Búsqueda.Text);
                DataGridView_VistaPrincipal.DataSource = listaConsultas;
           // }
        }

        private void ComboBox_Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if(ComboBox_Filtro.Text=="Emision" || ComboBox_Filtro.Text == "Entrega")
            {
                date_S.Visible = true;
                TextBox_Búsqueda.Visible = false;
            }
            else
            {
                date_S.Visible = false;
                TextBox_Búsqueda.Visible = true;
            }*/
        }

        private void DataGridView_VistaPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView_VistaPrincipal.CurrentRow.Selected = true;
            string codigo = DataGridView_VistaPrincipal.Rows[e.RowIndex].Cells["Solicitud"].FormattedValue.ToString();
        }
    }
}

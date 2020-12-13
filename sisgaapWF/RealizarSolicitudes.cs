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
using sisgaapCore.Entities;
using sisgaapCoreWF.Controllers;
namespace sisgaapWF
{
    public partial class RealizarSolicitudes : Form
    {
        public RealizarSolicitudes()
        {
            InitializeComponent();
        }
        SolicitudAbastecimiento objSA = new SolicitudAbastecimiento();
        SolicitudAbastecimientoCtr objSA_Ctr = new SolicitudAbastecimientoCtr();

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtAsunto.Text == "" | txtDescripcion.Text == "")
            {
                MessageBox.Show("Complete espacios en blanco");
                return;
            }
            else
            {
                objSA.asunto = txtAsunto.Text;
                objSA.descripcion = txtDescripcion.Text;
                objSA.fechaEntrega = dtpFechaEntrega.Value;
                objSA.observacion = "";
                objSA.redactor = "Rojas Mirko";
                mostrarMsj(objSA);
                objSA_Ctr.RegistrarSA(objSA);
            }          
        }
        public void mostrarMsj(SolicitudAbastecimiento SA)
        {
            switch (SA.error)
            {
                case 1:
                    MessageBox.Show("fecha Invalida!!");
                    break;
                case 2:
                    MessageBox.Show("Descripción supero los 50 caracteres!!");
                    break;
                case 3:
                    MessageBox.Show("Asunto supero los 50 caracteres!!");
                    break;
                case 4:
                    MessageBox.Show("observación supero los 50 caracteres!!");
                    break;
                case 77:
                    MessageBox.Show("Solicitud creada!! AÑADIR PRODUCTOS!!");
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Solicitudes S = new Solicitudes();
            S.Show();
            Hide();
        }
    }
}

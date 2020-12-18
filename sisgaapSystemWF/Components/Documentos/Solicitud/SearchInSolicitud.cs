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
using sisgaapSystemWF.Components.SISGAAP;

namespace sisgaapSystemWF.Components.Documentos.Solicitud
{
    public partial class SearchInSolicitud : SearchBar
    {
        public SearchInSolicitud()
        {
            InitializeComponent();
        }

        private SolicitudAbastecimientoCtr SActr = new SolicitudAbastecimientoCtr();
        private string searchIn = "";

        //---------------------------------------------------------------------------------------------------
        public string SearchIn {
            get => searchIn;
            set {
                searchIn = value;
                switch (searchIn) {
                    case "Abastecimiento": {
                            MessageSearchBox = "Buscar en todas las Solicitudes de Abastecimiento";
                        } break;
                    case "Produccion": {
                            MessageSearchBox = "Buscar en todas las Solicitudes de Produccion";
                        } break;
                    default: break;
                }
            }
        }

        //---------------------------------------------------------------------------------------------------
        public override void Search(){
            switch (searchIn) {
                case "Abastecimiento": {
                        var listaConsultas = SActr.ConsultaSolicitudAbastecimiento(FilterText, SearchText);
                        dgv.DataSource = listaConsultas;
                    } break;
                case "Produccion": {
                        MessageSearchBox = "Buscar en todas las Solicitudes de Produccion";
                    } break;
                default: break;
            }
        }
    }
}

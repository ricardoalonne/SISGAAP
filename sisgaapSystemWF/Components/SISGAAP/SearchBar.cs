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

namespace sisgaapSystemWF.Components.SISGAAP
{
    public partial class SearchBar : UserControl
    {
        public SearchBar()
        {
            InitializeComponent();
        }

        private string messageSearchBox = "Buscar en el sistema e internet.";
        private ControlController controlController;
        private DataGridView dgv;
        private object dataSource;

        private void SearchBar_BackColorChanged(object sender, EventArgs e) {
            this.ComboBox_Filtro.BackColor = this.BackColor;
        }

        private void SearchBar_Load(object sender, EventArgs e) {
            controlController = new ControlController();
            TextBox_Búsqueda.Text = messageSearchBox;
            SearchBoxInteractive();
        }

        private void Button_Buscar_Click(object sender, EventArgs e) => Search();

        private void ComboBox_Filtro_SelectedIndexChanged(object sender, EventArgs e) {
            //options = database.ConsultColumnLead(ComboBox_Filtro.Text); //Toma el combobox filtro para obtener la columna y guarda todos los elementos de esa columna
            //controlController.AutoComplete(TextBox_Búsqueda, options);
        }

        //---------------------------------------------------------------------------------------------

        public void DataGridView(DataGridView dgv) => this.dgv = dgv;

        public void RefreshDataGridView() => dgv.Refresh();

        public object DataSource {
            set => dataSource = value;
            get => dataSource;
        }

        public string MessageSearchBox{
            set { 
                messageSearchBox = value; 
                TextBox_Búsqueda.Text = messageSearchBox; 
            }
            get => messageSearchBox;
        }

        public void LoadItemsFilter(string[] items){
            controlController.ChangeItems(ComboBox_Filtro, items);
        }

        public void SearchBoxInteractive() {
            this.TextBox_Búsqueda.DoubleClick += new EventHandler(TextBox_Búsqueda_DoubleClick);
            this.TextBox_Búsqueda.Enter += new EventHandler(TextBox_Búsqueda_Enter);
            this.TextBox_Búsqueda.KeyDown += new KeyEventHandler(TextBox_Búsqueda_KeyDown);
            this.TextBox_Búsqueda.Leave += new EventHandler(TextBox_Búsqueda_Leave);

            void TextBox_Búsqueda_DoubleClick(object sender, EventArgs e) { TextBox_Búsqueda.Clear(); TextBox_Búsqueda.Select(); }

            void TextBox_Búsqueda_KeyDown(object sender, KeyEventArgs e){
                if (e.KeyCode == Keys.Enter){
                    Search(); Button_Buscar.Select();
                }
            }
            void TextBox_Búsqueda_Enter(object sender, EventArgs e){
                if (TextBox_Búsqueda.Text == messageSearchBox){
                    TextBox_Búsqueda.Text = ""; TextBox_Búsqueda.Select();
                    TextBox_Búsqueda.Location = new Point(6, 11);
                    TextBox_Búsqueda.Font = new Font(TextBox_Búsqueda.Font, FontStyle.Regular);
                    TextBox_Búsqueda.ForeColor = Color.Black;
                    Button_Buscar.Visible = true;
                    PictureBox_ImagenBuscar.Visible = !Button_Buscar.Visible;
                }
            }
            void TextBox_Búsqueda_Leave(object sender, EventArgs e){
                if (TextBox_Búsqueda.Text.Trim().Length == 0){
                    TextBox_Búsqueda.Text = messageSearchBox;
                    TextBox_Búsqueda.Location = new Point(41, 11);
                    Button_Buscar.Visible = false;
                    TextBox_Búsqueda.ForeColor = Color.Gray;
                    TextBox_Búsqueda.Font = new Font(TextBox_Búsqueda.Font, FontStyle.Italic);
                    PictureBox_ImagenBuscar.Visible = !Button_Buscar.Visible;
                }
            }

        }

        public void Search() { 

        }
    }
}

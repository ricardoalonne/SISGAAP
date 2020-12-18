using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using wmCoreWF;

using System.Drawing.Printing;

namespace sisgaapSystemWF.Views.Documentos
{
    public partial class VisualizarDocumento : Form
    {
        public VisualizarDocumento()
        {
            InitializeComponent();
        }

        private string documento = "", documentName = "documentoWM";
        private PDFGenerator docpdf;
        private bool landscape = false;

        private void VisualizarDocumento_Load(object sender, EventArgs e){
            RichTextBox_Documento.Select(RichTextBox_Documento.Text.Length, 0);
        }

        private void VisualizarDocumento_DragEnter(object sender, DragEventArgs e){
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void VisualizarDocumento_DragDrop(object sender, DragEventArgs e){
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (file[0] != null && !file[0].EndsWith(".pdf") && !file[0].EndsWith(".docx")) {
                if (RichTextBox_Documento.Text.Trim().Length > 0){
                    if (MessageBox.Show("Se perderá el contenido guardado, ¿Está seguro que quiere continuar?", "¿Desea abrir " + file[0] + "?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
                }

                TextReader readerText = new StreamReader(file[0], Encoding.GetEncoding(1252));
                RichTextBox_Documento.Text = readerText.ReadToEnd();
                readerText.Close();
                RichTextBox_Documento.Select(RichTextBox_Documento.Text.Length, 0);
            }
            else{
                MessageBox.Show("Actualmente el sistema no soporta el abrir archivos PDF y DOCX.", "Incompatibilidad con .docx y .pdf", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Button_GuardarComo_Click(object sender, EventArgs e){
            SaveFileDialog svd = new SaveFileDialog {
                Title = "Documentos - Guardar Como",
                Filter = "Archivo Documentos|*.pdf;*.doc;*.docx;*.txt;*.wmdoc",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                FileName = documentName,
                AddExtension = true,
            };
            try {
                if (svd.ShowDialog() == DialogResult.OK) {
                    if (svd.FileName.EndsWith(".pdf")){
                        docpdf = new PDFGenerator(RichTextBox_Documento.Text, svd.FileName);
                        docpdf.Font(RichTextBox_Documento.Font);
                        docpdf.Landscape(landscape);
                        docpdf.Print();
                    }
                    else {
                        StreamWriter saveText = new StreamWriter(svd.FileName, false, Encoding.GetEncoding(1252));
                        if (File.Exists(svd.FileName)){
                            saveText.Write(RichTextBox_Documento.Text);
                            saveText.Flush();
                            saveText.Close();
                        }
                        else{
                            saveText.Write(RichTextBox_Documento.Text);
                            saveText.Flush();
                            saveText.Close();
                        }
                    }
                }
            } catch(Exception) { }
        }

        private void Button_Cerrar_Click(object sender, EventArgs e) => this.Close();

        //---------------------------------------------------------------------------------------------------------------------------------------
        public Font DocumentFont {
            get => RichTextBox_Documento.Font;
            set => RichTextBox_Documento.Font = value;
        }

        public string Documento {
            set {
                documento = value;
                RichTextBox_Documento.Text = documento;
                RichTextBox_Documento.Select(RichTextBox_Documento.Text.Length, 0);
            }
            get => documento;
        }
        
        public string DocumentName {
            set => documentName = value;
            get => documentName;
        }

        public bool Landscape{
            set => landscape = value;
            get => landscape;
        }

    }
}

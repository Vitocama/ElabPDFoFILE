using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace unisciPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OrderRdx.Checked = true;
            OrderNoRdx.Checked = false;

        }

        private void ConcatenaBnt_Click(object sender, EventArgs e)
        {

            List<string> selectedFilesList = new List<string>();




            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Consenti la selezione di più file
            openFileDialog.Multiselect = true;

            // Imposta il filtro per visualizzare solo alcuni tipi di file (opzionale)
            openFileDialog.Filter = "File PDF (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Svuota la lista prima di aggiungere i nuovi file
                selectedFilesList.Clear();

                // Ottieni il percorso dei file selezionati e aggiungili alla lista
                string[] selectedFiles = openFileDialog.FileNames;


                selectedFilesList.AddRange(selectedFiles);
                if (OrderRdx.Checked)
                {
                    selectedFilesList.Sort();
                }

                ConcatenatePdfs(selectedFilesList);
            }
        }

        private void ConcatenatePdfs(List<string> pdfFiles)
        {
            // Verifica che ci siano file selezionati
            if (pdfFiles == null || pdfFiles.Count == 0)
            {
                MessageBox.Show("Nessun file PDF selezionato.");
                return;
            }

            // Crea un nuovo documento PDF per il file finale
            PdfDocument outputDocument = new PdfDocument();

            try
            {
                // Aggiungi ogni PDF alla fine del documento
                foreach (string pdfFile in pdfFiles)
                {
                    // Apri il file PDF corrente
                    PdfDocument inputDocument = PdfReader.Open(pdfFile, PdfDocumentOpenMode.Import);

                    // Aggiungi ogni pagina del PDF al documento di output
                    foreach (PdfPage page in inputDocument.Pages)
                    {
                        outputDocument.AddPage(page);
                    }
                }

                // Crea una finestra di dialogo per salvare il file
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                // Imposta il filtro per salvare solo file PDF
                saveFileDialog.Filter = "File PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Salva il file PDF concatenato";

                // Mostra la finestra di dialogo per scegliere dove salvare il file
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Salva il nuovo documento PDF con il percorso scelto dall'utente
                    outputDocument.Save(saveFileDialog.FileName);

                    // Mostra un messaggio di conferma
                    MessageBox.Show($"File PDF concatenato salvato in: {saveFileDialog.FileName}");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si è verificato un errore durante il concatenamento dei file PDF: " + ex.Message);
            }
        }

        private void OrderNoRdx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectPng_Click(object sender, EventArgs e)
        {
            // Crea una nuova istanza di OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File PNG (*.png)|*.png";
            openFileDialog.Multiselect = true; // Permette la selezione di più file

            // Mostra la finestra di dialogo e verifica che l'utente abbia selezionato dei file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Converti ciascun PNG selezionato in PDF
                foreach (string pngFilePath in openFileDialog.FileNames)
                {
                    ConvertPngToPdf(pngFilePath);
                }
            }
        }

        private void ConvertPngToPdf(string pngFilePath)
        {
            try
            {
                // Crea un nuovo documento PDF
                PdfDocument pdfDocument = new PdfDocument();
                pdfDocument.Info.Title = "Converted PNG to PDF";

                // Crea una nuova pagina nel PDF
                PdfPage pdfPage = pdfDocument.AddPage();

                // Carica l'immagine PNG
                using (XImage image = XImage.FromFile(pngFilePath))
                {
                    // Calcola le dimensioni della pagina in base all'immagine
                    pdfPage.Width = image.PointWidth;
                    pdfPage.Height = image.PointHeight;

                    // Disegna l'immagine nella pagina PDF
                    XGraphics gfx = XGraphics.FromPdfPage(pdfPage);
                    gfx.DrawImage(image, 0, 0);
                }

                // Crea una finestra di dialogo per salvare il file PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "File PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Salva il file PDF";
                saveFileDialog.FileName = System.IO.Path.GetFileNameWithoutExtension(pngFilePath) + ".pdf"; // Nome di default per il PDF

                // Mostra la finestra di dialogo per scegliere dove salvare il file
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Salva il documento PDF
                    pdfDocument.Save(saveFileDialog.FileName);
                    MessageBox.Show($"File PDF salvato in: {saveFileDialog.FileName}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si è verificato un errore durante la conversione: " + ex.Message);
            }
        }



        private void ConvPNG_PDF_bnt_Click(object sender, EventArgs e)
        {
            // Crea una nuova istanza di OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File PNG (*.png)|*.png";
            openFileDialog.Multiselect = true; // Permette la selezione di più file

            // Mostra la finestra di dialogo e verifica che l'utente abbia selezionato dei file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Converti ciascun PNG selezionato in PDF
                foreach (string pngFilePath in openFileDialog.FileNames)
                {
                    PngToPf(pngFilePath);
                }
            }
        }

        private void PngToPf(string pngFilePath)
        {
            try
            {
                // Crea un nuovo documento PDF
                PdfDocument pdfDocument = new PdfDocument();
                pdfDocument.Info.Title = "Converted PNG to PDF";

                // Crea una nuova pagina nel PDF
                PdfPage pdfPage = pdfDocument.AddPage();

                // Carica l'immagine PNG
                using (XImage image = XImage.FromFile(pngFilePath))
                {
                    // Calcola le dimensioni della pagina in base all'immagine
                    pdfPage.Width = image.PointWidth;
                    pdfPage.Height = image.PointHeight;

                    // Disegna l'immagine nella pagina PDF
                    XGraphics gfx = XGraphics.FromPdfPage(pdfPage);
                    gfx.DrawImage(image, 0, 0);
                }

                // Crea una finestra di dialogo per salvare il file PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "File PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Salva il file PDF";
                saveFileDialog.FileName = System.IO.Path.GetFileNameWithoutExtension(pngFilePath) + ".pdf"; // Nome di default per il PDF

                // Mostra la finestra di dialogo per scegliere dove salvare il file
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Salva il documento PDF
                    pdfDocument.Save(saveFileDialog.FileName);
                    MessageBox.Show($"File PDF salvato in: {saveFileDialog.FileName}");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si è verificato un errore durante la conversione: " + ex.Message);
            }
        }
    }
}



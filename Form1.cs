using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Unlock
{
    public partial class Form1 : Form
    {
        const string quote = "\"";
        public Form1()
        {
            InitializeComponent();
        }

        private void pdfDropBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] pdfFile = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            string extension = Path.GetExtension(pdfFile[0]);
            if (extension == ".pdf") {
                pdffile.Text = pdfFile[0];
                UnlockPDF();
                Process.Start(@"%TEMP%\temp.pdf");
            }
            else
            {
                MessageBox.Show("Please only drop PDFs in here. If its not a PDF I cant help you! :(");
            }

        }

        private void browsePDFbtn_Click(object sender, EventArgs e)
        {
            //openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Select PDF File";
            openFileDialog1.DefaultExt = "pdf";
            openFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(openFileDialog1.FileName);
                if (extension == ".pdf")
                {
                    pdffile.Text = openFileDialog1.FileName;
                    UnlockPDF();
                    Process.Start(@"%TEMP%\temp.pdf");
                }
                else
                {
                    MessageBox.Show("Please only select PDF files. If its not a PDF I cant help you! :(");
                }
            }
        }

        private void UnlockPDF()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = gswin64cLocationtxt.Text;
            startInfo.Arguments = @"-dPDFA -dBATCH -dNOPAUSE -sDEVICE=pdfwrite -sOutputFile=%TEMP%\temp.pdf " + quote + pdffile.Text + quote;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        private void pdfDropBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void BrowsePDF_HelpRequest(object sender, EventArgs e)
        {

        }


        private void browseGswin64cbtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                gswin64cLocationtxt.Text = openFileDialog2.FileName;
                Properties.Settings.Default.gswin64cLocation = gswin64cLocationtxt.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            
            try
            {
                File.Delete(@"C:\temp\temp.pdf");

            }
            catch(Exception)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gswin64cLocationtxt.Text = Properties.Settings.Default.gswin64cLocation;
            try
            {
                File.Delete(@"C:\temp\temp.pdf");

            }
            catch (Exception)
            {

            }
        }
    }
}

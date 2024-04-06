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

namespace Arhchivotexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Title="Abir Arhcivo";
                openFileDialog.ShowDialog();

                if (File.Exists(openFileDialog.FileName))
                {
                    string file = openFileDialog.FileName;

                    TextReader reader = new StreamReader(file);
                    rtxtDocument.Text = reader.ReadToEnd();
                    reader.Close();

                    txtFilePath.Text=file;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha generado un error al abrir el documento");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string file = saveFileDialog.FileName;

                    StreamWriter writer = File.CreateText(file);
                    writer.Write(rtxtDocument.Text);
                    writer.Flush();
                    writer.Close();
                }

                MessageBox.Show("Archivo guardado con exito");
                this.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar el archivo");
            }
        }
    }
}

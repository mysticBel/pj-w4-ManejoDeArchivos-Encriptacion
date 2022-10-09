using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using System.IO.Compression;

namespace pj_w4_ManejoDeArchivos_Encriptacion
{
    public partial class frmComprimir : Form
    {
        public frmComprimir()
        {
            InitializeComponent();
        }

        private void tsComprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Archivo comprimido ZIP | *.zip |Archivo comprimido RAR | *.rar";
            if (sv.ShowDialog() == DialogResult.OK) { 
                MemoryStream ms = new MemoryStream();
                StreamWriter sw = new StreamWriter(ms);
                sw.Write(txtEditor.Text);
                //que corra de manera secuencial
                sw.Flush();

                FileStream fs = new FileStream(sv.FileName, FileMode.Create);
                //zipeado
                GZipStream zip = new GZipStream(fs, CompressionMode.Compress);

                zip.Write(ms.ToArray(), 0, ms.ToArray().Length);
                zip.Close();
                fs.Close();
            }
        }

        private void tsDescomprimir_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivo ZIP | *.zip |Archivo RAR | *.rar  ";
            if (op.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(op.FileName, FileMode.Open);
                //des-zipeado
                GZipStream zip = new GZipStream(fs, CompressionMode.Decompress);

                Byte[] info = new Byte[4096];
                zip.Read(info, 0, info.Length);

                MemoryStream ms = new MemoryStream();
                ms.Write(info, 0, info.Length);

                //Obtener la información de la memoria
                ms.Position = 0;
                StreamReader sr = new StreamReader(ms);
                txtEditor.Text = sr.ReadToEnd();
                sr.Close();
                fs.Close();

            }
        }

        private void tsAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivo de Text | *.txt";
            if (op.ShowDialog() == DialogResult.OK) {
                StreamReader sr = new StreamReader(op.FileName);
                txtEditor.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}

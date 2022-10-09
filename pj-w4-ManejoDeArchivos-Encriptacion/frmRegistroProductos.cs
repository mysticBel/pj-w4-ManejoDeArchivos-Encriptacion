using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//agregamos
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Drawing; 



namespace pj_w4_ManejoDeArchivos_Encriptacion
{
    public partial class frmRegistroProductos : Form
    {
        public frmRegistroProductos()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Archivos JPG|*.jpg";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    pbImagen.Image = Image.FromFile(op.FileName);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto objP = new Producto()
                {
                    ide_pro = int.Parse(txtCodigo.Text),
                    des_pro = txtDescripcion.Text,
                    pre_pro = double.Parse(txtPrecio.Text),
                    sto_pro = int.Parse(txtStock.Text),
                    fve_pro = dtFecha.Value,
                    fot_pro = (Bitmap)pbImagen.Image
                };

                //Grabar con bin(binario)
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "Archivo Binario|*.bin";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(sv.FileName, FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, objP);
                    fs.Close();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}

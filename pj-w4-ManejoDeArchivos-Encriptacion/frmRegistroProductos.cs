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
                    pbFoto.Image = Image.FromFile(op.FileName);
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
                    fot_pro = (Bitmap)pbFoto.Image
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

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Archivo Binario|*.bin";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(op.FileName, FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    Producto objP = (Producto)bf.Deserialize(fs);
                    txtCodigo.Text = objP.ide_pro.ToString();
                    txtDescripcion.Text = objP.des_pro;
                    txtPrecio.Text = objP.pre_pro.ToString();
                    txtStock.Text = objP.sto_pro.ToString();
                    dtFecha.Value = objP.fve_pro;
                    pbFoto.Image = objP.fot_pro;
                    fs.Close();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Xml.Serialization; //Agregado para XML 


namespace pj_w4_ManejoDeArchivos_Encriptacion
{
    public partial class frmEmpleadoXML : Form
    {
        int n;
        public frmEmpleadoXML()
        {
            InitializeComponent();
            generaCodigo();
        }

        //generando codigo
        void generaCodigo()
        {
            n++;
            int año = DateTime.Now.Year;
            //lblCodigo.Text = n.ToString("0000") + "-" + año.ToString();
            lblCodigo.Text = n.ToString("0000");

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Instanciamos un objeto de la clase Empleado
            Empleado objP = new Empleado()
            {
                ide_emp = int.Parse(lblCodigo.Text),
                nom_emp = txtNombres.Text,
                sue_emp = double.Parse(txtSueldo.Text),
                fin_emp = dtFecha.Value
            };

            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Archivo XML|*.xml";
            if (sv.ShowDialog() == DialogResult.OK)
            {

                FileStream fs = new FileStream(sv.FileName, FileMode.Create);
                XmlSerializer xml = new XmlSerializer(typeof(Empleado));            
                xml.Serialize(fs, objP);
                fs.Close();
            }

        }
    }
}

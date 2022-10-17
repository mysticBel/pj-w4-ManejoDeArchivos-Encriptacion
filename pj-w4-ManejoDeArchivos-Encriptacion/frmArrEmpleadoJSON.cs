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
using System.Runtime.Serialization.Json;
using System.Collections;

namespace pj_w4_ManejoDeArchivos_Encriptacion
{
    public partial class frmArrEmpleadoJSON : Form
    {
        int n;
        List<Empleado> aEmpleados = new List<Empleado>();

        public frmArrEmpleadoJSON()
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Empleado objtE = new Empleado()
            {
                ide_emp = int.Parse(lblCodigo.Text),
                nom_emp = txtNombres.Text,
                sue_emp = double.Parse(txtSueldo.Text),
                fin_emp = dtFecha.Value
            };

            //arreglo de empleados
            aEmpleados.Add(objtE);
            listadoEmpleados();
            generaCodigo();
        }

        private void listadoEmpleados()
        {
            lvEmpleados.Items.Clear();
            foreach (Empleado emp in aEmpleados)
            {
                ListViewItem fila = new ListViewItem(emp.ide_emp.ToString());
                fila.SubItems.Add(emp.nom_emp);
                fila.SubItems.Add(emp.sue_emp.ToString("0.00"));  //2500.00
                fila.SubItems.Add(emp.fin_emp.ToShortDateString());
                lvEmpleados.Items.Add(fila);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Archivo JSON|*.json";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(sv.FileName, FileMode.Create))
                {
                    DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<Empleado>));
                    json.WriteObject(fs, aEmpleados);
                }
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivo JSON|*.json";
            if (op.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(op.FileName, FileMode.Open))
                {
                    DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<Empleado>));
                    aEmpleados = (List<Empleado>)json.ReadObject(fs);
                    listadoEmpleados();
                }
            }
        }
    }
}
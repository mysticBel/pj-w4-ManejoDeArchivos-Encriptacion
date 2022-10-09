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
using System.Collections;

namespace pj_w4_ManejoDeArchivos_Encriptacion
{
    
    public partial class frmRegistro : Form
    {
        int n;
        //para guardar e n una matriz 
        ArrayList aEmpleados = new ArrayList();

        public frmRegistro()
        {
            InitializeComponent();
            generaCodigo();
        }


        //generando codigo
        void generaCodigo(){
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
            listado();
            generaCodigo();
        }

        private void listado()
        {
            lvEmpleados.Items.Clear();
            foreach (Empleado emp in aEmpleados)
            {
                ListViewItem fila = new ListViewItem(emp.ide_emp.ToString());
                fila.SubItems.Add(emp.nom_emp);
                fila.SubItems.Add(emp.sue_emp.ToString());
                fila.SubItems.Add(emp.fin_emp.ToShortDateString());
                lvEmpleados.Items.Add(fila);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Archivo de Texto|*.txt";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sv.FileName, FileMode.Create);
                string miEmpleado = "";
                foreach (Empleado emp in aEmpleados)
                {
                    miEmpleado += emp.ide_emp + "|" + emp.nom_emp + "|" +
                                  emp.sue_emp + "|" + emp.fin_emp.ToShortDateString() + "\n";
                }
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(miEmpleado);
                sw.Close();
                fs.Close();
            }
        }
    }
}

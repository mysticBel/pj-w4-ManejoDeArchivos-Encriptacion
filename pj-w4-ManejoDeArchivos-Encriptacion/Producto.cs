using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//agregar
using System.Drawing;

namespace pj_w4_ManejoDeArchivos_Encriptacion
{
    //La serialización permite que imagenes puedan ser transfeeridas a mayor velocidad 
    // siendo texto
    // Producto se convertira en codigo de bytes

    [Serializable()] 
    internal class Producto
    {
        public int ide_pro { get; set; }
        public string des_pro { get; set; }
        public double pre_pro { get; set; }
        public int sto_pro { get; set; }
        public DateTime fve_pro { get; set; }

        //Bitmap
        public Bitmap fot_pro { get; set; }
    }
}

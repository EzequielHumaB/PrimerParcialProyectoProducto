using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoParcialProductos.Entidades
{
    public class Ubicaciones
    {
        [Key]
        public int UbicacionID { get; set; }
        public string Descripcion { get; set; }


        public Ubicaciones()
        {
            UbicacionID = 0;
            Descripcion = string.Empty;
        }
    }
}

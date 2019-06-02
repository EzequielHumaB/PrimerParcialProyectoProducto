using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoParcialProductos.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoID { get; set; }
        public string Descripcion { get; set; }
        public int existencia { get; set; }
        public decimal costo { get; set; }
        public decimal ValorInventario { get; set; }

        public Productos()
        {
            ProductoID = 0;
            Descripcion = string.Empty;
            existencia = 0;
            costo = 0;
            ValorInventario = 0;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoParcialProductos.Entidades
{
   public class TotalInventario
    {
        [Key]
        public int ProductoID { get; set; }

        public decimal InventarioTotal { get; set; }
     
        public TotalInventario()
        {
            InventarioTotal = 0;
        }
    }
}

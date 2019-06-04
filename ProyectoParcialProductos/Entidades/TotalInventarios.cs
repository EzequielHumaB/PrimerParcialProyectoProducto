using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoParcialProductos.Entidades
{
   public class TotalInventarios
    {
        [Key]
        public int ProductoId { get; set; }

        public decimal InventarioTotal { get; set; }
     
        public TotalInventarios()
        {
            ProductoId = 0;
            InventarioTotal = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProyectoParcialProductos.Entidades;

namespace ProyectoParcialProductos.DAL
{
   public class Contexto : DbContext
    {
        public DbSet<Productos> productos { get; set; }
        public DbSet<TotalInventario> totalInventarios { get; set; }

        public DbSet<Ubicaciones> ubicacion { get; set; }

     
        public Contexto() : base("ConStr")
        { }
    }
}

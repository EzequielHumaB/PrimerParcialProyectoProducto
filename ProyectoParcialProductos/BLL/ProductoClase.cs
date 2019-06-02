using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoParcialProductos.DAL;
using ProyectoParcialProductos.Entidades;

namespace ProyectoParcialProductos.BLL
{
   public class ProductoClase
    {
        public static bool Guardar(Productos productos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.productos.Add(productos)!=null)
                {
                    paso = contexto.SaveChanges() > 0;
                }
            } catch(Exception)
            {
                throw;
            }
            return paso;
        }
    }
}

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

        public static bool Modificar(Productos productos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(productos).State = System.Data.Entity.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;

            }catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.productos.Find(id);
                contexto.Entry(id).State = System.Data.Entity.EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;


            }catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        

    }
}

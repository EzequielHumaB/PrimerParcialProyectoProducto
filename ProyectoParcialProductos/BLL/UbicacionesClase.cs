using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections;
using ProyectoParcialProductos.DAL;
using ProyectoParcialProductos.Entidades;

namespace ProyectoParcialProductos.BLL
{
    public class UbicacionesClase
    {
        public static bool Guardar(Ubicaciones ubicaciones)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.ubicacion.Add(ubicaciones)!=null)
                {
                    paso = contexto.SaveChanges() > 0;
                }
            }catch(Exception)
            {
                throw;
            }
            return paso;
        }

       

        public static bool Modificar(Ubicaciones ubicaciones)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(ubicaciones).State = EntityState.Modified;
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
            Ubicaciones ubicaciones = new Ubicaciones();
            try
            {
                var eliminar = contexto.ubicacion.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;
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

        public static Ubicaciones Buscar(int id)
        {
            Ubicaciones ubicaciones = new Ubicaciones();
            Contexto contexto = new Contexto();
            try
            {
                ubicaciones = contexto.ubicacion.Find(id);

            }catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return ubicaciones;
        }

        public static List<Ubicaciones> getList(Expression<Func<Ubicaciones,bool>>ubicaciones)
        {
            List<Ubicaciones> lista = new List<Ubicaciones>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.ubicacion.Where(ubicaciones).ToList();
            }catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

    }
}

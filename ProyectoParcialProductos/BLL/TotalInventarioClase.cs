using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoParcialProductos.DAL;
using ProyectoParcialProductos.Entidades;
using System.Data.Entity;

namespace ProyectoParcialProductos.BLL
{
   public class TotalInventarioClase
    {
        public static bool Guardar(TotalInventario totalInventario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.totalInventarios.Add(totalInventario)!=null)
                {
                    paso = contexto.SaveChanges() > 0;
                }
            }catch(Exception)
            {
                throw;
            }
            return paso;
       }

        public static bool Modificar(TotalInventario totalInventario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(totalInventario).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;

            }catch(Exception)
            {
                throw;
            }
            return paso;
        }


    }
}
    
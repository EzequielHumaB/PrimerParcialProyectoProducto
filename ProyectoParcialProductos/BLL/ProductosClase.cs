﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ProyectoParcialProductos.DAL;
using ProyectoParcialProductos.Entidades;
using System.Data.Entity;
using System.Collections;
using System.Linq;


namespace ProyectoParcialProductos.BLL
{
   public class ProductosClase
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

        public static bool Modificar(Productos producto)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            Productos productos = ProductosClase.Buscar(producto.ProductoId);
            try
            {
                contexto.Entry(producto).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);

            }
            catch (Exception)
            {
                throw;
            }
            finally { contexto.Dispose(); }

            return paso;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.productos.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;
                paso = (contexto.SaveChanges()) > 0;


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

       public static Productos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Productos productos = new Productos();
            try
            {
                productos = contexto.productos.Find(id);

            } catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return productos;
        }

        public static List<Productos> GetList(Expression<Func<Productos,bool>> productos)
        {
            List<Productos> lista = new List<Productos>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.productos.Where(productos).ToList();
            }
            catch (Exception)
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

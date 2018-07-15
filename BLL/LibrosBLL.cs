using RegistroLibrosBiblicos.DAL;
using RegistroLibrosBiblicos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RegistroLibrosBiblicos.BLL
{
    public class LibrosBLL
    {
        public static bool Guardar(Libros Libro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Libro.Add(Libro) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Libros Libro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(Libro).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Libros Libro = contexto.Libro.Find(id);
                contexto.Libro.Remove(Libro);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static Libros Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Libros Libro = new Libros();

            try
            {
                Libro = contexto.Libro.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Libro;
        }

        public static List<Libros> GetList(Expression<Func<Libros, bool>> expression)
        {
            List<Libros> Libro = new List<Libros>();
            Contexto contexto = new Contexto();

            try
            {
                Libro = contexto.Libro.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Libro;
        }
    }
}
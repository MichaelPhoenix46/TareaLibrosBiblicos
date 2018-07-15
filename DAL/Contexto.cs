using RegistroLibrosBiblicos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroLibrosBiblicos.DAL
{
    public class Contexto
    {
        public DbSet<Libros> Libro { get; set; }
        public Contexto() : base("ConStr")
        { }

    }
}

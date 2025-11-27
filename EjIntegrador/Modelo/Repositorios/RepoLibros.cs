using Entidades;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public class RepoLibros
    {
        //llame al context usando using en cada funcion (es mas limpio?)
        //poner try catch una en la controladora, uno en el modelo y se puede poner en la lista tambien
        public IReadOnlyCollection<Libro> Listar()
        {
            using var context = new Context();
            return context.Libros.ToList().AsReadOnly();
        }

        public string Agregar(Libro libro)
        {
            try
            {
                using var context = new Context();

                if (context.Libros.Any(l => l.ISBN == libro.ISBN))
                {
                    return "Error. Ya existe un libro con ese ISBN.";
                }

                context.Libros.Add(libro);
                context.SaveChanges();
                return "Libro registrado con exito";
            }
            catch
            {
                return "Error al conectar con la BBDD.";
            }
        }

        public string Modificar(Libro libro)
        {
            try
            {
                using var context = new Context();

                var libroExistente = context.Libros.FirstOrDefault(l => l.LibroId == libro.LibroId);
                //var libroExistente = context.Libros.Find(libro.LibroId); Deberia funcionar igual

                if (libroExistente == null) return "El libro a modificar no existe.";

                libroExistente.ISBN = libro.ISBN;
                libroExistente.Titulo = libro.Titulo;
                libroExistente.Autor = libro.Autor;
                libroExistente.Estado = libro.Estado;

                context.SaveChanges();
                return "Libro modificado con exito";
            }
            catch
            {
                return "Error al conectar con la BBDD";
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                using var context = new Context();

                var libro = context.Libros.FirstOrDefault(l => l.LibroId == id);
                if (libro == null) return "No existe ese libro";

                context.Libros.Remove(libro);
                context.SaveChanges();
                return "Libro eliminado con exito.";
            }
            catch
            {
                return "Error al conectar con la BBDD";
            }
        }
    }
}

using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public class RepoPrestamos
    {
        public IReadOnlyCollection<Prestamo> Listar()
        {
            using var context = new Context();
            return context.Prestamos.ToList().AsReadOnly();
        }

        public IReadOnlyCollection<Prestamo> ListarActivos()
        {
            using var context = new Context();
            return context.Prestamos.Where(p => p.FechaDevolucion == null).ToList().AsReadOnly();
        }

        public string RegistrarPrestamo(int libroId, int socioId)
        {
            //Ya deberia llegar el presatmo armado (crear el prestamo en la controladora)
            try
            {
                using var context = new Context();

                var libro = context.Libros.Find(libroId);
                if (libro == null) return "El libro seleccionado no existe.";

                var socio = context.Socios.Find(socioId);
                if (socio == null) return "El socio seleccionado no existe.";

                if (!libro.Estado) return "Libro no disponible, se encuentra en prestamo.";

                Prestamo prestamo = new Prestamo
                {
                    FechaPrestamo = DateTime.Now,
                    FechaDevolucion = null,
                    Libro = libro,
                    Socio = socio,
                };

                context.Prestamos.Add(prestamo);
                libro.Estado = false;
                context.SaveChanges();
                return "Prestamo registrado con exito.";
            }
            catch
            {
                return "Error al conectar con la BBDD";
            }
        }

        public string RegistrarDevolucion(int idPrestamo)
        {
            try
            {
                using var context = new Context();

                var prestamo = context.Prestamos
                    .Include(p => p.Libro)
                    .FirstOrDefault(p => p.PrestamoId == idPrestamo);
                if (prestamo == null) return "El prestamo seleccionado no existe.";

                if (prestamo.FechaDevolucion != null) return "El libro ya fue devuelto.";

                prestamo.FechaDevolucion = DateTime.Now;
                prestamo.Libro.Estado = true;

                context.SaveChanges();
                return "Devolución registrada con éxito.";
            }
            catch
            {
                return "Error al conectarse con la BBDD";
            }
        }
    }
}

using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorios
{
    public class RepoSocios
    {
        public IReadOnlyCollection<Socio> Listar()
        {
            using var context = new Context();
            return context.Socios.ToList().AsReadOnly();
        }

        public string Agregar(Socio socio)
        {
            try
            {
                using var context = new Context();

                bool existe = context.Socios.Any(s => s.DNI == socio.DNI);
                if (existe) return "El DNI ingresado ya ha sido registrado.";

                context.Socios.Add(socio);
                context.SaveChanges();
                return "Socio registrado con exito.";
            }
            catch
            {
                return "Error al conectar con la BBDD";
            }
        }

        public string Modificar(Socio nuevoSocio)
        {
            try
            {
                using var context = new Context();

                var socio = context.Socios.Find(nuevoSocio.SocioId);
                if (socio == null) return "No se encontró ningun socio con ese Id";

                bool dniDuplicado = context.Socios.Any(s => s.DNI == nuevoSocio.DNI && s.SocioId != nuevoSocio.SocioId);
                if (dniDuplicado) return "El DNI ya está registrado por otro socio";

                socio.DNI = nuevoSocio.DNI;
                socio.Nombre = nuevoSocio.Nombre;
                socio.Email = nuevoSocio.Email;
                socio.Telefono = nuevoSocio.Telefono;

                context.SaveChanges();
                return "Modificación realizada con exito.";
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

                var socio = context.Socios.FirstOrDefault(s => s.SocioId == id);
                if (socio == null) return "No se encontró ningun socio con ese Id";

                var existe = context.Prestamos.Any(p => p.Socio.SocioId == id && p.FechaDevolucion == null);
                if (existe) return "El socio tiene un prestamo pendiente.";

                context.Socios.Remove(socio);
                context.SaveChanges();
                return "Socio eliminado con exito";
            }
            catch
            {
                return "Error al conectar con la BBDD";
            }
        }

        public bool VerificarPrestamoSocio(int id)
        {

            using var context = new Context();

            var existe = context.Prestamos
                .Any(p => p.Socio.SocioId == id && p.FechaDevolucion == null);

            return existe;
        }

    }
}

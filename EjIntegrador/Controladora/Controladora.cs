using Entidades;
using Microsoft.EntityFrameworkCore.Internal;
using Modelo.Repositorios;

namespace Controladora
{
    public sealed class BibliotecaControlador
    {
        private static BibliotecaControlador? _instance;
        private BibliotecaControlador()
        {
            _repoLibros = new RepoLibros();
            _repoSocios = new RepoSocios();
            _repoPrestamos = new RepoPrestamos();
        }
        public static BibliotecaControlador GetInstance()
        {
            if (_instance == null)
            {
                _instance = new BibliotecaControlador();
            }
            return _instance;
        }

        private readonly RepoLibros _repoLibros;
        private readonly RepoSocios _repoSocios;
        private readonly RepoPrestamos _repoPrestamos;

        //Metodos para Libros
        public IReadOnlyCollection<Libro> ListarLibros()
        {
            return _repoLibros.Listar();
        }

        public string AgregarLibro(string isbn, string titulo, string autor, bool estado)
        {
            Libro libro = new Libro
            {
                ISBN = isbn.Trim(),
                Titulo = titulo.Trim(),
                Autor = autor.Trim(),
                Estado = estado
            };
            return _repoLibros.Agregar(libro);
        }

        public string ModificarLibro(int libroId, string isbn, string titulo, string autor, bool estado)
        {
            Libro libro = new Libro
            {
                LibroId = libroId,
                ISBN = isbn.Trim(),
                Titulo = titulo.Trim(),
                Autor = autor.Trim(),
                Estado = estado
            };
            return _repoLibros.Modificar(libro);
        }

        public string EliminarLibro(int libroId)
        {
            return _repoLibros.Eliminar(libroId);
        }

        //Metodos para Socios

        public IReadOnlyCollection<Socio> ListarSocios()
        {
            return _repoSocios.Listar();
        }

        public string AgregarSocio(string dni, string nombre, string email, double telefono)
        {
            if (string.IsNullOrWhiteSpace(dni)) return "El DNI es obligatorio.";
            if (string.IsNullOrWhiteSpace(nombre)) return "El nombre es obligatorio.";
            if (string.IsNullOrWhiteSpace(email)) return "El email es obligatorio.";
            if (!double.IsPositive(telefono)) return "El teléfono es obligatorio.";
            Socio socio = new Socio
            {
                DNI = dni.Trim(),
                Nombre = nombre.Trim(),
                Email = email.Trim(),
                Telefono = telefono
            };
            return _repoSocios.Agregar(socio);
        }

        public string ModificarSocio(string dni, string nombre, string email, double telefono)
        {
            if (string.IsNullOrWhiteSpace(dni)) return "El DNI es obligatorio.";
            if (string.IsNullOrWhiteSpace(nombre)) return "El nombre es obligatorio.";
            if (string.IsNullOrWhiteSpace(email)) return "El email es obligatorio.";
            if (!double.IsPositive(telefono)) return "Ingrese un teléfono válido.";
            Socio socio = new Socio
            {
                DNI = dni.Trim(),
                Nombre = nombre.Trim(),
                Email = email.Trim(),
                Telefono = telefono
            };
            return _repoSocios.Modificar(socio);
        }

        public string EliminarSocio(int socioId)
        {
            return _repoSocios.Eliminar(socioId);
        }

        //Metodos para Prestamos
        public IReadOnlyCollection<Prestamo> ListarPrestamos()
        {
            return _repoPrestamos.Listar();
        }

        public IReadOnlyCollection<Prestamo> ListarPrestamosActivos()
        {
            return _repoPrestamos.ListarActivos();
        }

        public string RegistrarPrestamo(int libroId, int socioId)
        {
            return _repoPrestamos.RegistrarPrestamo(libroId, socioId);
        }

        public string EegistrarDevolucion(int prestamoId)
        {
            return _repoPrestamos.RegistrarDevolucion(prestamoId);
        }
    }
}

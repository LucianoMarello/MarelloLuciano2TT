using Entidades;
using Modelo;

namespace Controladora
{
    public class Controladora
    {
        private Repositorio repositorio = new Repositorio();

        //Aplicamos el singleton (copiar patron de diseño)
        private static Controladora instancia;
        public static Controladora Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return instancia = new Controladora();
                }
                return instancia;
            }
        }

        public IReadOnlyCollection<Partida> Listar()
        {
            return repositorio.Listar();
        }

        public string Agregar(Partida partida)
        {
            var fechaMayor = DateTime.Now < partida.Fecha;
            if (fechaMayor)
            {
                repositorio.Agregar(partida);
                return "Partida Registrada";
            }
            return "La fecha ya caducó";
        }

        public string AsignarJugador(Partida partida, Jugador jugador)
        {
            var existeJugador = partida.Jugadores.FirstOrDefault(x => x ==  jugador);
            var maximoJugadores = partida.Jugadores.Count();
            if (existeJugador == null && maximoJugadores < 2)
            {
                partida.Jugadores.Add(jugador);
                return "Jugador asociado";
            }

            return "No se pudo asociar el jugador";
        }
    }
}

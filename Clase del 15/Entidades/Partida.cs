namespace Entidades
{
    public class Partida
    {
        public int PartidaId { get; set; } //Propio de entity framework (por como se escribe)
        public DateTime Fecha { get; set; }
        public List<Jugador> Jugadores {  get; set; }

        //Esto es una composicion. Si borramos la partida, los jugadores tambien se borran
    }
}

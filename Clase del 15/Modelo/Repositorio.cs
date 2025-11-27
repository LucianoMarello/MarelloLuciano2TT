using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Repositorio
    {
        private Context context;

        public Repositorio()
        {
            context = new Context();
        }
        //poner try catch una en la controladora, uno en el modelo y se puede poner en la lista tambien
        public IReadOnlyCollection<Partida> Listar()
        {
            return context.Partidas.ToList().AsReadOnly();
        }

        public void Agregar(Partida partida)
        {
            context.Partidas.Add(partida);
            context.SaveChanges();
        }

        public void Modificar(Partida partida)
        {
            context.Partidas.Update(partida);
            context.SaveChanges();
        }

        public void Eliminar(Partida partida)
        {
            context.Partidas.Remove(partida);
            context.SaveChanges();
        }
    }
}

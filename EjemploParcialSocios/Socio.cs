using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploParcialSocios
{
    public class Socio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public int Numero_socio { get; set; }
        public bool Cuota_al_dia { get; set; }
    }
}

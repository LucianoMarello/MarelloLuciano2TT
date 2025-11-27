using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEntityF
{
    public class RepositorioMaterias
    {
        private UniversidadContext universidadContext;
        public RepositorioMaterias()
        {
            universidadContext = new UniversidadContext();
        }

        public List<Materia> Listar()
        {
            return universidadContext.Materias.ToList();
        }

        public string Agregar(Materia materia)
        {
            try
            {
                universidadContext.Materias.Add(materia);
                universidadContext.SaveChanges();
                return "Materia agregada";
            }
            catch(Exception ex)
            {
                throw new Exception("Error del sistema: "+ex);
            }

        }
        public string Modificar(Materia materia)
        {
            universidadContext.Materias.Update(materia);
            universidadContext.SaveChanges();
            return "Materia modificada";
        }

        public string Eliminar(Materia materia)
        {
            universidadContext.Materias.Remove(materia);
            universidadContext.SaveChanges();
            return "Materia eliminada";
        }
    }
}

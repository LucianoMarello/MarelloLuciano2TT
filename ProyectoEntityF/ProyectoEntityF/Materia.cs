using System;
using System.Collections.Generic;

namespace ProyectoEntityF;

public partial class Materia
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? CantidadHoras { get; set; }
}

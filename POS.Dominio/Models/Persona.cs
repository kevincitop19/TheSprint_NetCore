using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POS.Dominio.Models;

public partial class Persona
{
    [Key]
    public int IdPersona { get; set; }

    public string? Apellidos { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? Identificacion { get; set; }

    public string? Nombres { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}

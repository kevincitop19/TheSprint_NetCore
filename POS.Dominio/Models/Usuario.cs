using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POS.Dominio.Models;

public partial class Usuario
{
    [Key]
    public int IdUsuario { get; set; }

    public int? IntentosFallidos { get; set; }

    public string? Mail { get; set; }

    public string? Password { get; set; }

    public string? SessionActive { get; set; }

    public string? Status { get; set; }

    public string? UserName { get; set; }

    public int? PersonaIdPersona2 { get; set; }

    public virtual Persona? PersonaIdPersona2Navigation { get; set; }
}

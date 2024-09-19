using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POS.Dominio.Models;

public partial class Usuario
{
    [Key]
    public int id_usuario { get; set; }

    public int? intentos_fallidos { get; set; }

    public string? mail { get; set; }

    public string? password { get; set; }

    public string? session_active { get; set; }

    public string? status { get; set; }

    public string? user_name { get; set; }

    public int? persona_id_persona2 { get; set; }

    public virtual Persona? Persona { get; set; }

}

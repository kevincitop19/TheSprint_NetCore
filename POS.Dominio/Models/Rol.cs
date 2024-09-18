using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POS.Dominio.Models;

public partial class Rol
{
    [Key]
    public int IdRol { get; set; }

    public string? RolName { get; set; }
}

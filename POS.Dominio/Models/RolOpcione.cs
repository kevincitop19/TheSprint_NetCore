using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POS.Dominio.Models;

public partial class RolOpcione
{
    [Key]
    public int IdOpcion { get; set; }

    public string? NombreOpcion { get; set; }
}

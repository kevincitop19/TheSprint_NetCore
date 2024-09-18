using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POS.Dominio.Models;

public partial class RolRolOpcione
{
    [Key]
    public int RolOpcionesIdOpcion { get; set; }

    public int RolIdRol { get; set; }

    public virtual Rol RolIdRolNavigation { get; set; } = null!;

    public virtual RolOpcione RolOpcionesIdOpcionNavigation { get; set; } = null!;
}

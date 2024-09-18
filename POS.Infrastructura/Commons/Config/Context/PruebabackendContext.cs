using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using POS.Dominio.Models;

namespace POS.Infrastructura.Commons.Config.Context;

public partial class PruebabackendContext : DbContext
{
    public PruebabackendContext()
    {
    }

    public PruebabackendContext(DbContextOptions<PruebabackendContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<RolOpcione> RolOpciones { get; set; }

    public virtual DbSet<RolRolOpcione> RolRolOpciones { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
     
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

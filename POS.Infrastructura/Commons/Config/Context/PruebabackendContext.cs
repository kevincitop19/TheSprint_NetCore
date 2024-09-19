using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using POS.Dominio.Dtos.Request;
using POS.Dominio.Models;

namespace POS.Infrastructura.Commons.Config.Context;

public partial class PruebabackendContext : DbContext
{
    private readonly IConfiguration _configuration;
   

    public PruebabackendContext(DbContextOptions<PruebabackendContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<RolOpcione> RolOpciones { get; set; }

    public virtual DbSet<RolRolOpcione> RolRolOpciones { get; set; }

    public virtual DbSet<UsuarioRequest> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = _configuration.GetConnectionString("POSConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        
        OnModelCreatingPartial(modelBuilder);
        
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

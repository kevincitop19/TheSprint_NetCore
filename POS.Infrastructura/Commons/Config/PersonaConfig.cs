using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructura.Commons.Config
{
    public class PersonaConfig : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.HasKey(e => e.IdPersona).HasName("PK__persona__228148B078BBD013");

            builder.ToTable("persona");

            builder.Property(e => e.IdPersona).HasColumnName("id_persona");
            builder.Property(e => e.Apellidos)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            builder.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            builder.Property(e => e.Identificacion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("identificacion");
            builder.Property(e => e.Nombres)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombres");
        }
    }
}

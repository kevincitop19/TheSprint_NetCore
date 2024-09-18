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
    public class RolOpcioneConfig : IEntityTypeConfiguration<RolOpcione>
    {
        public void Configure(EntityTypeBuilder<RolOpcione> builder)
        {
            builder.HasKey(e => e.IdOpcion).HasName("PK__rol_opci__EFAF425896832761");

            builder.ToTable("rol_opciones");

            builder.Property(e => e.IdOpcion).HasColumnName("id_opcion");
            builder.Property(e => e.NombreOpcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_opcion");
        }
    }
}

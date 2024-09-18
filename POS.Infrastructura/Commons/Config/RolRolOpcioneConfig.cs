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
    public class RolRolOpcioneConfig : IEntityTypeConfiguration<RolRolOpcione>
    {
        public void Configure(EntityTypeBuilder<RolRolOpcione> builder)
        {
            builder
                .HasNoKey()
                .ToTable("rol_rol_opciones");

            builder.Property(e => e.RolIdRol).HasColumnName("rol_id_rol");
            builder.Property(e => e.RolOpcionesIdOpcion).HasColumnName("rol_opciones_id_opcion");

            builder.HasOne(d => d.RolIdRolNavigation).WithMany()
                .HasForeignKey(d => d.RolIdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__rol_rol_o__rol_i__3C69FB99");

            builder.HasOne(d => d.RolOpcionesIdOpcionNavigation).WithMany()
                .HasForeignKey(d => d.RolOpcionesIdOpcion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__rol_rol_o__rol_o__3D5E1FD2");
        }
    }
}

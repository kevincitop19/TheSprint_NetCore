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
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(e => e.IdUsuario).HasName("PK__usuarios__4E3E04AD378BED3E");

            builder.ToTable("usuarios");

            builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            builder.Property(e => e.IntentosFallidos).HasColumnName("intentos_fallidos");
            builder.Property(e => e.Mail)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("mail");
            builder.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            builder.Property(e => e.PersonaIdPersona2).HasColumnName("persona_id_persona2");
            builder.Property(e => e.SessionActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("session_active");
            builder.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status");
            builder.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_name");

            builder.HasOne(d => d.PersonaIdPersona2Navigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.PersonaIdPersona2)
                .HasConstraintName("FK__usuarios__person__4CA06362");
        }
    }
}

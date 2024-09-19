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
            builder.HasKey(e => e.id_usuario).HasName("PK__usuarios__4E3E04AD378BED3E");

            builder.ToTable("usuarios");

            builder.Property(e => e.id_usuario)
                .HasColumnName("id_usuario")
                ;
            builder.Property(e => e.intentos_fallidos).HasColumnName("intentos_fallidos");
            builder.Property(e => e.mail)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("mail");
            builder.Property(e => e.password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            builder.Property(e => e.persona_id_persona2).HasColumnName("persona_id_persona2");
            builder.Property(e => e.session_active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("session_active");
            builder.Property(e => e.status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("status");
            builder.Property(e => e.user_name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_name");

            builder.HasOne(d => d.Persona)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.persona_id_persona2)
                .HasConstraintName("FK__usuarios__person__4CA06362");
        }
    }
}

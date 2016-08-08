using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Entity.Admin;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data.Configuration.Admin
{
    public class UsuarioPerfilConfiguration : EntityTypeConfiguration<UsuarioPerfil>
    {
        public UsuarioPerfilConfiguration()
        {
            ToTable("UsuarioPerfil", "Comum");

            Property(l => l.Id)
               .HasColumnName("codigo")
               .HasColumnOrder(1);

            Property(l => l.UsuarioId)
               .HasColumnName("usuario")
               .HasColumnOrder(2);

            HasRequired<Usuario>(l => l.Usuario)
               .WithMany(l => l.ListaUsuarioPerfil);

            Property(l => l.ModuloId)
               .HasColumnName("sistema")
               .HasColumnOrder(3);

            Property(l => l.PerfilId)
               .HasColumnName("perfil")
               .HasColumnOrder(4);

        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Entity.Admin;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data.Configuration.Admin
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            ToTable("Usuario", "Comum");

            Property(l => l.Id)
                .HasColumnName("codigo")
                .HasColumnOrder(1);

            Property(l => l.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnOrder(2);

            Property(l => l.Login)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnOrder(3);

            Property(l => l.AssinaturaEletronica)
                .HasColumnType("image")
                .HasColumnName("assinaturaEletronica")
                .HasColumnOrder(5);

            Property(l => l.Situacao)
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(1)
                .HasColumnName("situacao")
                .HasColumnOrder(6);

            Property(l => l.Senha)
                .HasMaxLength(64)
                .HasColumnName("senhaWeb")
                .HasMaxLength(64)
                .HasColumnOrder(7);

            Ignore(l => l.Ativo);

            //Ignore(l => l.ParametrosUsuarioId);

            //Ignore(l => l.ParametrosUsuarioFinanceiroId);

            //HasRequired(l => l.ParametrosUsuario).WithRequiredPrincipal(l => l.Usuario);

            //HasRequired(l => l.ParametrosUsuarioFinanceiro).WithRequiredPrincipal(l => l.Usuario);

            //HasMany<UsuarioFuncionalidade>(l => l.ListaUsuarioFuncionalidade)
            //   .WithRequired(c => c.Usuario)
            //   .HasForeignKey(c => c.UsuarioId);

            //HasMany<UsuarioPerfil>(l => l.ListaUsuarioPerfil)
            //   .WithRequired(c => c.Usuario)
            //   .HasForeignKey(c => c.UsuarioId);

            //TODO: Implementar controle de acesso
            //Ignore(l => l.ListaFuncionalidade);
            //Ignore(l => l.ListaPerfil);
            //HasMany(l => l.ListaFuncionalidade).WithMany(l => l.ListaUsuario)
            //    .Map(m =>
            //    {
            //        m.ToTable("UsuarioFuncionalidade", "Sigim");
            //        m.MapLeftKey("UsuarioId");
            //        m.MapRightKey("FuncionalidadeId");
            //    });

            //HasMany(l => l.ListaPerfil).WithMany(l => l.ListaUsuario)
            //    .Map(m =>
            //    {
            //        m.ToTable("UsuarioPerfil", "Sigim");
            //        m.MapLeftKey("UsuarioId");
            //        m.MapRightKey("PerfilId");
            //    });
        }
    }
}
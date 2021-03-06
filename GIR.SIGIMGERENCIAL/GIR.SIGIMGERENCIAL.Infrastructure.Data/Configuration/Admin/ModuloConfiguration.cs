﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Entity.Admin;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data.Configuration.Admin
{
    public class ModuloConfiguration : EntityTypeConfiguration<Modulo>
    {
        public ModuloConfiguration()
        {
            ToTable("Sistema", "Comum");

            Property(l => l.Id)
                .HasColumnName("codigo")
                .HasColumnOrder(1);

            Property(l => l.Nome)
                .HasMaxLength(100)
                .HasColumnName("nome")
                .HasColumnOrder(2);

            Property(l => l.NomeCompleto)
                .HasMaxLength(100)
                .HasColumnName("nomeCompleto")
                .HasColumnOrder(3);

            Property(l => l.ChaveAcesso)
                .HasMaxLength(500)
                .HasColumnName("chaveAcesso")
                .HasColumnOrder(4);

            Property(l => l.Versao)
                .HasMaxLength(20)
                .HasColumnName("versao")
                .HasColumnOrder(5);

            Property(l => l.Bloqueio)
                .HasColumnName("bloqueio")
                .HasColumnType("bit")
                .HasColumnOrder(6);

            //TODO: Implementar controle de acesso
            //Ignore(l => l.ListaFuncionalidade);
            Ignore(l => l.ListaPerfil);
            //HasMany(l => l.ListaFuncionalidade).WithRequired(l => l.Modulo);

            //HasMany(l => l.ListaPerfil).WithRequired(l => l.Modulo);
        }
    }
}
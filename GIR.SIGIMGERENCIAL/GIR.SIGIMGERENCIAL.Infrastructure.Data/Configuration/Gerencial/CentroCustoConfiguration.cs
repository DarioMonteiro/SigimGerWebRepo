using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Entity.Gerencial;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data.Configuration.Gerencial
{
    public class CentroCustoConfiguration : EntityTypeConfiguration<CentroCusto>
    {

        public CentroCustoConfiguration()
        {
            ToTable("CentroCusto", "Gerencial");

            Ignore(l => l.Id);

            HasKey(l => l.Codigo);

            Property(l => l.Codigo)
                .IsRequired()
                .HasMaxLength(18)
                .HasColumnName("codigo");

            Property(l => l.Descricao)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("descricao");

            Property(l => l.Ativo)
                .IsRequired()
                .HasColumnType("bit")
                .HasColumnName("situacao");

            Property(l => l.CodigoPai)
                .HasMaxLength(18)
                .HasColumnName("pai");

            HasOptional(l => l.CentroCustoPai)
                .WithMany(l => l.ListaFilhos)
                .HasForeignKey(l => l.CodigoPai);

        }
    }
}

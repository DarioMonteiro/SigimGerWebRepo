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
    public class ValorPotencialLiquidoConfiguration : EntityTypeConfiguration<ValorPotencialLiquido>
    {
        public ValorPotencialLiquidoConfiguration()
        {
            ToTable("ValorPotencialLiquido", "Gerencial");

            Property(l => l.Id)
                .HasColumnName("codigo")
                .HasColumnOrder(1);

            Property(l => l.CodigoCentroCusto)
                .HasMaxLength(18)
                .HasColumnName("centroCusto")
                .HasColumnOrder(2);

            HasRequired<CentroCusto>(l => l.CentroCusto)
                .WithMany(l => l.ListaValorPotencialLiquido)
                .HasForeignKey(l => l.CodigoCentroCusto);

            Property(l => l.VGVEstoque)
                .HasColumnName("vgvEstoque")
                .HasPrecision(18, 2)
                .HasColumnOrder(3);

            Property(l => l.ImpostosVGVEstoque)
                .HasColumnName("impostosVgvEstoque")
                .HasPrecision(18, 2)
                .HasColumnOrder(4);

            Property(l => l.Corretagem)
                .HasColumnName("corretagem")
                .HasPrecision(18, 2)
                .HasColumnOrder(5);

            Property(l => l.Publicidade)
                .HasColumnName("publicidade")
                .HasPrecision(18, 2)
                .HasColumnOrder(6);

            Property(l => l.Investimento)
                .HasColumnName("investimento")
                .HasPrecision(18, 2)
                .HasColumnOrder(7);

            Property(l => l.VGVEstoqueLiquido)
                .HasColumnName("vgvEstoqueLiquido")
                .HasPrecision(18, 2)
                .HasColumnOrder(8);

            Property(l => l.RecebiveisEmVPL)
                .HasColumnName("recebiveisEmVPL")
                .HasPrecision(18, 2)
                .HasColumnOrder(9);

            Property(l => l.ImpostosRecebiveisEmVPL)
                .HasColumnName("impostosRecebiveisEmVPL")
                .HasPrecision(18, 2)
                .HasColumnOrder(10);

            Property(l => l.RecebiveisLiquido)
                .HasColumnName("recebiveisLiquido")
                .HasPrecision(18, 2)
                .HasColumnOrder(11);

            Property(l => l.ValorTotal)
                .HasColumnName("valorTotal")
                .HasPrecision(18, 2)
                .HasColumnOrder(12);
        }

    }
}

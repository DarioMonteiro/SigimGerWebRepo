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
    public class FluxoFinanceiroConfiguration : EntityTypeConfiguration<FluxoFinanceiro>
    {

        public FluxoFinanceiroConfiguration()
        {
            ToTable("FluxoFinanceiro", "Gerencial");

            Property(l => l.Id)
                .HasColumnName("codigo")
                .HasColumnOrder(1);

            Property(l => l.CodigoCentroCusto)
                .HasMaxLength(18)
                .HasColumnName("centroCusto")
                .HasColumnOrder(2);

            HasRequired<CentroCusto>(l => l.CentroCusto)
                .WithMany(l => l.ListaFluxoFinanceiro)
                .HasForeignKey(l => l.CodigoCentroCusto);

            Property(l => l.Ano)
                .HasColumnName("ano")
                .HasColumnOrder(3);

            Property(l => l.Mes)
                .HasColumnName("mes")
                .HasColumnOrder(4);

            Property(l => l.Item)
                .HasColumnName("item")
                .HasMaxLength(100)
                .HasColumnOrder(5);

            Property(l => l.Ordem)
                .HasColumnName("ordem")
                .HasColumnOrder(6);

            Property(l => l.Valor)
                .HasColumnName("valor")
                .HasPrecision(18, 2)
                .HasColumnOrder(7);

        }

    }

}

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
    public class ValorPotencialConfiguration : EntityTypeConfiguration<ValorPotencial>
    {
        public ValorPotencialConfiguration()
        {
            ToTable("ValorPotencial", "Gerencial");

            Property(l => l.Id)
                .HasColumnName("codigo")
                .HasColumnOrder(1);

            Property(l => l.CodigoCentroCusto)
                .HasMaxLength(18)
                .HasColumnName("centroCusto")
                .HasColumnOrder(2);

            HasRequired<CentroCusto>(l => l.CentroCusto)
                .WithMany(l => l.ListaValorPotencial)
                .HasForeignKey(l => l.CodigoCentroCusto);

            Property(l => l.VgvEstoqueMoeda)
                .HasColumnName("vgvEstoqueMoeda")
                .HasPrecision(18,2)
                .HasColumnOrder(3);

            Property(l => l.VgvEstoquePercentual)
                .HasColumnName("vgvEstoquePercentual")
                .HasPrecision(18, 5)
                .HasColumnOrder(4);

            Property(l => l.RecebivelVplMoeda)
                .HasColumnName("recebivelVplMoeda")
                .HasPrecision(18, 2)
                .HasColumnOrder(5);

            Property(l => l.RecebivelVplPercentual)
                .HasColumnName("recebivelVplPercentual")
                .HasPrecision(18, 5)
                .HasColumnOrder(6);

            Property(l => l.TotalMoeda)
                .HasColumnName("totalMoeda")
                .HasPrecision(18, 2)
                .HasColumnOrder(7);

            Property(l => l.TotalPercentual)
                .HasColumnName("totalPercentual")
                .HasPrecision(18, 5)
                .HasColumnOrder(8);
        }

    }
}

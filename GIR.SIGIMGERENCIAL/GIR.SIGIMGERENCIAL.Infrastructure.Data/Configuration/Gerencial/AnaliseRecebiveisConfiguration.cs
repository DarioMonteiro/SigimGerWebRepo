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
    public class AnaliseRecebiveisConfiguration : EntityTypeConfiguration<AnaliseRecebiveis>
    {
        public AnaliseRecebiveisConfiguration()
        {
            ToTable("AnaliseRecebiveis", "Gerencial");

            Property(l => l.Id)
                .HasColumnName("codigo")
                .HasColumnOrder(1);

            Property(l => l.CodigoCentroCusto)
                .HasMaxLength(18)
                .HasColumnName("centroCusto")
                .HasColumnOrder(2);

            HasRequired<CentroCusto>(l => l.CentroCusto)
                .WithMany(l => l.ListaAnaliseRecebiveis)
                .HasForeignKey(l => l.CodigoCentroCusto);

            Property(l => l.RecebiveisMoeda)
                .HasColumnName("recebiveisMoeda")
                .HasPrecision(18, 2)
                .HasColumnOrder(3);

            Property(l => l.ContratosEmDiaQtd)
                .HasColumnName("contratosEmDiaQtd")
                .HasColumnOrder(4);

            Property(l => l.EmAtrasoMoeda)
                .HasColumnName("emAtrasoMoeda")
                .HasPrecision(18, 2)
                .HasColumnOrder(4);

            Property(l => l.ContratosEmAtrasoQtd)
                .HasColumnName("contratosEmAtrasoQtd")
                .HasColumnOrder(5);

            Property(l => l.AtrasadosEncargo)
                .HasColumnName("atrasadosEncargo")
                .HasPrecision(18, 2)
                .HasColumnOrder(6);

            Property(l => l.TaxaInadimplencia)
                .HasColumnName("taxaInadimplencia")
                .HasPrecision(18, 5)
                .HasColumnOrder(7);
        }
    }
}

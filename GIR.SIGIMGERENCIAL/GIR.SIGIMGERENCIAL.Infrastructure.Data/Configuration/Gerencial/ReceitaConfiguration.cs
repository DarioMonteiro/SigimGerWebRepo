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
    public class ReceitaConfiguration : EntityTypeConfiguration<Receita>
    {
        public ReceitaConfiguration()
        {
            ToTable("Receita", "Gerencial");

            Property(l => l.Id)
                .HasColumnName("codigo")
                .HasColumnOrder(1);

            Property(l => l.CodigoCentroCusto)
                .HasMaxLength(18)
                .HasColumnName("centroCusto")
                .HasColumnOrder(2);

            HasRequired<CentroCusto>(l => l.CentroCusto)
                .WithMany(l => l.ListaReceita)
                .HasForeignKey(l => l.CodigoCentroCusto);

            Property(l => l.RecebidoMoeda)
                .HasColumnName("recebidoMoeda")
                .HasPrecision(18, 2)
                .HasColumnOrder(3);

            Property(l => l.RecebiveisMoeda)
                .HasColumnName("recebiveisMoeda")
                .HasPrecision(18, 2)
                .HasColumnOrder(4);

            Property(l => l.AReceberSemJurosMoeda)
                .HasColumnName("aReceberSemJurosMoeda")
                .HasPrecision(18, 2)
                .HasColumnOrder(5);
        }

    }
}

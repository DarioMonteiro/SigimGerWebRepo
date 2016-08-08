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
    public class AnaliseInadimplenciaConfiguration : EntityTypeConfiguration<AnaliseInadimplencia>
    {

        public AnaliseInadimplenciaConfiguration()
        {
            ToTable("AnaliseInadimplencia", "Gerencial");

            Property(l => l.Id)
                .HasColumnName("codigo")
                .HasColumnOrder(1);

            Property(l => l.CodigoCentroCusto)
                .HasMaxLength(18)
                .HasColumnName("centroCusto")
                .HasColumnOrder(2);

            HasRequired<CentroCusto>(l => l.CentroCusto)
                .WithMany(l => l.ListaAnaliseInadimplencia)
                .HasForeignKey(l => l.CodigoCentroCusto);

            Property(l => l.Valor60DiasMoeda)
                .HasColumnName("valor60DiasMoeda")
                .HasPrecision(18, 2)
                .HasColumnOrder(3);

            Property(l => l.Unidade60DiasQtd)
                .HasColumnName("unidade60DiasQtd")
                .HasColumnOrder(4);

            Property(l => l.ValorMais60DiasMoeda)
                .HasColumnName("valorMais60DiasMoeda")
                .HasPrecision(18, 2)
                .HasColumnOrder(5);

            Property(l => l.UnidadeMais60DiasQtd)
                .HasColumnName("unidadeMais60DiasQtd")
                .HasColumnOrder(6);

            Property(l => l.ValorJuridicoMoeda)
                .HasColumnName("valorJuridicoMoeda")
                .HasPrecision(18, 2)
                .HasColumnOrder(7);

            Property(l => l.UnidadeJuridicoQtd)
                .HasColumnName("unidadeJuridicoQtd")
                .HasColumnOrder(8);

        }
    }
}

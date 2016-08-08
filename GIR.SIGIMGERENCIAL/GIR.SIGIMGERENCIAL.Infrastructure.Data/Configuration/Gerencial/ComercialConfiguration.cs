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
    public class ComercialConfiguration : EntityTypeConfiguration<Comercial>
    {
        public ComercialConfiguration()
        {
            ToTable("ValorPotencial", "Comercial");

            Property(l => l.Id)
                .HasColumnName("codigo")
                .HasColumnOrder(1);

            Property(l => l.CodigoCentroCusto)
                .HasMaxLength(18)
                .HasColumnName("centroCusto")
                .HasColumnOrder(2);

            HasRequired<CentroCusto>(l => l.CentroCusto)
                .WithMany(l => l.ListaComercial)
                .HasForeignKey(l => l.CodigoCentroCusto);

            Property(l => l.VgvContratoAssinadoMoeda)
                .HasColumnName("vgvContratoAssinadoMoeda")
                .HasPrecision(18, 2)
                .HasColumnOrder(3);

            Property(l => l.UnidadeVendidaQtd)
                .HasColumnName("unidadeVendidaQtd")
                .HasColumnOrder(4);

            Property(l => l.VgvEstoqueMoeda)
                .HasColumnName("vgvEstoqueMoeda")
                .HasPrecision(18, 2)
                .HasColumnOrder(5);

            Property(l => l.VgvEstoqueQtd)
                .HasColumnName("vgvEstoqueQtd")
                .HasColumnOrder(6);
        }
    }
}

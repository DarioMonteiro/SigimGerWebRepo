using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Entity.Gerencial;

namespace GIR.SIGIMGERENCIAL.Domain.Specification.Gerencial
{
    public class ValorPotencialSpecification : BaseSpecification<ValorPotencial>
    {

        public static Specification<ValorPotencial> PertenceAoCentroCustoPai(string codigoCentroCustoPai)
        {
            Specification<ValorPotencial> specification = new TrueSpecification<ValorPotencial>();

            if (!string.IsNullOrEmpty(codigoCentroCustoPai))
            {
                var directSpecification = new DirectSpecification<ValorPotencial>(l => l.CentroCusto.CodigoPai == codigoCentroCustoPai);
                specification &= directSpecification;
            }

            return specification;
        }

    }
}

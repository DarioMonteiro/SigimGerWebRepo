using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIR.SIGIMGERENCIAL.Domain.Entity.Gerencial
{
    public class AnaliseRecebiveis : BaseEntity
    {
        public string CodigoCentroCusto { get; set; }
        public CentroCusto CentroCusto { get; set; }
        public Decimal RecebiveisMoeda { get; set; }
        public int ContratosEmDiaQtd { get; set; }
        public Decimal EmAtrasoMoeda { get; set; }
        public int ContratosEmAtrasoQtd { get; set; }
        public Decimal AtrasadosEncargo { get; set; }
        public Decimal TaxaInadimplencia { get; set; }

    }
}

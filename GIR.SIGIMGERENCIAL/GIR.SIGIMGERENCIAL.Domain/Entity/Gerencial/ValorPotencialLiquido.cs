using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIR.SIGIMGERENCIAL.Domain.Entity.Gerencial
{
    public class ValorPotencialLiquido : BaseEntity
    {
        public string CodigoCentroCusto { get; set; }
        public CentroCusto CentroCusto { get; set; }
        public Decimal VGVEstoque { get; set; }
        public Decimal ImpostosVGVEstoque { get; set; }
        public Decimal Corretagem { get; set; }
        public Decimal Publicidade { get; set; }
        public Decimal Investimento { get; set; }
        public Decimal VGVEstoqueLiquido { get; set; }
        public Decimal RecebiveisEmVPL { get; set; }
        public Decimal ImpostosRecebiveisEmVPL { get; set; }
        public Decimal RecebiveisLiquido { get; set; }
        public Decimal ValorTotal { get; set; }

    }
}

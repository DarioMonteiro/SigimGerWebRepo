using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIR.SIGIMGERENCIAL.Domain.Entity.Gerencial
{
    public class Receita : BaseEntity
    {
        public string CodigoCentroCusto { get; set; }
        public CentroCusto CentroCusto { get; set; }
        public Decimal RecebidoMoeda { get; set; }
        public Decimal RecebiveisMoeda { get; set; }
        public Decimal AReceberSemJurosMoeda { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIR.SIGIMGERENCIAL.Domain.Entity.Gerencial
{
    public class Comercial : BaseEntity
    {
        public string CodigoCentroCusto { get; set; }
        public CentroCusto CentroCusto { get; set; }
        public Decimal VgvContratoAssinadoMoeda { get; set; }
        public int UnidadeVendidaQtd { get; set; }
        public Decimal VgvEstoqueMoeda { get; set; }
        public Decimal VgvEstoqueQtd { get; set; }
    }
}

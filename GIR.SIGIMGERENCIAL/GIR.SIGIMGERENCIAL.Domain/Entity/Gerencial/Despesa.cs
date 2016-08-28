using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIR.SIGIMGERENCIAL.Domain.Entity.Gerencial
{
    public class Despesa : BaseEntity
    {
        public string CodigoCentroCusto { get; set; }
        public CentroCusto CentroCusto { get; set; }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public string Item { get; set; }
        public int Ordem { get; set; }
        public Decimal Valor { get; set; }
    }
}

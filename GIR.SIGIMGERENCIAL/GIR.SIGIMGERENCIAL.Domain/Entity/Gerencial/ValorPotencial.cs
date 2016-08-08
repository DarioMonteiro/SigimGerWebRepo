using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIR.SIGIMGERENCIAL.Domain.Entity.Gerencial
{
    public class ValorPotencial : BaseEntity
    {
        public string CodigoCentroCusto { get; set; }
        public CentroCusto CentroCusto { get; set; }
        public Decimal VgvEstoqueMoeda { get; set; }
        public Decimal VgvEstoquePercentual { get; set; }
        public Decimal RecebivelVplMoeda { get; set; }
        public Decimal RecebivelVplPercentual { get; set; }
        public Decimal TotalMoeda { get; set; }
        public Decimal TotalPercentual { get; set; }
    }
}

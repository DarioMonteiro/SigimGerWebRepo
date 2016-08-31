using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIR.SIGIMGERENCIAL.Application.DTO.Gerencial
{
    public class ValorPotencialDTO : BaseDTO
    {
        public string CodigoCentroCusto { get; set; }
        public CentroCustoDTO CentroCusto { get; set; }

        public Decimal VgvEstoqueMoeda { get; set; }
        public Decimal VgvEstoquePercentual { get; set; }
        public Decimal RecebivelVplMoeda { get; set; }
        public Decimal RecebivelVplPercentual { get; set; }
        public Decimal TotalMoeda { get; set; }
        public Decimal TotalPercentual { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIR.SIGIMGERENCIAL.Domain.Entity.Gerencial
{
    public class AnaliseInadimplencia : BaseEntity
    {
        public string CodigoCentroCusto { get; set; }
        public CentroCusto CentroCusto { get; set; }
        public Decimal Valor60DiasMoeda { get; set; }
        public int Unidade60DiasQtd { get; set; }
        public Decimal ValorMais60DiasMoeda { get; set; }
        public int UnidadeMais60DiasQtd { get; set; }
        public Decimal ValorJuridicoMoeda { get; set; }
        public int UnidadeJuridicoQtd { get; set; }
    }
}

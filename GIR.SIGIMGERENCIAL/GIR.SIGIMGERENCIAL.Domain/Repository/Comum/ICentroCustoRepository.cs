using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Entity.Gerencial;

namespace GIR.SIGIMGERENCIAL.Domain.Repository.Gerencial
{
    public interface ICentroCustoRepository : IRepository<CentroCusto>
    {
        CentroCusto ObterPeloCodigo(string codigo, params Expression<Func<CentroCusto, object>>[] includes);
    }
}

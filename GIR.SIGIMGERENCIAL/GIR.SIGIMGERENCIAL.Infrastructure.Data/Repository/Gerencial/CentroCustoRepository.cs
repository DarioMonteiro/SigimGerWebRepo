using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Entity.Gerencial;
using GIR.SIGIMGERENCIAL.Domain.Repository.Gerencial;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data.Repository.Gerencial
{
    public class CentroCustoRepository : Repository<CentroCusto>, ICentroCustoRepository
    {
        #region Constructor

        public CentroCustoRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        #endregion

        #region ICentroCustoRepository Members

        public CentroCusto ObterPeloCodigo(string codigo, params Expression<Func<CentroCusto, object>>[] includes)
        {
            var set = QueryableUnitOfWork.CreateSet<CentroCusto>().AsQueryable<CentroCusto>();

            if (includes.Any())
                set = includes.Aggregate(set, (current, expression) => current.Include(expression));

            return set.Where(l => l.Codigo == codigo).SingleOrDefault();
        }

        #endregion

    }
}

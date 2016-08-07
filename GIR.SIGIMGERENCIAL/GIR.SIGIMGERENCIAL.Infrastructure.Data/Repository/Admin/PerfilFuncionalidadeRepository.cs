using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Entity.Admin;
using GIR.SIGIMGERENCIAL.Domain.Repository.Admin;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data.Repository.Admin
{
    public class PerfilFuncionalidadeRepository : Repository<PerfilFuncionalidade>, IPerfilFuncionalidadeRepository
    {
        #region Constructor

        public PerfilFuncionalidadeRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        #endregion

        #region IPerfilFuncionalidadeRepository Members

        #endregion
    }
}
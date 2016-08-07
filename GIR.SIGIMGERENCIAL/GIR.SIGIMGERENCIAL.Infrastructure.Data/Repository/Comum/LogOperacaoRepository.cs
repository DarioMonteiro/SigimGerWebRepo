using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Entity.Comum;
using GIR.SIGIMGERENCIAL.Domain.Repository.Comum;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data.Repository.Comum
{
    public class LogOperacaoRepository : Repository<LogOperacao>, ILogOperacaoRepository
    {
        #region Constructor

        public LogOperacaoRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        #endregion
    }
}
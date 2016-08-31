using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Entity.Gerencial;
using GIR.SIGIMGERENCIAL.Domain.Repository.Gerencial;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data.Repository.Gerencial
{
    public class ValorPotencialRepository : Repository<ValorPotencial>, IValorPotencialRepository
    {
        #region Constructor

        public ValorPotencialRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Entity.Admin;
using GIR.SIGIMGERENCIAL.Domain.Repository.Admin;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data.Repository.Admin
{
    public class ModuloRepository : Repository<Modulo>, IModuloRepository
    {
        #region Constructor

        public ModuloRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        #endregion

        #region IModuloRepository Members

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Entity.Admin;
using GIR.SIGIMGERENCIAL.Domain.Repository.Admin;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data.Repository.Admin
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        #region Constructor

        public UsuarioRepository(UnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        #endregion

        #region IUsuarioRepository Members

        public Usuario ObterPeloLogin(string login)
        {
            return QueryableUnitOfWork.CreateSet<Usuario>().Where(l => l.Login == login).SingleOrDefault();
        }

        public void RemoverFuncionalidade(UsuarioFuncionalidade item)
        {
            if (item != (UsuarioFuncionalidade)null)
            {
                QueryableUnitOfWork.Attach(item);
                QueryableUnitOfWork.CreateSet<UsuarioFuncionalidade>().Remove(item);
            }
        }

        public void RemoverPerfil(UsuarioPerfil item)
        {
            if (item != (UsuarioPerfil)null)
            {
                QueryableUnitOfWork.Attach(item);
                QueryableUnitOfWork.CreateSet<UsuarioPerfil>().Remove(item);
            }
        }

        #endregion
    }
}
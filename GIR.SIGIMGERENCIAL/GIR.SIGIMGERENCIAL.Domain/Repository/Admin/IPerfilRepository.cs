using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Entity.Admin;

namespace GIR.SIGIMGERENCIAL.Domain.Repository.Admin
{
    public interface IPerfilRepository : IRepository<Perfil>
    {
        List<Perfil> ListarPeloModulo(int moduloId);
    }
}
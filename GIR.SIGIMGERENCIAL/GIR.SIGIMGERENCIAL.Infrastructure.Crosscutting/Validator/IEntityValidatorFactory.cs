using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.Validato
{
    public interface IEntityValidatorFactory
    {
        IEntityValidator Create();
    }
}
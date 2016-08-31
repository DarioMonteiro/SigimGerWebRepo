using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.IoC;
using GIR.SIGIMGERENCIAL.Infrastructure.Data.Repository.Gerencial;
using Microsoft.Practices.Unity;
using GIR.SIGIMGERENCIAL.Domain.Repository.Gerencial;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data.IoC
{
    public class GerencialBootstrapper
    {
        public static void Initialise()
        {
            Container.Current.RegisterType<ICentroCustoRepository, CentroCustoRepository>();
            Container.Current.RegisterType<IValorPotencialRepository, ValorPotencialRepository>();
        }

    }
}

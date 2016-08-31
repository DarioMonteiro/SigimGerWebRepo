using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.IoC;
using GIR.SIGIMGERENCIAL.Application.Service.Gerencial;

namespace GIR.SIGIMGERENCIAL.Application.Service.IoC
{
    public class GerencialBootstrapper
    {
        public static void Initialise()
        {
            Container.Current.RegisterType<ICentroCustoAppService, CentroCustoAppService>();
            Container.Current.RegisterType<IValorPotencialAppService, ValorPotencialAppService>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.IoC;
using Microsoft.Practices.Unity;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data.IoC
{
    public class Bootstrapper
    {
        public static void Initialise()
        {
            Container.Current.RegisterType(typeof(UnitOfWork), new PerResolveLifetimeManager());

            AdminBootstrapper.Initialise();
            ComumBootstrapper.Initialise();
            GerencialBootstrapper.Initialise();
        }
    }
}
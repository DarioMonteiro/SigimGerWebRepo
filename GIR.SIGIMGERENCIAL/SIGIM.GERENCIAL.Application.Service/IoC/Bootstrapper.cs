using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIR.SIGIMGERENCIAL.Application.Service.IoC
{
    public class Bootstrapper
    {
        public static void Initialise()
        {
            GIR.SIGIMGERENCIAL.Infrastructure.Data.IoC.Bootstrapper.Initialise();
            AdminBootstrapper.Initialise();
            GerencialBootstrapper.Initialise();
        }
    }
}
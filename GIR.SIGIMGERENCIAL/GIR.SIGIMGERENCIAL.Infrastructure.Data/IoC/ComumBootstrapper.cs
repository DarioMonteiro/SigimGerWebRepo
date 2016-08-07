using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.IoC;
using GIR.SIGIMGERENCIAL.Infrastructure.Data.Repository.Comum;
using Microsoft.Practices.Unity;
using GIR.SIGIMGERENCIAL.Domain.Repository.Comum;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data.IoC
{
    public class ComumBootstrapper
    {
        public static void Initialise()
        {
            Container.Current.RegisterType<ILogAcessoRepository, LogAcessoRepository>();
            Container.Current.RegisterType<ILogOperacaoRepository, LogOperacaoRepository>();
        }

    }
}

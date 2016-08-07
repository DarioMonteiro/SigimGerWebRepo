using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Application.Service.Admin;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.IoC;
using Microsoft.Practices.Unity;

namespace GIR.SIGIMGERENCIAL.Application.Service.IoC
{
    public class AdminBootstrapper
    {
        public static void Initialise()
        {
            //Container.Current.RegisterType<IFuncionalidadeAppService, FuncionalidadeAppService>();
            //Container.Current.RegisterType<IModuloAppService, ModuloAppService>();
            //Container.Current.RegisterType<IPerfilAppService, PerfilAppService>();
            Container.Current.RegisterType<IUsuarioAppService, UsuarioAppService>();
            //Container.Current.RegisterType<IUsuarioFuncionalidadeAppService, UsuarioFuncionalidadeAppService>();
        }
    }
}
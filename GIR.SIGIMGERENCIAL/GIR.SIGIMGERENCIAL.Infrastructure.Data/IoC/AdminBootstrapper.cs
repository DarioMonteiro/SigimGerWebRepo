using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Repository.Admin;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.IoC;
using GIR.SIGIMGERENCIAL.Infrastructure.Data.Repository.Admin;
using Microsoft.Practices.Unity;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Data.IoC
{
    public class AdminBootstrapper
    {
        public static void Initialise()
        {
            Container.Current.RegisterType<IModuloRepository, ModuloRepository>();
            Container.Current.RegisterType<IPerfilFuncionalidadeRepository, PerfilFuncionalidadeRepository>();
            Container.Current.RegisterType<IPerfilRepository, PerfilRepository>();
            Container.Current.RegisterType<IUsuarioRepository, UsuarioRepository>();
            Container.Current.RegisterType<IUsuarioFuncionalidadeRepository, UsuarioFuncionalidadeRepository>();
        }
    }
}
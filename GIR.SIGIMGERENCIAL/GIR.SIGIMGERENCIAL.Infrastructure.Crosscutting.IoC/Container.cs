using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.Adapter;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.Notification;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.Security;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.Validato;
using Microsoft.Practices.Unity;

namespace GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.IoC
{
    public static class Container
    {
        #region Properties

        static IUnityContainer currentContainer;
        public static IUnityContainer Current
        {
            get
            {
                return currentContainer;
            }
        }

        #endregion

        #region Constructor

        static Container()
        {
            ConfigureContainer();
            ConfigureFactories();
        }

        #endregion

        #region Methods

        static void ConfigureContainer()
        {
            currentContainer = new UnityContainer();

            currentContainer.RegisterType(typeof(MessageQueue), new PerResolveLifetimeManager());

            #region Adapter

            currentContainer.RegisterType<ITypeAdapterFactory, AutomapperTypeAdapterFactory>(new ContainerControlledLifetimeManager());

            #endregion
        }

        static void ConfigureFactories()
        {
            //LoggerFactory.SetCurrent(new TraceSourceLogFactory());
            EntityValidatorFactory.SetCurrent(new DataAnnotationsEntityValidatorFactory());

            AuthenticationServiceFactory.SetCurrent(new FormsAuthenticationFactory());

            var typeAdapterFactory = currentContainer.Resolve<ITypeAdapterFactory>();
            TypeAdapterFactory.SetCurrent(typeAdapterFactory);
        }

        #endregion
    }
}
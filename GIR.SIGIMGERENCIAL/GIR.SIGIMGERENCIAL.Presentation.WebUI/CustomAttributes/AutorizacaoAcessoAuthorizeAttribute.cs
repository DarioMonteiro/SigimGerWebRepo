﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.IoC;
using Microsoft.Practices.Unity;
using GIR.SIGIMGERENCIAL.Application.DTO.Comum;
//using GIR.SIGIMGERENCIAL.Application.Service.Comum;
using GIR.SIGIMGERENCIAL.Application.Service.Admin;

namespace GIR.SIGIMGERENCIAL.Presentation.WebUI.CustomAttributes
{
    public class AutorizacaoAcessoAuthorizeAttribute : AuthorizeAttribute
    {
        private string modulo;
        public AutorizacaoAcessoAuthorizeAttribute(string modulo)
        {
            this.modulo = modulo;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //var moduloSigimAppService = Container.Current.Resolve<IModuloSigimAppService>();
            //var moduloAppService = Container.Current.Resolve<IModuloAppService>();
            //var acessoAppService = Container.Current.Resolve<IAcessoAppService>();

            //string paramLogGIRCliente = System.Web.Configuration.WebConfigurationManager.AppSettings["LogGIRCliente"];
            //bool logGIRCliente = false;
            //if (!string.IsNullOrEmpty(paramLogGIRCliente))
            //{
            //    if (paramLogGIRCliente == "1")
            //    {
            //        logGIRCliente = true;
            //    }
            //}

            //InformacaoConfiguracaoDTO informacaoConfiguracao = moduloSigimAppService.SetarInformacaoConfiguracao(logGIRCliente, httpContext.Request.UserHostName);

            //if (!moduloAppService.PossuiModulo(modulo))
            //{
            //    return false;
            //}

            //if (!acessoAppService.ValidaAcessoAoModulo(modulo, informacaoConfiguracao))
            //{
            //    return false;
            //}

            return base.AuthorizeCore(httpContext);
        }
    }
}

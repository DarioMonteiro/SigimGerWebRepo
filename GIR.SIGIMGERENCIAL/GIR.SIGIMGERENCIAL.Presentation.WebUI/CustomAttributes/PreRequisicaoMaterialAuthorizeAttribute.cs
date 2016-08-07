using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
//using GIR.SIGIMGERENCIAL.Application.Service.OrdemCompra;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.IoC;
using Microsoft.Practices.Unity;

namespace GIR.SIGIMGERENCIAL.Presentation.WebUI.CustomAttributes
{
    public class PreRequisicaoMaterialAuthorizeAttribute : AutorizacaoAcessoAuthorizeAttribute
    {
        private string modulo;
        public PreRequisicaoMaterialAuthorizeAttribute(string modulo) : base(modulo) 
        {
            this.modulo = modulo;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool autorizou = base.AuthorizeCore(httpContext);

            //if (autorizou)
            //{
            //    var parametrosOrdemCompraAppService = Container.Current.Resolve<IParametrosOrdemCompraAppService>();
            //    var parametrosOrdemCompra = parametrosOrdemCompraAppService.Obter();
            //    if (!parametrosOrdemCompra.EhPreRequisicaoMaterial)
            //        return false;
            //}

            return autorizou;
        }
    }
}
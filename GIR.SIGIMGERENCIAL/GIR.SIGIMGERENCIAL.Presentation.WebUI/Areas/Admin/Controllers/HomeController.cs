using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.Notification;
using GIR.SIGIMGERENCIAL.Presentation.WebUI.Controllers;
using GIR.SIGIMGERENCIAL.Application.Service.Admin;
//using GIR.SIGIMGERENCIAL.Application.Service.Sigim;
using GIR.SIGIMGERENCIAL.Application.DTO.Comum;

namespace GIR.SIGIMGERENCIAL.Presentation.WebUI.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        //private IModuloAppService moduloAppService;
        //private IAcessoAppService acessoAppService;
        //private IModuloSigimAppService moduloSigimAppService;

        //public HomeController(IModuloAppService moduloAppService,
        //                      IAcessoAppService acessoAppService,
        //                      IModuloSigimAppService moduloSigimAppService,
        //                      MessageQueue messageQueue)
        //    : base(messageQueue)
        //{
        //    this.moduloAppService = moduloAppService;
        //    this.acessoAppService = acessoAppService;
        //    this.moduloSigimAppService = moduloSigimAppService;      
        //}

        public HomeController(MessageQueue messageQueue)
            : base(messageQueue)
        {
        }


        public ActionResult Index()
        {
            //InformacaoConfiguracaoDTO informacaoConfiguracao = moduloSigimAppService.SetarInformacaoConfiguracao(this.LogGIRCliente, Request.UserHostName);

            //if (!moduloAppService.PossuiModulo(GIR.Sigim.Application.Constantes.Modulo.AdminWeb))
            //{
            //    return RedirectToAction("Index", "Painel", new { Area = "" });
            //}

            //if (!acessoAppService.ValidaAcessoAoModulo(GIR.Sigim.Application.Constantes.Modulo.AdminWeb, informacaoConfiguracao))
            //{
            //    return RedirectToAction("Index", "Painel", new { Area = "" });
            //}

            //if (!acessoAppService.ValidaAcessoGirCliente(GIR.Sigim.Application.Constantes.Modulo.AdminWeb, Usuario.Id.Value, informacaoConfiguracao))
            //{
            //    return RedirectToAction("Index", "Painel", new { Area = "" });
            //}

            return View();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GIR.SIGIMGERENCIAL.Presentation.WebUI.Controllers;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.Notification;
using GIR.SIGIMGERENCIAL.Presentation.WebUI.CustomAttributes;
using GIR.SIGIMGERENCIAL.Application.Constantes;
using GIR.SIGIMGERENCIAL.Presentation.WebUI.Areas.Gerencial.ViewModel;

namespace GIR.SIGIMGERENCIAL.Presentation.WebUI.Areas.Gerencial.Controllers
{
    public class RelGerencialController : BaseController
    {

        public RelGerencialController(MessageQueue messageQueue)
            : base(messageQueue)
        { 
        }

        [AutorizacaoAcessoAuthorize(GIR.SIGIMGERENCIAL.Application.Constantes.Modulo.GerencialWeb, Roles = Funcionalidade.RelGerencialAcessar)]
        public ActionResult Index()
        {
            RelGerencialViewModel model = new RelGerencialViewModel();
            model.PodeImprimir = true;

            return View("Index2",model);
        }

    }
}

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
using GIR.SIGIMGERENCIAL.Application.DTO.Gerencial;
using GIR.SIGIMGERENCIAL.Application.Service.Gerencial;
using Newtonsoft.Json;

namespace GIR.SIGIMGERENCIAL.Presentation.WebUI.Areas.Gerencial.Controllers
{
    public class RelGerencialController : BaseController
    {
        private IValorPotencialAppService valorPotencialAppService;

        public RelGerencialController(IValorPotencialAppService valorPotencialAppService,
                                       MessageQueue messageQueue)
            : base(messageQueue)
        {
            this.valorPotencialAppService = valorPotencialAppService;
        }

        [AutorizacaoAcessoAuthorize(GIR.SIGIMGERENCIAL.Application.Constantes.Modulo.GerencialWeb, Roles = Funcionalidade.RelGerencialAcessar)]
        public ActionResult Index()
        {
            RelGerencialViewModel model = new RelGerencialViewModel();

            string codigoCentroCusto = "2";

            List<ValorPotencialDTO> listaValorPotencial = valorPotencialAppService.ListarValorPotencialPorCentroCusto(codigoCentroCusto);

            model.JsonValorPotencial = JsonConvert.SerializeObject(listaValorPotencial, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });

            model.PodeImprimir = true;

            //return View("Index2",model);
            return View("Index3", model);
        }

        [HttpPost]
        public ActionResult RecuperaValorPotencialPorCC(string codigoCentroCusto)
        {
            List<ValorPotencialDTO> listaValorPotencial = null;

            if (!string.IsNullOrEmpty(codigoCentroCusto))
            {
                listaValorPotencial = valorPotencialAppService.ListarValorPotencialPorCentroCusto(codigoCentroCusto);
                return Json(new
                {
                    ehRecuperou = true,
                    listaValorPotencial = listaValorPotencial
                });

            }
            return Json(new
            {
                ehRecuperou = false,
                listaValorPotencial = listaValorPotencial
            });
        }
    }
}

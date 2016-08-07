using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GIR.SIGIMGERENCIAL.Presentation.WebUI.Controllers;
using GIR.SIGIMGERENCIAL.Application.DTO.Gerencial;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.Notification;
using GIR.SIGIMGERENCIAL.Application.Service.Gerencial;

namespace GIR.SIGIMGERENCIAL.Presentation.WebUI.Areas.Gerencial.Controllers
{
    public class CentroCustoController : BaseController
    {
        private ICentroCustoAppService centroCustoAppService;

        public CentroCustoController(ICentroCustoAppService centroCustoAppService, MessageQueue messageQueue)
            : base(messageQueue)
        {
            this.centroCustoAppService = centroCustoAppService;
        }

        [HttpPost]
        public ActionResult ValidaCentroCustoPorUsuario(string codigo)
        {
            var centroCusto = centroCustoAppService.ObterPeloCodigo(codigo);
            if (!string.IsNullOrEmpty(codigo))
            {
                return Json(new { ehValido = true, errorMessage = string.Empty, descricao = centroCusto.Descricao });
            }
            return Json(new { ehValido = true, errorMessage = string.Empty, descricao = string.Empty });
        }

        [HttpPost]
        public ActionResult TreeView()
        {
            var model = centroCustoAppService.ListarRaizesAtivas();
            ViewBag.FirstNode = "Centro de Custo";
            return View("~/Views/Shared/EditorTemplates/TreeView.cshtml", model);
        }

    }
}

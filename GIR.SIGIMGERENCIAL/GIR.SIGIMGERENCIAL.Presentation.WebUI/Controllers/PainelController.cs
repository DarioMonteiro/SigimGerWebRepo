using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.Notification;

namespace GIR.SIGIMGERENCIAL.Presentation.WebUI.Controllers
{
    public class PainelController : BaseController
    {
        public PainelController(MessageQueue messageQueue)
            : base(messageQueue)
        {

        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GIR.SIGIMGERENCIAL.Presentation.WebUI.Controllers;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.Notification;

namespace GIR.SIGIMGERENCIAL.Presentation.WebUI.Areas.Gerencial.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(MessageQueue messageQueue)
            : base(messageQueue)
        {

        }

        public ActionResult Index()
        {
            return View();
        }

    }
}

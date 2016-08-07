using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GIR.SIGIMGERENCIAL.Application.Filtros;

namespace GIR.SIGIMGERENCIAL.Presentation.WebUI.ViewModel
{
    public class ListaViewModel : PaginationParameters
    {
        public SelectList PageSizeList { get; set; }
        public Pagination Pagination { get; set; }
        public object Records { get; set; }
    }
}
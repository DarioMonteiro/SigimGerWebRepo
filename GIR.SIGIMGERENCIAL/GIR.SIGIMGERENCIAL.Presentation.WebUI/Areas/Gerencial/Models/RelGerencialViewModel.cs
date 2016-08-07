using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GIR.SIGIMGERENCIAL.Application.DTO.Gerencial;

namespace GIR.SIGIMGERENCIAL.Presentation.WebUI.Areas.Gerencial.ViewModel
{
    public class RelGerencialViewModel
    {
        public bool PodeImprimir { get; set; }
        public CentroCustoDTO CentroCusto { get; set; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(GIR.SIGIMGERENCIAL.Application.Resource.Comum.ErrorMessages), ErrorMessageResourceName = "InformeDataValida")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data inicial")]
        public Nullable<DateTime> DataInicial { get; set; }

        [DataType(DataType.Date, ErrorMessageResourceType = typeof(GIR.SIGIMGERENCIAL.Application.Resource.Comum.ErrorMessages), ErrorMessageResourceName = "InformeDataValida")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data final")]
        public Nullable<DateTime> DataFinal { get; set; }

        public RelGerencialViewModel()
        {
            this.DataInicial = DateTime.Now;
            this.DataFinal = DateTime.Now;
            this.CentroCusto = new CentroCustoDTO();
            CentroCusto.Codigo = "1";
            CentroCusto.Descricao = "Empresas";
        }
    }
}
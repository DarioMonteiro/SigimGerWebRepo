using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIR.SIGIMGERENCIAL.Application.DTO.Gerencial
{
    [Serializable]
    public class CentroCustoDTO :BaseDTO
    {
        [StringLength(18, ErrorMessageResourceType = typeof(Resource.Comum.ErrorMessages), ErrorMessageResourceName = "LimiteMaximoCaracteresExcedido")]
        [Display(Name = "Centro de Custo")]
        public string Codigo { get; set; }

        public string Descricao { get; set; }

        [Display(Name = "Centro de custo")]
        public string CentroCustoDescricao
        {
            get { return this.Codigo + " - " + this.Descricao; }
        }
        public bool Ativo { get; set; }
        public List<CentroCustoDTO> ListaFilhos { get; set; }

        public CentroCustoDTO()
        {
            this.ListaFilhos = new List<CentroCustoDTO>();
        }

    }
}

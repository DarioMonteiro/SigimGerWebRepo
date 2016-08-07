using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Application.DTO.Gerencial;
using GIR.SIGIMGERENCIAL.Application.DTO.Comum;

namespace GIR.SIGIMGERENCIAL.Application.Service.Gerencial
{
    public interface ICentroCustoAppService 
    {
        CentroCustoDTO ObterPeloCodigo(string codigo);
        List<TreeNodeDTO> ListarRaizesAtivas();
    }
}

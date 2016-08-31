using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Application.DTO.Gerencial;

namespace GIR.SIGIMGERENCIAL.Application.Service.Gerencial
{
    public interface IValorPotencialAppService
    {

        List<ValorPotencialDTO> ListarValorPotencialPorCentroCusto(string codigoCentroCusto);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GIR.SIGIMGERENCIAL.Application.DTO.Gerencial;
using GIR.SIGIMGERENCIAL.Application.DTO.Comum;

namespace GIR.SIGIMGERENCIAL.Application.Helper
{
    public class ComumMapperHelper
    {
        public static void Initialise()
        {
            Mapper.CreateMap<CentroCustoDTO, TreeNodeDTO>()
                .ForMember(d => d.ListaFilhos, m => m.MapFrom(s => s.ListaFilhos));
        }
    }
}

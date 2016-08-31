using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GIR.SIGIMGERENCIAL.Application.Adapter;
using GIR.SIGIMGERENCIAL.Application.DTO.Gerencial;
using GIR.SIGIMGERENCIAL.Domain.Entity.Gerencial;


namespace GIR.SIGIMGERENCIAL.Application.Helper
{
    class GerencialMapperHelper
    {

        public static void Initialise()
        {
            Mapper.CreateMap<CentroCusto, CentroCustoDTO>();
            Mapper.CreateMap<CentroCustoDTO, CentroCusto>();

            Mapper.CreateMap<ValorPotencial, ValorPotencialDTO>();
            Mapper.CreateMap<ValorPotencialDTO, ValorPotencial>();

        }

    }
}

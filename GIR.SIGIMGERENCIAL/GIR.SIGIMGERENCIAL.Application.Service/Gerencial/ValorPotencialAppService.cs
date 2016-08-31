using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Application.Adapter;
using GIR.SIGIMGERENCIAL.Application.Service.Gerencial;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.Notification;
using GIR.SIGIMGERENCIAL.Domain.Repository.Gerencial;
using GIR.SIGIMGERENCIAL.Application.DTO.Gerencial;
using GIR.SIGIMGERENCIAL.Domain.Specification;
using GIR.SIGIMGERENCIAL.Domain.Entity.Gerencial;
using GIR.SIGIMGERENCIAL.Domain.Specification.Gerencial;


namespace GIR.SIGIMGERENCIAL.Application.Service.Gerencial
{
    public class ValorPotencialAppService : BaseAppService, IValorPotencialAppService
    {
        #region Declaração

        private IValorPotencialRepository valorPotencialRepository;
        private ICentroCustoRepository centroCustoRepository;

        #endregion

        #region Construtor

        public ValorPotencialAppService(IValorPotencialRepository valorPotencialRepository,
                                        ICentroCustoRepository centroCustoRepository,
                                        MessageQueue messageQueue)
            : base(messageQueue)
        {
            this.valorPotencialRepository = valorPotencialRepository;
            this.centroCustoRepository = centroCustoRepository;

        }

        #endregion

        #region IValorPotencialAppService Members

        public List<ValorPotencialDTO> ListarValorPotencialPorCentroCusto(string codigoCentroCustoPai)
        {
            if (string.IsNullOrEmpty(codigoCentroCustoPai))
            {
                return null;
            }

            var centroCusto = centroCustoRepository.ObterPeloCodigo(codigoCentroCustoPai);

            if (centroCusto != null)
            {
                var specification = (Specification<ValorPotencial>)new TrueSpecification<ValorPotencial>();

                specification &= ValorPotencialSpecification.PertenceAoCentroCustoPai(codigoCentroCustoPai);

                var listaValorPotencial = valorPotencialRepository.ListarPeloFiltro(specification,
                                                                                    l => l.CentroCusto);

                return listaValorPotencial.To<List<ValorPotencialDTO>>();

            }
            else
            {
                return null;
            }

        }

        #endregion

    }
}

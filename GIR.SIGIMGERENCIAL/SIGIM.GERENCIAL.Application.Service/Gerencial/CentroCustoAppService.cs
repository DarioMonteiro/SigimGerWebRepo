using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Infrastructure.Crosscutting.Notification;
using GIR.SIGIMGERENCIAL.Application.DTO.Gerencial;
using GIR.SIGIMGERENCIAL.Application.DTO.Comum;
using GIR.SIGIMGERENCIAL.Application.Adapter;

namespace GIR.SIGIMGERENCIAL.Application.Service.Gerencial
{
    public class CentroCustoAppService : BaseAppService, ICentroCustoAppService
    {
        private List<CentroCustoDTO> lista = new List<CentroCustoDTO>();
        public CentroCustoAppService(MessageQueue messageQueue)
            : base(messageQueue)
        {
            CentroCustoDTO cc = new CentroCustoDTO();
            cc.Codigo = "1";
            cc.Descricao = "Empresas";
            cc.Ativo = true;
            cc.Id = null;
            cc.ListaFilhos = new List<CentroCustoDTO>();

            CentroCustoDTO ccFilhoEmp = new CentroCustoDTO();
            ccFilhoEmp.Codigo = "1.01";
            ccFilhoEmp.Descricao = "Vila Mar";
            ccFilhoEmp.Ativo = true;
            ccFilhoEmp.Id = null;
            ccFilhoEmp.ListaFilhos = new List<CentroCustoDTO>();

            cc.ListaFilhos.Add(ccFilhoEmp);

            ccFilhoEmp = new CentroCustoDTO();
            ccFilhoEmp.Codigo = "1.02";
            ccFilhoEmp.Descricao = "Barratiba";
            ccFilhoEmp.Ativo = true;
            ccFilhoEmp.Id = null;
            ccFilhoEmp.ListaFilhos = new List<CentroCustoDTO>();

            cc.ListaFilhos.Add(ccFilhoEmp);

            ccFilhoEmp = new CentroCustoDTO();
            ccFilhoEmp.Codigo = "1.03";
            ccFilhoEmp.Descricao = "Vila Mar - Área 8";
            ccFilhoEmp.Ativo = true;
            ccFilhoEmp.Id = null;
            ccFilhoEmp.ListaFilhos = new List<CentroCustoDTO>();

            cc.ListaFilhos.Add(ccFilhoEmp);

            lista.Add(cc);

            cc = new CentroCustoDTO();
            cc.Codigo = "2";
            cc.Descricao = "HOLDING";
            cc.Ativo = true;
            cc.Id = null;
            cc.ListaFilhos = new List<CentroCustoDTO>();

            ccFilhoEmp = new CentroCustoDTO();
            ccFilhoEmp.Codigo = "2.01";
            ccFilhoEmp.Descricao = "VILA MAR";
            ccFilhoEmp.Ativo = true;
            ccFilhoEmp.Id = null;
            ccFilhoEmp.ListaFilhos = new List<CentroCustoDTO>();

            CentroCustoDTO ccFilhoBlo = new CentroCustoDTO();
            ccFilhoBlo.Codigo = "2.01.01";
            ccFilhoBlo.Descricao = "ADM. GERAL VILAMAR";
            ccFilhoBlo.Ativo = true;
            ccFilhoBlo.Id = null;
            ccFilhoEmp.ListaFilhos.Add(ccFilhoBlo);

            cc.ListaFilhos.Add(ccFilhoEmp);

            ccFilhoBlo = new CentroCustoDTO();
            ccFilhoBlo.Codigo = "2.01.02";
            ccFilhoBlo.Descricao = "OPERACIONAL GERAL";
            ccFilhoBlo.Ativo = true;
            ccFilhoBlo.Id = null;
            ccFilhoEmp.ListaFilhos.Add(ccFilhoBlo);

            cc.ListaFilhos.Add(ccFilhoEmp);

            ccFilhoBlo = new CentroCustoDTO();
            ccFilhoBlo.Codigo = "2.01.10";
            ccFilhoBlo.Descricao = "AREAS PEDRA DE GUARATIBA";
            ccFilhoBlo.Ativo = true;
            ccFilhoBlo.Id = null;
            ccFilhoEmp.ListaFilhos.Add(ccFilhoBlo);

            cc.ListaFilhos.Add(ccFilhoEmp);

            ccFilhoEmp = new CentroCustoDTO();
            ccFilhoEmp.Codigo = "2.02";
            ccFilhoEmp.Descricao = "BARRATIBA";
            ccFilhoEmp.Ativo = true;
            ccFilhoEmp.Id = null;
            ccFilhoEmp.ListaFilhos = new List<CentroCustoDTO>();

            ccFilhoBlo = new CentroCustoDTO();
            ccFilhoBlo.Codigo = "2.02.01";
            ccFilhoBlo.Descricao = "ADM. GERAL BARRATIBA";
            ccFilhoBlo.Ativo = true;
            ccFilhoBlo.Id = null;
            ccFilhoEmp.ListaFilhos.Add(ccFilhoBlo);

            cc.ListaFilhos.Add(ccFilhoEmp);

            ccFilhoBlo = new CentroCustoDTO();
            ccFilhoBlo.Codigo = "2.02.10";
            ccFilhoBlo.Descricao = "SAIBREIRA";
            ccFilhoBlo.Ativo = true;
            ccFilhoBlo.Id = null;
            ccFilhoEmp.ListaFilhos.Add(ccFilhoBlo);

            cc.ListaFilhos.Add(ccFilhoEmp);

            ccFilhoBlo = new CentroCustoDTO();
            ccFilhoBlo.Codigo = "2.02.11";
            ccFilhoBlo.Descricao = "JARDIM GARRIDO";
            ccFilhoBlo.Ativo = true;
            ccFilhoBlo.Id = null;
            ccFilhoEmp.ListaFilhos.Add(ccFilhoBlo);

            cc.ListaFilhos.Add(ccFilhoEmp);


            lista.Add(cc);

        }

        public CentroCustoDTO ObterPeloCodigo(string codigo)
        {
            CentroCustoDTO centroCusto = new CentroCustoDTO();

            foreach (CentroCustoDTO cc in lista)
            {
                if (!cc.Codigo.Equals(codigo))
                {
                    centroCusto = LerLista(cc.ListaFilhos, codigo);
                    if (centroCusto != null) break;
                }
                else
                {
                    centroCusto = cc;
                    break;
                }
            }

            //List<CentroCustoDTO> result = lista.Where(g => g.ListaFilhos.Any(t => t.Codigo.Equals(codigo) || g.Codigo.Equals(codigo))).To<List<CentroCustoDTO>>();
            //if (result != null)
            //{
            //    centroCusto = result.Where(l => l.Codigo.Equals(codigo)).FirstOrDefault().To<CentroCustoDTO>();
            //    if (centroCusto == null)
            //    {
            //        foreach(CentroCustoDTO ccAux in result) centroCusto = LerLista(ccAux, codigo);
            //    }
            //}
            return centroCusto;
        }

        public List<TreeNodeDTO> ListarRaizesAtivas()
        {
            var listaCC = lista.Where(l => l.Ativo).To<List<TreeNodeDTO>>();
            return listaCC;
        }

        private CentroCustoDTO LerLista(List<CentroCustoDTO> listaCentroCusto, string codigo)
        {
            CentroCustoDTO centroCusto = null;

            foreach (CentroCustoDTO cc in listaCentroCusto)
            {
                if (!cc.Codigo.Equals(codigo))
                {
                    centroCusto = LerLista(cc.ListaFilhos, codigo);
                    if (centroCusto != null) break;
                }
                else
                {
                    centroCusto = cc;
                    break;
                }
            }

            return centroCusto;
        }
    }
}

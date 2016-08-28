using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIR.SIGIMGERENCIAL.Domain.Entity.Gerencial
{
    public class CentroCusto : BaseEntity
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public string CodigoPai { get; set; }
        public virtual CentroCusto CentroCustoPai { get; set; }
        public virtual ICollection<CentroCusto> ListaFilhos { get; set; }
        public ICollection<ValorPotencial> ListaValorPotencial { get; set; }
        public ICollection<Comercial> ListaComercial { get; set; }
        public ICollection<Receita> ListaReceita { get; set; }
        public ICollection<AnaliseRecebiveis> ListaAnaliseRecebiveis { get; set; }
        public ICollection<AnaliseInadimplencia> ListaAnaliseInadimplencia { get; set; }
        public ICollection<ValorPotencialLiquido> ListaValorPotencialLiquido { get; set; }
        public ICollection<Despesa> ListaDespesa { get; set; }
        public ICollection<FluxoFinanceiro> ListaFluxoFinanceiro { get; set; }

        public CentroCusto()
        {
            this.ListaFilhos = new HashSet<CentroCusto>();
            this.ListaValorPotencial = new HashSet<ValorPotencial>();
            this.ListaComercial = new HashSet<Comercial>();
            this.ListaReceita = new HashSet<Receita>();
            this.ListaAnaliseRecebiveis = new HashSet<AnaliseRecebiveis>();
            this.ListaAnaliseInadimplencia = new HashSet<AnaliseInadimplencia>();
            this.ListaValorPotencialLiquido = new HashSet<ValorPotencialLiquido>();
            this.ListaDespesa = new HashSet<Despesa>();
            this.ListaFluxoFinanceiro = new HashSet<FluxoFinanceiro>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Domain.Resource.Comum;
using GIR.SIGIMGERENCIAL.Domain.Entity.Comum;

namespace GIR.SIGIMGERENCIAL.Domain.Entity.Admin
{
    public class Usuario : BaseEntity
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        [Obsolete("Esta propriedade será removida em uma versão futura. Caso NÃO esteja codificando em um repositório, utilize a propriedade \"Ativo\"")]
        public string Situacao { get; set; }
        public bool Ativo
        {
            get { return Situacao == "A"; }
            set { Situacao = value ? "A" : "I"; }
        }
        public byte[] AssinaturaEletronica { get; set; }

        //public int? ParametrosUsuarioId { get; set; }
        //public int? ParametrosUsuarioFinanceiroId { get; set; }
        //public ParametrosUsuario ParametrosUsuario { get; set; }
        //public ParametrosUsuarioFinanceiro ParametrosUsuarioFinanceiro { get; set; }
        //public ICollection<UsuarioCentroCusto> ListaUsuarioCentroCusto { get; set; }
        public ICollection<UsuarioFuncionalidade> ListaUsuarioFuncionalidade { get; set; }
        public ICollection<UsuarioPerfil> ListaUsuarioPerfil { get; set; }

        public Usuario()
        {
            //this.ListaUsuarioCentroCusto = new HashSet<UsuarioCentroCusto>();
            this.ListaUsuarioFuncionalidade = new HashSet<UsuarioFuncionalidade>();
            this.ListaUsuarioPerfil = new HashSet<UsuarioPerfil>();
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            foreach (var item in ListaUsuarioFuncionalidade)
            {
                if (item.UsuarioId == 0)
                {
                    yield return new ValidationResult(string.Format(Resource.Comum.ErrorMessages.CampoObrigatorio, "Usuário"));
                }
                if (item.ModuloId == 0)
                {
                    yield return new ValidationResult(string.Format(Resource.Comum.ErrorMessages.CampoObrigatorio, "Módulo"));
                }
                if ((item.Funcionalidade == null) || (item.Funcionalidade == ""))
                {
                    yield return new ValidationResult(string.Format(Resource.Comum.ErrorMessages.CampoObrigatorio, "Funcionalidade"));
                }
            }

            foreach (var item in ListaUsuarioPerfil)
            {
                if (item.UsuarioId == 0)
                {
                    yield return new ValidationResult(string.Format(Resource.Comum.ErrorMessages.CampoObrigatorio, "Usuário"));
                }
                if (item.ModuloId == 0)
                {
                    yield return new ValidationResult(string.Format(Resource.Comum.ErrorMessages.CampoObrigatorio, "Módulo"));
                }
                if (item.PerfilId == 0)
                {
                    yield return new ValidationResult(string.Format(Resource.Comum.ErrorMessages.CampoObrigatorio, "Perfil"));
                }
            }
        }

    }
}
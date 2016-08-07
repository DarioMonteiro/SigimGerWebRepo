using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GIR.SIGIMGERENCIAL.Presentation.WebUI.ViewModel.Admin
{
    public class LoginViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Application.Resource.Comum.ErrorMessages), ErrorMessageResourceName = "CampoObrigatorio")]
        [StringLength(50, ErrorMessageResourceType = typeof(Application.Resource.Comum.ErrorMessages), ErrorMessageResourceName = "LimiteMaximoCaracteresExcedido")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Application.Resource.Comum.ErrorMessages), ErrorMessageResourceName = "CampoObrigatorio")]
        [StringLength(50, ErrorMessageResourceType = typeof(Application.Resource.Comum.ErrorMessages), ErrorMessageResourceName = "LimiteMaximoCaracteresExcedido")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Mantenha-me conectado")]
        public bool RememberMe { get; set; }
    }
}
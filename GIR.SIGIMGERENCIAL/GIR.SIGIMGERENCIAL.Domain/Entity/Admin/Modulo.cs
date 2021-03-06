﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using GIR.SIGIMGERENCIAL.Domain.Entity.Sigim;

namespace GIR.SIGIMGERENCIAL.Domain.Entity.Admin
{
    public class Modulo : BaseEntity
    {
        public string Nome { get; set; }
        public string NomeCompleto { get; set; }
        public string ChaveAcesso { get; set; }
        public string Versao { get; set; }
        public bool Bloqueio { get; set; }
        public ICollection<Perfil> ListaPerfil { get; set; }
        //public ICollection<UsuarioCentroCusto> ListaUsuarioCentroCusto { get; set; }
        public ICollection<UsuarioFuncionalidade> ListaUsuarioFuncionalidade { get; set; }


        public Modulo()
        {
            this.ListaPerfil = new HashSet<Perfil>();
            //this.ListaUsuarioCentroCusto = new HashSet<UsuarioCentroCusto>();
            this.ListaUsuarioFuncionalidade = new HashSet<UsuarioFuncionalidade>();
        }
    }
}
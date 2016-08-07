using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GIR.SIGIMGERENCIAL.Application.Constantes
{
    public class Funcionalidade
    {

        #region Hashtable

        public System.Collections.Hashtable MenuAdmin;
        public System.Collections.Hashtable MenuGerencial;

        #endregion

        #region Admin

        public const string PerfilAcessar = "PERFIL_ACESSAR";
        public const string PerfilGravar = "PERFIL_GRAVAR";
        public const string PerfilDeletar = "PERFIL_DELETAR";
        public const string PerfilImprimir = "PERFIL_IMPRIMIR";

        public const string UsuarioFuncionalidadeAcessar = "USUARIOFUNCIONALIDADE_ACESSAR";
        public const string UsuarioFuncionalidadeGravar = "USUARIOFUNCIONALIDADE_GRAVAR";
        public const string UsuarioFuncionalidadeDeletar = "USUARIOFUNCIONALIDADE_DELETAR";
        public const string UsuarioFuncionalidadeImprimir = "USUARIOFUNCIONALIDADE_IMPRIMIR";

        #endregion

        #region Gerencial

        public const string RelGerencialAcessar = "REL_GERENCIAL_ACESSAR";
        public const string RelGerencialImprimir = "REL_GERENCIAL_IMPRIMIR";

        #endregion


        public Funcionalidade()
        {
            FuncionalidadeAdmin();
            FuncionalidadeGerencial();
        }

        private void FuncionalidadeAdmin()
        {
            MenuAdmin = new System.Collections.Hashtable();

            MenuAdmin.Add(PerfilAcessar, "Perfil - acessar");
            MenuAdmin.Add(PerfilGravar, "Perfil - gravar");
            MenuAdmin.Add(PerfilDeletar, "Perfil - deletar");
            //MenuAdmin.Add(PerfilImprimir, "Perfil - imprimir");

            MenuAdmin.Add(UsuarioFuncionalidadeAcessar, "Usuário funcionalidades - acessar");
            MenuAdmin.Add(UsuarioFuncionalidadeGravar, "Usuário funcionalidades - gravar");
            MenuAdmin.Add(UsuarioFuncionalidadeDeletar, "Usuário funcionalidades - deletar");
            //MenuAdmin.Add(UsuarioFuncionalidadeImprimir, "Usuário funcionalidades - imprimir");
        }

        private void FuncionalidadeGerencial()
        {
            MenuGerencial = new System.Collections.Hashtable();

            MenuGerencial.Add(RelGerencialAcessar, "Relatório gerencial - acessar");
            MenuGerencial.Add(RelGerencialImprimir, "Relatório gerencial - imprimir");
        }


    }
}
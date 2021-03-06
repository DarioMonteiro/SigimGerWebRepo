﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIR.SIGIMGERENCIAL.Application.DTO;
using GIR.SIGIMGERENCIAL.Application.DTO.Admin;
using GIR.SIGIMGERENCIAL.Application.Filtros.Admin;

namespace GIR.SIGIMGERENCIAL.Application.Service.Admin
{
    public interface IUsuarioAppService
    {
        bool Login(string userName, string password, bool isPersistent, int timeout, string hostName);
        void Logout();
        bool ChangePassword(string currentPassword, string newPassword, string confirmPassword);
        //bool UsuarioPossuiCentroCustoDefinidoNoModulo(int? idUsuario, string modulo);
        UsuarioDTO ObterUsuarioPorLogin(string login);
        UsuarioDTO ObterUsuarioPorId(int id);
        string[] ObterPermissoesUsuario(int? usuarioId);
        List<UsuarioDTO> ListarTodos();
        List<UsuarioPerfilDTO> ListarPeloUsuarioModulo(UsuarioFuncionalidadeFiltro filtro, out int totalRegistros);
        bool SalvarPermissoes(int UsuarioId, int ModuloId, int? PerfilId, List<UsuarioFuncionalidadeDTO> listaFuncionalidadeDTO);
        bool DeletarPermissoes(int UsuarioId, int ModuloId);
        bool EhPermitidoSalvar();
        bool EhPermitidoDeletar();
    }
}
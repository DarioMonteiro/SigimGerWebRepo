﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GIR.SIGIMGERENCIAL.Application.Adapter;
using GIR.SIGIMGERENCIAL.Application.DTO.Admin;
using GIR.SIGIMGERENCIAL.Domain.Entity.Admin;

namespace GIR.SIGIMGERENCIAL.Application.Helper
{
    public class AdminMapperHelper
    {
        public static void Initialise()
        {
            Mapper.CreateMap<Usuario, UsuarioDTO>();
            Mapper.CreateMap<UsuarioDTO, Usuario>();

            Mapper.CreateMap<UsuarioFuncionalidade, UsuarioFuncionalidadeDTO>();
            Mapper.CreateMap<UsuarioFuncionalidadeDTO, UsuarioFuncionalidade>();
            Mapper.CreateMap<UsuarioFuncionalidade, string>()
                .ConvertUsing(m => m.Funcionalidade);

            Mapper.CreateMap<UsuarioPerfil, UsuarioPerfilDTO>();
            Mapper.CreateMap<UsuarioPerfilDTO, UsuarioPerfil>();
                

            Mapper.CreateMap<Modulo, ModuloDTO>();
            Mapper.CreateMap<ModuloDTO, Modulo>();

            Mapper.CreateMap<Perfil, PerfilDTO>();
            Mapper.CreateMap<PerfilDTO, Perfil>();

            Mapper.CreateMap<PerfilFuncionalidade, PerfilFuncionalidadeDTO>();
            Mapper.CreateMap<PerfilFuncionalidadeDTO, PerfilFuncionalidade>();
            Mapper.CreateMap<PerfilFuncionalidade, string>()
                .ConvertUsing(m => m.Funcionalidade);
        }
    }
}
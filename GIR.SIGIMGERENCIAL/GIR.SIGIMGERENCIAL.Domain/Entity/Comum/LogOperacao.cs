﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIR.SIGIMGERENCIAL.Domain.Entity.Comum
{
    public class LogOperacao : BaseEntity
    {
        public DateTime Data { get; set; }
        public string LoginUsuario { get; set; }
        public string Descricao { get; set; }
        public string NomeRotina { get; set; }
        public string NomeTabela { get; set; }
        public string NomeComando { get; set; }
        public string Dados { get; set; }
        public string HostName { get; set; }
    }
}
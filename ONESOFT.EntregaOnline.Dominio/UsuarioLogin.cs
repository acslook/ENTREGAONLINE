﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONESOFT.EntregaOnline.Dominio
{
   public class UsuarioLogin
    {
        public int Id { get; set; }
        public Guid Hash { get; set; }
        public string Senha { get; set; }
        public string Usuario { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Status { get; set; }
    }
}

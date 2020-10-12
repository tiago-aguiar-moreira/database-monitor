﻿using System;

namespace DatabaseMonitor.WebAPI.Model
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public DateTime Criacao { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; }
    }
}

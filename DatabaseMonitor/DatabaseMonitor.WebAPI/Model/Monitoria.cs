using System;

namespace DatabaseMonitor.WebAPI.Model
{
    public class Monitoria
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int CodConsulta { get; set; }
        public DateTime Criacao { get; set; }
        public bool Ativo { get; set; }
    }
}

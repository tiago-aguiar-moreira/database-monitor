using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseMonitor.WebAPI.Entidade
{
    public class Consulta
    {
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public string ConsultaBD { get; set; }
        public DateTime Criacao { get; set; }
        public string BancoDados { get; set; }
    }
}

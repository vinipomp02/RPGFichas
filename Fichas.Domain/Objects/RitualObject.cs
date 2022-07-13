using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFichas.Domain.Objects
{
    public class RitualObject
    {
        public string Ritual { get; set; }
        public string Elemento { get; set; }
        public int Circulo { get; set; }
        public string Custo { get; set; }
        public string Acao { get; set; }
        public string Alcance { get; set; }
        public string Duracao { get; set; }
        public string Resistencia { get; set; }
        public string Descricao { get; set; }
    }
}

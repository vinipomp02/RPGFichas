using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RPGFichas.Domain.Collections
{
    public class Rituais
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
        public List<Rituais> GetRituais()
        {
            List<Rituais> Rituais = new List<Rituais>();

            string fileName = Directory.GetParent( Directory.GetCurrentDirectory()).Parent.Parent + @"\Data\Rituais.json";
            string jsonString = File.ReadAllText(fileName);
            Rituais = JsonSerializer.Deserialize<List<Rituais>>(jsonString);
            return Rituais;

        }
    }
}



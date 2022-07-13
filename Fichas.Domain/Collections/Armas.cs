using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RPGFichas.Domain
{

    public class Arma
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Espacos { get; set; }
        public string Dano { get; set; }
        public string Alcance { get; set; }
        public string Critico { get; set; }
        public string Ataque { get; set; }
        public string Tipo { get; set; }
        public string TipoDano { get; set; }
        public string Municao { get; set; }
        public int Categoria { get; set; }
        public string Especial { get; set; }
        public List<Arma> GetArmas()
        {
            List<Arma> Armas = new List<Arma>();

            string fileName = Directory.GetParent( Directory.GetCurrentDirectory()).Parent.Parent + @"\Data\Armas.json";
            string jsonString = File.ReadAllText(fileName);
            Armas = JsonSerializer.Deserialize<List<Arma>>(jsonString);

            return Armas;
        }
    }
}

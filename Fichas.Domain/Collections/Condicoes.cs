using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RPGFichas.Domain.Collections
{
    public class Condicoes
    {

        public int Id { get; set; }
        public string Condicao { get; set; }
        public string Tipo { get; set; }
        public string Upgrade { get; set; }
        public string Descricao { get; set; }

        public List<Condicoes> GetCondicoes()
        {
            string fileName = Directory.GetParent( Directory.GetCurrentDirectory()).Parent.Parent + @"\Data\Condicoes.json";
            string jsonString = File.ReadAllText(fileName);
            List<Condicoes> Condicoes = JsonSerializer.Deserialize<List<Condicoes>>(jsonString);

            return Condicoes;
        }

    }
}

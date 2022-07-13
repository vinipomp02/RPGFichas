using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RPGFichas.Domain.Collections
{
    public class Poderes
    {
        public string Poder { get; set; }
        public string Descricao { get; set; }
        public int? Nex { get; set; }
        public string Requisito { get; set; }
        public string Classe { get; set; }
        public string Trilha { get; set; }
        public string Origem { get; set; }
        public string Elemento { get; set; }

        public List<Poderes> GetPoderes()
        {
            List<Poderes> Poderes = new List<Poderes>();

            string fileName = Directory.GetParent( Directory.GetCurrentDirectory()).Parent.Parent + @"\Data\Poderes.json";
            string jsonString = File.ReadAllText(fileName);
            Poderes = JsonSerializer.Deserialize<List<Poderes>>(jsonString);

            return Poderes;

        }

    }
}

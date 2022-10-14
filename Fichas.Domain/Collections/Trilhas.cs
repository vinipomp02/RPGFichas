using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RPGFichas.Domain.Collections
{
    public class Trilhas
    {
        public string Trilha { get; set; }
        public string Classe { get; set; }
        public List<Trilhas> GetTrilhas()
        {
            List<Trilhas> Trilhas = new List<Trilhas>();

            string fileName = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent + @"\Data\Trilhas.json";
            string jsonString = File.ReadAllText(fileName);
            Trilhas = JsonSerializer.Deserialize<List<Trilhas>>(jsonString);

            return Trilhas;
        }
    }
}

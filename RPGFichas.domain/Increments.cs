using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFichas.Domain
{
    public class Increments
    {
        public int incremento { get; set; } = 0;
        public string Incrementa()
        {
            incremento++;

            if(incremento > 0) return "+" + incremento.ToString();
            return incremento.ToString();
        }

        public string Decrementa()
        {
            incremento--;

            if (incremento > 0) return "+" + incremento.ToString();
            return incremento.ToString();
        }
    }
}

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
            if (incremento < 15)
            {
                incremento++;
            }
            return IncrementoToString();
        }

        public string Decrementa()
        {
            if (incremento > -15)
            {
                incremento--;
            }

            return IncrementoToString();
        }

        public string IncrementoToString()
        {

            if (incremento >= 0) return "+" + incremento.ToString();
            return incremento.ToString();
        }
    }
}

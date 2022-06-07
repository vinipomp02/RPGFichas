using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFichas.Domain
{
    public class Dados
    {

        public List<int> GetDados(int atributoValue)
        {

            var dadosJogados = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < Math.Abs(atributoValue) + 1; i++)
            {
                int dado = rnd.Next(1, 21);
                dadosJogados.Add(dado);

            }

            return dadosJogados;
        }

        public int GetDadoResultado(List<int> dadosJogado, int atributoValue)
        {
            if(atributoValue>=0) return dadosJogado.Max();
            return dadosJogado.Min();

        }

        public void roll(int atributoValue)
        {
            
            
        }
        
    }
}
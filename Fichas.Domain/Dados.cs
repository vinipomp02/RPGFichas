using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGFichas.Domain
{
    public class Dados
    {
        public List<int> dadosJogadosList = new List<int>();

        public int dadoIndex = 0;
        public string resultado { get; set; }

        public int melhorDado { get; set; }

        public List<int> GetDados20(int atributoValue)
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

        public string GetResultado(List<int> dadosJogado, int atributoValue, int bonusPericia)
        {
            if (atributoValue >= 0) return $"{dadosJogado.Max()} + {bonusPericia} = {dadosJogado.Max() + bonusPericia}";
            return $"{dadosJogado.Min()} + {bonusPericia} = {dadosJogado.Min() + bonusPericia}";

        }
        public void escreveProximoDado(Label lblDadosJogados, Label lbldadoFinal, Label lblMelhorDado, Button btnNext)
        {
            if(dadosJogadosList==null) return;

            lblDadosJogados.Text += $"{dadosJogadosList[dadoIndex]}";
            if (dadoIndex < dadosJogadosList.Count - 1) lblDadosJogados.Text += ", ";

            if(dadoIndex+1 == dadosJogadosList.Count) 
            {
                mostraDadoFinal(lbldadoFinal, lblMelhorDado, btnNext);
                dadosJogadosList = null;
                return;
            }
            dadoIndex++;

            if(melhorDado == 1 || melhorDado == 20)
            {
                if (dadosJogadosList[dadoIndex - 1] == melhorDado) escreveAllDados(lblDadosJogados, lbldadoFinal, lblMelhorDado, btnNext);
            }

        }
        public void escreveAllDados(Label lblDadosJogados, Label lbldadoFinal, Label lblMelhorDado, Button btnNext)
        {
            do
            {
                escreveProximoDado(lblDadosJogados, lbldadoFinal, lblMelhorDado, btnNext);
                if (dadosJogadosList == null) return;

            } while (dadoIndex < dadosJogadosList.Count);
        }
        public void mostraDadoFinal(Label lbldadoFinal, Label lblMelhorDado,Button btnNext) 
        {
            lbldadoFinal.Text = melhorDado.ToString();
            lbldadoFinal.ForeColor = colorResultado(melhorDado);
            lbldadoFinal.Visible = true;
            lblMelhorDado.Text = resultado;
            btnNext.Visible = false;

        }
        public void rollDados(int atributoFinal, int periciaValue)
        {
            this.dadoIndex = 0;
            this.dadosJogadosList = this.GetDados20(atributoFinal);
            this.resultado = this.GetResultado(dadosJogadosList, atributoFinal, periciaValue);
            melhorDado = int.Parse(resultado.Substring(0, resultado.IndexOf(' ')));
        }

        public Color colorResultado(int resultado)
        {
            switch (resultado)
            {
                case 20: return Color.Green;

                case 1: return Color.Red;

                default: return Color.White;
            }


        }

    }
}
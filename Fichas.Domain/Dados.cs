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
        public int melhorResultado { get; set; }


        public List<int> GetDados(int quantidadeDados)
        {
            return GetDados(Math.Abs(quantidadeDados) + 1, 20);
        }
        public List<int> GetDados(int quantidadeDados,int quantidadeLados)
        {

            var dadosJogados = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < quantidadeDados; i++)
            {
                int dado = rnd.Next(1, quantidadeLados+1);
                dadosJogados.Add(dado);

            }

            return dadosJogados;
        }
        public string GetResultado(List<int> dadosJogado, int atributoValue, int bonusPericia)
        {
            if (atributoValue >= 1) return $"{dadosJogado.Max()} + {bonusPericia} = {dadosJogado.Max() + bonusPericia}";
            return $"{dadosJogado.Min()} + {bonusPericia} = {dadosJogado.Min() + bonusPericia}";

        }
        public void escreveProximoDado(Label lblDadosJogados, Label lbldadoFinal, Label lblMelhorDado, Button btnNext,int maxValue)
        {
            if(dadosJogadosList==null) return;

            lblDadosJogados.Text += $"{dadosJogadosList[dadoIndex]}";
            if (dadoIndex < dadosJogadosList.Count - 1) lblDadosJogados.Text += ", ";

            if(dadoIndex+1 == dadosJogadosList.Count) 
            {
                mostraDadoFinal(lbldadoFinal, lblMelhorDado, btnNext,maxValue);
                dadosJogadosList = null;
                return;
            }
            dadoIndex++;

            if(melhorDado == 1 || melhorDado == maxValue)
            {
                if (dadosJogadosList[dadoIndex - 1] == melhorDado) escreveAllDados(lblDadosJogados, lbldadoFinal, lblMelhorDado, btnNext,maxValue);
            }

        }
        public void escreveAllDados(Label lblDadosJogados, Label lbldadoFinal, Label lblMelhorDado, Button btnNext,int maxValue)
        {
            do
            {
                escreveProximoDado(lblDadosJogados, lbldadoFinal, lblMelhorDado, btnNext,maxValue);
                if (dadosJogadosList == null) return;

            } while (dadoIndex < dadosJogadosList.Count);
        }
        public void mostraDadoFinal(Label lbldadoFinal, Label lblMelhorDado,Button btnNext,int maxValue) 
        {
            lbldadoFinal.Text = melhorResultado.ToString();
            lbldadoFinal.ForeColor = colorResultado(melhorDado,maxValue);
            lbldadoFinal.Visible = true;
            lblMelhorDado.Text = resultado;
            btnNext.Visible = false;

        }
        public void rollDados(int qtdDados, int periciaValue,int qtdLados)
        {
            this.dadoIndex = 0;
            this.dadosJogadosList = this.GetDados(Math.Abs(qtdDados-1) + 1, qtdLados);
            this.resultado = this.GetResultado(dadosJogadosList, qtdDados, periciaValue);
            melhorResultado = int.Parse(resultado.Substring(resultado.IndexOf('=')+1));
            melhorDado = int.Parse(resultado.Substring(0,resultado.IndexOf(' ')));
        }
        public void rollDadosBonus(int quantidadeDados, int quantidadeLados,Label lblMelhorDado,int bonus=0)
        {
            lblMelhorDado.Text = null;
            var dadosJogados = GetDados(quantidadeDados, quantidadeLados);
            for (int i = 0; i < dadosJogados.Count; i++)
            {
                lblMelhorDado.Text += $"{dadosJogados[i]}";
                if (i + 1 < dadosJogados.Count) lblMelhorDado.Text += " + ";
            }
            if(bonus>0) lblMelhorDado.Text += $" + {bonus}";
            lblMelhorDado.Text += $" = {dadosJogados.Sum() + bonus}";
        }   
        public Color colorResultado(int resultado,int maxValue)
        {
            if (resultado == maxValue)
            {
                return Color.Green;
            } 
            else if (resultado == 1) 
            {
                return Color.Red;
            }
            else
            {
                return Color.White;
            }
        }

    }
}
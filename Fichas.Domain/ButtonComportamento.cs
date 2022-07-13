using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFichas.Domain
{
    public class ButtonComportamento
    {
        public Button? buttonMarcado { get; set; }
        public void selecionaAtributo(object sender)
        {
            var btnAtributo = sender as Button;
            btnAtributo.BackColor = Color.Gray;
            if (buttonMarcado != null) desmarcarAtributo();
            buttonMarcado = btnAtributo;
        }

        public void desmarcarAtributo()
        {
            if (buttonMarcado == null) return;
            buttonMarcado.BackColor = Color.White;
            buttonMarcado = null;
        }

        public void ClicaBotao(object sender)
        {
            
            var button = sender as Button;
            if (buttonMarcado == null || buttonMarcado != button) selecionaAtributo(button);
            else desmarcarAtributo();
        }
    }
}

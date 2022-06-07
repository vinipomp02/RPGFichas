using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGFichas.Domain;


namespace RPGFichas
{
    public partial class FichaBruna : Form
    {
        Dados dados = new Dados();
        Increments Increments = new Increments();
        CheckboxComportamento checkboxComportamento = new CheckboxComportamento();
        ButtonComportamento buttonComportamento = new ButtonComportamento();
       
        
        public FichaBruna()
        {
            InitializeComponent();
        }

        private void FichaBruna_Load(object sender, EventArgs e)
        {
            checkboxComportamento.selecionaCheckBox(cbxRollAll,"Roll");
        }
        private void ResetaInfoDados()
        {
            lblDadosJogados.Text = null;
            lblMelhorDado.Text = null;
            lblDadoFinal.Text = null;
        }
        private void ResetaRoll()
        {
            buttonComportamento.desmarcarAtributo();
            checkboxComportamento.desmarcarCheckBox(checkboxComportamento.checkBoxPericiaMarcada);
            Increments = new Increments();
            lblVantagem.Text = "0";
        }
        protected void ShowRoll() 
        {
            ResetaInfoDados();

            var pericia = checkboxComportamento.checkBoxPericiaMarcada;
            var atributo = buttonComportamento.buttonMarcado;

            var atributoFinal = int.Parse(atributo.Text) + Increments.incremento;
            var periciaValue = int.Parse(pericia.Text);


            lblDadosJogados.Text = $"{Increments.IncrementoToString()} + {atributo.Name.Substring(atributo.Name.IndexOf("n") + 1).ToUpper()} + {pericia.Name.Substring(pericia.Name.IndexOf("x") + 1)}:\n";
            dados.rollDados(atributoFinal, periciaValue);

            if (checkboxComportamento.checkBoxRollsMarcada.Name.Contains("All")) dados.escreveAllDados(lblDadosJogados, lblDadoFinal, lblMelhorDado, btnNext);
            if (checkboxComportamento.checkBoxRollsMarcada.Name.Contains("Next")) btnNext.Visible = true;

            ResetaRoll();
        }
        protected void SelecionaElemento(object sender)
        {

            switch (sender.GetType().Name)
            {
                case "CheckBox":
                    checkboxComportamento.selecionaCheckBox(sender);

                    if (buttonComportamento.buttonMarcado != null)
                    {
                        ShowRoll();
                    }
                    break;
                case "RoundButton":
                    buttonComportamento.selecionaAtributo(sender);

                    if (checkboxComportamento.checkBoxPericiaMarcada != null)
                    {
                        ShowRoll();
                    }
                    break;
            }
           
        }
        private void agiBtn_Click(object sender, EventArgs e) => SelecionaElemento(sender);

        private void btnInt_Click(object sender, EventArgs e) => SelecionaElemento(sender);

        private void btnVig_Click(object sender, EventArgs e) => SelecionaElemento(sender);

        private void btnPre_Click(object sender, EventArgs e) => SelecionaElemento(sender);

        private void btnFor_Click(object sender, EventArgs e) => SelecionaElemento(sender);
    
        private void btnVantagem_Click(object sender, EventArgs e) => lblVantagem.Text = Increments.Incrementa();

        private void btnDesvantagem_Click(object sender, EventArgs e) => lblVantagem.Text = Increments.Decrementa();

        private void cbxAtletismo_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxAtualidades_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxCiencia_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);
        
        private void cbxDiplomacia_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);
        
        private void cbxEnganação_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxFortitude_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxFurtividade_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxIntimidação_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxIntuicao_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxInvestigacao_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxLuta_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxMedicina_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxOcultismo_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxPercepcao_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxPilotagem_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxPontaria_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxPrestidigitacao_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxProfissao_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxTática_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxRelexo_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxReligiao_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxTecnologia_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxVontade_CheckedChanged(object sender, EventArgs e) => SelecionaElemento(sender);

        private void cbxRollNext_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender, "Roll");
        private void cbxRollAll_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender, "Roll");

        private void btnNext_Click(object sender, EventArgs e) => dados.escreveProximoDado(lblDadosJogados,lblDadoFinal,lblMelhorDado, btnNext);
    }
}


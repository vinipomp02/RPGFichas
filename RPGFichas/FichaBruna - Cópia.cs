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
        Visual visual = new Visual();
        
        public FichaBruna()
        {
            InitializeComponent();
        }

        private void FichaBruna_Load(object sender, EventArgs e)
        {

        }

        protected void roll(object sender)
        {
            var atributo = sender as Button;

            lblDadosJogados.Text = null;
            var pericia = checkboxComportamento.ultimaCheckBox;

            if (checkboxComportamento.ultimaCheckBox != null)
            {
                var atributoFinal = int.Parse(atributo.Text) + Increments.incremento;
                var periciaValue = int.Parse(pericia.Text);

                dados.rollDados(atributoFinal, lblMelhorDado, periciaValue, lblDadosJogados, lblDadoFinal);

                checkboxComportamento.desmarcarCheckBox(pericia);
                Increments = new Increments();
                lblVantagem.Text = "0";

            }
            else
            {
                lblMelhorDado.Text = ("Selecione a \nPerícia");
            }

        }
        private void agiBtn_Click(object sender, EventArgs e) => roll(sender);

        private void btnInt_Click(object sender, EventArgs e) => roll(sender);

        private void btnVig_Click(object sender, EventArgs e) => roll(sender);

        private void btnPre_Click(object sender, EventArgs e) => roll(sender);

        private void btnFor_Click(object sender, EventArgs e) => roll(sender);
    
        private void btnVantagem_Click(object sender, EventArgs e) => lblVantagem.Text = Increments.Incrementa();

        private void btnDesvantagem_Click(object sender, EventArgs e) => lblVantagem.Text = Increments.Decrementa();

        private void cbxAtletismo_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxAtualidades_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxCiencia_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);
        
        private void cbxDiplomacia_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);
        
        private void cbxEnganação_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxFortitude_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxFurtividade_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxIntimidação_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxIntuicao_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxInvestigacao_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxLuta_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxMedicina_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxOcultismo_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxPercepcao_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxPilotagem_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxPontaria_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxPrestidigitacao_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxProfissao_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxTática_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxRelexo_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxReligiao_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxTecnologia_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void cbxVontade_CheckedChanged(object sender, EventArgs e) => checkboxComportamento.selecionaCheckBox(sender);

        private void lblDados_Paint(object sender, PaintEventArgs e) => visual.Form_Paint(sender, e);
    }
}


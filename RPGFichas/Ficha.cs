using System.Security;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using ProgressBarSample;
using ProjectMentor.Windows.Controls;
using RPGFichas.Domain;
using RPGFichas.Domain.Collections;
using RPGFichas.Domain.Objects;
using RPGFichas.FormsHelper;
using Arma = RPGFichas.Domain.Arma;

namespace RPGFichas
{
    public partial class Ficha : Form
    {
        public DgvComportamento DgvComportamento = new();
        Dados Dados = new();
        Increments Increments = new();
        CheckboxComportamento CheckboxComportamento = new();
        ButtonComportamento ButtonComportamento = new();

        Menu Menu;
        string ImageFile;
        FichaObject fichaBase;

        public ArmasGrid ArmaGrid;
        public ConditionsGrid ConditionGrid;
        public Inventario Inventario;
        public DanoArmaEdit DanoEdit;
        public CritArmaEdit CritEdit;

        public Ficha(string Modo, Menu menu, FichaObject? ficha, string? imageFile)
        {
            InitializeComponent();

            Menu = menu;
            fichaBase = ficha;

            int nex = 0;
            if (Modo == "Jogo")
            {
                int.TryParse(txtNEX.Text.Replace("%", ""), out nex);
                btnAddFicha.Visible = false;
                btnAddFicha.Enabled = false;
            }
            else
            {
                editar();
                txtNome.ReadOnly = false;
                btnAddFicha.Visible = true;
                btnAddFicha.Enabled = true;

            }

            if (imageFile != null) ImageFile = imageFile;
        }

        private void Ficha_Load(object sender, EventArgs e)
        {
            ArmaGrid = new(this);
            ConditionGrid = new(this);
            Inventario = new(this);

            carregaInfos();
            carregaData(fichaBase);
        }
        private void Ficha_FormClosed(object sender, FormClosedEventArgs e) => Menu.Show();
        private void Ficha_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu.Form1_Load(sender, e);

            if (txtNome.Text == "" || txtNome.Text == null) return;
            this.salvar(sender, e,"manual");
        }
        private void cbxClasse_SelectedIndexChanged(object sender, EventArgs e) => carregaTrilhas();
        private void carregaTrilhas()
        {
            if (cbxClasse.Text == null) return;
            Trilhas trilha = new Trilhas();
            var trilhas = trilha.GetTrilhas().Where(x => x.Classe == cbxClasse.Text.ToString()).Select(x => x.Trilha);
            cbxTrilha.Items.Clear();
            cbxTrilha.Items.AddRange(trilhas.ToArray());
        }
        private void carregaInfos()
        {
            carregaTrilhas();

            if (CheckboxComportamento.checkBoxRollsMarcada == null)
            {
                CheckboxComportamento.selecionaCheckBox(cbxRollAll, "Roll");
            }


            AtualizaPeso();
            AtualizaDefesas();
        }
        private void AtualizaDefesas()
        {
            if (txtDefPassiva.Text == null || txtDefPassiva.Text == "") return;
            txtDefEsquiva.Text = (int.Parse(txtDefPassiva.Text) + int.Parse(cbxReflexos.Text)).ToString();
        }

        #region Atributos e Pericias
        protected void SelecionaElemento(object sender)
        {

            switch (sender.GetType().Name)
            {
                case "CheckBox":
                    CheckboxComportamento.selecionaCheckBox(sender);

                    if (ButtonComportamento.buttonMarcado != null)
                    {
                        ShowRoll();
                    }
                    break;
                case "RoundButton":
                    ButtonComportamento.selecionaAtributo(sender);

                    if (CheckboxComportamento.checkBoxPericiaMarcada != null)
                    {
                        ShowRoll();
                    }
                    break;
            }



        }
        private void btnVantagem_Click(object sender, EventArgs e) => lblVantagem.Text = Increments.Incrementa();
        private void btnDesvantagem_Click(object sender, EventArgs e) => lblVantagem.Text = Increments.Decrementa();
        private void btnSelect(object sender, EventArgs e) => SelecionaElemento(sender);
        private void cbxSelect(object sender, EventArgs e) => SelecionaElemento(sender);
        private void btnFor_TextChanged(object sender, EventArgs e) => AtualizaPeso();
        private void cbxReflexos_TextChanged(object sender, EventArgs e) => AtualizaDefesas();
        private void txtDefPassiva_TextChanged(object sender, EventArgs e) => AtualizaDefesas();


        #endregion

        #region RollActions
        private void ResetaInfoDados()
        {
            lblDadosJogados.Text = null;
            lblMelhorDado.Text = null;
            lblDadoFinal.Text = null;

        }
        private void ResetaRoll()
        {
            ButtonComportamento.desmarcarAtributo();
            CheckboxComportamento.desmarcarCheckBox(CheckboxComportamento.checkBoxPericiaMarcada);
            Increments = new Increments();
            lblVantagem.Text = "0";
            numBonus.Value = 0;
        }
        protected void ShowRoll()
        {
            ResetaInfoDados();

            var pericia = CheckboxComportamento.checkBoxPericiaMarcada;
            var atributo = ButtonComportamento.buttonMarcado;

            var bonus = Decimal.ToInt32(numBonus.Value);
            var atributoFinal = int.Parse(atributo.Text) + Increments.incremento;
            var periciaValue = int.Parse(pericia.Text) + bonus;


            lblDadosJogados.Text = $"{Increments.IncrementoToString()} + {atributo.Name.Substring(atributo.Name.IndexOf("n") + 1).ToUpper()} + {pericia.Name.Substring(pericia.Name.IndexOf("x") + 1)} :\n";

            Roll(atributoFinal, 20, periciaValue);
        }
        protected void Roll(int qtdDados, int qtdLados, int bonus)
        {
            Dados.rollDados(qtdDados, bonus, qtdLados);

            if (CheckboxComportamento.checkBoxRollsMarcada.Name.Contains("All")) Dados.escreveAllDados(lblDadosJogados, lblDadoFinal, lblMelhorDado, btnNext, qtdLados);
            if (CheckboxComportamento.checkBoxRollsMarcada.Name.Contains("Next")) btnNext.Visible = true;

            ResetaRoll();
        }
        private void cbxRollNext_CheckedChanged(object sender, EventArgs e) => CheckboxComportamento.selecionaCheckBox(sender, "Roll");
        private void cbxRollAll_CheckedChanged(object sender, EventArgs e) => CheckboxComportamento.selecionaCheckBox(sender, "Roll");
        private void btnNext_Click(object sender, EventArgs e) => Dados.escreveProximoDado(lblDadosJogados, lblDadoFinal, lblMelhorDado, btnNext, (Int32)numQtdLados.Value);
        private void btnRollSoma_Click(object sender, EventArgs e)
        {
            if ((Int32)numQtdDados.Value == 0) return;
            ResetaInfoDados();
            Dados.rollDadosBonus((Int32)numQtdDados.Value, (Int32)numQtdLados.Value, lblMelhorDado, (Int32)numBonusDados.Value);
        }
        private void btnRollMaior_Click(object sender, EventArgs e)
        {
            if ((Int32)numQtdDados.Value == 0) return;
            ResetaInfoDados();
            Roll((Int32)numQtdDados.Value - 1, (Int32)numQtdLados.Value, (Int32)numBonusDados.Value);
        }
        #endregion

        #region LayoutPanelArmasActions
        private void btnAddArma_Click(object sender, EventArgs e) => ArmaGrid.ShowDialog();
        public void ExcluirArma(string nome)
        {
            for (int i = 0; i < dgvItens.Rows.Count; i++)
            {
                if (dgvItens.Rows[i].Cells["Item"].Value.ToString() == nome)
                {
                    dgvItens.Rows.RemoveAt(i);
                }
            }
        }
        public bool AdicionaArma(Arma arma, string Nome, string[] Modificadores)
        {
            int.TryParse(Regex.Replace((string?)lblEspacoTotal.Text, "[^0-9]", ""), out int espacoTotal);
            var espacoAtual = int.Parse(lblEspacoAtual.Text);

            if(espacoAtual - arma.Espacos < -espacoTotal)
            {
                MessageBox.Show("Inventário cheio de mais, não consegue pegar essa arma","Inventário Cheio",MessageBoxButtons.OK);
                return false;
            }
            ArmaForms armaForms = new ArmaForms(this, lblMelhorDado, arma, Nome, Modificadores);
            armaForms.Show();
            armaForms.TopLevel = false;
            flpArmas.Controls.Add(armaForms);
            flpArmas.Controls.SetChildIndex(flpArmas.Controls["btnAddArma"], flpArmas.Controls.GetChildIndex(btnAddArma) + 1);


            DataGridViewRow newRow = dgvItens.Rows[dgvItens.Rows.Add()];
            newRow.Cells["Quantidade"].Value = 1;
            newRow.Cells["Item"].Value = Nome;
            newRow.Cells["Detalhes"].Value = arma.Tipo + "  -  " + arma.Municao;
            newRow.Cells["Espacos"].Value = arma.Espacos;
            newRow.Cells["Prestigio"].Value = arma.Categoria + Modificadores.Count();

            AtualizaPeso();
            return true;
        }
        public void abreEdicaoCrit(ArmaForms armaForms)
        {
            if (CritEdit != null) CritEdit.Dispose();
            CritEdit = new(this, armaForms);
            CritEdit.ShowDialog();
        }
        public void abreEdicaoDano(ArmaForms armaForms)
        {
            if (DanoEdit != null) DanoEdit.Dispose();
            DanoEdit = new(this, armaForms);
            DanoEdit.ShowDialog();
        }
        public void editaDano(int qtdDados, int qtdLados, int bonus, bool forca, ArmaForms armaForms)
        {
            string dano = $"{qtdDados}D{qtdLados}";

            if (bonus > 0) dano += $" + {bonus}";

            if (forca) dano += $" + {this.btnFor.Text}";

            armaForms.Controls["btnDano"].Text = dano;
        }
        public void editaCritico(int margem, int multiplicador, ArmaForms armaForms) => armaForms.Controls["btnCritico"].Text = $"{margem}/x{multiplicador}";
        #endregion

        #region GridCondicoesActions
        private void btnAddCondition_Click(object sender, EventArgs e) => ConditionGrid.ShowDialog();
        public void AdicionaCondicao(Condicoes? condicao)
        {
            if (btnAddCondicoes.Location.Y < dgvCondicoes.Location.Y + dgvCondicoes.Height - btnAddCondicoes.Height * 2)
            {
                btnAddCondicoes.Location = new Point(btnAddCondicoes.Location.X, btnAddCondicoes.Location.Y + btnAddCondicoes.Height);
            }

            DataGridViewRow newRow = dgvCondicoes.Rows[dgvCondicoes.Rows.Add()];
            newRow.Cells["Condicao"].Value = condicao.Condicao;
            newRow.Cells["TipoCondicao"].Value = condicao.Tipo;
            newRow.Cells["Upgrade"].Value = condicao.Upgrade;
        }
        private void dgvCondicoes_CellClick(object sender, DataGridViewCellEventArgs e) => DgvComportamento.DgvCondicoesActions(sender);
        #endregion

        #region GridItensAction
        private void btnAddItem_Click(object sender, EventArgs e) => Inventario.ShowDialog();
        private void btnExcluirItem_Click(object sender, EventArgs e) => DgvComportamento.ExcluirLinha(dgvItens, btnAddItens, lblEspacoAtual, dgvItens, btnAddItens);
        public bool AdicionarItem(DataGridViewRow item)
        {
            if (btnAddItens.Location.Y < dgvItens.Location.Y + dgvItens.Height - btnAddItens.Height * 2)
            {
                btnAddItens.Location = new Point(btnAddItens.Location.X, btnAddItens.Location.Y + btnAddItens.Height);
            }

            int espacoTotal = int.Parse(lblEspacoTotal.Text.Substring(lblEspacoTotal.Text.IndexOf("/") + 1));
            int espacoRestante = (int.Parse(lblEspacoAtual.Text) - int.Parse((String)item.Cells[3].Value) * int.Parse((String)item.Cells[0].Value));
            if (espacoRestante < -espacoTotal)
            {
                MessageBox.Show("Limite Máximo de Carga Atingido,Não Pode Carregar mais Itens", "LIMITE DE CARGA", MessageBoxButtons.OK);
                return false;
            }
            lblEspacoAtual.Text = espacoRestante.ToString();

            DataGridViewRow newRow = dgvItens.Rows[dgvItens.Rows.Add()];
            newRow.Cells["Quantidade"].Value = item.Cells[0].Value;
            newRow.Cells["Item"].Value = item.Cells[1].Value;
            newRow.Cells["Detalhes"].Value = item.Cells[2].Value;
            newRow.Cells["Espacos"].Value = item.Cells[3].Value;
            newRow.Cells["Prestigio"].Value = item.Cells[4].Value;

            return true;
        }

        public void AtualizaPeso()
        {
            switch (btnFor.Text)
            {
                case "0": lblEspacoTotal.Text = "/2"; break;
                default: lblEspacoTotal.Text = "/" + (int.Parse(btnFor.Text) * 5).ToString(); break;
            }

            var espacosUsado = 0;
            int.TryParse(Regex.Replace((string?)lblEspacoTotal.Text, "[^0-9]", ""), out int espacoTotal);

            for (int i = 0; i < dgvItens.Rows.Count; i++)
            {
                var espacos = int.Parse((string)dgvItens.Rows[i].Cells["Espacos"].Value.ToString());
                var qtd = int.Parse((string)dgvItens.Rows[i].Cells["Quantidade"].Value.ToString());
                espacosUsado += espacos * qtd;
            }

            lblEspacoAtual.Text = (espacoTotal - espacosUsado).ToString();
        }
        private void dgvItens_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv.Columns["Item"].Index == e.ColumnIndex || dgv.Columns["Detalhes"].Index == e.ColumnIndex) return;
            if (dgv.EditingControl == null) return;


            int.TryParse(Regex.Replace((string?)e.FormattedValue, "[^0-9]", ""), out int formattedValue);


            dgv.EditingControl.Text = formattedValue.ToString();



            if (dgv.Columns["Espacos"].Index == e.ColumnIndex || dgv.Columns["Quantidade"].Index == e.ColumnIndex)
            {
                int.TryParse(dgv.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString(), out int qtdValue);
                int.TryParse(dgv.Rows[e.RowIndex].Cells["Espacos"].Value.ToString(), out int espacoValue);
                string espacoRestante = null;

                if (dgv.Columns["Espacos"].Index == e.ColumnIndex) espacoRestante = (int.Parse(lblEspacoAtual.Text) + (qtdValue * espacoValue) - (formattedValue * qtdValue)).ToString();
                if (dgv.Columns["Quantidade"].Index == e.ColumnIndex) espacoRestante = (int.Parse(lblEspacoAtual.Text) + (qtdValue * espacoValue) - (formattedValue * espacoValue)).ToString();

                if (int.Parse(espacoRestante) < -int.Parse(Regex.Replace(lblEspacoTotal.Text, "[^0-9]", "")))
                {
                    e.Cancel = true;
                    MessageBox.Show("Limite Máximo de Carga Atingido,Não Pode Carregar mais Itens", "LIMITE DE CARGA", MessageBoxButtons.OK);
                    return;

                }
                lblEspacoAtual.Text = espacoRestante;
            }
        }
        private void atualizaPeso(object sender, DataGridViewRowsRemovedEventArgs e) => AtualizaPeso();

        #endregion

        #region LayoutPanelRitualActions
        private void btnAddRitual_Click(object sender, EventArgs e)
        {
            RitualForm ritual = new RitualForm(this, int.Parse(txtNEX.Text.Replace("%", "")));
            ritual.Show();
        }
        public void adicionarRitual(RitualForm ritual)
        {
            if (ritual == null) return;
            ritual.TopLevel = false;
            flpRituais.Controls.Add(ritual);
            flpRituais.Controls.SetChildIndex(flpRituais.Controls["btnAddRitual"], flpRituais.Controls.GetChildIndex(btnAddRitual) + 1);
        }
        public void excluirRitual(RitualForm ritual, string nomeRitual)
        {
            var confirmResult = MessageBox.Show($"Tem Certeza que Quer Remover o Ritual: {nomeRitual}?", "Tem Certeza?", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) return;

            if (ritual == null) return;
            flpRituais.Controls.Remove(ritual);
        }

        #endregion

        #region LayoutPanelPoderActions
        private void btnAddPoder_Click(object sender, EventArgs e)
        {
            PoderForm poder = new(this, cbxClasse.Text, cbxOrigem.Text, cbxTrilha.Text, int.Parse(txtNEX.Text.Replace("%", "")));
            poder.Show();
        }
        internal void adcionarPoder(PoderForm poderForm)
        {
            if (poderForm == null) return;
            poderForm.TopLevel = false;
            flpPoderes.Controls.Add(poderForm);
            flpPoderes.Controls.SetChildIndex(flpPoderes.Controls["btnAddPoder"], flpPoderes.Controls.GetChildIndex(btnAddPoder) + 1);
        }
        public void excluirPoder(PoderForm poderForm, string nomePoder)
        {
            var confirmResult = MessageBox.Show($"Tem Certeza que Quer Remover o Poder: {nomePoder}?", "Tem Certeza?", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) return;

            if (poderForm == null) return;
            flpPoderes.Controls.Remove(poderForm);
        }
        #endregion

        #region EditActions

        public void editar()
        {
            salvar(this, EventArgs.Empty,"add");

            foreach (Button button in this.Controls.OfType<Button>())
            {
                if (!button.Name.Contains("btnIncrease") && !button.Name.Contains("btnDecrease"))
                {
                    button.Enabled = false;
                }
                button.Visible = true;
            }
            foreach (CheckBox cbx in this.Controls.OfType<CheckBox>())
            {
                cbx.Enabled = false;
            }
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Enabled = true;
                txt.ReadOnly = false;
            }
            foreach (ComboBox cbx in this.Controls.OfType<ComboBox>())
            {
                cbx.Enabled = true;
            }

            ResetaInfoDados();
            ResetaRoll();

            btnEditarFicha.Visible = false;
            btnFinalizaEdicao.Visible = true;
            btnFinalizaEdicao.Enabled = true;
            lblEdicao.Visible = true;
            btnCancel.Visible = true;
            btnCancel.Enabled = true;

            txtNome.ReadOnly = true;
            btnAddFicha.Visible = false;
            btnAddFicha.Enabled = false;

            btnAddArma.Enabled = true;
            btnAddCondicoes.Enabled = true;
            btnAddItens.Enabled = true;

            txtNEX.Text = int.Parse(txtNEX.Text.AsSpan(0, txtNEX.Text.IndexOf("%"))).ToString();

            txtDefEsquiva.ReadOnly = true;
        }
        public void btnEditarFicha_Click(object sender, EventArgs e) => editar();
        public void finalizaEdit(object sender, EventArgs e)
        {
            foreach (ComboBox cbx in this.Controls.OfType<ComboBox>())
            {
                cbx.Enabled = false; ;
            }
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.Enabled = true;
                if (button.Name.Contains("btnIncrease") || button.Name.Contains("btnDecrease"))
                {
                    button.Visible = false;
                }
            }
            foreach (ReadOnlyComboBox rcbx in this.Controls.OfType<ReadOnlyComboBox>())
            {
                rcbx.ReadOnly = true;
                rcbx.Enabled = true;
            }
            foreach (CheckBox cbx in this.Controls.OfType<CheckBox>())
            {
                cbx.Enabled = true;
            }
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.ReadOnly = true;
            }
            btnAddFicha.Visible = false;
            btnAddFicha.Enabled = false;
            btnCancel.Visible = false;

            btnEditarFicha.Visible = true;
            btnFinalizaEdicao.Visible = false;
            lblEdicao.Visible = false;

            int.TryParse(txtNEX.Text.Replace("%", ""), out int nex);
            txtNEX.Text = $"{nex}%";

            salvar(sender, e,"auto");
            this.Ficha_Load(sender, e);

        }
        private void btnFinalizaEdicao_Click(object sender, EventArgs e) => finalizaEdit(sender, e);
        private void VerificaInt(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
        }
        private void txtInt_keyPress(object sender, KeyPressEventArgs e) => VerificaInt(sender, e);
        private void btnIncreaseAtributo_Click(object sender, EventArgs e) => incrementaAtributoBtn(sender);
        private void btnDecreaseAtributo_Click(object sender, EventArgs e) => decrementaAtributo(sender);
        private void incrementaAtributoBtn(object sender)
        {
            var btn = (Button)sender;
            foreach (var controls in this.Controls)
            {
                if (controls.GetType() == typeof(RoundButton))
                {
                    var roundbtn = (RoundButton)controls;
                    if (roundbtn.Name.Contains(btn.Name.Replace("btnIncrease", "")))
                    {
                        roundbtn.Text = (int.Parse(roundbtn.Text) + 1).ToString();
                    }
                }
            }
        }
        private void decrementaAtributo(object sender)
        {
            var btn = (Button)sender;
            foreach (var controls in this.Controls)
            {
                if (controls.GetType() == typeof(RoundButton))
                {
                    var roundbtn = (RoundButton)controls;
                    if (roundbtn.Name.Contains(btn.Name.Replace("btnDecrease", "")))
                    {
                        if (int.Parse(roundbtn.Text) <= 0) return;
                        roundbtn.Text = (int.Parse(roundbtn.Text) - 1).ToString();
                    }
                }
            }
        }
        private void incrementaPericiaoBtn(object sender,MouseButtons mouseButton)
        {
            int incremento = 5;
            if(mouseButton == MouseButtons.Right) incremento = 1;

            var btn = (Button)sender;
            foreach (var controls in this.Controls)
            {
                if (controls.GetType() == typeof(CheckBox))
                {
                    var cbx = (CheckBox)controls;
                    if (cbx.Name.Contains(btn.Name.Replace("btnIncrease", "")))
                    {

                        cbx.Text = "+" + (int.Parse(cbx.Text) + incremento).ToString();
                    }
                }
            }
        }
        private void decrementaPericia(object sender, MouseButtons mouseButton)
        {
            int incremento = 5;
            if (mouseButton == MouseButtons.Right) incremento = 1;

            var btn = (Button)sender;
            foreach (var controls in this.Controls)
            {
                if (controls.GetType() == typeof(CheckBox))
                {
                    var cbx = (CheckBox)controls;
                    if (cbx.Name.Contains(btn.Name.Replace("btnDecrease", "")))
                    {
                        if (int.Parse(cbx.Text)-incremento < 0) return;
                        var cbxVal = (int.Parse(cbx.Text) - incremento);
                        if (cbxVal > 0) cbx.Text = "+" + cbxVal.ToString();
                        else cbx.Text = cbxVal.ToString();
                    }
                }
            }
        }
        #endregion

        #region DataActions
        public void salvar(object sender, EventArgs e, string modo)
        {
            Caracteristicas caracteristicas = new Caracteristicas()
            {
                Classe = cbxClasse.Text,
                Nex = int.Parse(Regex.Replace((string)txtNEX.Text, "[^0-9]", "")),
                Nome = txtNome.Text,
                Origem = cbxOrigem.Text,
                Patente = rcbxPatente.Text,
                Prestigio = int.Parse(txtPrestigio.Text),
                Trilha = cbxTrilha.Text,
            };

            Atributos atributos = new Atributos()
            {
                Int = int.Parse(btnInt.Text),
                Agi = int.Parse(btnAgi.Text),
                For = int.Parse(btnFor.Text),
                Vig = int.Parse(btnVig.Text),
                Pre = int.Parse(btnPre.Text),
            };

            Saude saude = new Saude()
            {
                PeAtual = tpbPe.Value,
                PvAtual = tpbPv.Value,
                SanAtual = tpbSan.Value,
                PeTotal = tpbPe.Maximum,
                PvTotal = tpbPv.Maximum,
                SanTotal = tpbSan.Maximum,
            };

            Defesas defesas = new Defesas()
            {
                ResAcido = int.Parse(txtResAcido.Text),
                DefPassiva = int.Parse(txtDefPassiva.Text),
                ResBalistico = int.Parse(txtResBalistico.Text),
                ResConhecimento = int.Parse(txtResConhecimento.Text),
                ResCorte = int.Parse(txtResCorte.Text),
                ResEletrico = int.Parse(txtResEletricidade.Text),
                ResEnergia = int.Parse(txtResEnergia.Text),
                ResFogo = int.Parse(txtResFogo.Text),
                ResFrio = int.Parse(txtResFrio.Text),
                ResImpacto = int.Parse(txtResImpacto.Text),
                ResMedo = int.Parse(txtResMedo.Text),
                ResMental = int.Parse(txtResMental.Text),
                ResMorte = int.Parse(txtResMorte.Text),
                ResPerfuracao = int.Parse(txtResPerfuracao.Text),
                ResSangue = int.Parse(txtResSangue.Text),
                ResVeneno = int.Parse(txtResVeneno.Text),
            };

            Pericias pericias = new Pericias()
            {
                Acrobacia = cbxAcrobacia.Text,
                Adestramento = cbxAdestramento.Text,
                Artes = cbxArtes.Text,
                Atletismo = cbxAtletismo.Text,
                Atualidades = cbxAtualidades.Text,
                Ciencia = cbxCiencia.Text,
                Crime = cbxCrime.Text,
                Diplomacia = cbxDiplomacia.Text,
                Enganacao = cbxEnganacao.Text,
                Fortitude = cbxFortitude.Text,
                Furtividade = cbxFurtividade.Text,
                Iniciativa = cbxIniciativa.Text,
                Intimidacao = cbxIntimidacao.Text,
                Intuicao = cbxIntuicao.Text,
                Investigacao = cbxInvestigacao.Text,
                Luta = cbxLuta.Text,
                Medicina = cbxMedicina.Text,
                Ocultismo = cbxOcultismo.Text,
                Percepcao = cbxPercepcao.Text,
                Pilotagem = cbxPilotagem.Text,
                Pontaria = cbxPontaria.Text,
                Profissao = cbxProfissao.Text,
                Reflexos = cbxReflexos.Text,
                Religiao = cbxReligiao.Text,
                Sobrevivencia = cbxSobrevivencia.Text,
                Tatica = cbxTatica.Text,
                Tecnologia = cbxTecnologia.Text,
                Vontade = cbxVontade.Text,
            };

            List<ArmaObject> armas = new List<ArmaObject>();
            {
                for (int i = 0; i < flpArmas.Controls.Count; i++)
                {
                    if (flpArmas.Controls[i].GetType() == typeof(ArmaForms))
                    {

                        var arma = flpArmas.Controls[i] as ArmaForms;

                        armas.Add(new ArmaObject()
                        {
                            Ataque = (String)arma.Controls["txtAtaque"].Text,
                            Alcance = (String)arma.Controls["txtAlcance"].Text,
                            Critico = (String)arma.Controls["btnCritico"].Text,
                            Dano = (String)arma.Controls["btnDano"].Text,
                            Especial = (String)arma.Controls["txtEspecial"].Text,
                            Modificador = (String)arma.Controls["txtModificadores"].Text,
                            Municao = (String)arma.Controls["txtMunicao"].Text,
                            Nome = (String)arma.Controls["txtNome"].Text,
                            Tipo = (String)arma.Controls["txtTipo"].Text,
                        });
                    }
                }
            }

            string Proeficiencias = txtProeficiencia.Text;

            string ImageFile = this.ImageFile;

            List<CondicaoObject> condicoes = new List<CondicaoObject>();
            {
                for (int i = 0; i < dgvCondicoes.Rows.Count; i++)
                {
                    condicoes.Add(new CondicaoObject()
                    {
                        NomeCondicao = (String)dgvCondicoes.Rows[i].Cells["Condicao"].Value,
                        Tipo = (String)dgvCondicoes.Rows[i].Cells["TipoCondicao"].Value,
                        Upgrade = (String)dgvCondicoes.Rows[i].Cells["Upgrade"].Value,
                    });
                }
            }

            List<InventarioObject> inventario = new List<InventarioObject>();
            {
                for (int i = 0; i < dgvItens.Rows.Count; i++)
                {
                    inventario.Add(new InventarioObject()
                    {
                        Detalhes = (string)dgvItens.Rows[i].Cells["Detalhes"].Value,
                        Espacos = int.Parse(dgvItens.Rows[i].Cells["Espacos"].Value.ToString()),
                        Item = (string)dgvItens.Rows[i].Cells["Item"].Value,
                        Prestigio = int.Parse(dgvItens.Rows[i].Cells["Prestigio"].Value.ToString()),
                        Qtd = int.Parse(dgvItens.Rows[i].Cells["Quantidade"].Value.ToString()),
                    });
                }
            }

            List<RitualObject> rituais = new List<RitualObject>();
            {
                for (int i = 0; i < flpRituais.Controls.Count; i++)
                {
                    if (flpRituais.Controls[i].GetType() == typeof(RitualForm))
                    {
                        var ritual = flpRituais.Controls[i] as RitualForm;

                        var ritualName = ritual.Controls["cbxRitual"].Text;
                        var ritualElemento = ritual.Controls["txtElemento"].Text;
                        var ritualCirculo = int.Parse(ritual.Controls["txtCirculo"].Text);
                        var ritualAcao = ritual.Controls["txtAcao"].Text;
                        var ritualAlcance = ritual.Controls["txtAlcance"].Text;
                        var ritualCusto = ritual.Controls["txtCusto"].Text;
                        var ritualDescricao = ritual.Controls["txtDescricao"].Text;
                        var ritualResistencia = ritual.Controls["txtResistencia"].Text;
                        var ritualDuracao = ritual.Controls["txtDuracao"].Text;

                        rituais.Add(new RitualObject()
                        {
                            Acao = ritualAcao,
                            Alcance = ritualAlcance,
                            Circulo = ritualCirculo,
                            Custo = ritualCusto,
                            Descricao = ritualDescricao,
                            Duracao = ritualDuracao,
                            Elemento = ritualElemento,
                            Resistencia = ritualResistencia,
                            Ritual = ritualName
,
                        });
                    }
                }
            }

            List<PoderObject> poderes = new List<PoderObject>();
            {
                for (int i = 0; i < flpPoderes.Controls.Count; i++)
                {
                    if (flpPoderes.Controls[i].GetType() == typeof(PoderForm))
                    {
                        var poder = flpPoderes.Controls[i] as PoderForm;
                        var poderNome = poder.Controls["cbxPoder"].Text;
                        var poderElemento = poder.Controls["txtElemento"].Text;
                        var poderRequisito = poder.Controls["txtRequisito"].Text;
                        var poderDescricao = poder.Controls["txtDescricao"].Text;

                        poderes.Add(new PoderObject()
                        {
                            Descricao = poderDescricao,
                            Elemento = poderElemento,
                            Poder = poderNome,
                            Requisito = poderRequisito,
                        });
                    }
                }
            };
            FichaObject fichaObject = new FichaObject()
            {
                Armas = armas,
                Atributos = atributos,
                Condicao = condicoes,
                Defesas = defesas,
                Inventario = inventario,
                Pericias = pericias,
                Saude = saude,
                ImageFile = ImageFile,
                Proeficiencias = Proeficiencias,
                Caracteristicas = caracteristicas,
                RitualObject = rituais,
                PoderObject = poderes
            };
            
            string fileName = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent + $@"\FichasData\{caracteristicas.Nome}.json";
            string jsonStringSerialize = JsonSerializer.Serialize(fichaObject);

            if (modo != "add")
            {
                string jsonStringDeserialize = null;
                try
                {
                    jsonStringDeserialize = File.ReadAllText(fileName);

                }
                catch
                {
                    salvar(sender, e, "add");
                }
                if (jsonStringSerialize == jsonStringDeserialize) return;

            }
            if (modo == "manual")
            {
                var salvar = MessageBox.Show("Voce Deseja Salvar a Ficha?", "Salvar a Ficha", MessageBoxButtons.YesNo);
                if (salvar == DialogResult.Yes)
                {
                    fichaBase = fichaObject;
                    File.WriteAllText(fileName, jsonStringSerialize);
                }
            }
            else
            {
                fichaBase = fichaObject;
            }


        }
        private void btnSalvar_Click(object sender, EventArgs e) => salvar(sender, e,"manual");
        private void carregaData(FichaObject fichaObject)
        {
            if (fichaObject.ImageFile != null)
            {
                pbxToken.Image = Image.FromFile(fichaObject.ImageFile);
            }
            else
            {
                if (ImageFile != null)
                {
                    pbxToken.Image = Image.FromFile(ImageFile);
                }
            }

            cbxClasse.Text = fichaObject.Caracteristicas.Classe;
            txtNEX.Text = fichaObject.Caracteristicas.Nex + "%";
            txtNome.Text = fichaObject.Caracteristicas.Nome;
            cbxOrigem.Text = fichaObject.Caracteristicas.Origem;
            rcbxPatente.Text = fichaObject.Caracteristicas.Patente;
            cbxTrilha.Text = fichaObject.Caracteristicas.Trilha;
            txtPrestigio.Text = fichaObject.Caracteristicas.Prestigio.ToString();

            btnAgi.Text = fichaObject.Atributos.Agi.ToString();
            btnInt.Text = fichaObject.Atributos.Int.ToString();
            btnFor.Text = fichaObject.Atributos.For.ToString();
            btnPre.Text = fichaObject.Atributos.Pre.ToString();
            btnVig.Text = fichaObject.Atributos.Vig.ToString();

            tpbPe.Maximum = fichaObject.Saude.PeTotal;
            tpbPv.Maximum = fichaObject.Saude.PvTotal;
            tpbSan.Maximum = fichaObject.Saude.SanTotal;
            tpbPe.Value = fichaObject.Saude.PeAtual;
            tpbPv.Value = fichaObject.Saude.PvAtual;
            tpbSan.Value = fichaObject.Saude.SanAtual;

            txtResAcido.Text = fichaObject.Defesas.ResAcido.ToString();
            txtDefPassiva.Text = fichaObject.Defesas.DefPassiva.ToString();
            txtResBalistico.Text = fichaObject.Defesas.ResBalistico.ToString();
            txtResConhecimento.Text = fichaObject.Defesas.ResConhecimento.ToString();
            txtResCorte.Text = fichaObject.Defesas.ResCorte.ToString();
            txtResEletricidade.Text = fichaObject.Defesas.ResEletrico.ToString();
            txtResEnergia.Text = fichaObject.Defesas.ResEnergia.ToString();
            txtResFogo.Text = fichaObject.Defesas.ResFogo.ToString();
            txtResFrio.Text = fichaObject.Defesas.ResFrio.ToString();
            txtResImpacto.Text = fichaObject.Defesas.ResImpacto.ToString();
            txtResMedo.Text = fichaObject.Defesas.ResMedo.ToString();
            txtResMental.Text = fichaObject.Defesas.ResMental.ToString();
            txtResMorte.Text = fichaObject.Defesas.ResMorte.ToString();
            txtResPerfuracao.Text = fichaObject.Defesas.ResPerfuracao.ToString();
            txtResSangue.Text = fichaObject.Defesas.ResSangue.ToString();
            txtResVeneno.Text = fichaObject.Defesas.ResVeneno.ToString();

            cbxAcrobacia.Text = fichaObject.Pericias.Acrobacia;
            cbxAdestramento.Text = fichaObject.Pericias.Adestramento;
            cbxArtes.Text = fichaObject.Pericias.Artes;
            cbxAtletismo.Text = fichaObject.Pericias.Atletismo;
            cbxAtualidades.Text = fichaObject.Pericias.Atualidades;
            cbxCiencia.Text = fichaObject.Pericias.Ciencia;
            cbxCrime.Text = fichaObject.Pericias.Crime;
            cbxDiplomacia.Text = fichaObject.Pericias.Diplomacia;
            cbxEnganacao.Text = fichaObject.Pericias.Enganacao;
            cbxFortitude.Text = fichaObject.Pericias.Fortitude;
            cbxFurtividade.Text = fichaObject.Pericias.Furtividade;
            cbxIniciativa.Text = fichaObject.Pericias.Iniciativa;
            cbxIntimidacao.Text = fichaObject.Pericias.Intimidacao;
            cbxIntuicao.Text = fichaObject.Pericias.Intuicao;
            cbxInvestigacao.Text = fichaObject.Pericias.Investigacao;
            cbxLuta.Text = fichaObject.Pericias.Luta;
            cbxMedicina.Text = fichaObject.Pericias.Medicina;
            cbxOcultismo.Text = fichaObject.Pericias.Ocultismo;
            cbxPercepcao.Text = fichaObject.Pericias.Percepcao;
            cbxPilotagem.Text = fichaObject.Pericias.Pilotagem;
            cbxPontaria.Text = fichaObject.Pericias.Pontaria;
            cbxProfissao.Text = fichaObject.Pericias.Profissao;
            cbxReflexos.Text = fichaObject.Pericias.Reflexos;
            cbxReligiao.Text = fichaObject.Pericias.Religiao;
            cbxSobrevivencia.Text = fichaObject.Pericias.Sobrevivencia;
            cbxTatica.Text = fichaObject.Pericias.Tatica;
            cbxTecnologia.Text = fichaObject.Pericias.Tecnologia;
            cbxVontade.Text = fichaObject.Pericias.Vontade;



            flpArmas.Controls.Clear();
            flpArmas.Controls.Add(btnAddArma);
            for (int i = 0; i < fichaObject.Armas.Count; i++)
            {
                var armaName = fichaObject.Armas[i].Tipo.Substring(0, fichaObject.Armas[i].Tipo.IndexOf(" ("));
                var arma = new Arma().GetArmas().Where(x => x.Name == armaName).FirstOrDefault();
                if (fichaObject.Armas[i].Modificador == null) fichaObject.Armas[i].Modificador = "";
                ArmaForms armas = new ArmaForms(this, lblMelhorDado, arma, fichaObject.Armas[i].Nome, fichaObject.Armas[i].Modificador.Split(", "));
                armas.Show();

                armas.Controls["txtNome"].Text = fichaObject.Armas[i].Nome;
                armas.Controls["txtAtaque"].Text = fichaObject.Armas[i].Ataque;
                armas.Controls["txtAlcance"].Text = fichaObject.Armas[i].Alcance;
                armas.Controls["txtTipo"].Text = fichaObject.Armas[i].Tipo;
                armas.Controls["txtMunicao"].Text = fichaObject.Armas[i].Municao;
                armas.Controls["btnDano"].Text = fichaObject.Armas[i].Dano;
                armas.Controls["btnCritico"].Text = fichaObject.Armas[i].Critico;
                armas.Controls["txtModificadores"].Text = fichaObject.Armas[i].Modificador;
                armas.Controls["txtEspecial"].Text = fichaObject.Armas[i].Especial;

                flpArmas.Controls.Add(armas);
                flpArmas.Controls.SetChildIndex(flpArmas.Controls["btnAddArma"], flpArmas.Controls.GetChildIndex(btnAddArma) + 1);

            }


            txtProeficiencia.Text = fichaObject.Proeficiencias;

            dgvCondicoes.Rows.Clear();
            for (int i = 0; i < fichaObject.Condicao.Count; i++)
            {
                if (btnAddCondicoes.Location.Y < dgvCondicoes.Bottom - btnAddCondicoes.Height * 2)
                {
                    btnAddCondicoes.Location = new Point(btnAddCondicoes.Location.X, btnAddCondicoes.Location.Y + btnAddCondicoes.Height);
                }

                DataGridViewRow newRow = dgvCondicoes.Rows[dgvCondicoes.Rows.Add()];
                newRow.Cells["Condicao"].Value = fichaObject.Condicao[i].NomeCondicao;
                newRow.Cells["TipoCondicao"].Value = fichaObject.Condicao[i].Tipo;
                newRow.Cells["Upgrade"].Value = fichaObject.Condicao[i].Upgrade;
            }

            dgvItens.Rows.Clear();
            for (int i = 0; i < fichaObject.Inventario.Count; i++)
            {
                if (btnAddItens.Location.Y < dgvItens.Bottom - btnAddItens.Height * 2)
                {
                    btnAddItens.Location = new Point(btnAddItens.Location.X, btnAddItens.Location.Y + btnAddItens.Height);
                }

                DataGridViewRow newRow = dgvItens.Rows[dgvItens.Rows.Add()];
                newRow.Cells["Quantidade"].Value = fichaObject.Inventario[i].Qtd;
                newRow.Cells["Espacos"].Value = fichaObject.Inventario[i].Espacos;
                newRow.Cells["Prestigio"].Value = fichaObject.Inventario[i].Prestigio;
                newRow.Cells["Detalhes"].Value = fichaObject.Inventario[i].Detalhes;
                newRow.Cells["Item"].Value = fichaObject.Inventario[i].Item;

            }

            flpRituais.Controls.Clear();
            flpRituais.Controls.Add(btnAddRitual);
            for (int i = 0; i < fichaObject.RitualObject.Count; i++)
            {
                RitualForm ritual = new RitualForm(this, int.Parse(txtNEX.Text.Replace("%", "")));
                ritual.Show();

                ritual.Controls["cbxRitual"].Text = fichaObject.RitualObject[i].Ritual;
                ritual.Controls["txtElemento"].Text = fichaObject.RitualObject[i].Elemento;
                ritual.Controls["txtCirculo"].Text = fichaObject.RitualObject[i].Circulo.ToString();
                ritual.Controls["txtAcao"].Text = fichaObject.RitualObject[i].Acao;
                ritual.Controls["txtAlcance"].Text = fichaObject.RitualObject[i].Alcance;
                ritual.Controls["txtCusto"].Text = fichaObject.RitualObject[i].Custo;
                ritual.Controls["txtDescricao"].Text = fichaObject.RitualObject[i].Descricao.Replace("\n", Environment.NewLine); ;
                ritual.Controls["txtResistencia"].Text = fichaObject.RitualObject[i].Resistencia;
                ritual.Controls["txtDuracao"].Text = fichaObject.RitualObject[i].Duracao;

                ritual.addRitual();

            }

            flpPoderes.Controls.Clear();
            flpPoderes.Controls.Add(btnAddPoder);

            for (int i = 0; i < fichaObject.PoderObject.Count; i++)
            {
                PoderForm poderes = new PoderForm(this, cbxClasse.Text, cbxOrigem.Text, cbxTrilha.Text, int.Parse(txtNEX.Text.Replace("%", "")));
                poderes.Show();

                poderes.Controls["cbxPoder"].Text = fichaObject.PoderObject[i].Poder;
                poderes.Controls["txtElemento"].Text = fichaObject.PoderObject[i].Elemento;
                poderes.Controls["txtRequisito"].Text = fichaObject.PoderObject[i].Requisito;
                poderes.Controls["txtDescricao"].Text = fichaObject.PoderObject[i].Descricao;


                poderes.addPoder();

            }

            fichaBase = fichaObject;
            this.carregaInfos();
        }
        private void btnAddFicha_Click(object sender, EventArgs e)
        {
            bool infoFaltando = false;
            if (cbxClasse.Text == "" || cbxClasse.Text == null) { cbxClasse.BackColor = Color.Red; infoFaltando = true; } else { cbxClasse.BackColor = Color.White; }
            if (txtNome.Text == "" || txtNome.Text == null) { txtNome.BackColor = Color.Red; infoFaltando = true; } else { txtNome.BackColor = Color.White; }
            if (cbxOrigem.Text == "" || cbxOrigem.Text == null) { cbxOrigem.BackColor = Color.Red; infoFaltando = true; } else { cbxOrigem.BackColor = Color.White; }
            if (cbxTrilha.Text == "" || cbxTrilha.Text == null) { cbxTrilha.BackColor = Color.Red; infoFaltando = true; } else { cbxTrilha.BackColor = Color.White; }

            if (infoFaltando) return;

            txtNome.Text = txtNome.Text.ToUpper();

            salvar(sender, e,"add");
            this.finalizaEdit(sender, e);

            Menu.Form1_Load(sender, e);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirmaExclusao = MessageBox.Show("Tem Certeza que Deseja Cancelar a Edição?", "Cancelar Edicao", MessageBoxButtons.YesNo);
            if (confirmaExclusao == DialogResult.No) return;

            if (txtNome.Text == "" || txtNome.Text == null)
            {
                Close();
            }
            else
            {
                carregaData(fichaBase);
                finalizaEdit(sender, e);
            }

        }
        #endregion

        private void pbxToken_MouseDown(object sender, MouseEventArgs e)
        {
            List<ToolStripMenuItem> toolStripItem = new();

            ToolStripMenuItem toolStripItem1 = new();
            toolStripItem1.Text = "Excluir Imagem";
            toolStripItem1.Click += new EventHandler((sender, arg) => ExcluirImagem());
            toolStripItem.Add(toolStripItem1);

            ToolStripMenuItem toolStripItem2 = new();
            toolStripItem2.Text = "Adicionar Imagem";
            toolStripItem2.Click += new EventHandler((sender, args) => AddImg());
            toolStripItem.Add(toolStripItem2);

            ContextMenuStrip strip = new ContextMenuStrip();
            foreach (var item in toolStripItem)
            {
                strip.Items.Add(item);
            }
            pbxToken.ContextMenuStrip = strip;
        }
        private void AddImg()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Title = "Localizar Imagem";
            openFileDialog.DefaultExt = "jpg";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImageFile = openFileDialog.FileName;
                    pbxToken.Image = Image.FromFile(ImageFile);
                    pbxToken.Text = null;

                    fichaBase.ImageFile = ImageFile;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                "Mensagem : " + ex.Message + "\n\n" +
                                                "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não é possível exibir a imagem : " + ImageFile.Substring(ImageFile.LastIndexOf('\\'))
                                               + ". Você pode não ter permissão para ler o arquivo , ou " +
                                               " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                }
            }
        }
        private void ExcluirImagem()
        {
            var confirmaExclusao = MessageBox.Show("Tem Certeza que Deseja excluir a Imagem", "Excluir Imagem", MessageBoxButtons.YesNo);
            if (confirmaExclusao == DialogResult.No) return;

            ImageFile = null;
            pbxToken.Image = null;
        }
        private void SaveTimer_tick(object sender, EventArgs e)
        {
            if (!lblEdicao.Visible) salvar(sender, e,"auto");
        }
        private void tpb_MouseMove(object sender, MouseEventArgs e)
        {
            var tpb = sender as TextProgressBar;
            if (MousePosition.X > (tpb.Left + tpb.Width / 2)) Cursor = Cursors.Cross;
            if (MousePosition.X < (tpb.Left + tpb.Width / 2)) Cursor = Cursors.PanWest;
            MousePositionX = MousePosition.X;
        }
        private int MousePositionX = 0;
        private MouseButtons buttonPressed;
        private void tpb_MouseDown(object sender, MouseEventArgs e) => buttonPressed = e.Button;
        private void tpb_MouseLeave(object sender, EventArgs e) => Cursor = Cursors.Default;
        private void tpb_Click(object sender, EventArgs e)
        {
            var tpb = sender as TextProgressBar;
            if (buttonPressed == MouseButtons.Left)
            {
                modificaProgress(1, tpb);
            }
            if (buttonPressed == MouseButtons.Right)
            {
                SaudeForms saude = new SaudeForms(tpb);
                saude.ShowDialog();
            }
        }
        public void modificaProgress(int val, TextProgressBar tpb)
        {
            if (MousePositionX > tpb.Left + (tpb.Width / 2))
            {
                if (tpb.Value == tpb.Maximum)
                {
                    tpb.Incremento += val;
                }
                else
                {
                    tpb.Increment(val);
                    if (tpb.Value >= tpb.Maximum / 2 + 0.5)
                    {
                        for (int i = 0; i < dgvCondicoes.Rows.Count; i++)
                        {
                            var condicao = "";
                            if (tpb.Name.Contains("San")) condicao = "Perturbado";
                            if (tpb.Name.Contains("Pv")) condicao = "Machucado";
                            if (tpb.Name.Contains("Pe")) return;
                            if (dgvCondicoes.Rows[i].Cells[0].Value.ToString() == condicao)
                            {
                                dgvCondicoes.Rows.RemoveAt(i);
                            }
                        }
                    }
                }
            }
            else
            {
                if (tpb.Incremento > 0)
                {
                    tpb.Incremento -= val;
                }
                else
                {
                    tpb.Increment(-val);

                    if (tpb.Value < tpb.Maximum / 2 + 0.5)
                    {
                        var condicao = "";
                        var tipo = "";
                        if (tpb.Name.Contains("San")) { condicao = "Perturbado"; tipo = "Mental"; }
                        if (tpb.Name.Contains("Pv")) {condicao = "Machucado"; tipo = "Geral";}
                        if (tpb.Name.Contains("Pe")) return;
                        for (int i = 0; i < dgvCondicoes.Rows.Count; i++)
                        {
                            if (dgvCondicoes.Rows[i].Cells[0].Value.ToString() == condicao) return;
                        }
                        DataGridViewRow newRow = dgvCondicoes.Rows[dgvCondicoes.Rows.Add()];
                        newRow.Cells[0].Value = condicao;
                        newRow.Cells[1].Value = tipo;
                    }
                }
            }
        }
        private void editaSaude(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn.Name.Contains("Increase"))
            {
                foreach (var controls in this.Controls)
                {
                    if (controls.GetType() == typeof(TextProgressBar))
                    {
                        var tpb = (TextProgressBar)controls;
                        tpb.Incremento = 0;

                        if (tpb.Name.Contains(btn.Name.Replace("btnIncrease", "")))
                        {
                            tpb.Maximum++;
                        }
                    }
                }
            }
            else if (btn.Name.Contains("Decrease"))
            {
                foreach (var controls in this.Controls)
                {
                    if (controls.GetType() == typeof(TextProgressBar))
                    {
                        var tpb = (TextProgressBar)controls;
                        tpb.Incremento = 0;

                        if (tpb.Name.Contains(btn.Name.Replace("btnDecrease", "")) && tpb.Maximum>0)
                        {
                            tpb.Maximum--;
                        }
                    }
                }
            }
        }
        private void dgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            var dgv = sender as DataGridView;
            if (dgv.Rows.Count <= 0 || e.RowIndex < 0) return;
            dgv.CurrentCell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];


            if (dgv.ContextMenuStrip != null) dgv.ContextMenuStrip.Dispose();
            if (dgv.Rows.Count <= 0) return;

            Button btn = this.Controls[dgv.Name.Replace("dgv", "btnAdd")] as Button;

            List<ToolStripMenuItem> toolStripItem = new();

            ToolStripMenuItem toolStripItem1 = new();
            toolStripItem1.Text = "Excluir Item";
            toolStripItem1.Click += new EventHandler((sender, arg) => DgvComportamento.ExcluirLinha(dgv, btn, null, dgvItens, btnAddItens));
            toolStripItem.Add(toolStripItem1);

            ContextMenuStrip strip = new ContextMenuStrip();

            foreach (var item in toolStripItem)
            {
                strip.Items.Add(item);
            }

            dgv.ContextMenuStrip = strip;

        }
        private DataGridViewCellEventArgs mouseLocation;
        private void dgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            mouseLocation = e;
            DgvComportamento.SetMouseType(sender, e);
            var dgv = sender as DataGridView;
            if (dgv.Name.Contains("Condicoes")) DgvComportamento.ShowTooltipCondicoes(sender, e);
        }
        private void readOnlyComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipPatente.ShowAlways = true;
            if (rcbxPatente.Text == "Recruta") tipPatente.SetToolTip(this.rcbxPatente, "Crédito Baixo\n\nPrestígio\nI - 2\nII - 0\nIII - 0\nIV - 0\n");
            if (rcbxPatente.Text == "Operador") tipPatente.SetToolTip(this.rcbxPatente, "Crédito Médio\n\nPrestígio\nI - 3\nII - 1\nIII - 0\nIV - 0\n");
            if (rcbxPatente.Text == "Agente especial") tipPatente.SetToolTip(this.rcbxPatente, "Crédito Médio\n\nPrestígio\nI - 3\nII - 2\nIII - 1\nIV - 0\n");
            if (rcbxPatente.Text == "Oficial de operações") tipPatente.SetToolTip(this.rcbxPatente, "Crédito Alto\n\nPrestígio\nI - 3\nII - 3\nIII - 2\nIV - 1\n");
            if (rcbxPatente.Text == "Agente de elite") tipPatente.SetToolTip(this.rcbxPatente, "Crédito Ilimitado\n\nPrestígio\nI - 3\nII - 3\nIII - 3\nIV - 2\n");
        }
        private void rcbxPatente_MouseHover(object sender, EventArgs e)
        {
            tipPatente.Show(tipPatente.GetToolTip(rcbxPatente), rcbxPatente);
        }
        private void rcbxPatente_MouseLeave(object sender, EventArgs e)
        {
            tipPatente.Hide(rcbxPatente);
        }
        private void txtPrestigio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrestigio.Text == null || txtPrestigio.Text == "") return;

            if (int.Parse(txtPrestigio.Text) < 20) rcbxPatente.Text = "Recruta";
            if (int.Parse(txtPrestigio.Text) >= 20) rcbxPatente.Text = "Operador";
            if (int.Parse(txtPrestigio.Text) >= 50) rcbxPatente.Text = "Agente especial";
            if (int.Parse(txtPrestigio.Text) >= 100) rcbxPatente.Text = "Oficial de operações";
            if (int.Parse(txtPrestigio.Text) >= 200) rcbxPatente.Text = "Agente de elite";
        }
        private void btnIncreaseVontade_MouseClick(object sender, MouseEventArgs e) => incrementaPericiaoBtn(sender,e.Button);
        private void btnDecreasePericia_Click(object sender, MouseEventArgs e) => decrementaPericia(sender, e.Button);
    }
}


using RPGFichas.Domain.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RPGFichas.Domain
{
    public  class DgvComportamento
    {
        Dados Dados = new();
        Arma Arma = new();
        Condicoes condicoes = new();

        public void DgvArmasActions(string dano, string? crit,Label lblMelhorDado)
        {
            if (dano == null || dano .Length<=0) return;

            if (crit!=null) DarDano(dano, crit,lblMelhorDado);
            else DarDano(dano, null,lblMelhorDado);

        }
        public void DgvCondicoesActions(object sender)
        {
            var dgv = sender as DataGridView;
            if (dgv == null || dgv?.CurrentCell.Value == null) return;

            Condicoes? condicaoUsada = condicoes.GetCondicoes().FirstOrDefault(x => dgv.CurrentCell.OwningRow.Cells["Condicao"].
            Value.ToString() ==  x.Condicao);

            switch (dgv.CurrentCell.OwningColumn.Name)
            {
                case "Upgrade": Upgrade(dgv.CurrentRow, condicaoUsada); break;
            }
        }
        private void Upgrade(DataGridViewRow currentRow, Condicoes? condicaoUsada)
        {
            var upgrade = condicaoUsada.Upgrade;
            if (upgrade == null) return ;

            var condicaoUpgrade = condicoes.GetCondicoes().Where(x => x.Condicao == upgrade).FirstOrDefault();
            if (condicaoUpgrade == null) return;

            currentRow.Cells["Condicao"].Value = condicaoUpgrade.Condicao;
            currentRow.Cells["TipoCondicao"].Value = condicaoUpgrade.Tipo;
            currentRow.Cells["Upgrade"].Value = condicaoUpgrade.Upgrade;

        }
        private void ReduzirMunicao(DataGridViewRow currentRow)
        {
            if (currentRow.Cells["Municao"].Value == null) return;

            var CellRecargaValue = currentRow.Cells["Municao"].Value.ToString();
            if (CellRecargaValue == "" || CellRecargaValue == null || !CellRecargaValue.Contains("/")) return;


            var Recarga = int.Parse(Regex.Match(CellRecargaValue, @"\d+").Value);
            var Acao = CellRecargaValue.Substring(CellRecargaValue.IndexOf("/"));
            var Municao = CellRecargaValue.Substring(0,CellRecargaValue.IndexOf("(") + 1);

            if (Recarga <= 0)
            {
                MessageBox.Show("Sem Munição\nRecarregue a Arma", "Recarregue", MessageBoxButtons.OK);
                return;
            }
            currentRow.Cells["Municao"].Value = $"{Municao}{Recarga-1}{Acao}";


        }
        public void DarDano(string dano,string? crit,Label lblMelhorDado)
        {
            var quantidadeDados = int.Parse(dano.Substring(0, dano.IndexOf("D")));
            if (crit != null)
            {
                quantidadeDados *= int.Parse(crit.Substring(crit.IndexOf("x") + 1, 1));
            }
            int quantidadeLados = GetQuantidadeLados(dano);
            var bonus = GetQuantidadeBonus(dano);
                
            Dados.rollDadosBonus(quantidadeDados, quantidadeLados,lblMelhorDado,bonus);
        }

        public void ExcluirLinha(DataGridView dgv, Button addButton, Label lblEspacoAtual, DataGridView dgvItem, Button addButtonItem)
        {
            if (dgv.CurrentCell == null || dgv.Rows.Count < 1) return;

            var confirmResult = MessageBox.Show("Tem Certeza que Quer Remover?", "Tem Certeza?", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) return;

            if (lblEspacoAtual != null)
            {
                lblEspacoAtual.Text = (int.Parse(lblEspacoAtual.Text) + (int.Parse(dgv.CurrentRow.Cells["Espacos"].Value.ToString())
                * int.Parse(dgv.CurrentRow.Cells["Quantidade"].Value.ToString()))).ToString();
            }


            dgv.Rows.RemoveAt(dgv.CurrentCell.RowIndex);


            if (addButton.Location.Y - addButton.Height > dgv.Location.Y)
            {
                addButton.Location = new Point(addButton.Location.X, addButton.Location.Y - addButton.Height);
            }


        }
        public void ShowTooltipCondicoes(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            SetMouseType(sender, e);

            var dgv = sender as DataGridView;
            var row = dgv.Rows[e.RowIndex];
            var condicao = condicoes.GetCondicoes().Where(x=>x.Condicao==row.Cells[0].Value.ToString()).FirstOrDefault();

            if (condicao == null) return;
            else
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    row.Cells[i].ToolTipText = condicao.Descricao;
                }
            }


        }
        public void SetMouseType(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            var colType = dgv.Columns[e.ColumnIndex].CellType.Name;

            if (colType != "DataGridViewButtonCell" || dgv.Rows.Count == 0 || e.RowIndex < 0) dgv.Cursor = Cursors.Arrow;
            else dgv.Cursor = Cursors.Hand;            
        }
        private static int GetQuantidadeBonus(string cellDano)
        {
            int bonus = 0;
            if (cellDano.Contains("+"))
            {
                
                var BonusString = cellDano.Substring(cellDano.IndexOf("+") + 1);
                for (int i = 0; i < BonusString.Length; i++)
                {
                    if (char.IsDigit(BonusString[i])) bonus += int.Parse(BonusString[i].ToString());
                }
            }
            return bonus;
        }
        private static int GetQuantidadeLados(string cellDano)
        {

            int quantidadeLados;
            

            if (cellDano.Contains("+"))
            {
                quantidadeLados = int.Parse(cellDano.Substring(cellDano.IndexOf("D") + 1, cellDano.IndexOf("+") - 2));
            }
            else
            {
                quantidadeLados = int.Parse(cellDano.Substring(cellDano.IndexOf("D") + 1));
            }

            return quantidadeLados;
        }
        public void ModificaArma(Form arma, string[] modificadores)
        {
            for(int i = 0;i < modificadores.Length; i++)
            {
                switch (modificadores[i])
                {
                    case "Certeira":
                        arma.Controls["txtAtaque"].Text = "+" + (int.Parse((string)arma.Controls["txtAtaque"].Text) + 2).ToString();
                        break;
                    case "Cruel":
                        arma.Controls["btnDano"].Text += " + 2";
                        break;
                    case "Perigosa":
                        var cellCriticoPerigoso = arma.Controls["btnCritico"].Text.ToString();
                        arma.Controls["btnCritico"].Text = int.Parse(cellCriticoPerigoso.Substring(0, cellCriticoPerigoso.IndexOf("/"))) - 2 + cellCriticoPerigoso.Substring(cellCriticoPerigoso.IndexOf("/"));
                        break;
                    case "Alongada":
                        arma.Controls["txtAtaque"].Text = "+" + (int.Parse(arma.Controls["txtAtaque"].Text) +2).ToString();
                        break;
                    case "Calibre Grosso":
                        var cellDanoCG = (string)arma.Controls["btnDano"].Text;
                        arma.Controls["btnDano"].Text = (int.Parse(cellDanoCG.Substring(0, cellDanoCG.IndexOf("D"))) + 1) + cellDanoCG.Substring(cellDanoCG.IndexOf("D"));
                        break;
                    case "Ferrolho Automático":
                        if (arma.Controls["txtEspecial"].Text != null) arma.Controls["txtEspecial"].Text += " + ";
                        arma.Controls["txtEspecial"].Text += "Automática";
                        break;
                    case "Mira laser":
                        var cellCritico = arma.Controls["btnCritico"].Text.ToString();
                        arma.Controls["btnCritico"].Text = int.Parse(cellCritico.Substring(0, cellCritico.IndexOf("/")))-2 + cellCritico.Substring(cellCritico.IndexOf("/"));
                        break;
                    case "Mira Telescópica":
                        if (arma.Controls["txtAlcance"].Text == null) return;
                        var cellAlcance = arma.Controls["txtAlcance"].Text.ToString();
                        switch (cellAlcance) 
                        {
                            case "Curto":
                                arma.Controls["txtAlcance"].Text = "Médio"; break;
                            case "Médio":
                                arma.Controls["txtAlcance"].Text = "Longo"; break;
                            default: break;
                        }
                        break;
                    default: break;
                }
            }
        }
    }
}

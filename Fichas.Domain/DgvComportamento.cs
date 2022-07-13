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

        public void DgvArmasActions(object sender, Label lblMelhorDado)
        {
            var dgv = sender as DataGridView;
            if (dgv?.CurrentCell.Value == null) return;

            Arma? armaUsada = Arma.GetArmas().FirstOrDefault(x => dgv.CurrentCell.OwningRow.Cells["Tipo"].
            Value.ToString().Contains(x.Name));

            switch (dgv.CurrentCell.OwningColumn.Name)
            {
                case "Dano": DarDano(dgv.CurrentCell, lblMelhorDado); break;
                case "Critico": DarDanoCritico(dgv.CurrentRow, lblMelhorDado); break;
                case "Ataque": ReduzirMunicao(dgv.CurrentRow); break;
            }
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
        private void DarDanoCritico(DataGridViewRow currentRow, Label lblMelhorDado)
        {
            var CellCritico = currentRow.Cells["Critico"].Value.ToString();
            if (currentRow.Cells["Dano"].Value == null) return;
            var CellDano = currentRow.Cells["Dano"].Value.ToString();

            var quantidadeDados = int.Parse(CellDano.Substring(0, CellDano.IndexOf("D"))) * int.Parse(CellCritico.Substring(CellCritico.IndexOf("x") + 1, 1));
            var quantidadeLados = GetQuantidadeLados(CellDano);
            var bonus = GetQuantidadeBonus(CellDano);

            Dados.rollDadosBonus(quantidadeDados, quantidadeLados, lblMelhorDado);
        }
        public void DarDano(DataGridViewCell dgvCurrentCell,Label lblMelhorDado)
        {
            var Cell = dgvCurrentCell.Value.ToString();
            var quantidadeDados = int.Parse(Cell.Substring(0, Cell.IndexOf("D")));
            int quantidadeLados = GetQuantidadeLados(Cell);
            var bonus = GetQuantidadeBonus(Cell);
                
            Dados.rollDadosBonus(quantidadeDados, quantidadeLados,lblMelhorDado,bonus);
        }
        public void ExcluirLinha(DataGridView dgv, Button addButton) => ExcluirLinha(dgv, addButton, null,null,null);
        public void ExcluirLinha(DataGridView dgv, Button addButton, DataGridView dgvItem, Button addButtonItem) => ExcluirLinha(dgv, addButton, null, dgvItem,addButtonItem);
        public void ExcluirLinha(DataGridView dgv,Button addButton,Label lblEspacoAtual, DataGridView dgvItem, Button addButtonItem)
        {
            if (dgv.CurrentCell == null || dgv.Rows.Count<1) return;

            var confirmResult = MessageBox.Show("Tem Certeza que Quer Remover?", "Tem Certeza?", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) return;

            if (lblEspacoAtual != null)
            {
                lblEspacoAtual.Text = (int.Parse(lblEspacoAtual.Text) + (int.Parse(dgv.CurrentRow.Cells["Espacos"].Value.ToString())
                * int.Parse(dgv.CurrentRow.Cells["Quantidade"].Value.ToString()))).ToString();
            }

            try
            {
                if (dgvItem == null || dgvItem == dgv || dgvItem.Rows.Count <= 0) throw new Exception();

                for (int i = 0; i < dgvItem.Rows.Count; i++)
                {
                    if ((string)dgvItem.Rows[i].Cells["Item"].Value == (string)dgv.CurrentRow.Cells["Nome"].Value)
                    {
                        dgvItem.Rows.RemoveAt(i);
                    }

                    if (addButtonItem.Location.Y - addButtonItem.Height > dgvItem.Location.Y)
                    {
                        addButtonItem.Location = new Point(addButtonItem.Location.X, addButtonItem.Location.Y - addButtonItem.Height);
                    }

                };

                dgv.Rows.RemoveAt(dgv.CurrentCell.RowIndex);
            }
            catch
            {
                dgv.Rows.RemoveAt(dgv.CurrentCell.RowIndex);
            }
            finally
            {

                if (addButton.Location.Y - addButton.Height > dgv.Location.Y)
                {
                    addButton.Location = new Point(addButton.Location.X, addButton.Location.Y - addButton.Height);
                }
            }

        }
        public void ShowTooltip(object sender, DataGridViewCellEventArgs e)
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
        public void ModificaArma(DataGridViewRow dgvRow, string[] modificadores)
        {
            for(int i = 0;i < modificadores.Length; i++)
            {
                switch (modificadores[i])
                {
                    case "Certeira":
                        dgvRow.Cells["Ataque"].Value = (int.Parse((string)dgvRow.Cells["Ataque"].Value) + 2).ToString();
                        break;
                    case "Cruel":
                        dgvRow.Cells["Dano"].Value += " + 2";
                        break;
                    case "Perigosa":
                        var cellCriticoPerigoso = dgvRow.Cells["Critico"].Value.ToString();
                        dgvRow.Cells["Critico"].Value = int.Parse(cellCriticoPerigoso.Substring(0, cellCriticoPerigoso.IndexOf("/"))) - 2 + cellCriticoPerigoso.Substring(cellCriticoPerigoso.IndexOf("/"));
                        break;
                    case "Alongada":
                        dgvRow.Cells["Ataque"].Value = (int.Parse((string)dgvRow.Cells["Ataque"].Value) +2).ToString();
                        break;
                    case "Calibre Grosso":
                        var cellDanoCG = (string)dgvRow.Cells["Dano"].Value;
                        dgvRow.Cells["Dano"].Value = (int.Parse(cellDanoCG.Substring(0, cellDanoCG.IndexOf("D"))) + 1) + cellDanoCG.Substring(cellDanoCG.IndexOf("D"));
                        break;
                    case "Ferrolho Automático":
                        if (dgvRow.Cells["Especial"].Value != null) dgvRow.Cells["Especial"].Value += " + ";
                        dgvRow.Cells["Especial"].Value += "Automática";
                        break;
                    case "Mira laser":
                        var cellCritico = dgvRow.Cells["Critico"].Value.ToString(); 
                        dgvRow.Cells["Critico"].Value = int.Parse(cellCritico.Substring(0, cellCritico.IndexOf("/")))-2 + cellCritico.Substring(cellCritico.IndexOf("/"));
                        break;
                    case "Mira Telescópica":
                        if (dgvRow.Cells["Alcance"].Value == null) return;
                        var cellAlcance = dgvRow.Cells["Alcance"].Value.ToString();
                        switch (cellAlcance) 
                        {
                            case "Curto":
                                dgvRow.Cells["Alcance"].Value = "Médio"; break;
                            case "Médio":
                                dgvRow.Cells["Alcance"].Value = "Longo"; break;
                            default: break;
                        }
                        break;
                    default: break;
                }
            }
        }
    }
}

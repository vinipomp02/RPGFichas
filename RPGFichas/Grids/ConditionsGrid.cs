using RPGFichas.Domain.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGFichas
{
    public partial class ConditionsGrid : Form
    {
        Condicoes condicoes = new Condicoes();
        Ficha fichaSender;

        public ConditionsGrid(Ficha sender)
        {
            InitializeComponent();
            fichaSender = sender;
        }
        private void ConditionGrid_Load(object sender, EventArgs e)
        {
            PopulaGrid();
            fichaSender.ConditionGrid = new(fichaSender);
        }
        private void PopulaGrid()
        {

            dgvCondicoes.AutoGenerateColumns = true;
            dgvCondicoes.DataSource = condicoes.GetCondicoes();
            dgvCondicoes.Columns[dgvCondicoes.Columns.Count-1].DefaultCellStyle.Font = new System.Drawing.Font("Euphorogenic", 10F, FontStyle.Regular);
            dgvCondicoes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }
        private void dgvCondicoes_CellClick(object sender, DataGridViewCellEventArgs e) => dgvCondicoes.Rows[dgvCondicoes.CurrentCell.RowIndex].Selected = true;
        private void btnAddCondicao_Click(object sender, EventArgs e)
        {
            var CondicaoId = dgvCondicoes.CurrentRow.Cells["Id"].Value.ToString();
            if (CondicaoId == null) return;

            var CondicaoSelecionada = condicoes.GetCondicoes().FirstOrDefault(condicao => condicao.Id == int.Parse(CondicaoId));

            fichaSender.AdicionaCondicao(CondicaoSelecionada);
            this.Close();
        }
    }
}

using RPGFichas.Domain;
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
    public partial class ArmasGrid : Form
    {
        private Arma Arma = new Arma();
        private Ficha fichaSender;

        public ArmasGrid(Ficha sender)
        {
            InitializeComponent();
            fichaSender = sender;
        }
        private void ArmasGrid_Load(object sender, EventArgs e)
        {
            PopulaGrid();
            fichaSender.ArmaGrid = new(fichaSender);
        }
        private void PopulaGrid()
        {
            
            dgvArmas.AutoGenerateColumns = true;
            dgvArmas.DataSource = Arma.GetArmas();
        }
        private void btnAdcionar_Click(object sender, EventArgs e)
        {

            var armaId = dgvArmas.CurrentRow.Cells["Id"].Value.ToString();
            if (armaId == null) return;

            var armaSelecionada = Arma.GetArmas().FirstOrDefault(arma => arma.Id == int.Parse(armaId));
            if(txtNomeArma.Text == null || txtNomeArma.Text.Length == 0)
            {
                txtNomeArma.Text = armaSelecionada.Name;
            }

            var modificadores = lstModificadores.SelectedItems.OfType<string>().ToArray();
            bool armaAdcionada = fichaSender.AdicionaArma(armaSelecionada, txtNomeArma.Text, modificadores);

            if(armaAdcionada) this.Close();
        }
        private void dgvArmas_CellClick(object sender, DataGridViewCellEventArgs e) => dgvArmas.Rows[dgvArmas.CurrentCell.RowIndex].Selected = true;
    }
}

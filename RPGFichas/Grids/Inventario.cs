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
    public partial class Inventario : Form
    {
        Ficha fichaSender;
        public Inventario(Ficha sender)
        {
            InitializeComponent();
            fichaSender = sender;
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            dgvItens.Rows.Add();
            dgvItens.CurrentCell = null;
        }

        private void txtItem_TextChanged(object sender, EventArgs e) => AtualizaGrid(sender, "Item");
        private void txtDescricao_TextChanged(object sender, EventArgs e) => AtualizaGrid(sender, "Detalhes");
        private void txtEspacos_TextChanged(object sender, EventArgs e) => AtualizaGrid(sender, "Espacos");
        private void txtPrestigio_TextChanged(object sender, EventArgs e) => AtualizaGrid(sender, "Prestigio");
        private void txtQtd_TextChanged(object sender, EventArgs e) => AtualizaGrid(sender, "Quantidade");
        private void AtualizaGrid(object sender,string coluna)
        {
            var txt = sender as TextBox;
            
            dgvItens.Rows[0].Cells[coluna].Value = txt.Text;
            dgvItens.AutoResizeColumns();
        }
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
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                if (txt.Text == null || txt.Text == "")
                {
                    txt.BackColor = Color.Red;
                }
                else 
                {
                    txt.BackColor = Color.White;
                }
            }

            for(int i = 0; i < dgvItens.ColumnCount; i++)
            {
                if (dgvItens.Rows[0].Cells[i].Value == null) return;
            }

            bool itemAdcionado = fichaSender.AdicionarItem(dgvItens.Rows[0]);

            if (itemAdcionado)
            {
                Close();
                fichaSender.Inventario = new Inventario(fichaSender);
            }

        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e) => VerificaInt(sender, e);
    }
}

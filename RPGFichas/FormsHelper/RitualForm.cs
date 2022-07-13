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
    
    public partial class RitualForm : Form
    {
        private List<Rituais> ListRituais = new Rituais().GetRituais();
        private Ficha fichaSender;

        public RitualForm(Ficha sender)
        {
            InitializeComponent();
            fichaSender = sender;
        }
        private void RitualForm_Load(object sender, EventArgs e)
        {
            cbxRitual.DataSource = ListRituais.Select(x => x.Ritual).ToList();
            fichaSender.RitualForm = new(fichaSender);
        }
        private void cbxRitual_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Ritual = ListRituais.Where(x => x.Ritual == cbxRitual.Text);
            txtElemento.Text = Ritual.Select(s=>s.Elemento).FirstOrDefault();
            if(txtElemento.Text == "Escolha") { txtElemento.ReadOnly = false; } else { txtElemento.ReadOnly = true; }
            txtCirculo.Text = Ritual.Select(s=>s.Circulo).FirstOrDefault().ToString();
            txtCusto.Text = Ritual.Select(s=>s.Custo).FirstOrDefault();
            txtAcao.Text = Ritual.Select(s=>s.Acao).FirstOrDefault();
            txtAlcance.Text = Ritual.Select(s=>s.Alcance).FirstOrDefault();
            txtDuracao.Text = Ritual.Select(s=>s.Duracao).FirstOrDefault();
            txtResistencia.Text = Ritual.Select(s=>s.Resistencia).FirstOrDefault();
            txtDescricao.Text = Ritual.Select(s => s.Descricao).FirstOrDefault();
        }
        private void btnCancel_Click(object sender, EventArgs e) => Dispose();
        private void btnAdicionar_Click(object sender, EventArgs e) => addRitual();
        public void addRitual()
        {
            this.Height = btnExcluir.Bottom;

            btnAdicionar.Visible = false;
            btnCancel.Visible = false;
            btnExcluir.Visible = true;
            cbxRitual.Enabled = false;

            cbxRitual.DropDownStyle = ComboBoxStyle.Simple;
            txtElemento.ReadOnly = true;

            fichaSender.adicionarRitual(this);
        }
        private void btnExcluir_Click(object sender, EventArgs e) => fichaSender.excluirRitual(this, cbxRitual.Text);
    }
}

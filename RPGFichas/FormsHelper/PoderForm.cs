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

namespace RPGFichas.FormsHelper
{
    public partial class PoderForm : Form
    {

        private List<Poderes> ListPoderes = new Poderes().GetPoderes();
        private List<Poderes> ListPoderesFiltrados;
        private Ficha fichaSender;
        private string Classe;
        private string Origem;
        private string Trilha;
        private int Nex;

        public PoderForm(Ficha sender,string classe,string origem, string trilha,int nex)
        {
            InitializeComponent();
            fichaSender = sender;
            Classe = classe;
            Origem = origem;
            Trilha = trilha;
            Nex = nex;
        }
        private void btnAdicionar_Click(object sender, EventArgs e) => addPoder();
        public void addPoder()
        {
            this.Width = btnExcluir.Right;
            btnAdicionar.Visible = false;
            btnCancel.Visible = false;
            btnExcluir.Visible = true;
            cbxPoder.Enabled = false;

            cbxPoder.DropDownStyle = ComboBoxStyle.Simple;
            fichaSender.adcionarPoder(this);
        }
        private void PoderForm_Load(object sender, EventArgs e)
        {
            ListPoderesFiltrados = ListPoderes.Where(c => (c.Classe == Classe || c.Classe == null) &&
            (c.Trilha == Trilha || c.Trilha == null) &&
            (c.Origem == Origem || c.Origem == null) &&
            (c.Nex <= Nex) 
            ).Select(x => x).ToList();

            cbxPoder.DataSource = ListPoderesFiltrados.Select(x => x.Poder).ToList();
        }
        private void cbxPoder_SelectedIndexChanged(object sender, EventArgs e)
        {
            var poder = ListPoderesFiltrados.Where(x => x.Poder == cbxPoder.Text);
            txtElemento.Text = poder.Select(s => s.Elemento).FirstOrDefault();
            txtRequisito.Text = poder.Select(s => s.Requisito).FirstOrDefault();
            txtDescricao.Text = poder.Select(s => s.Descricao).FirstOrDefault();
        }
        private void btnCancel_Click(object sender, EventArgs e) => Dispose();
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            fichaSender.excluirPoder(this, cbxPoder.Text);
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Dispose();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}

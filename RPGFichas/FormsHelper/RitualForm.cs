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
        private int Nex;

        public RitualForm(Ficha sender,int nex)
        {
            InitializeComponent();
            fichaSender = sender;
            Nex = nex;
        }
        private void RitualForm_Load(object sender, EventArgs e)
        {
            var circulo = 1;
            if(Nex>=25) circulo = 2;
            if(Nex>=55) circulo = 3;
            if(Nex>=85) circulo = 4;

            cbxRitual.DataSource = ListRituais.Where(x => x.Circulo <=circulo ).OrderBy(x=>x.Circulo).
                ThenBy(x=>x.Elemento).ThenBy(x=>x.Ritual).Select(x => x.Ritual).ToList();
        }
        private void cbxRitual_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Ritual = ListRituais.Where(x => x.Ritual == cbxRitual.Text);

            txtElemento.Text = Ritual.Select(s => s.Elemento).FirstOrDefault();
            txtCirculo.Text = Ritual.Select(s => s.Circulo).FirstOrDefault().ToString();
            txtCusto.Text = Ritual.Select(s => s.Custo).FirstOrDefault();
            txtAcao.Text = Ritual.Select(s => s.Acao).FirstOrDefault();
            txtAlcance.Text = Ritual.Select(s => s.Alcance).FirstOrDefault();
            txtDuracao.Text = Ritual.Select(s => s.Duracao).FirstOrDefault();
            txtResistencia.Text = Ritual.Select(s => s.Resistencia).FirstOrDefault();
            txtDescricao.Text = Ritual.Select(s => s.Descricao).FirstOrDefault().Replace("\n", Environment.NewLine);
            var imagem = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent + @"\Data\RituaisImagens\" + Ritual.Select(s => s.Ritual).FirstOrDefault() + ".png";
            try 
            {
                pbxImagem.Image = Image.FromFile(imagem); 
            }
            catch
            {
                pbxImagem.Image = null;
            }

        }
        private void btnCancel_Click(object sender, EventArgs e) => Dispose();
        private void btnAdicionar_Click(object sender, EventArgs e) => addRitual();
        public void addRitual()
        {
            this.Height = pbxImagem.Bottom;
            pbxImagem.Visible = true;

            btnAdicionar.Visible = false;
            btnCancel.Visible = false;
            btnExcluir.Visible = true;
            cbxRitual.Enabled = false;

            cbxRitual.DropDownStyle = ComboBoxStyle.Simple;
            txtElemento.ReadOnly = true;

            fichaSender.adicionarRitual(this);
        }
        private void btnExcluir_Click(object sender, EventArgs e) => fichaSender.excluirRitual(this, cbxRitual.Text);

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

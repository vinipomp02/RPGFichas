using RPGFichas.FormsHelper;

namespace RPGFichas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.WindowState = FormWindowState.Maximized;
            flpFichas.Controls.Clear();
            flpFichas.Controls.Add(btnAddFicha);
            populaFichas();
        }
        private void btnAddFicha_Click(object sender, EventArgs e)
        {
            var ficha = new Ficha("Novo",this,null,null);
            ficha.Show();
            this.Hide();
        }
        public void populaFichas()
        {
            string filepath = Directory.GetParent( Directory.GetCurrentDirectory()).Parent.Parent + $@"\FichasData\";
            DirectoryInfo dir = new DirectoryInfo(filepath);

            foreach (var file in dir.GetFiles("*.json"))
            {
                if (file.Name.Replace(".json", "").Length <= 0)
                {
                    File.Delete(file.FullName);
                    continue;
                }
                var ficha = new FichasMenu(file.Name.Replace(".json",""),this);
                if (ficha == null) return;
                ficha.Show();
                ficha.TopLevel = false;
                flpFichas.Controls.Add(ficha);
                flpFichas.Controls.SetChildIndex(flpFichas.Controls["btnAddFicha"], flpFichas.Controls.GetChildIndex(btnAddFicha) + 1);

            }

            this.Hide();
        }
    }
}
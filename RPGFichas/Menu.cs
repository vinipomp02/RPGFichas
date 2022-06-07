namespace RPGFichas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnBruna_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FichaBruna FichaBruna = new FichaBruna();
            FichaBruna.Show();
        }
    }
}
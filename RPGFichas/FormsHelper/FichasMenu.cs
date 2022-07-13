using RPGFichas.Domain.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGFichas.FormsHelper
{
    public partial class FichasMenu : Form
    {
        Menu Menu;
        string imageFile;
        FichaObject fichaObject;
        public FichasMenu(string nome,Menu menu)
        {
            InitializeComponent();
            lblPersonagem.Text = nome;
            Menu = menu;
        }
        private void FichasMenu_Load(object sender, EventArgs e)
        {

            LoadStrip();

            LoadJson();

            LoadImg();
        }
        private void LoadImg()
        {
            if (fichaObject.ImageFile == null) return;
            imageFile = fichaObject.ImageFile;
            btnImage.BackgroundImage = Image.FromFile(imageFile);
            btnImage.Text = null;
        }
        private void LoadJson()
        {
            string fileName = Directory.GetParent( Directory.GetCurrentDirectory()).Parent.Parent+ $@"\FichasData\{lblPersonagem.Text}.json";
            string jsonString = File.ReadAllText(fileName);

            fichaObject = JsonSerializer.Deserialize<FichaObject>(jsonString);
        }
        private void LoadStrip()
        {
            List<ToolStripMenuItem> toolStripItem = new();

            ToolStripMenuItem toolStripItem1 = new();
            toolStripItem1.Text = "Excluir Ficha";
            toolStripItem1.Click += new EventHandler((sender, arg) => ExcluirFicha());
            toolStripItem.Add(toolStripItem1);

            ToolStripMenuItem toolStripItem2 = new();
            toolStripItem2.Text = "Add Imagem";
            toolStripItem2.Click += new EventHandler((sender, args) => AddImg());
            toolStripItem.Add(toolStripItem2);

            ContextMenuStrip strip = new ContextMenuStrip();
            foreach (var item in toolStripItem)
            {
                strip.Items.Add(item);
            }
            btnImage.ContextMenuStrip = strip;
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            Menu.Hide();
            
            Ficha ficha = new Ficha("Jogo", Menu, fichaObject,imageFile);
            ficha.Show();
        }
        private void AddImg()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Title = "Localizar Imagem";
            openFileDialog.DefaultExt = "jpg";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageFile = openFileDialog.FileName;
                    btnImage.BackgroundImage = Image.FromFile(imageFile);
                    btnImage.Text = null;

                    fichaObject.ImageFile = imageFile;

                    string fileName = Directory.GetParent( Directory.GetCurrentDirectory()).Parent.Parent + $@"\FichasData\{lblPersonagem.Text}.json";
                    string jsonString = JsonSerializer.Serialize(fichaObject);
                    File.WriteAllText(fileName, jsonString);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                "Mensagem : " + ex.Message + "\n\n" +
                                                "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não é possível exibir a imagem : " + imageFile.Substring(imageFile.LastIndexOf('\\'))
                                               + ". Você pode não ter permissão para ler o arquivo , ou " +
                                               " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                }
            }
        }
        private void ExcluirFicha()
        {
            var confirmaExclusao = MessageBox.Show($"Tem Certeza que Deseja excluir a Ficha: {lblPersonagem.Text}","Excluir Ficha",MessageBoxButtons.YesNo);
            if (confirmaExclusao == DialogResult.No) return;

            string fileName = Directory.GetParent( Directory.GetCurrentDirectory()).Parent.Parent + $@"\FichasData\{lblPersonagem.Text}.json";
            File.Delete(fileName);
            this.Dispose();
        }
    }
}

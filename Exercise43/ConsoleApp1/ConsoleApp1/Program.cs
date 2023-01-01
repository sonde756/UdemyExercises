using System.Windows.Forms;

namespace ButtonExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Criar um botão e definir sua propriedade Text
            Button button = new Button();
            button.Text = "Clique aqui";

            // Adicionar o botão ao formulário
            this.Controls.Add(button);
        }
    }
}

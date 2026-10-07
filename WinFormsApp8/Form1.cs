namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá! Seja bem-vindo ao aplicativo.", "Mensagem");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

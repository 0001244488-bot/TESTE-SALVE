namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string telefone = mskTelefone.Text.Trim();

            // Verifica se os campos foram preenchidos.
            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(email) ||
                !mskTelefone.MaskCompleted)
            {
                MessageBox.Show(
                    "Preencha o nome, o e-mail e o telefone corretamente.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Verificação simples do formato do e-mail.
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show(
                    "Digite um e-mail válido.",
                    "E-mail inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtEmail.Focus();
                return;
            }

            // Adiciona uma nova linha na tabela.
            dgvPessoas.Rows.Add(nome, email, telefone);

            MessageBox.Show(
                "Cadastro realizado com sucesso! ♡",
                "Tudo certo!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mskTelefone.Clear();
            txtNome.Focus();
        }
    }
}
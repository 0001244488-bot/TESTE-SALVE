namespace WinFormsApp8
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlMenu;
        private Panel pnlConteudo;
        private Label lblMarca;
        private Label lblSubMarca;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblNome;
        private Label lblEmail;
        private Label lblTelefone;
        private TextBox txtNome;
        private TextBox txtEmail;
        private MaskedTextBox mskTelefone;
        private Button btnCadastrar;
        private Button btnLimpar;
        private Label lblLista;
        private DataGridView dgvPessoas;
        private Label lblRodape;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            lblMarca = new Label();
            lblSubMarca = new Label();
            pnlConteudo = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblNome = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            mskTelefone = new MaskedTextBox();
            btnCadastrar = new Button();
            btnLimpar = new Button();
            lblLista = new Label();
            dgvPessoas = new DataGridView();
            lblRodape = new Label();
            pnlMenu.SuspendLayout();
            pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).BeginInit();
            SuspendLayout();
            // pnlMenu
            pnlMenu.BackColor = Color.FromArgb(190, 112, 153);
            pnlMenu.Controls.Add(lblSubMarca);
            pnlMenu.Controls.Add(lblMarca);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Width = 235;
            // lblMarca
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblMarca.ForeColor = Color.White;
            lblMarca.Location = new Point(27, 48);
            lblMarca.Text = "flor de lis";
            // lblSubMarca
            lblSubMarca.AutoSize = true;
            lblSubMarca.Font = new Font("Segoe UI", 9F);
            lblSubMarca.ForeColor = Color.FromArgb(255, 235, 245);
            lblSubMarca.Location = new Point(30, 91);
            lblSubMarca.Text = "GESTÃO DE CADASTROS";
            // pnlConteudo
            pnlConteudo.BackColor = Color.FromArgb(250, 246, 249);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Padding = new Padding(38, 32, 38, 22);
            pnlConteudo.Controls.Add(lblRodape);
            pnlConteudo.Controls.Add(dgvPessoas);
            pnlConteudo.Controls.Add(lblLista);
            pnlConteudo.Controls.Add(btnLimpar);
            pnlConteudo.Controls.Add(btnCadastrar);
            pnlConteudo.Controls.Add(mskTelefone);
            pnlConteudo.Controls.Add(txtEmail);
            pnlConteudo.Controls.Add(txtNome);
            pnlConteudo.Controls.Add(lblTelefone);
            pnlConteudo.Controls.Add(lblEmail);
            pnlConteudo.Controls.Add(lblNome);
            pnlConteudo.Controls.Add(lblSubtitulo);
            pnlConteudo.Controls.Add(lblTitulo);
            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(91, 62, 80);
            lblTitulo.Location = new Point(38, 27);
            lblTitulo.Text = "Olá, seja bem-vinda! ♡";
            // lblSubtitulo
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(139, 119, 132);
            lblSubtitulo.Location = new Point(43, 79);
            lblSubtitulo.Text = "Organize seus contatos de um jeito simples e especial.";
            // lblNome
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNome.ForeColor = Color.FromArgb(91, 62, 80);
            lblNome.Location = new Point(43, 137);
            lblNome.Text = "Nome completo";
            // txtNome
            txtNome.Font = new Font("Segoe UI", 11F);
            txtNome.Location = new Point(43, 163);
            txtNome.Size = new Size(390, 32);
            txtNome.PlaceholderText = "Digite o nome completo";
            // lblEmail
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(91, 62, 80);
            lblEmail.Location = new Point(455, 137);
            lblEmail.Text = "E-mail";
            // txtEmail
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(455, 163);
            txtEmail.Size = new Size(390, 32);
            txtEmail.PlaceholderText = "exemplo@email.com";
            // lblTelefone
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefone.ForeColor = Color.FromArgb(91, 62, 80);
            lblTelefone.Location = new Point(43, 215);
            lblTelefone.Text = "Telefone";
            // mskTelefone
            mskTelefone.Font = new Font("Segoe UI", 11F);
            mskTelefone.Location = new Point(43, 241);
            mskTelefone.Mask = "(00) 00000-0000";
            mskTelefone.Size = new Size(200, 32);
            // btnCadastrar
            btnCadastrar.BackColor = Color.FromArgb(190, 112, 153);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(455, 235);
            btnCadastrar.Size = new Size(185, 42);
            btnCadastrar.Text = "♡  Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // btnLimpar
            btnLimpar.BackColor = Color.FromArgb(239, 222, 233);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.FromArgb(112, 75, 99);
            btnLimpar.Location = new Point(653, 235);
            btnLimpar.Size = new Size(135, 42);
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // lblLista
            lblLista.AutoSize = true;
            lblLista.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblLista.ForeColor = Color.FromArgb(91, 62, 80);
            lblLista.Location = new Point(43, 315);
            lblLista.Text = "Seus contatos";
            // dgvPessoas
            dgvPessoas.AllowUserToAddRows = false;
            dgvPessoas.AllowUserToDeleteRows = false;
            dgvPessoas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPessoas.BackgroundColor = Color.White;
            dgvPessoas.BorderStyle = BorderStyle.None;
            dgvPessoas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPessoas.EnableHeadersVisualStyles = false;
            dgvPessoas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(239, 222, 233);
            dgvPessoas.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(91, 62, 80);
            dgvPessoas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvPessoas.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvPessoas.DefaultCellStyle.ForeColor = Color.FromArgb(75, 61, 70);
            dgvPessoas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(250, 225, 239);
            dgvPessoas.DefaultCellStyle.SelectionForeColor = Color.FromArgb(75, 61, 70);
            dgvPessoas.RowTemplate.Height = 34;
            dgvPessoas.Location = new Point(43, 355);
            dgvPessoas.Size = new Size(802, 220);
            dgvPessoas.ReadOnly = true;
            dgvPessoas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPessoas.MultiSelect = false;
            dgvPessoas.Columns.Add("Nome", "Nome");
            dgvPessoas.Columns.Add("Email", "E-mail");
            dgvPessoas.Columns.Add("Telefone", "Telefone");
            // lblRodape
            lblRodape.AutoSize = true;
            lblRodape.Font = new Font("Segoe UI", 8.5F);
            lblRodape.ForeColor = Color.FromArgb(160, 142, 154);
            lblRodape.Location = new Point(43, 594);
            lblRodape.Text = "Feito com carinho  •  Flor de Lis";
            // Form1
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 246, 249);
            ClientSize = new Size(1120, 680);
            MinimumSize = new Size(1000, 650);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlMenu);
            Font = new Font("Segoe UI", 9F);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flor de Lis | Cadastro";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlConteudo.ResumeLayout(false);
            pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).EndInit();
            ResumeLayout(false);
        }
    }
}
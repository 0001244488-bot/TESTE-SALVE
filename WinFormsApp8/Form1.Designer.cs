namespace WinFormsApp8
{
    partial class Form1
    {
        private Button btnMensagem;
        private Label lblTitulo;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnMensagem = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnMensagem
            // 
            btnMensagem.Location = new Point(325, 235);
            btnMensagem.Name = "btnMensagem";
            btnMensagem.Size = new Size(150, 40);
            btnMensagem.TabIndex = 1;
            btnMensagem.Text = "Clique aqui";
            btnMensagem.UseVisualStyleBackColor = true;
            btnMensagem.Click += btnMensagem_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F);
            lblTitulo.Location = new Point(267, 155);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(266, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bem-vindo ao aplicativo";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMensagem);
            Controls.Add(lblTitulo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela inicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}

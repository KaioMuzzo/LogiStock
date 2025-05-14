namespace LogiStock.Forms
{
    public partial class formRegister : Form
    {
        private LogiStockMain logiStockMain;
        bdLogistock bd = new bdLogistock();
        public formRegister(LogiStockMain logiStockMain)
        {
            InitializeComponent();
            this.logiStockMain = logiStockMain;
            txtMatricula.Text = bdLogistock.PegarMatricula().ToString();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            // Verifica campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome é obrigatório.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("A matrícula é obrigatória.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("O nome de usuário é obrigatório.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Informe um e-mail válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefone.Text) || txtTelefone.Text.Length < 8)
            {
                MessageBox.Show("Informe um telefone válido.");
                return;
            }

            if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres.");
                return;
            }

            // Tudo OK, prossegue com o cadastro
            bd.CadastrarFuncionario(
                txtNome.Text,
                txtMatricula.Text,
                txtUsuario.Text,
                txtEmail.Text,
                txtTelefone.Text,
                txtSenha.Text
            );
            logiStockMain.OpenChildForm(new Forms.FormFuncionarios(logiStockMain));
        }
    }
}

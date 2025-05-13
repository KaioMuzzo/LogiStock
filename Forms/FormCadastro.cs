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
            if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("A senha deve ter pelo menos 8 caracteres.");
                return;
            }

            bd.CadastrarFuncionario(txtNome.Text, txtMatricula.Text, txtUsuario.Text, txtEmail.Text, txtTelefone.Text, txtSenha.Text);
            logiStockMain.OpenChildForm(new Forms.FormFuncionarios(logiStockMain));
        }
    }
}

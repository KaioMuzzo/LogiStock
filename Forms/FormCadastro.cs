namespace LogiStock.Forms
{
    public partial class formRegister : Form
    {
        bdLogistock bd = new bdLogistock();
        public formRegister()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            bd.CadastrarFuncionario(txtNome.Text, txtMatricula.Text, txtUsuario.Text, txtEmail.Text, txtTelefone.Text, txtSenha.Text);
            this.Close();
        }
    }
}

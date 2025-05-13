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
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            bd.CadastrarFuncionario(txtNome.Text, txtMatricula.Text, txtUsuario.Text, txtEmail.Text, txtTelefone.Text, txtSenha.Text);
            logiStockMain.OpenChildForm(new Forms.FormFuncionarios(logiStockMain));
        }
    }
}

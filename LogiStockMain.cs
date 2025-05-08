namespace LogiStock
{
    public partial class LogiStockMain : Form
    {
        private Form activeForm;
        public LogiStockMain()
        {
            InitializeComponent();
            OpenChildForm(new Forms.FormLogin(this));
        }

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAcess_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLogin(this));
        }

        private void btnCadastrarMerc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormListarMercadorias());
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFuncionarios(this));
        }

        private void btnCadastroForn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFornecedores(this));
        }

        public void UsuarioConectado()
        {
            btnAcess.Visible = false;
            btnCadastrarMerc.Visible = true;
            btnFuncionario.Visible = true;
            btnCadastroForn.Visible = true;
        }
    }
}

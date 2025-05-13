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
            OpenChildForm(new Forms.FormListarMercadorias(this));

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFuncionarios(this));
        }

        private void btnCadastroForn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormFornecedores(this));
        }

        private void btnCadastroMerc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCadastroMerc());
        }

        public void UsuarioConectado()
        {
            btnAcess.Visible = false;
            btnCadastrarMerc.Visible = true;
            btnFuncionario.Visible = true;
            btnCadastroForn.Visible = true;
            btnCadastroMerc.Visible = true;
            btnSaida.Visible = true;
            btnEntrada.Visible = true;
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSaida());

        }

        private void btnEntrada_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEntrada());
        }
    }
}

namespace LogiStock.Forms
{
    public partial class FormCadastroMerc : Form
    {
        public FormCadastroMerc()
        {
            InitializeComponent();
            bdLogistock.ListaProdutos(cmbProduto);
            bdLogistock.ListaUnidades(cmbUnidadeDestino);
            bdLogistock.ListaUnidades(cmbUnidadeOrigem);
            bdLogistock.ListaCategorias(cmbCategoria);
            bdLogistock.ListaFornecedoresUnidades(cmbFornecedores, cmbCategoria.SelectedText);
            bdLogistock.ListaUnidades(cmbUnidade);
        }

        private void btnRelacionar_Click(object sender, EventArgs e)
        {
            if (cmbUnidadeDestino.Text == cmbUnidadeOrigem.Text)
            {
                MessageBox.Show("Você não pode fazer um de/para de 2 unidades iguais.");
            }

            bdLogistock.relacionarUnidade(Convert.ToInt32(cmbProduto.SelectedValue), Convert.ToInt32(cmbProduto.SelectedValue), Convert.ToInt32(cmbProduto.SelectedValue), Convert.ToDecimal(cmbProduto.SelectedValue));
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedValue != null && cmbCategoria.SelectedValue is int)
            {
                string idCategoria = cmbCategoria.SelectedValue.ToString();
                cmbFornecedores.SelectedIndex = -1;
                bdLogistock.ListaFornecedoresUnidades(cmbFornecedores, idCategoria);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtDescricao.Text) || string.IsNullOrEmpty(cmbCategoria.Text) || string.IsNullOrEmpty(cmbFornecedores.Text) || nudCustoProduto.Value <= 0 || nudValorVenda.Value <= 0 || nudQuantidade.Value <= 0)
            {
                MessageBox.Show("Preencha todos os campos para cadastrar a nova mercadoria");
                return;
            }

            int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            int idFornecedor = Convert.ToInt32(cmbFornecedores.SelectedValue);
            int quantidade = Convert.ToInt32(nudQuantidade.Value);
            int idUnidade = Convert.ToInt32(cmbUnidade.SelectedValue);
            bdLogistock.CadastrarMercadoria(txtNome.Text, txtDescricao.Text, idCategoria, idFornecedor, nudCustoProduto.Value, nudValorVenda.Value, quantidade, idUnidade);
            txtNome.Text = null;
            txtDescricao.Text = null;
            cmbCategoria.SelectedValue = -1;
            cmbFornecedores.SelectedValue = -1;
            nudCustoProduto.Value = 0;
            nudValorVenda.Value = 0;
            nudQuantidade.Value = 0;
            cmbUnidade.SelectedValue = -1;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}

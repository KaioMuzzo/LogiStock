using System.Data;

namespace LogiStock
{
    public partial class FormSaida : Form
    {

        public FormSaida()
        {
            InitializeComponent();
            bdLogistock.ListaUnidades(cmbUnidade);
            bdLogistock.ListaProdutos(cmbProduto);
        }

        private void FormSaida_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedItem != null && cmbUnidade.SelectedItem != null && nudQuantidade.Value >= 1)
            {
                DataRowView linhaProduto = (DataRowView)cmbProduto.SelectedItem;
                DataRowView linhaUnidade = (DataRowView)cmbUnidade.SelectedItem;

                int idProduto = Convert.ToInt32(linhaProduto["id_produto"]);
                string nomeProduto = linhaProduto["nome_produto"].ToString();

                int idUnidade = Convert.ToInt32(linhaUnidade["id_unidade"]);
                string siglaUnidade = linhaUnidade["sigla"].ToString();

                int quantidade = Convert.ToInt32(nudQuantidade.Value);

                ItemPedido item = new ItemPedido
                {
                    idProduto = idProduto,
                    NomeProduto = nomeProduto,
                    idUnidade = idUnidade,
                    siglaUnidade = siglaUnidade,
                    Quantidade = quantidade
                };

                listBox1.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Selecione produto, quantidade e unidade");
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            List<ItemPedido> itens = new List<ItemPedido>();

            foreach (var obj in listBox1.Items)
            {
                if (obj is ItemPedido item)
                {
                    itens.Add(item);
                }
            }

            if (itens.Count > 0)
            {
                string tipoMovimentacao = "saida";
                bdLogistock.CriarPedido(itens, tipoMovimentacao);
            }
            else
            {
                MessageBox.Show("Nenhum item na lista para criar o pedido.");
            }
        }
    }
}
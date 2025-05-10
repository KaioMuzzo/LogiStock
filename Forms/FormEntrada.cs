using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogiStock.Forms
{
    public partial class FormEntrada: Form
    {
        public FormEntrada()
        {
            InitializeComponent();
            bdLogistock.ListaUnidades(cmbUnidade);
            bdLogistock.ListaProdutos(cmbProduto);
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

                listbox1.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Selecione produto, quantidade e unidade");
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            List<ItemPedido> itens = new List<ItemPedido>();

            foreach (var obj in listbox1.Items)
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

                
                listbox1.Items.Clear();

                cmbProduto.SelectedIndex = -1;
                cmbUnidade.SelectedIndex = -1;
                nudQuantidade.Value = nudQuantidade.Minimum;

                MessageBox.Show("Pedido concluído e itens apagados da lista.");
            }
            else
            {
                MessageBox.Show("Nenhum item na lista para criar o pedido.");
            }

           
        }

    }
}

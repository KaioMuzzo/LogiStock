using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogiStock.Forms
{
    public partial class FormFornecedores : Form
    {
        private LogiStockMain logiStockmain;
        public FormFornecedores(LogiStockMain main)
        {
            InitializeComponent();
            logiStockmain = main;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            string nome = txtNomeFornecedor.Text;
            string endereco = txtEnderecoFornecedor.Text;
            string telefone = txtTelefoneFornecedor.Text;
            string email = txtEmailFornecedor.Text;
            string site = txtSiteFornecedor.Text;
            string cnpj = txtCNPJFornecedor.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco) || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(site) || string.IsNullOrEmpty(cnpj))
            {
                MessageBox.Show("Todos os campos devem ser devidamentes preenchidos.");
                return;
            }

            if (nome.Length < 3)
            {
                MessageBox.Show("Nome do fornecedor deve ter pelo menos 3 caracteres.");
                return;
            }

            if (nome.Length > 255)
            {
                MessageBox.Show("Nome do fornecedor deve ter no máximo 255.");
                return;
            }

            // validar se telefone tem exatamente 11 digitos
            if (telefone.Length != 11)
            {
                MessageBox.Show("Digite somente os números do telefone. O número deve conter 11 dígitos.");
                return;
            }

            // validar se cnpj tem exatamente 14 digitos
            if (cnpj.Length != 14)
            {
                MessageBox.Show("Digite somente os números do CNPJ. O CNPJ deve ter 14 dígitos.");
                return;
            }

            if (bdLogistock.CadastrarFornecedor(nome, endereco, telefone, email, site, cnpj))
            {
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                txtNomeFornecedor.Text = null;
                txtEnderecoFornecedor.Text = null;
                txtTelefoneFornecedor.Text = null;
                txtEmailFornecedor.Text = null;
                txtSiteFornecedor.Text = null;
                txtCNPJFornecedor.Text = null;
                return;
            }
            else
            {
                MessageBox.Show("Fornecedor não cadastrado, verifique os valores digitados");
                return;
            }
        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            string tipo = txtTipoCategoria.Text;
            string descricao = txtDescricaoCategoria.Text;

            if (string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(descricao))
            {
                MessageBox.Show("Todos os campos devem ser devidamentes preenchidos.");
                return;
            }

            if (descricao.Length < 10)
            {
                MessageBox.Show("A descrição deve ter pelo menos 10 caracteres.");
                return;
            }

            if(bdLogistock.CadastrarCategoria(tipo, descricao))
            {
                MessageBox.Show("Nova categoria cadastrada com sucesso!");
                txtTipoCategoria.Text = null;
                txtDescricaoCategoria.Text = null;
                return;
            }
            else
            {
                MessageBox.Show("Categoria não cadastrada, verifique os valores digitados");
                return;
            }
        }

        private void btnAtribuirFornCate_Click(object sender, EventArgs e)
        {
            cmbCategoria.Items.AddRange(new string[] { "aqui vao ficar os dados" });
            cmbCategoria.SelectedIndex = 0;
            cmbFornecedor.Items.AddRange(new string[] { "aqui vao ficar os dados" });
            cmbFornecedor.SelectedIndex = 0;
        }
    }
}

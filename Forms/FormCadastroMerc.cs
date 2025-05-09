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
    public partial class FormCadastroMerc : Form
    {
        public FormCadastroMerc()
        {
            InitializeComponent();
            bdLogistock.ListaProdutos(cmbProduto);
            bdLogistock.ListaUnidades(cmbUnidadeDestino);
            bdLogistock.ListaUnidades(cmbUnidadeOrigem);
            bdLogistock.ListaCategorias(comboBox4);
            bdLogistock.ListaFornecedores(comboBox5);
        }

        private void btnRelacionar_Click(object sender, EventArgs e)
        {
            if (cmbUnidadeDestino.Text == cmbUnidadeOrigem.Text)
            {
                MessageBox.Show("Você não pode fazer um de/para de 2 unidades iguais.");
            }

            bdLogistock.relacionarUnidade(Convert.ToInt32(cmbProduto.SelectedValue), Convert.ToInt32(cmbProduto.SelectedValue), Convert.ToInt32(cmbProduto.SelectedValue), Convert.ToDecimal(cmbProduto.SelectedValue));
        }

    }
}

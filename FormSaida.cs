using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogiStock
{
    public partial class FormSaida : Form
    {
       
        public FormSaida()
        {
            InitializeComponent();
            bdLogistock.ListaUnidades(comboBox1);
            bdLogistock.ListaProdutos(comboBox2);
        }

        private void FormSaida_Load(object sender, EventArgs e)
        {

        }

        

        private void btnInserir_Click(object sender, EventArgs e)
        {
            
            if(comboBox2.SelectedItem != null)
            {
                DataRowView linhaSelecionada = (DataRowView)comboBox2.SelectedItem;
                DataRowView dataQuantidade = (DataRowView)comboBox1.SelectedItem;

                string nomeProduto = linhaSelecionada["nome_produto"].ToString();

                string unidade = dataQuantidade["sigla"].ToString();

                int quantidade = Convert.ToInt32(numericUpDown1.Text);

                listBox1.Items.Add($"{nomeProduto}, {unidade}, {quantidade}");
                ;

            }
            else
            {
                MessageBox.Show("Selecione um produto primeiro.");
            }
            
        }
    }
}

using MySql.Data.MySqlClient;
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
    public partial class FormListarMercadorias : Form
    {
        LogiStockMain cadastrar;
        bdLogistock bd = new bdLogistock();
        public FormListarMercadorias(LogiStockMain cadastrarMerc)
        {
            InitializeComponent();
            bdLogistock.ListarMercadorias(dtGridMerc);
            cmbFiltro.Items.Clear();
            cmbFiltro.Items.AddRange(new string[]
            {
                "Produto",
                "Descrição",
                "Custo Produto",
                "Valor Produto",
                "Código Barra",
                "Quantidade",
                "Data Cadastro",
                "Categoria",
                "Fornecedor"
            });
            cmbFiltro.SelectedIndex = 0;
            cadastrar = cadastrarMerc;

        }

        private void FormListarMercadorias_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dtGridMerc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var column = dtGridMerc.Columns[e.ColumnIndex];
                if (column.ReadOnly)
                {
                    MessageBox.Show("Essa campo não pode ser editado!");

                }
            }
            catch (Exception ex)
            {

            }



        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bdLogistock bd = new bdLogistock();

            if (dtGridMerc.DataSource != null && dtGridMerc.DataSource is DataTable dt)
            {
                bd.SalvarMercadorias(dt);
            }
            else
            {
                MessageBox.Show("Nenhuma mercadoria carregada.");
            }
        }

        private void dtGridMerc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bdLogistock bd = new bdLogistock();
            bd.DeletarMercadorias(dtGridMerc);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormListarMercadorias_Load(object sender, EventArgs e)
        {

        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bdLogistock.MercadoriasFiltro(dtGridMerc, cmbFiltro, txtFiltro.Text);
            }
        }

        private void btnCadastrarMercadoria_Click(object sender, EventArgs e)
        {

            cadastrar.OpenChildForm(new Forms.FormCadastroMerc());

        }
    }
}

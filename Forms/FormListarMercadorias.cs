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
        bdLogistock bd = new bdLogistock();
        public FormListarMercadorias()
        {
            InitializeComponent();
            bdLogistock.ListarMercadorias(dtGridMerc);


        }

        private void FormListarMercadorias_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dtGridMerc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = dtGridMerc.Columns[e.ColumnIndex];
            if (column.ReadOnly)
            {
                MessageBox.Show("Essa campo não pode ser editado!");

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
            
        }
    }
}

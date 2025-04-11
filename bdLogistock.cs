using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LogiStock
{
    class bdLogistock
    {
        static  string conexao = "server=localhost; port=3307; user=root; password=senacJBQ; database=logistock";

        public void CadastrarFuncionario(string txtMatricula, string txtUsuario, string txtNome, string txtTelefone, string txtEmail)
        {
            int matricula = Convert.ToInt32(txtMatricula);
            string usuario = txtUsuario;
            string nome = txtNome;
            string telefone = txtTelefone;
            string email = txtEmail;
            int cargo = 2;
            string senha = "testeteste";

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string query = "INSERT INTO clientes (matricula, nome, usuario, senha, telefone, email, cargo) VALUES (@matricula, @nome, @usuario, @senha, @telefone, @email, @cargo)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cargo", cargo);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Pessoa cadastrada com sucesso");
            }
        }

        public static void ListarMercadorias(DataGridView tblGrid)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string query = "SELECT * FROM mercadorias";
                MySqlDataAdapter listClient = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                listClient.Fill(dataTable);

                tblGrid.DataSource = dataTable;
            }
        }
    }
}

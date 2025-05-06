using System.Data;
using System.Linq.Expressions;
using System.Security.Policy;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LogiStock
{
    class bdLogistock
    {
        static  string conexao = "server=localhost; port=3307; user=root; password=senacJBQ; database=logistock";

        public void CadastrarFuncionario(string txtNome, string txtMatricula, string txtUsuario, string txtEmail, string txtTelefone, string txtSenha)
        {
            string nome = txtNome;
            int matricula = Convert.ToInt32(txtMatricula);
            string usuario = txtUsuario;
            string email = txtEmail;
            string telefone = txtTelefone;
            int cargo = 0;
            string senha = Criptografia.GerarHash(txtSenha);

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string query = "INSERT INTO usuarios (matricula, nome, usuario, senha, telefone, email, cargo) VALUES (@matricula, @nome, @usuario, @senha, @telefone, @email, @cargo)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cargo", cargo);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario cadastrada com sucesso!");
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

        public static void ListarFuncionarios(DataGridView tblGrid)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string query = "SELECT * FROM usuarios";
                MySqlDataAdapter listClient = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                listClient.Fill(dataTable);

                tblGrid.DataSource = dataTable;
            }
        }

        public static bool FazerLogin(string usuario, string senha)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string query = "SELECT * FROM usuarios WHERE usuario = @usuario AND senha = @senha";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool CadastrarFornecedor(string nome, string endereco, string telefone, string email, string site, string cnpj)
        {
            try 
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    DateTime dataSql = DateTime.Now;

                    conn.Open();
                    string query = "INSERT INTO fornecedores (nome, endereco, telefone, email, site, cnpj, data_cadastro) VALUES (@nome, @endereco, @telefone, @email, @site, @cnpj, @data_cadastro)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@site", site);
                    cmd.Parameters.AddWithValue("@cnpj", cnpj);
                    cmd.Parameters.AddWithValue("@data_cadastro", dataSql);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool CadastrarCategoria(string tipo_categoria, string descricao)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    DateTime dataSql = DateTime.Now;

                    conn.Open();
                    string query = "INSERT INTO categorias (tipo_categoria, descricao) VALUES (@tipo_categoria, @descricao)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tipo_categoria", tipo_categoria);
                    cmd.Parameters.AddWithValue("@descricao", descricao);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            } 
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

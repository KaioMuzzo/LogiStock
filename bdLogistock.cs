using System.Data;
using System.Data.Common;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LogiStock
{

    class bdLogistock
    {
        static string conexao = "server=localhost; port=3307; user=root; password=senacJBQ; database=logistock";
        public static string matriculaUsuarioAtual;
        public static int cargoUsuarioAtual;

        public void CadastrarFuncionario(string txtNome, string txtMatricula, string txtUsuario, string txtEmail, string txtTelefone, string txtSenha)
        {
            string nome = txtNome;
            int matricula = Convert.ToInt32(txtMatricula);
            string usuario = txtUsuario;
            string email = txtEmail;
            string telefone = txtTelefone;
            int cargo = 1;
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

                
                string query = "SELECT mercadorias.id_produto AS ID, " +
                               "mercadorias.nome_produto AS Produto, " +
                               "mercadorias.descricao_produto AS Descrição, " +                               
                               "mercadorias.id_categoria AS ID_Categoria, " +                               
                               "mercadorias.custo_produto AS `Custo Produto`, " +
                               "mercadorias.valor_venda AS `Valor Produto`, " +
                               "mercadorias.id_fornecedor AS ID_Fornecedor, " +
                               "mercadorias.codigo_barras AS `Código Barra`, " +
                               "mercadorias.quantidade AS `Quantidade`," +
                               "mercadorias.data_cadastro AS `Data Cadastro` " +                              
                               "FROM mercadorias " +
                               "INNER JOIN categorias ON mercadorias.id_categoria = categorias.id_categoria " +
                               "INNER JOIN fornecedores ON mercadorias.id_fornecedor = fornecedores.id_fornecedor";

                MySqlDataAdapter listMercadorias = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                listMercadorias.Fill(dataTable);

                
                DataTable categoriasTable = new DataTable();
                string queryCategorias = "SELECT id_categoria, tipo_categoria FROM categorias";
                new MySqlDataAdapter(queryCategorias, conn).Fill(categoriasTable);

                
                DataTable fornecedoresTable = new DataTable();
                string queryFornecedores = "SELECT id_fornecedor, nome FROM fornecedores";
                new MySqlDataAdapter(queryFornecedores, conn).Fill(fornecedoresTable);

                
                tblGrid.Columns.Clear();
                tblGrid.DataSource = dataTable;
                tblGrid.ReadOnly = false;
                tblGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                
                DataGridViewComboBoxColumn cmbCategoria = new DataGridViewComboBoxColumn
                {
                    HeaderText = "Categoria",
                    DataPropertyName = "ID_Categoria",
                    DataSource = categoriasTable,
                    DisplayMember = "tipo_categoria",
                    ValueMember = "id_categoria",
                    FlatStyle = FlatStyle.Flat
                };
                tblGrid.Columns.Add(cmbCategoria);

                
                DataGridViewComboBoxColumn cmbFornecedor = new DataGridViewComboBoxColumn
                {
                    HeaderText = "Fornecedor",
                    DataPropertyName = "ID_Fornecedor",
                    DataSource = fornecedoresTable,
                    DisplayMember = "nome",
                    ValueMember = "id_fornecedor",
                    FlatStyle = FlatStyle.Flat
                    
                };
                tblGrid.Columns.Add(cmbFornecedor);

                
                tblGrid.Columns["ID"].Visible = false;               
                tblGrid.Columns["ID_Fornecedor"].Visible = false;
                tblGrid.Columns["ID_Categoria"].Visible = false;
                tblGrid.Columns["Código Barra"].ReadOnly = true;
                tblGrid.Columns["Quantidade"].ReadOnly = true;

                foreach (DataGridViewColumn column in tblGrid.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }

                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn
                {
                    HeaderText = "",
                    Text = "✏",
                    UseColumnTextForButtonValue = true,
                    FlatStyle = FlatStyle.Flat,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };
                tblGrid.Columns.Add(btnEditar);
                btnEditar.DefaultCellStyle.BackColor = tblGrid.DefaultCellStyle.BackColor;

            }
        }

        public void SalvarMercadorias(DataTable dataTable)
        {

            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Nenhuma mercadoria carregada para salvar.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                foreach (DataRow row in dataTable.Rows)
                {
                    if (row.RowState == DataRowState.Modified)
                    {
                        string updateQuery = "UPDATE mercadorias SET " +
                            "nome_produto = @nome, " +
                            "descricao_produto = @descricao, " +
                            "custo_produto = @custo, " +
                            "valor_venda = @valor, " +
                            "codigo_barras = @codigo, " +
                            "data_cadastro = @cadastro, " +
                            "id_fornecedor = @id_fornecedor, " +
                            "id_categoria = @id_categoria, " +
                            "quantidade = @quantidade " +
                            "WHERE id_produto = @id";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@nome", row["Produto"]);
                            cmd.Parameters.AddWithValue("@descricao", row["Descrição"]);
                            cmd.Parameters.AddWithValue("@custo", row["Custo Produto"]);
                            cmd.Parameters.AddWithValue("@valor", row["Valor Produto"]);
                            cmd.Parameters.AddWithValue("@codigo", row["Código Barra"]);
                            cmd.Parameters.AddWithValue("@quantidade", row["Quantidade"]);
                            cmd.Parameters.AddWithValue("@cadastro", Convert.ToDateTime(row["Data Cadastro"]));                            
                            cmd.Parameters.AddWithValue("@id_fornecedor", row["ID_Fornecedor"]);
                            cmd.Parameters.AddWithValue("@id_categoria", row["ID_Categoria"]);
                            cmd.Parameters.AddWithValue("@id", row["ID"]);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Alterações salvas com sucesso!");
                dataTable.AcceptChanges();
            }
        }


        public void DeletarMercadorias(DataGridView tblGrid)
        {
            if (tblGrid.SelectedRows.Count > 0)
            {
                var confirm = MessageBox.Show("Deseja realmente excluir o(s) produto(s)?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes) return;

                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    foreach (DataGridViewRow row in tblGrid.SelectedRows)
                    {
                        int idProduto = Convert.ToInt32(row.Cells["ID"].Value);

                        string deleteQuery = "DELETE FROM mercadorias WHERE id_produto = @id";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", idProduto);
                            cmd.ExecuteNonQuery();
                        }
                        tblGrid.Rows.Remove(row);
                    }
                }
                MessageBox.Show("Produto(s) excluído(s) com sucesso!");
            }
        }

        public static void MercadoriasFiltro(DataGridView tblGrid, ComboBox cmbFiltro, string valor)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                if (cmbFiltro.SelectedIndex != -1)
                {
                    string query = $"SELECT nome_produto, descricao_produto, custo_produto, valor_venda, quantidade, data_cadastro, codigo_barras FROM mercadorias WHERE {cmbFiltro.Text} LIKE @valor";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@valor", "%" + valor + "%");
                    MySqlDataAdapter listarMercadoriaFiltro = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    listarMercadoriaFiltro.Fill(dataTable);
                    tblGrid.DataSource = dataTable;
                }
            }
        }


        public static void ListarFuncionarios(DataGridView tblGrid)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string query = "SELECT matricula, nome, usuario, telefone, email, cargo FROM usuarios";
                MySqlDataAdapter listarFuncionarios = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                listarFuncionarios.Fill(dataTable);
                tblGrid.DataSource = dataTable;
            }
        }


        public static void FuncionariosFiltro(DataGridView tblGrid, ComboBox cmbFiltro, string valor)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                if (cmbFiltro.SelectedIndex != -1)
                {
                    string query = $"SELECT matricula, nome, usuario, telefone, email, cargo FROM usuarios WHERE {cmbFiltro.Text} LIKE @valor";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@valor", "%" + valor + "%");
                    MySqlDataAdapter listarFuncionariosFiltro = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    listarFuncionariosFiltro.Fill(dataTable);
                    tblGrid.DataSource = dataTable;
                }
            }
        }

        public static void EditarFuncionarios(string matricula, Dictionary<string, string> campos)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                List<string> updates = new List<string>();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                foreach (var campo in campos)
                {
                    string param = "@" + campo.Key;
                    updates.Add($"{campo.Key} = {param}");
                    cmd.Parameters.AddWithValue(param, campo.Value);
                }

                cmd.Parameters.AddWithValue("@matricula", matricula);
                string query = $"UPDATE usuarios SET {string.Join(", ", updates)} WHERE matricula = @matricula";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
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
                    matriculaUsuarioAtual = reader["matricula"].ToString();
                    cargoUsuarioAtual = Convert.ToInt16(reader["cargo"].ToString());
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
                MessageBox.Show("Erro: ", ex.Message);
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
                MessageBox.Show("Erro: " + ex.Message);
                return false;
            }
        }

        public static void CriarPedido(List<ItemPedido> itens, string tipo_movimentacao)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    string queryPedido = "INSERT INTO pedidos (matricula, data_pedido, tipo_movimentacao) VALUES (@matricula, NOW(), @tipo)";
                    MySqlCommand cmdPedido = new MySqlCommand(queryPedido, conn);
                    cmdPedido.Parameters.AddWithValue("@matricula", matriculaUsuarioAtual);
                    cmdPedido.Parameters.AddWithValue("@tipo", tipo_movimentacao);
                    cmdPedido.ExecuteNonQuery();

                    long idPedido = cmdPedido.LastInsertedId;

                    foreach (var item in itens)
                    {
                        string queryItem = @"INSERT INTO itens_pedido (id_pedido, id_produto, id_unidade, quantidade) 
                                     VALUES (@id_pedido, @id_produto, @id_unidade, @quantidade)";
                        MySqlCommand cmdItem = new MySqlCommand(queryItem, conn);
                        cmdItem.Parameters.AddWithValue("@id_pedido", idPedido);
                        cmdItem.Parameters.AddWithValue("@id_produto", item.idProduto);
                        cmdItem.Parameters.AddWithValue("@id_unidade", item.idUnidade);
                        cmdItem.Parameters.AddWithValue("@quantidade", item.Quantidade);
                        cmdItem.ExecuteNonQuery();

                        string queryUpdate = "UPDATE mercadorias SET quantidade = quantidade + @quantidade WHERE id_produto = @id_produto";
                        if (tipo_movimentacao == "saida")
                        {
                            queryUpdate = "UPDATE mercadorias SET quantidade = quantidade - @quantidade WHERE id_produto = @id_produto";
                        }

                        MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, conn);
                        cmdUpdate.Parameters.AddWithValue("@quantidade", item.Quantidade);
                        cmdUpdate.Parameters.AddWithValue("@id_produto", item.idProduto);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show("Pedido feito com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        public static void ListaFornecedores(ComboBox cmb)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_fornecedor, nome FROM fornecedores";
                    MySqlDataAdapter listaFornecedores = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    listaFornecedores.Fill(dt);

                    cmb.DataSource = dt;
                    cmb.DisplayMember = "nome";
                    cmb.ValueMember = "id_fornecedor";
                    cmb.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        public static void ListaFornecedoresUnidades(ComboBox cmb, string id_categoria)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT f.id_fornecedor, f.nome FROM fornecedores_categorias fc INNER JOIN fornecedores f ON fc.id_fornecedor = f.id_fornecedor INNER JOIN categorias c ON fc.id_categoria = c.id_categoria WHERE c.id_categoria = @id_categoria";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_categoria", id_categoria);

                    MySqlDataAdapter listaFornecedores = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    listaFornecedores.Fill(dt);

                    cmb.DataSource = dt;
                    cmb.DisplayMember = "nome";
                    cmb.ValueMember = "id_fornecedor";
                    cmb.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar a lista de fornecedores: " + ex.Message);
                }
            }
        }

        public static void DeletarFuncionario(int matricula)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM usuarios WHERE matricula = @matricula";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@matricula", matricula);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionário apagado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        public static void ListaCategorias(ComboBox cmb)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_categoria, tipo_categoria FROM categorias";
                    MySqlDataAdapter listaFornecedores = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    listaFornecedores.Fill(dt);

                    cmb.DataSource = dt;
                    cmb.DisplayMember = "tipo_categoria";
                    cmb.ValueMember = "id_categoria";
                    cmb.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar a lista de categorias: " + ex.Message);
                }
            }
        }

        public static void ListaProdutos(ComboBox cmb)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_produto, nome_produto FROM mercadorias";
                    MySqlDataAdapter listaProdutos = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    listaProdutos.Fill(dt);

                    cmb.DataSource = dt;
                    cmb.DisplayMember = "nome_produto";
                    cmb.ValueMember = "id_produto";
                    cmb.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar a lista de produtos: " + ex.Message);
                }
            }
        }

        public static void ListaUnidades(ComboBox cmb)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_unidade, sigla FROM unidades";
                    MySqlDataAdapter listaProdutos = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    listaProdutos.Fill(dt);

                    cmb.DataSource = dt;
                    cmb.DisplayMember = "sigla";
                    cmb.ValueMember = "id_unidade";
                    cmb.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar a lista de unidades: " + ex.Message);
                }
            }
        }

        public static void relacionarUnidade(int id_produto, int id_unidade_origem, int id_unidade_destino, Decimal fator_conversao)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string query = "insert into depara_unidades (id_produto, id_unidade_origem, id_unidade_destino, fator_conversao) VALUES (@id_produto, @id_unidade_origem, @id_unidade_destino, @fator_conversao)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_produto", id_produto);
                    cmd.Parameters.AddWithValue("@id_unidade_origem", id_unidade_origem);
                    cmd.Parameters.AddWithValue("@id_unidade_destino", id_unidade_destino);
                    cmd.Parameters.AddWithValue("@fator_conversao", fator_conversao);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("De/para realizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        public static void AtribuirCategoriaForne(int id_fornecedor, int id_categoria)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM fornecedores_categorias WHERE id_fornecedor = @id_fornecedor AND id_categoria = @id_categoria";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_fornecedor", id_fornecedor);
                    cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
                    int count = Convert.ToInt16(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        query = "INSERT INTO fornecedores_categorias (id_fornecedor, id_categoria) VALUES (@id_fornecedor, @id_categoria)";
                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id_fornecedor", id_fornecedor);
                        cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("De/Para fornecedor e categoria criado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível realizar a adição do De/Para, essa associação já foi criada.");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir o de/para de fornecedor com categoria: " + ex.Message);
                }
            }
        }

        public static int PegarMatricula()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT MAX(matricula) FROM usuarios";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object resultado = cmd.ExecuteScalar();
                        return Convert.ToInt32(resultado) + 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: ", ex.Message);
                }
            }
            return 1;
        }

        public static void CadastrarMercadoria(string nome, string descricao, int categoria, int fornecedor, decimal custo, decimal valorVenda, int quantidade, int unidade)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT MAX(codigo_barras) FROM mercadorias;";
                    long codigoBarras = 7891234567900;

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object resultado = cmd.ExecuteScalar();
                        if (resultado != DBNull.Value)
                        {
                            codigoBarras = Convert.ToInt32(resultado) + 1;
                        }
                    }

                    query = "INSERT INTO mercadorias (nome_produto, descricao_produto, id_categoria, id_fornecedor, custo_produto, valor_venda, quantidade, id_unidade, data_cadastro, status_produto, codigo_barras) VALUES (@nome, @descricao, @categoria, @fornecedor, @custo, @valorVenda, @quantidade, @unidade, NOW(), 1, @codigoBarras)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@categoria", categoria);
                        cmd.Parameters.AddWithValue("@fornecedor", fornecedor);
                        cmd.Parameters.AddWithValue("@custo", custo);
                        cmd.Parameters.AddWithValue("@valorVenda", valorVenda);
                        cmd.Parameters.AddWithValue("@quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@unidade", unidade);
                        cmd.Parameters.AddWithValue("@codigoBarras", codigoBarras);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Mercadoria Cadastrada com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
    }
}

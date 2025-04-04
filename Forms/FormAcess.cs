using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LogiStock.Forms
{
    public partial class formRegister : Form
    {
        string conexao = "server=localhost; port=3307; user=root; password=senacJBQ; database=logistock";
        public formRegister()
        {
            InitializeComponent();
        }

        private void CriarCadastro()
        {
            int matricula = Convert.ToInt32(txtMatricula.Text);
            string usuario = txtUsuario.Text;
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CriarCadastro();
        }
    }
}

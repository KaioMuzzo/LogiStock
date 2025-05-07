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
    public partial class FormEditar : Form
    {
        private string matricula;
        private string nome;
        private string usuario;
        private string telefone;
        private string email;
        private string senha;

        public FormEditar(string matricula, string nome, string usuario, string telefone, string email)
        {
            InitializeComponent();

            this.matricula = matricula;
            this.nome = nome;
            this.usuario = usuario;
            this.telefone = telefone;
            this.email = email;
        }

        private void FormEditar_Load(object sender, EventArgs e)
        {
            txtMatricula.Text = matricula;
            txtMatricula.ReadOnly = true;
            txtMatricula.BackColor = SystemColors.Window;

            txtNome.Text = nome;
            txtUsuario.Text = usuario;
            txtTelefone.Text = telefone;
            txtEmail.Text = email;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> camposAlterados = new Dictionary<string, string>();

            if (txtMatricula.Text != matricula)
            {
                camposAlterados.Add("matricula", txtMatricula.Text);
            }

            if (txtNome.Text != nome)
            {
                camposAlterados.Add("nome", txtNome.Text);
            }

            if (txtUsuario.Text != usuario)
            {
                camposAlterados.Add("usuario", txtUsuario.Text);
            }

            if (txtTelefone.Text != telefone)
            {
                camposAlterados.Add("telefone", txtTelefone.Text);
            }

            if (txtEmail.Text != email)
            {
                camposAlterados.Add("email", txtEmail.Text);
            }

            if (txtSenha.Text.Length > 0)
            {
                if (txtSenha.Text.Length >= 8)
                {
                    senha = Criptografia.GerarHash(txtSenha.Text);
                    camposAlterados.Add("senha", senha);
                }
                else
                {
                    MessageBox.Show("A nova senha do funcionario deve ter pelo menos 8 caracteres.");
                }
                
            }

            if (camposAlterados.Count == 0)
            {
                MessageBox.Show("Nenhuma alteração detectada.");
                return;
            }

            bdLogistock.EditarFuncionarios(matricula, camposAlterados);
            MessageBox.Show("Funcionário atualizado com sucesso!");
            this.Close();
        }
    }
}

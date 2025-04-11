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
        bdLogistock bd = new bdLogistock();
        public formRegister()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bd.CadastrarFuncionario(txtMatricula.Text, txtUsuario.Text, txtNome.Text, txtTelefone.Text, txtEmail.Text);
            txtMatricula.Text = "";
            txtUsuario.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
        }
    }
}

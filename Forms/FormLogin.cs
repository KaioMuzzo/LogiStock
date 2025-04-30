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
    public partial class FormLogin : Form
    {
        LogiStockMain logiStockMain;
        public FormLogin(LogiStockMain main)
        {
            InitializeComponent();
            logiStockMain = main;
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = Criptografia.GerarHash(txtSenha.Text);

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (bdLogistock.FazerLogin(usuario, senha))
            {
                logiStockMain.UsuarioConectado();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario ou senha inválidos.");
            }
        }
    }
}

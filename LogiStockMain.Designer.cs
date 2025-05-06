namespace LogiStock
{
    partial class LogiStockMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogiStockMain));
            panelMenu = new Panel();
            btnCadastroForn = new Button();
            btnRegisterUser = new Button();
            btnFuncionario = new Button();
            btnCadastrarMerc = new Button();
            btnAcess = new Button();
            panel1 = new Panel();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnCadastroForn);
            panelMenu.Controls.Add(btnRegisterUser);
            panelMenu.Controls.Add(btnFuncionario);
            panelMenu.Controls.Add(btnCadastrarMerc);
            panelMenu.Controls.Add(btnAcess);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 978);
            panelMenu.TabIndex = 0;
            // 
            // btnCadastroForn
            // 
            btnCadastroForn.Dock = DockStyle.Top;
            btnCadastroForn.FlatAppearance.BorderSize = 0;
            btnCadastroForn.FlatStyle = FlatStyle.Flat;
            btnCadastroForn.ForeColor = Color.Gainsboro;
            btnCadastroForn.Image = Properties.Resources.acess;
            btnCadastroForn.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastroForn.Location = new Point(0, 320);
            btnCadastroForn.Name = "btnCadastroForn";
            btnCadastroForn.Padding = new Padding(20, 0, 0, 0);
            btnCadastroForn.Size = new Size(200, 60);
            btnCadastroForn.TabIndex = 6;
            btnCadastroForn.Text = "   CadastroFornecedor";
            btnCadastroForn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastroForn.UseVisualStyleBackColor = true;
            btnCadastroForn.Click += btnCadastroForn_Click;
            // 
            // btnRegisterUser
            // 
            btnRegisterUser.Dock = DockStyle.Top;
            btnRegisterUser.FlatAppearance.BorderSize = 0;
            btnRegisterUser.FlatStyle = FlatStyle.Flat;
            btnRegisterUser.ForeColor = Color.Gainsboro;
            btnRegisterUser.Image = Properties.Resources.acess;
            btnRegisterUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegisterUser.Location = new Point(0, 260);
            btnRegisterUser.Name = "btnRegisterUser";
            btnRegisterUser.Padding = new Padding(20, 0, 0, 0);
            btnRegisterUser.Size = new Size(200, 60);
            btnRegisterUser.TabIndex = 5;
            btnRegisterUser.Text = "   Cadastro";
            btnRegisterUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegisterUser.UseVisualStyleBackColor = true;
            btnRegisterUser.Visible = false;
            btnRegisterUser.Click += btnRegisterUser_Click;
            // 
            // btnFuncionario
            // 
            btnFuncionario.Dock = DockStyle.Top;
            btnFuncionario.FlatAppearance.BorderSize = 0;
            btnFuncionario.FlatStyle = FlatStyle.Flat;
            btnFuncionario.ForeColor = Color.Gainsboro;
            btnFuncionario.Image = Properties.Resources.acess;
            btnFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btnFuncionario.Location = new Point(0, 200);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Padding = new Padding(20, 0, 0, 0);
            btnFuncionario.Size = new Size(200, 60);
            btnFuncionario.TabIndex = 3;
            btnFuncionario.Text = "   Funcionários";
            btnFuncionario.TextAlign = ContentAlignment.MiddleLeft;
            btnFuncionario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFuncionario.UseVisualStyleBackColor = true;
            btnFuncionario.Visible = false;
            btnFuncionario.Click += btnFuncionario_Click;
            // 
            // btnCadastrarMerc
            // 
            btnCadastrarMerc.Dock = DockStyle.Top;
            btnCadastrarMerc.FlatAppearance.BorderSize = 0;
            btnCadastrarMerc.FlatStyle = FlatStyle.Flat;
            btnCadastrarMerc.ForeColor = Color.Gainsboro;
            btnCadastrarMerc.Image = Properties.Resources.acess;
            btnCadastrarMerc.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrarMerc.Location = new Point(0, 140);
            btnCadastrarMerc.Name = "btnCadastrarMerc";
            btnCadastrarMerc.Padding = new Padding(20, 0, 0, 0);
            btnCadastrarMerc.Size = new Size(200, 60);
            btnCadastrarMerc.TabIndex = 2;
            btnCadastrarMerc.Text = "   Cadastrar Mercadoria";
            btnCadastrarMerc.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastrarMerc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrarMerc.UseVisualStyleBackColor = true;
            btnCadastrarMerc.Visible = false;
            btnCadastrarMerc.Click += btnCadastrarMerc_Click;
            // 
            // btnAcess
            // 
            btnAcess.Dock = DockStyle.Top;
            btnAcess.FlatAppearance.BorderSize = 0;
            btnAcess.FlatStyle = FlatStyle.Flat;
            btnAcess.ForeColor = Color.Gainsboro;
            btnAcess.Image = (Image)resources.GetObject("btnAcess.Image");
            btnAcess.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcess.Location = new Point(0, 80);
            btnAcess.Name = "btnAcess";
            btnAcess.Padding = new Padding(20, 0, 0, 0);
            btnAcess.Size = new Size(200, 60);
            btnAcess.TabIndex = 1;
            btnAcess.Text = "   Login";
            btnAcess.TextAlign = ContentAlignment.MiddleLeft;
            btnAcess.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAcess.UseVisualStyleBackColor = true;
            btnAcess.Click += btnAcess_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 80);
            panel1.TabIndex = 0;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(200, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1704, 978);
            panelDesktop.TabIndex = 2;
            // 
            // LogiStockMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 978);
            Controls.Add(panelDesktop);
            Controls.Add(panelMenu);
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1017);
            MinimizeBox = false;
            MinimumSize = new Size(1918, 1017);
            Name = "LogiStockMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogiStock";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Button btnAcess;
        private Button btnFuncionario;
        private Button btnCadastrarMerc;
        private Panel panelDesktop;
        private Button btnRegisterUser;
        private Button btnCadastroForn;
    }
}

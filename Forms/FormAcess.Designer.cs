namespace LogiStock.Forms
{
    partial class formRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegister));
            txtNome = new TextBox();
            txtMatricula = new TextBox();
            txtUsuario = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI", 30F);
            txtNome.Location = new Point(308, 286);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(507, 54);
            txtNome.TabIndex = 0;
            txtNome.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMatricula
            // 
            txtMatricula.BackColor = Color.White;
            txtMatricula.BorderStyle = BorderStyle.None;
            txtMatricula.Cursor = Cursors.IBeam;
            txtMatricula.Font = new Font("Segoe UI", 30F);
            txtMatricula.Location = new Point(905, 286);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(507, 54);
            txtMatricula.TabIndex = 1;
            txtMatricula.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Font = new Font("Segoe UI", 30F);
            txtUsuario.Location = new Point(308, 457);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(507, 54);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = Color.White;
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Cursor = Cursors.IBeam;
            txtTelefone.Font = new Font("Segoe UI", 30F);
            txtTelefone.Location = new Point(605, 627);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(507, 54);
            txtTelefone.TabIndex = 0;
            txtTelefone.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI", 30F);
            txtEmail.Location = new Point(905, 457);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(507, 54);
            txtEmail.TabIndex = 1;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackgroundImage = (Image)resources.GetObject("btnCadastrar.BackgroundImage");
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(661, 749);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(394, 92);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // formRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.telaCadastro;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1704, 978);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtMatricula);
            Controls.Add(txtUsuario);
            Controls.Add(txtNome);
            MaximizeBox = false;
            MaximumSize = new Size(1720, 1017);
            MinimizeBox = false;
            MinimumSize = new Size(1720, 1017);
            Name = "formRegister";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtMatricula;
        private TextBox txtUsuario;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Button btnCadastrar;
    }
}
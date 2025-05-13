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
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtSenha = new TextBox();
            btnCadastro = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.CausesValidation = false;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI", 27.75F);
            txtNome.Location = new Point(302, 311);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(475, 50);
            txtNome.TabIndex = 1;
            txtNome.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMatricula
            // 
            txtMatricula.BackColor = Color.White;
            txtMatricula.BorderStyle = BorderStyle.None;
            txtMatricula.CausesValidation = false;
            txtMatricula.Cursor = Cursors.IBeam;
            txtMatricula.Font = new Font("Segoe UI", 27.75F);
            txtMatricula.Location = new Point(955, 311);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.ReadOnly = true;
            txtMatricula.Size = new Size(475, 50);
            txtMatricula.TabIndex = 2;
            txtMatricula.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.CausesValidation = false;
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Font = new Font("Segoe UI", 27.75F);
            txtUsuario.Location = new Point(302, 487);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(475, 50);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.CausesValidation = false;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI", 27.75F);
            txtEmail.Location = new Point(955, 487);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(475, 50);
            txtEmail.TabIndex = 4;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTelefone
            // 
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.CausesValidation = false;
            txtTelefone.Cursor = Cursors.IBeam;
            txtTelefone.Font = new Font("Segoe UI", 27.75F);
            txtTelefone.Location = new Point(302, 668);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(475, 50);
            txtTelefone.TabIndex = 5;
            txtTelefone.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.CausesValidation = false;
            txtSenha.Cursor = Cursors.IBeam;
            txtSenha.Font = new Font("Segoe UI", 27.75F);
            txtSenha.Location = new Point(955, 668);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(475, 50);
            txtSenha.TabIndex = 6;
            txtSenha.TextAlign = HorizontalAlignment.Center;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.Transparent;
            btnCadastro.FlatAppearance.BorderSize = 0;
            btnCadastro.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCadastro.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.Location = new Point(659, 811);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(394, 89);
            btnCadastro.TabIndex = 7;
            btnCadastro.UseVisualStyleBackColor = false;
            // 
            // formRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1704, 978);
            Controls.Add(btnCadastro);
            Controls.Add(txtSenha);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtUsuario);
            Controls.Add(txtMatricula);
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
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtSenha;
        private Button btnCadastro;
    }
}
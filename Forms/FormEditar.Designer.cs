namespace LogiStock.Forms
{
    partial class FormEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditar));
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            txtUsuario = new TextBox();
            txtMatricula = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Segoe UI", 27.75F);
            txtNome.Location = new Point(309, 310);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(458, 50);
            txtNome.TabIndex = 0;
            txtNome.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTelefone
            // 
            txtTelefone.BorderStyle = BorderStyle.None;
            txtTelefone.Cursor = Cursors.IBeam;
            txtTelefone.Font = new Font("Segoe UI", 27.75F);
            txtTelefone.Location = new Point(309, 669);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(458, 50);
            txtTelefone.TabIndex = 1;
            txtTelefone.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Cursor = Cursors.IBeam;
            txtSenha.Font = new Font("Segoe UI", 27.75F);
            txtSenha.Location = new Point(959, 669);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(472, 50);
            txtSenha.TabIndex = 2;
            txtSenha.TextAlign = HorizontalAlignment.Center;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI", 27.75F);
            txtEmail.Location = new Point(959, 487);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(472, 50);
            txtEmail.TabIndex = 3;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Font = new Font("Segoe UI", 27.75F);
            txtUsuario.Location = new Point(309, 487);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(458, 50);
            txtUsuario.TabIndex = 4;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMatricula
            // 
            txtMatricula.BorderStyle = BorderStyle.None;
            txtMatricula.Cursor = Cursors.IBeam;
            txtMatricula.Font = new Font("Segoe UI", 27.75F);
            txtMatricula.Location = new Point(959, 310);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.ReadOnly = true;
            txtMatricula.Size = new Size(472, 50);
            txtMatricula.TabIndex = 5;
            txtMatricula.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(660, 810);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(394, 90);
            btnSalvar.TabIndex = 6;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1704, 978);
            Controls.Add(btnSalvar);
            Controls.Add(txtMatricula);
            Controls.Add(txtUsuario);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Name = "FormEditar";
            Text = "FormEditar";
            Load += FormEditar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private TextBox txtUsuario;
        private TextBox txtMatricula;
        private Button btnSalvar;
    }
}
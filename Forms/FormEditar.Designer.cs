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
            btnSalvar = new Button();
            txtMatricula = new TextBox();
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
            txtTelefone.TabIndex = 2;
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
            txtSenha.TabIndex = 5;
            txtSenha.TextAlign = HorizontalAlignment.Center;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI", 27.75F);
            txtEmail.Location = new Point(958, 487);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(472, 50);
            txtEmail.TabIndex = 4;
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
            txtUsuario.TabIndex = 1;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderColor = Color.FromArgb(0, 34, 80);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(657, 808);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(398, 95);
            btnSalvar.TabIndex = 6;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtMatricula
            // 
            txtMatricula.BackColor = Color.White;
            txtMatricula.BorderStyle = BorderStyle.None;
            txtMatricula.Font = new Font("Segoe UI", 27.75F);
            txtMatricula.Location = new Point(959, 312);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.ReadOnly = true;
            txtMatricula.Size = new Size(471, 50);
            txtMatricula.TabIndex = 3;
            txtMatricula.TextAlign = HorizontalAlignment.Center;
            // 
            // FormEditar
            // 
            AcceptButton = btnSalvar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1704, 978);
            Controls.Add(txtMatricula);
            Controls.Add(btnSalvar);
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
        private Button btnSalvar;
        private TextBox txtMatricula;
    }
}
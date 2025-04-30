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
            Nome = new TextBox();
            Telefone = new TextBox();
            Senha = new TextBox();
            Email = new TextBox();
            Usuario = new TextBox();
            Matricula = new TextBox();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.BorderStyle = BorderStyle.None;
            Nome.Cursor = Cursors.IBeam;
            Nome.Font = new Font("Segoe UI", 27.75F);
            Nome.Location = new Point(306, 306);
            Nome.Name = "Nome";
            Nome.Size = new Size(458, 50);
            Nome.TabIndex = 0;
            Nome.TextAlign = HorizontalAlignment.Center;
            // 
            // Telefone
            // 
            Telefone.BorderStyle = BorderStyle.None;
            Telefone.Cursor = Cursors.IBeam;
            Telefone.Font = new Font("Segoe UI", 27.75F);
            Telefone.Location = new Point(306, 665);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(458, 50);
            Telefone.TabIndex = 1;
            Telefone.TextAlign = HorizontalAlignment.Center;
            // 
            // Senha
            // 
            Senha.BorderStyle = BorderStyle.None;
            Senha.Cursor = Cursors.IBeam;
            Senha.Font = new Font("Segoe UI", 27.75F);
            Senha.Location = new Point(952, 665);
            Senha.Name = "Senha";
            Senha.Size = new Size(472, 50);
            Senha.TabIndex = 2;
            Senha.TextAlign = HorizontalAlignment.Center;
            Senha.UseSystemPasswordChar = true;
            // 
            // Email
            // 
            Email.BorderStyle = BorderStyle.None;
            Email.Cursor = Cursors.IBeam;
            Email.Font = new Font("Segoe UI", 27.75F);
            Email.Location = new Point(952, 484);
            Email.Name = "Email";
            Email.Size = new Size(472, 50);
            Email.TabIndex = 3;
            Email.TextAlign = HorizontalAlignment.Center;
            // 
            // Usuario
            // 
            Usuario.BorderStyle = BorderStyle.None;
            Usuario.Cursor = Cursors.IBeam;
            Usuario.Font = new Font("Segoe UI", 27.75F);
            Usuario.Location = new Point(306, 484);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(458, 50);
            Usuario.TabIndex = 4;
            Usuario.TextAlign = HorizontalAlignment.Center;
            // 
            // Matricula
            // 
            Matricula.BorderStyle = BorderStyle.None;
            Matricula.Cursor = Cursors.IBeam;
            Matricula.Font = new Font("Segoe UI", 27.75F);
            Matricula.Location = new Point(952, 306);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(472, 50);
            Matricula.TabIndex = 5;
            Matricula.TextAlign = HorizontalAlignment.Center;
            // 
            // FormEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1704, 978);
            Controls.Add(Matricula);
            Controls.Add(Usuario);
            Controls.Add(Email);
            Controls.Add(Senha);
            Controls.Add(Telefone);
            Controls.Add(Nome);
            Name = "FormEditar";
            Text = "FormEditar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Nome;
        private TextBox Telefone;
        private TextBox Senha;
        private TextBox Email;
        private TextBox Usuario;
        private TextBox Matricula;
    }
}
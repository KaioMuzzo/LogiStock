namespace LogiStock.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            txtUsuario = new TextBox();
            btnAcessar = new Button();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(611, 435);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(500, 64);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = Color.Transparent;
            btnAcessar.Cursor = Cursors.Hand;
            btnAcessar.FlatAppearance.BorderColor = Color.FromArgb(0, 34, 80);
            btnAcessar.FlatAppearance.BorderSize = 0;
            btnAcessar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAcessar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAcessar.FlatStyle = FlatStyle.Flat;
            btnAcessar.Location = new Point(660, 782);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(396, 90);
            btnAcessar.TabIndex = 2;
            btnAcessar.UseVisualStyleBackColor = false;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(611, 637);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(500, 64);
            txtSenha.TabIndex = 1;
            txtSenha.TextAlign = HorizontalAlignment.Center;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1704, 978);
            Controls.Add(txtSenha);
            Controls.Add(btnAcessar);
            Controls.Add(txtUsuario);
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private Button btnAcessar;
        private TextBox txtSenha;
    }
}
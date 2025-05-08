namespace LogiStock.Forms
{
    partial class FormCadastroMerc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroMerc));
            textBox3 = new TextBox();
            cmbProduto = new ComboBox();
            cmbUnidadeOrigem = new ComboBox();
            cmbUnidadeDestino = new ComboBox();
            btnRelacionar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(1198, 712);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(357, 36);
            textBox3.TabIndex = 2;
            // 
            // cmbProduto
            // 
            cmbProduto.FlatStyle = FlatStyle.Flat;
            cmbProduto.Font = new Font("Segoe UI", 20F);
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(1198, 328);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(357, 45);
            cmbProduto.TabIndex = 3;
            // 
            // cmbUnidadeOrigem
            // 
            cmbUnidadeOrigem.FlatStyle = FlatStyle.Flat;
            cmbUnidadeOrigem.Font = new Font("Segoe UI", 20F);
            cmbUnidadeOrigem.FormattingEnabled = true;
            cmbUnidadeOrigem.Location = new Point(1198, 451);
            cmbUnidadeOrigem.Name = "cmbUnidadeOrigem";
            cmbUnidadeOrigem.Size = new Size(357, 45);
            cmbUnidadeOrigem.TabIndex = 4;
            // 
            // cmbUnidadeDestino
            // 
            cmbUnidadeDestino.FlatStyle = FlatStyle.Flat;
            cmbUnidadeDestino.Font = new Font("Segoe UI", 20F);
            cmbUnidadeDestino.FormattingEnabled = true;
            cmbUnidadeDestino.Location = new Point(1198, 576);
            cmbUnidadeDestino.Name = "cmbUnidadeDestino";
            cmbUnidadeDestino.Size = new Size(357, 45);
            cmbUnidadeDestino.TabIndex = 5;
            // 
            // btnRelacionar
            // 
            btnRelacionar.BackColor = Color.Transparent;
            btnRelacionar.Cursor = Cursors.Hand;
            btnRelacionar.FlatAppearance.BorderSize = 0;
            btnRelacionar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRelacionar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRelacionar.FlatStyle = FlatStyle.Flat;
            btnRelacionar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRelacionar.Location = new Point(1405, 798);
            btnRelacionar.Name = "btnRelacionar";
            btnRelacionar.Size = new Size(172, 59);
            btnRelacionar.TabIndex = 6;
            btnRelacionar.Text = "Relacionar";
            btnRelacionar.UseVisualStyleBackColor = false;
            btnRelacionar.Click += btnRelacionar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnVoltar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(1405, 913);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(214, 63);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // FormCadastroMerc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1704, 978);
            Controls.Add(btnVoltar);
            Controls.Add(btnRelacionar);
            Controls.Add(cmbUnidadeDestino);
            Controls.Add(cmbUnidadeOrigem);
            Controls.Add(cmbProduto);
            Controls.Add(textBox3);
            Name = "FormCadastroMerc";
            Text = "FormCadastroMerc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private ComboBox cmbProduto;
        private ComboBox cmbUnidadeOrigem;
        private ComboBox cmbUnidadeDestino;
        private Button btnRelacionar;
        private Button btnVoltar;
    }
}
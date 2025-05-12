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
            cmbCategoria = new ComboBox();
            cmbFornecedores = new ComboBox();
            nudCustoProduto = new NumericUpDown();
            nudValorVenda = new NumericUpDown();
            nudQuantidade = new NumericUpDown();
            btnCadastrar = new Button();
            txtDescricao = new TextBox();
            txtNome = new TextBox();
            cmbUnidade = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudCustoProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudValorVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
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
            textBox3.TabIndex = 11;
            // 
            // cmbProduto
            // 
            cmbProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProduto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProduto.FlatStyle = FlatStyle.Flat;
            cmbProduto.Font = new Font("Segoe UI", 20F);
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(1198, 326);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(357, 45);
            cmbProduto.TabIndex = 8;
            // 
            // cmbUnidadeOrigem
            // 
            cmbUnidadeOrigem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnidadeOrigem.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUnidadeOrigem.FlatStyle = FlatStyle.Flat;
            cmbUnidadeOrigem.Font = new Font("Segoe UI", 20F);
            cmbUnidadeOrigem.FormattingEnabled = true;
            cmbUnidadeOrigem.Location = new Point(1198, 451);
            cmbUnidadeOrigem.Name = "cmbUnidadeOrigem";
            cmbUnidadeOrigem.Size = new Size(357, 45);
            cmbUnidadeOrigem.TabIndex = 9;
            // 
            // cmbUnidadeDestino
            // 
            cmbUnidadeDestino.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnidadeDestino.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUnidadeDestino.FlatStyle = FlatStyle.Flat;
            cmbUnidadeDestino.Font = new Font("Segoe UI", 20F);
            cmbUnidadeDestino.FormattingEnabled = true;
            cmbUnidadeDestino.Location = new Point(1198, 576);
            cmbUnidadeDestino.Name = "cmbUnidadeDestino";
            cmbUnidadeDestino.Size = new Size(357, 45);
            cmbUnidadeDestino.TabIndex = 10;
            // 
            // btnRelacionar
            // 
            btnRelacionar.BackColor = Color.Transparent;
            btnRelacionar.Cursor = Cursors.Hand;
            btnRelacionar.FlatAppearance.BorderSize = 0;
            btnRelacionar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRelacionar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRelacionar.FlatStyle = FlatStyle.Flat;
            btnRelacionar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnRelacionar.Location = new Point(1405, 798);
            btnRelacionar.Name = "btnRelacionar";
            btnRelacionar.Size = new Size(172, 59);
            btnRelacionar.TabIndex = 12;
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
            btnVoltar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnVoltar.Location = new Point(1405, 913);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(214, 59);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // cmbCategoria
            // 
            cmbCategoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Segoe UI", 20F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(128, 660);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(340, 45);
            cmbCategoria.TabIndex = 2;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // cmbFornecedores
            // 
            cmbFornecedores.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbFornecedores.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbFornecedores.FlatStyle = FlatStyle.Flat;
            cmbFornecedores.Font = new Font("Segoe UI", 20F);
            cmbFornecedores.FormattingEnabled = true;
            cmbFornecedores.Location = new Point(128, 783);
            cmbFornecedores.Name = "cmbFornecedores";
            cmbFornecedores.Size = new Size(340, 45);
            cmbFornecedores.TabIndex = 3;
            // 
            // nudCustoProduto
            // 
            nudCustoProduto.BorderStyle = BorderStyle.None;
            nudCustoProduto.DecimalPlaces = 2;
            nudCustoProduto.Font = new Font("Segoe UI", 20F);
            nudCustoProduto.Location = new Point(592, 279);
            nudCustoProduto.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudCustoProduto.Name = "nudCustoProduto";
            nudCustoProduto.Size = new Size(341, 39);
            nudCustoProduto.TabIndex = 4;
            // 
            // nudValorVenda
            // 
            nudValorVenda.BorderStyle = BorderStyle.None;
            nudValorVenda.DecimalPlaces = 2;
            nudValorVenda.Font = new Font("Segoe UI", 20F);
            nudValorVenda.Location = new Point(592, 406);
            nudValorVenda.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudValorVenda.Name = "nudValorVenda";
            nudValorVenda.Size = new Size(341, 39);
            nudValorVenda.TabIndex = 5;
            // 
            // nudQuantidade
            // 
            nudQuantidade.BorderStyle = BorderStyle.None;
            nudQuantidade.Font = new Font("Segoe UI", 20F);
            nudQuantidade.Location = new Point(592, 533);
            nudQuantidade.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(341, 39);
            nudQuantidade.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Transparent;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnCadastrar.Location = new Point(774, 798);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(172, 59);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.BorderStyle = BorderStyle.None;
            txtDescricao.Location = new Point(132, 410);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(331, 157);
            txtDescricao.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(128, 282);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(340, 36);
            txtNome.TabIndex = 0;
            // 
            // cmbUnidade
            // 
            cmbUnidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnidade.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUnidade.FlatStyle = FlatStyle.Flat;
            cmbUnidade.Font = new Font("Segoe UI", 20F);
            cmbUnidade.FormattingEnabled = true;
            cmbUnidade.Location = new Point(592, 660);
            cmbUnidade.Name = "cmbUnidade";
            cmbUnidade.Size = new Size(340, 45);
            cmbUnidade.TabIndex = 14;
            // 
            // FormCadastroMerc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1803, 1061);
            Controls.Add(cmbUnidade);
            Controls.Add(txtNome);
            Controls.Add(txtDescricao);
            Controls.Add(btnCadastrar);
            Controls.Add(nudQuantidade);
            Controls.Add(nudValorVenda);
            Controls.Add(nudCustoProduto);
            Controls.Add(cmbFornecedores);
            Controls.Add(cmbCategoria);
            Controls.Add(btnVoltar);
            Controls.Add(btnRelacionar);
            Controls.Add(cmbUnidadeDestino);
            Controls.Add(cmbUnidadeOrigem);
            Controls.Add(cmbProduto);
            Controls.Add(textBox3);
            Name = "FormCadastroMerc";
            Text = "FormCadastroMerc";
            ((System.ComponentModel.ISupportInitialize)nudCustoProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudValorVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
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
        private ComboBox cmbCategoria;
        private ComboBox cmbFornecedores;
        private NumericUpDown nudCustoProduto;
        private NumericUpDown nudValorVenda;
        private NumericUpDown nudQuantidade;
        private Button btnCadastrar;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private ComboBox cmbUnidade;
    }
}
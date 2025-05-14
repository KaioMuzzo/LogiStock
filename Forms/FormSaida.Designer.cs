namespace LogiStock
{
    partial class FormSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaida));
            cmbUnidade = new ComboBox();
            cmbProduto = new ComboBox();
            btnInserir = new Button();
            btnConcluir = new Button();
            nudQuantidade = new NumericUpDown();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            SuspendLayout();
            // 
            // cmbUnidade
            // 
            cmbUnidade.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnidade.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUnidade.FlatStyle = FlatStyle.Flat;
            cmbUnidade.Font = new Font("Segoe UI", 20F);
            cmbUnidade.FormattingEnabled = true;
            cmbUnidade.Location = new Point(948, 678);
            cmbUnidade.Name = "cmbUnidade";
            cmbUnidade.Size = new Size(376, 45);
            cmbUnidade.TabIndex = 2;
            // 
            // cmbProduto
            // 
            cmbProduto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProduto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProduto.FlatStyle = FlatStyle.Flat;
            cmbProduto.Font = new Font("Segoe UI", 20F);
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(948, 382);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(376, 45);
            cmbProduto.TabIndex = 0;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.Transparent;
            btnInserir.BackgroundImageLayout = ImageLayout.None;
            btnInserir.Cursor = Cursors.Hand;
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnInserir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Segoe UI", 20F);
            btnInserir.Location = new Point(910, 793);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(203, 66);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnConcluir
            // 
            btnConcluir.BackColor = Color.Transparent;
            btnConcluir.Cursor = Cursors.Hand;
            btnConcluir.FlatAppearance.BorderSize = 0;
            btnConcluir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnConcluir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnConcluir.FlatStyle = FlatStyle.Flat;
            btnConcluir.Font = new Font("Segoe UI", 20F);
            btnConcluir.Location = new Point(1163, 792);
            btnConcluir.Name = "btnConcluir";
            btnConcluir.Size = new Size(199, 67);
            btnConcluir.TabIndex = 4;
            btnConcluir.Text = "Concluir";
            btnConcluir.UseVisualStyleBackColor = false;
            btnConcluir.Click += btnConcluir_Click;
            // 
            // nudQuantidade
            // 
            nudQuantidade.BorderStyle = BorderStyle.None;
            nudQuantidade.Font = new Font("Segoe UI", 20F);
            nudQuantidade.Location = new Point(948, 525);
            nudQuantidade.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(376, 39);
            nudQuantidade.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 15F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(323, 379);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(437, 448);
            listBox1.TabIndex = 5;
            // 
            // FormSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1704, 978);
            Controls.Add(listBox1);
            Controls.Add(nudQuantidade);
            Controls.Add(btnConcluir);
            Controls.Add(btnInserir);
            Controls.Add(cmbProduto);
            Controls.Add(cmbUnidade);
            Name = "FormSaida";
            Text = "FormSaida";
            Load += FormSaida_Load;
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmbUnidade;
        private ComboBox cmbProduto;
        private Button btnInserir;
        private Button btnConcluir;
        private NumericUpDown nudQuantidade;
        private ListBox listBox1;
    }
}
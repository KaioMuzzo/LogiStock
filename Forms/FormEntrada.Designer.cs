namespace LogiStock.Forms
{
    partial class FormEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntrada));
            btnInserir = new Button();
            btnConcluir = new Button();
            nudQuantidade = new NumericUpDown();
            cmbProduto = new ComboBox();
            cmbUnidade = new ComboBox();
            listbox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.Transparent;
            btnInserir.Cursor = Cursors.Hand;
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnInserir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Segoe UI", 20F);
            btnInserir.Location = new Point(916, 764);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(209, 78);
            btnInserir.TabIndex = 5;
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
            btnConcluir.Location = new Point(1169, 764);
            btnConcluir.Name = "btnConcluir";
            btnConcluir.Size = new Size(209, 78);
            btnConcluir.TabIndex = 6;
            btnConcluir.UseVisualStyleBackColor = false;
            btnConcluir.Click += btnConcluir_Click;
            // 
            // nudQuantidade
            // 
            nudQuantidade.BorderStyle = BorderStyle.None;
            nudQuantidade.Font = new Font("Segoe UI", 20F);
            nudQuantidade.Location = new Point(970, 528);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(376, 39);
            nudQuantidade.TabIndex = 10;
            // 
            // cmbProduto
            // 
            cmbProduto.FlatStyle = FlatStyle.Flat;
            cmbProduto.Font = new Font("Segoe UI", 20F);
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(970, 378);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(376, 45);
            cmbProduto.TabIndex = 11;
            // 
            // cmbUnidade
            // 
            cmbUnidade.FlatStyle = FlatStyle.Flat;
            cmbUnidade.Font = new Font("Segoe UI", 20F);
            cmbUnidade.FormattingEnabled = true;
            cmbUnidade.Location = new Point(970, 668);
            cmbUnidade.Name = "cmbUnidade";
            cmbUnidade.Size = new Size(376, 45);
            cmbUnidade.TabIndex = 12;
            // 
            // listbox1
            // 
            listbox1.BorderStyle = BorderStyle.None;
            listbox1.FormattingEnabled = true;
            listbox1.ItemHeight = 15;
            listbox1.Location = new Point(338, 354);
            listbox1.Name = "listbox1";
            listbox1.Size = new Size(437, 465);
            listbox1.TabIndex = 13;
            // 
            // FormEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1704, 978);
            Controls.Add(listbox1);
            Controls.Add(cmbUnidade);
            Controls.Add(cmbProduto);
            Controls.Add(nudQuantidade);
            Controls.Add(btnConcluir);
            Controls.Add(btnInserir);
            Name = "FormEntrada";
            Text = "FormEntrada";
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnInserir;
        private Button btnConcluir;
        private NumericUpDown nudQuantidade;
        private ComboBox cmbProduto;
        private ComboBox cmbUnidade;
        private ListBox listbox1;
    }
}
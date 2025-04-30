namespace LogiStock.Forms
{
    partial class FormFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionarios));
            dataGridView1 = new DataGridView();
            Cadastrar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(131, 312);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1338, 446);
            dataGridView1.TabIndex = 0;
            // 
            // Cadastrar
            // 
            Cadastrar.BackColor = Color.Transparent;
            Cadastrar.FlatAppearance.BorderSize = 0;
            Cadastrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Cadastrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Cadastrar.FlatStyle = FlatStyle.Flat;
            Cadastrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cadastrar.Location = new Point(781, 839);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(207, 66);
            Cadastrar.TabIndex = 1;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(1029, 839);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(206, 66);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(1271, 839);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(208, 66);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // FormFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1704, 978);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(Cadastrar);
            Controls.Add(dataGridView1);
            Name = "FormFuncionarios";
            Text = "FormFuncionarios";
            Load += FormFuncionarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Cadastrar;
        private Button btnEditar;
        private Button btnExcluir;
    }
}
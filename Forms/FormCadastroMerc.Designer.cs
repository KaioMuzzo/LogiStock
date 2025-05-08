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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
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
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 20F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1198, 328);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(357, 45);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Segoe UI", 20F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1198, 451);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(357, 45);
            comboBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.Font = new Font("Segoe UI", 20F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(1198, 576);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(357, 45);
            comboBox3.TabIndex = 5;
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
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Name = "FormCadastroMerc";
            Text = "FormCadastroMerc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button btnRelacionar;
        private Button btnVoltar;
    }
}
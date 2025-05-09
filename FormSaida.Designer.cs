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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            btnInserir = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 20F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(941, 678);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(387, 45);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Segoe UI", 20F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(941, 382);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(387, 45);
            comboBox2.TabIndex = 2;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.Transparent;
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnInserir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Segoe UI", 20F);
            btnInserir.Location = new Point(910, 792);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(203, 66);
            btnInserir.TabIndex = 4;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(1163, 791);
            button2.Name = "button2";
            button2.Size = new Size(199, 67);
            button2.TabIndex = 5;
            button2.Text = "Concluir";
            button2.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 20F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(313, 364);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(458, 481);
            listBox1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.Font = new Font("Segoe UI", 20F);
            numericUpDown1.Location = new Point(941, 525);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(387, 39);
            numericUpDown1.TabIndex = 7;
            // 
            // FormSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1704, 978);
            Controls.Add(numericUpDown1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(btnInserir);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "FormSaida";
            Text = "FormSaida";
            Load += FormSaida_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btnInserir;
        private Button button2;
        private ListBox listBox1;
        private NumericUpDown numericUpDown1;
    }
}
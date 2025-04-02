namespace LogiStock
{
    partial class LogiStockMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogiStockMain));
            panelMenu = new Panel();
            button2 = new Button();
            btnCadastrarMerc = new Button();
            btnAcess = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            lblTitle = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(btnCadastrarMerc);
            panelMenu.Controls.Add(btnAcess);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 519);
            panelMenu.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Gainsboro;
            button2.Image = Properties.Resources.acess;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 200);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(200, 60);
            button2.TabIndex = 3;
            button2.Text = "   Coisa2";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarMerc
            // 
            btnCadastrarMerc.Dock = DockStyle.Top;
            btnCadastrarMerc.FlatAppearance.BorderSize = 0;
            btnCadastrarMerc.FlatStyle = FlatStyle.Flat;
            btnCadastrarMerc.ForeColor = Color.Gainsboro;
            btnCadastrarMerc.Image = Properties.Resources.acess;
            btnCadastrarMerc.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrarMerc.Location = new Point(0, 140);
            btnCadastrarMerc.Name = "btnCadastrarMerc";
            btnCadastrarMerc.Padding = new Padding(20, 0, 0, 0);
            btnCadastrarMerc.Size = new Size(200, 60);
            btnCadastrarMerc.TabIndex = 2;
            btnCadastrarMerc.Text = "   Cadastrar Mercadoria";
            btnCadastrarMerc.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastrarMerc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrarMerc.UseVisualStyleBackColor = true;
            // 
            // btnAcess
            // 
            btnAcess.Dock = DockStyle.Top;
            btnAcess.FlatAppearance.BorderSize = 0;
            btnAcess.FlatStyle = FlatStyle.Flat;
            btnAcess.ForeColor = Color.Gainsboro;
            btnAcess.Image = (Image)resources.GetObject("btnAcess.Image");
            btnAcess.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcess.Location = new Point(0, 80);
            btnAcess.Name = "btnAcess";
            btnAcess.Padding = new Padding(20, 0, 0, 0);
            btnAcess.Size = new Size(200, 60);
            btnAcess.TabIndex = 1;
            btnAcess.Text = "   Acesso";
            btnAcess.TextAlign = ContentAlignment.MiddleLeft;
            btnAcess.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAcess.UseVisualStyleBackColor = true;
            btnAcess.Click += btnAcess_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 58);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 80);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 150, 136);
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Segoe UI", 16F);
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(708, 80);
            panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(318, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(77, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(200, 80);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(708, 439);
            panelDesktop.TabIndex = 2;
            // 
            // LogiStockMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 519);
            Controls.Add(panelDesktop);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            Name = "LogiStockMain";
            Text = "LogiStock";
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Button btnAcess;
        private Button button2;
        private Button btnCadastrarMerc;
        private Panel panel2;
        private Label lblTitle;
        private Panel panelDesktop;
    }
}

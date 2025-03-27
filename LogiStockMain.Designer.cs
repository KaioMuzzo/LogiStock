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
            button1 = new Button();
            btnAcess = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
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
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Image = Properties.Resources.acess;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 140);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(200, 60);
            button1.TabIndex = 2;
            button1.Text = "   Coisa1";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
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
            panel2.BackColor = Color.FromArgb(39, 39, 58);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(708, 80);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(329, 33);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "HOME";
            // 
            // LogiStockMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 519);
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
        private Button button1;
        private Panel panel2;
        private Label label1;
    }
}

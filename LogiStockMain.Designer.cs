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
            panelMenu = new Panel();
            panelLogo = new Panel();
            btnAcesso = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnAcesso);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 450);
            panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // btnAcesso
            // 
            btnAcesso.Dock = DockStyle.Top;
            btnAcesso.FlatAppearance.BorderSize = 0;
            btnAcesso.FlatStyle = FlatStyle.Flat;
            btnAcesso.ForeColor = Color.Gainsboro;
            btnAcesso.Image = Properties.Resources.user;
            btnAcesso.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcesso.Location = new Point(0, 80);
            btnAcesso.Name = "btnAcesso";
            btnAcesso.Size = new Size(220, 60);
            btnAcesso.TabIndex = 0;
            btnAcesso.Text = "Acesso";
            btnAcesso.TextAlign = ContentAlignment.MiddleLeft;
            btnAcesso.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAcesso.UseVisualStyleBackColor = true;
            // 
            // LogiStockMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMenu);
            Name = "LogiStockMain";
            Text = "LogiStock";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnAcesso;
        private Panel panelLogo;
    }
}

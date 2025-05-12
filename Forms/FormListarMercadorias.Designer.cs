namespace LogiStock.Forms
{
    partial class FormListarMercadorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListarMercadorias));
            dtGridMerc = new DataGridView();
            btnSalvar = new Button();
            btnExcluir = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dtGridMerc).BeginInit();
            SuspendLayout();
            // 
            // dtGridMerc
            // 
            dtGridMerc.AllowUserToAddRows = false;
            dtGridMerc.AllowUserToDeleteRows = false;
            dtGridMerc.AllowUserToResizeColumns = false;
            dtGridMerc.AllowUserToResizeRows = false;
            dtGridMerc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridMerc.BackgroundColor = SystemColors.Window;
            dtGridMerc.BorderStyle = BorderStyle.None;
            dtGridMerc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dtGridMerc, "dtGridMerc");
            dtGridMerc.Name = "dtGridMerc";
            dtGridMerc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtGridMerc.CellClick += dtGridMerc_CellClick;
            dtGridMerc.CellContentClick += dtGridMerc_CellContentClick;
            // 
            // btnSalvar
            // 
            resources.ApplyResources(btnSalvar, "btnSalvar");
            btnSalvar.Name = "btnSalvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            resources.ApplyResources(btnExcluir, "btnExcluir");
            btnExcluir.Name = "btnExcluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FormListarMercadorias
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(dtGridMerc);
            Name = "FormListarMercadorias";

            MouseClick += FormListarMercadorias_MouseClick;
            ((System.ComponentModel.ISupportInitialize)dtGridMerc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtGridMerc;
        private Button btnSalvar;
        private Button btnExcluir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
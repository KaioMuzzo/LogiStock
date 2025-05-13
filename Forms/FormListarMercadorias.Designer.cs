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
            cmbFiltro = new ComboBox();
            txtFiltro = new TextBox();
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
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            resources.ApplyResources(btnSalvar, "btnSalvar");
            btnSalvar.Name = "btnSalvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            resources.ApplyResources(btnExcluir, "btnExcluir");
            btnExcluir.Name = "btnExcluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // cmbFiltro
            // 
            resources.ApplyResources(cmbFiltro, "cmbFiltro");
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Name = "cmbFiltro";
            // 
            // txtFiltro
            // 
            txtFiltro.BorderStyle = BorderStyle.None;
            resources.ApplyResources(txtFiltro, "txtFiltro");
            txtFiltro.Name = "txtFiltro";
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            txtFiltro.KeyDown += txtFiltro_KeyDown;
            // 
            // FormListarMercadorias
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbFiltro);
            Controls.Add(txtFiltro);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(dtGridMerc);
            Name = "FormListarMercadorias";
            Load += FormListarMercadorias_Load;
            MouseClick += FormListarMercadorias_MouseClick;
            ((System.ComponentModel.ISupportInitialize)dtGridMerc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtGridMerc;
        private Button btnSalvar;
        private Button btnExcluir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cmbFiltro;
        private TextBox txtFiltro;
    }
}
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
            dtGridMerc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dtGridMerc, "dtGridMerc");
            dtGridMerc.Name = "dtGridMerc";
            dtGridMerc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            // 
            // FormListarMercadorias
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtGridMerc);
            Name = "FormListarMercadorias";
            Load += FormListarMercadorias_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridMerc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtGridMerc;
    }
}
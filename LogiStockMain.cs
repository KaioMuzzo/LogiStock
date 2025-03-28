namespace LogiStock
{
    public partial class LogiStockMain : Form
    {
        private Form activeForm;
        public LogiStockMain()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnAcess_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAcess(), sender);
        }
    }
}

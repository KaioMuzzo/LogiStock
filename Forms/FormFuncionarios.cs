namespace LogiStock.Forms
{
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
            bdLogistock.ListarFuncionarios(dataGridView1);
        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEditar editar = new FormEditar();
            //bdLogistock.op
            
        }
    }
}

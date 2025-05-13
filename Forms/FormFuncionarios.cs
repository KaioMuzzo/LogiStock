namespace LogiStock.Forms
{
    public partial class FormFuncionarios : Form
    {
        private LogiStockMain logiStockMain;

        public FormFuncionarios(LogiStockMain main)
        {
            InitializeComponent();
            bdLogistock.ListarFuncionarios(dataGridView1);
            cmbFiltro.Items.AddRange(new string[] { "matricula", "nome", "usuario", "telefone", "email", "cargo" });
            cmbFiltro.SelectedIndex = 0;
            logiStockMain = main;
        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            logiStockMain.OpenChildForm(new Forms.formRegister(logiStockMain));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var row = dataGridView1.SelectedRows[0];
                string matricula = row.Cells["matricula"].Value.ToString();
                string nome = row.Cells["nome"].Value.ToString();
                string usuario = row.Cells["usuario"].Value.ToString();
                string telefone = row.Cells["telefone"].Value.ToString();
                string email = row.Cells["email"].Value.ToString();

                logiStockMain.OpenChildForm(new Forms.FormEditar(matricula, nome, usuario, telefone, email));
            }
            else
            {
                MessageBox.Show("Seleciona pelo menos 1 funcionário para editar a informação dele.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int matricula = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["matricula"].Value);
                bdLogistock.DeletarFuncionario(matricula);
                bdLogistock.ListarFuncionarios(dataGridView1);
            }
            else
            {
                MessageBox.Show("Seleciona pelo menos 1 funcionário para editar a informação dele.");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            bdLogistock.FuncionariosFiltro(dataGridView1, cmbFiltro, txtFiltro.Text);
        }
    }
}

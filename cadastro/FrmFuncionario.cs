using System;
using System.Windows.Forms;

namespace PDV.cadastro
{
    public partial class FrmFuncionario : Form
    {
        private DatabaseManager dbManager = new DatabaseManager();

        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string telefone = txtTel.Text;
            string email = txtEmail.Text;
            string endereco = txtEndereco.Text;
            string cargo = cbCargo.SelectedItem.ToString();
            string fotoPath = img.ImageLocation;

            dbManager.AddFuncionario(nome, cpf, telefone, email, endereco, cargo, fotoPath);
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["FuncionarioId"]
                    .Value); // Assumindo que você tem uma coluna "FuncionarioId"

                string nome = txtNome.Text;
                string cpf = txtCpf.Text;
                string telefone = txtTel.Text;
                string email = txtEmail.Text;
                string endereco = txtEndereco.Text;
                string cargo = cbCargo.SelectedItem.ToString();
                string fotoPath = img.ImageLocation;

                dbManager.UpdateFuncionario(id, nome, cpf, telefone, email, endereco, cargo, fotoPath);
                LoadData();
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para editar.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["FuncionarioId"]
                    .Value); // Assumindo que você tem uma coluna "FuncionarioId"

                dbManager.DeleteFuncionario(id);
                LoadData();
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para excluir.");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Limpar os campos para um novo cadastro
            txtNome.Clear();
            txtCpf.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            cbCargo.SelectedIndex = -1;
            img.Image = null;
        }

        private void LoadData()
        {
            dataGridView1.DataSource = dbManager.GetFuncionarios();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView(); // Configura o DataGridView ao carregar o formulário
            LoadData();
        }

        private void ConfigureDataGridView()
        {
            // Limpar colunas existentes
            dataGridView1.Columns.Clear();

            // Adicionar colunas
            dataGridView1.Columns.Add("FuncionarioId", "ID");
            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("CPF", "CPF");
            dataGridView1.Columns.Add("Telefone", "Telefone");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Endereco", "Endereco");
            dataGridView1.Columns.Add("Cargo", "Cargo");
            dataGridView1.Columns.Add("Foto", "Foto");

            // Ajustar a largura das colunas
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
    }
}
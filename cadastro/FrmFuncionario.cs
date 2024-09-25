using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PDV.context;

namespace PDV.cadastro
{ 
    public partial class FrmFuncionario : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        private PdvContext _context; // Contexto do banco de dados

        public FrmFuncionario()
        {
            InitializeComponent();
            _context = new PdvContext(); // Inicializa o contexto
            CarregarFuncionarios(); // Carrega os dados ao iniciar o formulário
        }

        // Método para carregar a lista de funcionários
        private void CarregarFuncionarios()
        {
            var funcionarios = _context.Funcionarios.ToList();
            dataGridView1.DataSource = funcionarios; // Supondo que você tenha um DataGridView chamado dataGridView1
        }

        // Método para adicionar um novo funcionário
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos(); // Limpa os campos para adicionar um novo funcionário
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Funcionario (Nome, Telefone, Email, Endereco, Cpf, Cargo, Foto) " +
                               "VALUES (@Nome, @Telefone, @Email, @Endereco, @Cpf, @Cargo, @Foto)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", txtNome.Text);
                    command.Parameters.AddWithValue("@Telefone", txtTel.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                    command.Parameters.AddWithValue("@Cpf", txtCpf.Text);
                    command.Parameters.AddWithValue("@Cargo", cbCargo.SelectedItem.ToString());
                    // Aqui você pode adicionar a lógica para a foto, se necessário

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            // Limpar campos ou atualizar a grid
        }


        // Método para editar um funcionário existente
        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                // Obter o ID do funcionário selecionado na DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int idFuncionario = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["FuncionarioId"].Value);
            
                    // Definindo a query de atualização
                    string query = "UPDATE Funcionario SET Nome = @Nome, Telefone = @Telefone, Email = @Email, " +
                                   "Endereco = @Endereco, Cpf = @Cpf, Cargo = @Cargo, Foto = @Foto " +
                                   "WHERE FuncionarioId = @FuncionarioId";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        // Adicionando os parâmetros
                        command.Parameters.AddWithValue("@Nome", txtNome.Text);
                        command.Parameters.AddWithValue("@Telefone", txtTel.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                        command.Parameters.AddWithValue("@Cpf", txtCpf.Text);
                        command.Parameters.AddWithValue("@Cargo", cbCargo.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@FuncionarioId", idFuncionario);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    // Limpar campos ou atualizar a grid, se necessário
                    CarregarFuncionarios(); // Atualiza a lista de funcionários
                    MessageBox.Show("Funcionário atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Selecione um funcionário para editar.");
                }
            }
        }



        // Método para excluir um funcionário
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                // Obter o ID do funcionário selecionado na DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int idFuncionario = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["FuncionarioId"].Value);

                    // Definindo a query de exclusão
                    string query = "DELETE FROM Funcionario WHERE FuncionarioId = @FuncionarioId";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        // Adicionando o parâmetro
                        command.Parameters.AddWithValue("@FuncionarioId", idFuncionario);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    // Limpar campos ou atualizar a grid, se necessário
                    CarregarFuncionarios(); // Atualiza a lista de funcionários
                    MessageBox.Show("Funcionário excluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Selecione um funcionário para excluir.");
                }
            }
        }


        // Método para limpar os campos
        private void LimparCampos()
        {
            txtNome.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtCpf.Clear();
            cbCargo.SelectedIndex = -1; // Reseta a seleção do ComboBox
            img.ImageLocation = null; // Limpa a imagem
        }
    }
}

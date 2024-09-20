using MySql.Data.MySqlClient;
using System;
using System.Data;

    public class DatabaseManager
{
    private string connectionString = "Server=localhost;Database=pdv;User ID=root;Password=root;";

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public void AddFuncionario(string nome, string cpf, string telefone, string email, string endereco, string cargo, string fotoPath)
    {
        using (var connection = GetConnection())
        {
            connection.Open();
            string query = "INSERT INTO Funcionario (Nome, CPF, Telefone, Email, Endereco, Cargo, Foto) VALUES (@Nome, @CPF, @Telefone, @Email, @Endereco, @Cargo, @Foto)";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@CPF", cpf);
                command.Parameters.AddWithValue("@Telefone", telefone);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Endereco", endereco);
                command.Parameters.AddWithValue("@Cargo", cargo);
                command.Parameters.AddWithValue("@Foto", fotoPath);
                command.ExecuteNonQuery();
            }
        }
    }

    public void UpdateFuncionario(int id, string nome, string cpf, string telefone, string email, string endereco, string cargo, string fotoPath)
    {
        using (var connection = GetConnection())
        {
            connection.Open();
            string query = "UPDATE Funcionario SET Nome = @Nome, CPF = @CPF, Telefone = @Telefone, Email = @Email, Endereco = @Endereco, Cargo = @Cargo, Foto = @Foto WHERE FuncionarioId = @Id";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@CPF", cpf);
                command.Parameters.AddWithValue("@Telefone", telefone);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Endereco", endereco);
                command.Parameters.AddWithValue("@Cargo", cargo);
                command.Parameters.AddWithValue("@Foto", fotoPath);
                command.ExecuteNonQuery();
            }
        }
    }

    public void DeleteFuncionario(int id)
    {
        using (var connection = GetConnection())
        {
            connection.Open();
            string query = "DELETE FROM Funcionario WHERE FuncionarioId = @Id";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }

    public DataTable GetFuncionarios()
    {
        DataTable dataTable = new DataTable();
        using (var connection = GetConnection())
        {
            connection.Open();
            string query = "SELECT * FROM Funcionario";
            using (var adapter = new MySqlDataAdapter(query, connection))
            {
                adapter.Fill(dataTable);
            }
        }
        return dataTable;
    }
}
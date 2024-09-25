namespace PDV.context
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FuncionarioId { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Telefone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Endereco { get; set; }

        [Required]
        public string Cpf { get; set; }

        public string Cargo { get; set; }

        public string Foto { get; set; }
    }

}
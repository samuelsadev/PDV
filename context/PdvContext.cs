using MySql.Data.EntityFramework;

namespace PDV.context
{
    using System.Data.Entity;
    using MySql.Data.EntityFramework;

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class PdvContext : DbContext
    {
        public PdvContext() : base("MySqlConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<PdvContext>());
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }

}
using Microsoft.EntityFrameworkCore;

namespace Comandas
{
    // Classe que representa o banco de dados
    public class BancoDeDados : DbContext
    {
        // propriedade que representa a tabela Usuarios
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cardapio> Cardapios { get; set; }

        // métodos que configura informando para o EF que o banco será SQlite
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=comandas.db");
        }
    }
}

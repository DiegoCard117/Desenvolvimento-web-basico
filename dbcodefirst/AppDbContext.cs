using Microsoft.EntityFrameworkCore;

namespace dbcodefirst {
    public class AppDbContext : DbContext{
        //mapeamento de entidade para a tabela
        public DbSet<Produto> Produtos {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer("Data Source=diego;" + "Initial Catalog=EFCoreDB;Integrated Security=True");
        }
    }
}
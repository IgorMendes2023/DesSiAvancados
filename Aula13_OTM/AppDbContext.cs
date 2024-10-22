using Microsoft.EntityFramework;
namespace Aula13_OTM{
    public class AppDbContext : DbContext{
        public DbSet<Categoria> Categorias { get; set; } = null;
        public DbSet<Produto> Produtos { get; set; } = null;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqulite("Data Source=relacionamento.db");
        }
    }
}
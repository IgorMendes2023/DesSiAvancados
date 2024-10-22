public class AppDbContext : DbContext{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("Data Source=pessoas.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        
    }
}
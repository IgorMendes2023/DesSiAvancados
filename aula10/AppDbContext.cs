using Microsoft.EntityFrameworkCore;
using aula11_EF.Models;

public class AppDbContext : AppDbContext{
    public DbSet<Cliente> Cliente { get; set;}
    public DbSet<Livro> Livro { get; set;}
    public DbSet<Venda> Vendas { get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UserSqlite(" Data Source=vendas.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Vendas>()
            .HasMany(v=> v.Livros)
            .WitchMany()
            .UsingEntity(j => j.ToTable("VendasLivros"));

            base.OnModelCreating(modelBuilder);
    }
}
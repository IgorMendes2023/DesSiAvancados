﻿using System.Linq;
using aula11_EF.Models;

public class Program{
    public static void Main(){

        using (var db = new AppDbContext()){
            
            db.Database.EnsyreCreated();

            Cliente cliente1 = new Cliente("Rafael", 33);
            Cliente cliente2 = new Cliente("João",32);
            db.Cliente.Add(cliente1);
            db.Cliente.Add(cliente2);
            db.SaveChanges();

            Livro livro1 = new Livro("C# para iniciantes", 45.00M);
            Livro livro2 = new Livro("Java: Como programar", 130.00M);
            db.Livro.Add(livro1);
            db.Livro.Add(livro2);
            db.SaveChanges();

            Venda venda1 = new Venda(cliente1);
            venda1.AdicionarLivro(livro1);
            venda1.AdicionarLivro(livro2);
            db.Venda.Add(venda1);

            Console.WriteLine(venda1);

        }
    }
}
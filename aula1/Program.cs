using System;
public class Program{
    public static void Main(string[] args){
        //Cadastrar os dados de pessoa
        Console.WriteLine("Cadastro de pessoa!");

        Console.Write("Nome: ");
        string? nomePessoa = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        int idadePessoa = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu CPF: ");
        int cpf = int.Parse(Console.ReadLine());

        Pessoa pessoa1 = new Pessoa(nomePessoa,idadePessoa,cpf);

        Console.WriteLine(pessoa1.ToString());

    }
}
﻿class Program{

    public static void Main(string[] args){
        Pessoa objPessoa = new("Rafael");
        Console.WriteLine("Antes do método (Classe):" + objPessoa.ToString());
        AlteraNomeClasse(objPessoa);
        Console.WriteLine("Depois do método (Classe): " + objPessoa.ToString());
        PessoaStruct pessoaStruct = new("Miguel");
        Console.WriteLine("Antes do método (Struct): " + pessoaStruct.ToString());
        AlteraNomeStruct(pessoaStruct);
        Console.WriteLine("Depois do método (Struct):" + pessoaStruct.ToString());
    }

    public static void AlteraNomeClasse(Pessoa objAux){
        objAux.Nome = "Igor";
    }

    public static void AlteraNomeStruct(PessoaStruct objAux){
        objAux.NomeStruct = "Maria";
    }


}
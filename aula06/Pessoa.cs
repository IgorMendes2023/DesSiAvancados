public class Pessoa{
    private string? nome;
    private int idade;
    private int cpf;

    public Pessoa(string nome, int idade, int cpf){
        Nome = nome;
        Idade = idade;
        Cpf = cpf;
    }
    public Pessoa(){}

    public string Nome{
        get{return nome;}
        set{nome = value;}
    }

    public int Idade{
        get{return idade;}
        set{idade = value;}
    }

    public int Cpf{
        get{return cpf;}
        set{cpf = value;}
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}, Cpf: {Cpf}";
    }
}
public class Program{
    public delegate void exibirNumero();
    public static void imprimeNumero(int numero){
        Console.WriteLine("O quadrado do número" + numero + "é: " + numero*numero);
    }   


public static void Main(){
    ExibirNumero meuDelegate = imprimeNumero;
    meuDelegate(10);

    meuDelegate += ExibirQuadrado;
    meuDelegate(2);

    meuDelegate +=delegate(int num){
        Console.WriteLine("O dobro do número " + num + "é: " + num*2);
    };
    meuDelegate(3);
}
}
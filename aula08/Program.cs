public class Program{

    public static void Main()
    {

    List<int> numeros = new List<int>{1,2,3,4,5,6,7,8,9,10};

    List<int> numerosPares = numeros.Where(n => n % 2 == 0).ToList();

    Console.WriteLine("Números Pares: ");
    numerosPares.ForEach( n => Console.WriteLine(n));

    List<string> frutas = new List<string> {"Maçã","Banana","Manga","Abacaxi"};

    List<string> frutasOrdenadas = frutas.OrderBy(f => f).ToList();

    List<string> frutasComM = frutasOrdenadas.Where(f => f.StartsWith("M")).ToList();

    Console.WriteLine("Frutas ordenadas que começam com M");
    frutasComM.ForEach(f => Console.WriteLine(f));
}
}
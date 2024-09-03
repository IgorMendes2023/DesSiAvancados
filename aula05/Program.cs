public class Program{
    public static void Main(string[] args){
        int numInt = 45;
        double numDouble = numInt;
        Console.WriteLine ("Conversão implícita de int para double: ");
        Console.WriteLine($"Int: {numInt}, Double: {numDouble}");

        // Conversão usando o Convert
        double valorDouble = 9.323;
        int valorConvertidoInt = Convert.ToInt32(valorDouble);
        string textoValor = "232";
        int textoConvertidoInt = Convert.ToInt32(textoValor);
        Console.WriteLine($"Double: {valorDouble}, Inteiro{valorConvertidoInt}");
        Console.WriteLine($"String:{textoValor}, Inteiro {textoConvertidoInt}");

        double numDouble2 = 9.66;
        int a = (int) numDouble2;
        Console.WriteLine($"Double: {numDouble2}, Inteiro: {a}");
    }
}
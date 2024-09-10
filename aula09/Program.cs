class Program{
    public static void Main(string[] args){
      Cliente cliente1 = new Cliente(1,"Igor");
      Cliente cliente2 = new Cliente(2,"João");
      
      Produto produto1 = new Produto(1,"PS5", 4000.00m);
      Produto produto2 = new Produto(2,"Iphone",80000.00m);
      Produto produto3 = new Produto(3,"Azera", 600000.00m);
      Produto produto4 = new Produto(4,"PSP",500.00m);


      Compra compra1 = new Compra(cliente1);
      compra1.AdicionaProduto(produto1);
      compra1.AdicionaProduto(produto2);

      Compra compra2 = new Compra(cliente1);
      compra2.AdicionaProduto(produto3);
      compra2.AdicionaProduto(produto4);

      Console.WriteLine(compra1);
      Console.WriteLine(compra2);
    }
}

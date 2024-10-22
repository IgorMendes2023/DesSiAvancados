public class Program{
    public static void Main(string[] args){
        using(var context = new AppDbContext()){
            context.Database.EnsureDeleted()
        }
    }
}
using ConsoleApp8;

internal class Program
{
    private static void Main(string[] args)
    {
      /* Compte C1 = new Compte();
        Console.WriteLine(C1.ToString());
        Compte C2 = new Compte(8000);
        Console.WriteLine(C2.ToString()); 
      
        CompteSimple cs1 = new CompteSimple(100);
        Console.WriteLine(cs1.ToString());
        CompteSimple cs2 =new CompteSimple(100,1000);
        Console.WriteLine(cs2.ToString());*/

        CompteEpargne ce1 = new CompteEpargne(0.05F,100);
        ce1.ajouterInterets();
        Console.WriteLine(ce1.ToString());






    }
}
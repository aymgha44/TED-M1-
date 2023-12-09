using Transport;

internal class Program
{
    private static void Main(string[] args)
    {
        Cargaison cr = new CargaisonRoutiere(90);
        cr.Ajouter(new Marchandise(1, 80, 70));
        cr.Ajouter(new Marchandise(2, 30, 90));
        cr.Ajouter(new Marchandise(3, 35, 100));
        cr.afficher();
        Console.WriteLine("Cout =" +cr.count());

        Cargaison ca = new CargaisonAerienne(90);
        ca.Ajouter(new Marchandise(4, 80, 70));
        ca.Ajouter(new Marchandise(5, 30, 90));
        ca.Ajouter(new Marchandise(6, 35, 100));
        cr.afficher();
        Console.WriteLine("Cout =" +ca.count());
        Console.WriteLine("chercher la marchandise num 3");
        Marchandise m = cr.getMarchandises(3);
        Console.WriteLine(m);
        Console.ReadLine();


    }
}
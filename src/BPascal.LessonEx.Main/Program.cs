public class Program //è una classe
{
    public static void Main() //entrata per esecuzione codice
    {
        Console.WriteLine("whats your name");
        string brother = Console.ReadLine(); //chiedo nome di cliente

        Console.WriteLine($"hello {brother}, welcome to hell");

        Console.WriteLine("dobbiamo ordinare della roba per la scuola. quanti ne vuoi? non fare domande");
        int pacchi = Console.Read();
        int costoSpedizione = 90;
        costoSpedizione = 10;
        int costoPerPacco = 5;
        int costoTot = (costoPerPacco * pacchi) + costoSpedizione;

        if (costoTot <= 0)
        {
            Console.WriteLine($"{brother} che hai comprato???");
        }
        else
        {
            Console.WriteLine($"il costo totale dei tuoi pacchi sono {costoTot} euro.");
            Console.WriteLine("paga o mi troverai in camera tua.");
        }
    }
}
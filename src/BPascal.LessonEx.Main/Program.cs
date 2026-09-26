public class Program //è una classe
{
    public static void Main() //entrata per esecuzione codice
    {
        string brother = "pete";
        brother = "bob";

        Console.WriteLine($"hello {brother}, welcome to hell");

        int pacchi = 3;
        int costoSpedizione = 90;
        costoSpedizione = 10;
        int costoPerPacco = 5;

        int costoTot = (costoPerPacco * pacchi)+costoSpedizione;
        costoTot = 0;
       

        if (costoTot == 0)
        {
            Console.WriteLine($"{brother} che hai comprato???");
        }
        else
        {
            Console.WriteLine($"una cosa, il costo totale dei tuoi pacchi sono {costoTot} euro. paga.");
        }
    }
}
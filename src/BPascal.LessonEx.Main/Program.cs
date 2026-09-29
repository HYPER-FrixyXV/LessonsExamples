public class Program //è una classe
{
    public static void Main() //entrata per esecuzione codice
    {
        /*Realizzare un programma C# da console per gestire un semplice ordine
        effettuato in una libreria. Il programma deve chiedere all'utente il
        nome del cliente, il numero di libri acquistati, il prezzo di un singolo
        libro, se il cliente è uno studente (forse qui serve qualcosa di nuovo) e il tipo di consegna desiderato (spedizione, ritiro).

        Dopo aver acquisito i dati, il programma deve calcolare il subtotale
        dell'ordine moltiplicando il numero dei libri per il prezzo unitario. La spedizione costa 5 euro. 

        Al termine, il programma deve mostrare l'elenco dei libri
        acquistati e un riepilogo contenente il nome del cliente, la quantità,
        il prezzo unitario, il tipo di consegna, il subtotale, le
        eventuali spese di spedizione e il totale finale. Deve inoltre mostrare
        un messaggio conclusivo diverso (forse qui serve qualcosa di nuovo)  in base all'importo dell'ordine.
        Es: grazie per il tuo ordine! - Ordine non valido! - Ordine di piccolo importo!. 

        Per realizzare il programma utilizzare variabili e costanti locali,
        i tipi string, int, decimal e bool, gli operatori aritmetici, logici e
        di confronto, le strutture if, else if, else. Tutto il codice deve essere scritto all'interno del metodo Main.

        Il codice deve rispettare i principi di base del Clean Code, utilizzando
        nomi chiari e descrittivi, un'indentazione coerente e una suddivisione
        ordinata delle diverse parti del programma.*/

        string name;
        do
        {
            Console.WriteLine("Inserisci il tuo nome");
            name = Console.ReadLine();
            if (name == "" || name.IsWhiteSpace()) Console.WriteLine("Il tuo nome non può essere vuoto o nullo");
        } while (name=="" || name.IsWhiteSpace());
        
        int bookAmount;
        do
        {
            Console.WriteLine("Inserisci il numero di libri che vorreste comprare");
            bookAmount = int.Parse(Console.ReadLine());
            if (bookAmount < 0) Console.WriteLine("Il numero di libri può essere solo positivo o nullo, non negativo");
        } while (bookAmount < 0);

        decimal bookPrice;
        do
        {
            Console.WriteLine("Inserisci il prezzo di ogni libro");
            bookPrice = int.Parse(Console.ReadLine());
            if (bookPrice < 0) Console.WriteLine("Il prezzo dei libri può essere solo positivo o nullo, non negativo");
        } while (bookPrice < 0);

        
        string shipment;
        do
        {
            Console.WriteLine("Inserisci il tipo di consegna desiderato (spedizione, ritiro)");
            shipment = Console.ReadLine();
            if (shipment!= "spedizione" && shipment!= "ritiro") 
                Console.WriteLine($"Ci dispiace {name}, ma il suo ordine non può essere eseguito");
        } while (shipment!= "spedizione" && shipment!= "ritiro");


        Console.WriteLine($"Nome cliente: {name}");
        Console.WriteLine($"Numero libri acquistati e prezzo totale: {bookAmount}, {(bookAmount*bookPrice)+5}€");
        Console.WriteLine($"Tipo consegna: {shipment}");
    }
}
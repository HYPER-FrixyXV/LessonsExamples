﻿using BPascal.LessonEx0.Domain;

public class Program
{

    public static void Main()
    {
        Do{
            Console.WriteLine("Insert your name");
            string name = Console.ReadLine();
            If(name=”” || name.isBlankSpace()). Console.WriteLine(Error: name cannot be empty or blank);
        }While(name=”” || name.isBlankSpace());

Do{
            Console.WriteLine("Insert the amount of books you'd like to order");
            Int bookAmount = int.Parse(Console.ReadLine());
            If(bookAmount<0) Console.WriteLine(Error: the amount cannot be negative);
        }While(bookAmount<0);

Do{
            Console.WriteLine("Insert the price of a single book");
            Decimal bookPrice = decimal.Parse(Console.ReadLine());
            If(bookPrice<0) Console.WriteLine(Error: the price cannot be negative);
        }While(bookPrice<0);

Do{
            Console.WriteLine("Are you a student? (True/false)");
            bool student=Console.ReadLine());
            If(student!=true || student=!false) Console.WriteLine(Error: answer invalid, insert true or false);
        }While(student!=true || student=!false);

Do{
            Console.WriteLine("Insert the kind of shipment you'd like (delivery/takeaway)");
            string ship=Console.ReadLine());
            If(ship!=”delivery” || ship=!”takeaway”) Console.WriteLine(Error: answer invalid, insert one of the previously listed options);
        }While(ship!=”delivery” || ship=!”takeaway”);

        Console.WriteLine($”Name: {name});
        Console.WriteLine($”Total order price: {(bookAmount*bookPrice)+5}€”);
        Console.WriteLine($”Student? {student})
        Console.WriteLine($”Shipment type: {ship});
    }
}


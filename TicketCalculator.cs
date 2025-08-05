using System;

class TicketPriceCalculator
{
    static void Main()
    {
        int ticket_price;

        Console.WriteLine("Enter your age");
        int CustomerAge = Convert.ToInt32(Console.ReadLine());

        if (CustomerAge <= 12 || CustomerAge >= 65)
        {
            ticket_price = 7;
        }
        else
        {
            ticket_price = 10;
        }
        Console.WriteLine($"Your ticket price is GHC{ticket_price}.");
    }
}
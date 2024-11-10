using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalFinanceApp 
{
    class Program
    {
        static decimal balance = 0; // Detta är en varibel som det nuvarande saldot
        static List<Transaction> transactions = new List<Transaction>(); // Listan för att spara/lagra transaktionerna.

            BankTitel.BankMessage();
           

        static void Main(string[] args) 
        {
            while (true) // En loop som inte slutar loopa, tills använadren själv att sluta genom "exit"
                
            { // Detta är menyn där användaren väljer vad hen vill göra med sin "Finance"
                Console.WriteLine("\nChoose an option:"); 
                Console.WriteLine("1. Add Transaction"); 
                Console.WriteLine("2. Delete Transaction"); 
                Console.WriteLine("3. Current balance");
                Console.WriteLine("4. Date transactions"); 
                Console.WriteLine("5. Exit"); 

                switch (Console.ReadLine()) 
                {
                    case "1": AddTransaction(); break; // Anropar metoden för att lägga till transaktion.
                    case "2": DeleteTransaction(); break; // Anropar metoden för att ta bort transaktion.
                    case "3": ShowBalance(); break; // Anropar metoden för att visa ditt akutella saldot.
                    case "4": ShowStats(); break; // Anropar metoden för att visa transaktioner med Datum.
                    case "5": return;
                    default: Console.WriteLine("Choose again between the numbers shown"); break; 
                }
            }
        } 
    }
}
  
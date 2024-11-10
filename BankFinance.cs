using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalFinanceApp 
{
    class Program
    {
        static decimal balance = 0; // Detta är en varibel som det nuvarande saldot
        static List<Transaction> transactions = new List<Transaction>(); // Listan för att spara/lagra transaktionerna.

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

//         static void AddTransaction() // Metod för att lägga till en ny transaktion.
//         {
//             Console.Write("Type your amount: "); // Ber användaren att ange belopp.
//             if (decimal.TryParse(Console.ReadLine(), out decimal amount)) // koden konverterar inmatningen till ett decimalvärde.
//             {
//                 Console.Write("Enter date, by following instructions (yyyy-MM-dd): "); // Ber om datum.
//                 if (DateTime.TryParse(Console.ReadLine(), out DateTime date)) // Försöker konvertera inputet till ett datum.
//                 {
//                     transactions.Add(new Transaction(amount, date)); // Lägger till den nya transaktionen i listan.
//                     balance += amount; // Uppdaterar saldot med det nya beloppet.
//                     Console.WriteLine($"Added {amount} on {date:yyyy-MM-dd}"); // Bekräftar att transaktionen lagts till.
//                 }
//                 else
//                 {
//                     Console.WriteLine("Invalid date. Transaction not added."); 
//                 }
//             }
//            // else
//             //{
//               //  Console.WriteLine("Invalid amount. Transaction not added."); 
//             //}
//         }

//         static void DeleteTransaction() 
//         {
//             if (transactions.Count > 0) // Kontrollerar om det finns transaktioner att ta bort. dvs har hen gjort "add" transaktion än.
//             {
//                 var last = transactions[^1]; // Hämtar den senaste transaktionen.
//                 balance -= last.Amount; // tar bort saldot med från den senaste transaktionen.
//                 transactions.RemoveAt(transactions.Count - 1); // Tar bort den senaste transaktionen från listan.
//                 Console.WriteLine($"Removed: {last.Amount} on {last.Date:yyyy-MM-dd}"); // Bekräftar att transaktionen har tagits bort.
//             }
//             else
//             {
//                 Console.WriteLine("No transactions to delete, maybe add one :)"); 
//             }
//         }

//         static void ShowBalance() 
//         {
//             Console.WriteLine($"Current balance: {balance}$"); 
//         }

//         static void ShowStats()
//         {
//             if (transactions.Count == 0) // Kontrollerar om det finns några tillagda transaktioner.
//             {
//                 Console.WriteLine("No transactions to added, Your transaction cant be shown."); 
//                 return; 
//             }
//             // T är ett index, men även förkortning för time i detta fall
//             foreach (var t in transactions) // går igenom alla transaktioner.
//             {
//                 Console.WriteLine($"{t.Date:yyyy-MM-dd}: {t.Amount}$"); // Skriver ut datum plus belopp för varje transaktion.
//             }
//         }
//     }

//     class Transaction 
//     {
//         // proporties 
//         public decimal Amount { get; } // lagra beloppet.
//         public DateTime Date { get; } // spara  datumet.

//         public Transaction(decimal amount, DateTime date) // Konstruktör för att skapa en ny transaktion.
//         {
//             Amount = amount; // Sätter beloppet.
//             Date = date; // Sätter datumet.
//         }
//     }
// }

static void AddTransaction() // Metod för att lägga till en ny transaktion.
        {
            Console.Write("Type your amount: "); // Ber användaren att ange belopp.
            if (decimal.TryParse(Console.ReadLine(), out decimal amount)) // koden konverterar inmatningen till ett decimalvärde.
            {
                Console.Write("Enter date, by following instructions (yyyy-MM-dd): "); // Ber om datum.
                if (DateTime.TryParse(Console.ReadLine(), out DateTime date)) // Försöker konvertera inputet till ett datum.
                {
                    transactions.Add(new Transaction(amount, date)); // Lägger till den nya transaktionen i listan.
                    balance += amount; // Uppdaterar saldot med det nya beloppet.
                    Console.WriteLine($"Added {amount} on {date:yyyy-MM-dd}"); // Bekräftar att transaktionen lagts till.
                }
                else
                {
                    Console.WriteLine("Invalid date. Transaction not added."); 
                }
            }
           // else
            //{
              //  Console.WriteLine("Invalid amount. Transaction not added."); 
            //}
        }

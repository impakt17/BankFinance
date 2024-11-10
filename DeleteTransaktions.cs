static void DeleteTransaction() 
        {
            if (transactions.Count > 0) // Kontrollerar om det finns transaktioner att ta bort. dvs har hen gjort "add" transaktion än.
            {
                var last = transactions[^1]; // Hämtar den senaste transaktionen.
                balance -= last.Amount; // tar bort saldot med från den senaste transaktionen.
                transactions.RemoveAt(transactions.Count - 1); // Tar bort den senaste transaktionen från listan.
                Console.WriteLine($"Removed: {last.Amount} on {last.Date:yyyy-MM-dd}"); // Bekräftar att transaktionen har tagits bort.
            }
            else
            {
                Console.WriteLine("No transactions to delete, maybe add one :)"); 
            }
        }

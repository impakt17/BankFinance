static void ShowBalance() 
{
        {
            Console.WriteLine($"Current balance: {balance}$"); 
        }

        static void ShowStats()
        {
            if (transactions.Count == 0) // Kontrollerar om det finns några tillagda transaktioner.
            {
                Console.WriteLine("No transactions to added, Your transaction cant be shown."); 
                return; 
            }
            // T är ett index, men även förkortning för time i detta fall
            foreach (var t in transactions) // går igenom alla transaktioner.
            {
                Console.WriteLine($"{t.Date:yyyy-MM-dd}: {t.Amount}$"); // Skriver ut datum plus belopp för varje transaktion.
            }
        }
}
 
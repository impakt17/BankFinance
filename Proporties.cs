 class Transaction 
 {
    {
        // proporties 
        public decimal Amount { get; } // lagra beloppet.
        public DateTime Date { get; } // spara  datumet.

        public Transaction(decimal amount, DateTime date) // Konstruktör för att skapa en ny transaktion.
        {
            Amount = amount; // Sätter beloppet.
            Date = date; // Sätter datumet.
        }
    }
}

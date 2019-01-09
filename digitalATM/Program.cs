using System;

namespace digitalATM
{
    public class Program
    {
        public int balance = 1000; // set initial balance
        // public string receipt = "";

        public static void Main(string[] args)
        {
            // starts session to track transactions and build receipt
            // launches Interface (w/ balance) and keep open until user exits
            // prints receipt after user exits
        }

        public static string ViewBalance(int balance)
        {
            string transaction = "0,0," + balance;

            return transaction;
        }

        // Interface method
        // - accepts and maintains balance
        // - display menu
        // - get and route user selection from actions menu (w/ transaction type and balance)
        // - route to InvalidInputs if invalid
        // - return true to Main (to keep running until user exits)
        // - return false to Main (to exit when selected by user)
        // Tests
        // - return true when user doesn't exit
        // - return false when user exits

        // ViewBalance method
        // - calls ShowData with balance
        // - return receipt string

        // Deposit method
        // - throw exception if invalid deposit amount
        // - adds to balance
        // - calls ShowData with deposit amount and new balance
        // - return receipt string

        // Withdraw method
        // - throw exception if invalid withdrawal amount
        // - check for sufficient funds
        // - change withdrawal amount to $0 if insufficient (try-catch)
        // - calls ShowData with withdrawal amount and new balance (finally)
        // - return receipt string

        // ShowData method
        // builds receipt string and displays single transaction
        // - receives switchCase and transaction details from calling method
        // - (ViewBalance - type 0) displays balance
        // - (Deposit - 1) displays deposit amount and new balance
        // - (Withdraw - 2) displays withdrawal amount and new balance
        // - (Withdraw catch - 3) displays available balance and overdraft message
        // - return receipt string

        // BuildReceipt
        // - receives receipt string
        // - parses receipt string into array
        // - return formatted array for printing

        // InvalidInputs
        // - handle invalid inputs with try-catch

        // Transaction Record Format
        // transType,amount,balance
        // "2,20,980"
    }
}

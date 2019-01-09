using System;

namespace digitalATM
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int balance = 10000;
            string receiptString = "";
            // starts session to track transactions and build receipt
            // launches Interface (w/ balance) and keep open until user exits
            // prints receipt after user exits
        }

        public static string ViewBalance(int balance)
        {
            string transaction = "Checked balance: $" + balance + ";";

            return transaction;
        }

        public static string Deposit(int balance, int depositAmt)
        {
            balance += depositAmt;

            string transaction = "Deposited $" + depositAmt + ". New balance: $" + balance + ";";

            return transaction;
        }

        public static string Withdraw(int balance, int withdrawAmt)
        {
            string transaction = "";
            if (balance > withdrawAmt)
            {
                balance -= withdrawAmt;
                transaction = "Withdraw $" + withdrawAmt + ". New balance: $" + balance + ";";
            }
            else
            {
                transaction = "Withdraw $" + withdrawAmt + ". Insufficient funds. Balance: $" + balance + ";";
            }


            return transaction;
        }

        public static string[] BuildReceipt(string receiptString)
        {
            receiptString = receiptString.TrimEnd(';');
            string[] receiptArray = receiptString.Split(";");

            return receiptArray;
        }

        // Interface method
        // - accepts and maintains balance
        // - display menu
        // - get and route user selection from actions menu (w/ transaction type and balance)
        // - route to InvalidInputs if invalid
        // - return true to Main (to keep running until user exits)
        // - return false to Main (to exit when selected by user)

        // ViewBalance method
        // - calls ShowData with balance
        // - DONE return receipt string

        // Deposit method
        // - throw exception if invalid deposit amount
        // - adds to balance
        // - calls ShowData with deposit amount and new balance
        // - DONE return receipt string

        // Withdraw method
        // - throw exception if invalid withdrawal amount
        // - check for sufficient funds
        // - change withdrawal amount to $0 if insufficient (try-catch)
        // - calls ShowData with withdrawal amount and new balance (finally)
        // - DONE return receipt string

        // ShowData method
        // builds receipt string and displays single transaction
        // - receives switchCase and transaction details from calling method
        // - (ViewBalance - type 0) displays balance
        // - (Deposit - 1) displays deposit amount and new balance
        // - (Withdraw - 2) displays withdrawal amount and new balance
        // - (Withdraw catch - 3) displays available balance and overdraft message

        // BuildReceipt
        // - receives receipt string
        // - parses receipt string into array
        // - return formatted array for printing

        // InvalidInputs
        // - handle invalid inputs with try-catch

        // DONE Transaction Record Format
        // DONE "Deposited $50. New balance: $1050;"
    }
}

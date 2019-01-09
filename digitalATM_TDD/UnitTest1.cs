
using System;
using Xunit;
using digitalATM;

namespace UnitTestingTDD
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalance_CanReturnTransaction()
        {
            string[] returned = { "Checked balance: $1000;", "1000" };
            Assert.Equal(returned, Program.ViewBalance(1000));
        }

        [Fact]
        public void Deposit_CanReturnTransaction()
        {
            string[] returned = { "Deposited $50. New balance: $1050;", "1050" };
            Assert.Equal(returned, Program.Deposit(1000,50));
        }

        [Fact]
        public void Deposit_RejectsNegativeDeposit()
        {
            string[] returned = { "Invalid (negative) deposit amount. Try 'Withdraw funds' instead. New balance: $10;", "10" };
            Assert.Equal(returned, Program.Deposit(10, -100));
        }

        [Fact]
        public void Withdraw_CanReturnTransaction()
        {
            string[] returned = { "Withdraw $50. New balance: $950;", "950" };
            Assert.Equal(returned, Program.Withdraw(1000, 50));
        }

        [Fact]
        public void BuildReceipt()
        {
            string receiptString = "Checked balance: $1000;Deposited $50. New balance: $950;Withdraw $50. New balance: $1050;";
            string[] receiptArray = { "Checked balance: $1000", "Deposited $50. New balance: $950", "Withdraw $50. New balance: $1050" };
            Assert.Equal(receiptArray, Program.BuildReceipt(receiptString));
        }

        [Fact]
        public void Withdraw_NoOverdraft()
        {
            string[] returned = { "Withdraw $50. Insufficient funds. Balance: $10;", "10" };
            Assert.Equal(returned, Program.Withdraw(10, 50));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Menu
    {
        public void MainMenu()
        {
            Console.WriteLine("Please make your selection from the following options:");
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
        }

        public void AccountMenu()
        {
            Console.WriteLine("Please make a selection:");
            Console.WriteLine("1. Checking Account");
            Console.WriteLine("2. Savings Account");
        }

        public void ValidationMenu()
        {
            Console.WriteLine("Please make a valid selection: enter 1 or 2");
            //Console.WriteLine("1. Checking Account");
            //Console.WriteLine("2. Savings Account");
        }
    }
}

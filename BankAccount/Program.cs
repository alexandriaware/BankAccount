using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate!
            Client potter = new Client();
            Checking check = new Checking();
            Savings save = new Savings();
            Menu main = new Menu();

            float input; //store input numbers
            
            //view menu
            main.MainMenu();

            string selection = Console.ReadLine().Trim(); //store input

            if (selection == "1") //client info
            {
                Console.WriteLine(potter.GetInfo());
            }
            else if (selection == "2") //Acct balance
            {
                main.AccountMenu();
                selection = Console.ReadLine().Trim();

                if (selection == "1") //Deposit to checking
                {
                    Console.WriteLine("Please enter the amount you'd like to deposit.");
                    input = float.Parse(Console.ReadLine());
                    check.Deposit(input);
                    Console.WriteLine("Your new Checking Account balance is : $" + check.acctBalance);
                }
                else if (selection == "2") //Deposit to savings
                {
                    Console.WriteLine("Please enter the amount you'd like to deposit.");
                    input = float.Parse(Console.ReadLine());
                    save.Deposit(input);
                    Console.WriteLine("Your new Savings Account balance is: $" + save.acctBalance);
                }
                else
                {
                    main.ValidationMenu();
                    selection = Console.ReadLine().Trim();
                }
            }
            else if (selection == "3") //Deposit funds
            {
                main.AccountMenu();
                //check.Deposit();
            }
            else if (selection == "4") //Withdraw funds
            {
                main.AccountMenu();
            }
            else if (selection == "5") //Exit
            {
                //still need an exit strategy
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}

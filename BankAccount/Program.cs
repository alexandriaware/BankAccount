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

            string selection;

            Console.WriteLine("Welcome to Gringott's Bank, sir. How may I be of service?");
            

            do
            {
                //View Menu
                main.MainMenu();

                selection = Console.ReadLine().Trim(); //store input

                if (selection == "1") //client info
                {
                    Console.WriteLine(potter.GetInfo());
                    Console.WriteLine("\nCan I do anything else for you, sir?\n");

                }
                else if (selection == "2") //Acct balance
                {
                    do
                    {
                        main.AccountMenu();
                        selection = Console.ReadLine().Trim();


                        if (selection == "1") //Show checking balance
                        {
                            Console.WriteLine("Your Checking Account balance is : $" + check.acctBalance);
                            Console.WriteLine("\nCan I do anything else for you, sir?\n");
                        }
                        else if (selection == "2") //show savings balance
                        {
                            Console.WriteLine("Your Savings Account balance is: $" + save.acctBalance);
                            Console.WriteLine("\nCan I do anything else for you, sir?\n");
                        }
                        else
                        {
                            main.ValidationMenu();
                        }
                    } while (selection != "1" && selection != "2");
                }
                else if (selection == "3") //Deposit funds
                {
                    do
                    {
                        main.AccountMenu();
                        selection = Console.ReadLine().Trim();
                        if (selection == "1") //Deposit to checking
                        {
                            Console.WriteLine("Please enter the amount you'd like to deposit.");
                            input = float.Parse(Console.ReadLine());
                            check.Deposit(input);
                            Console.WriteLine("Your Checking Account balance is : $" + check.acctBalance);
                            Console.WriteLine("\nCan I do anything else for you, sir?\n");
                        }
                        else if (selection == "2") //Deposit to savings
                        {
                            Console.WriteLine("Please enter the amount you'd like to deposit.");
                            input = float.Parse(Console.ReadLine());
                            save.Deposit(input);
                            Console.WriteLine("Your Savings Account balance is: $" + save.acctBalance);
                            Console.WriteLine("\nCan I do anything else for you, sir?\n");
                        }
                        else
                        {
                            main.ValidationMenu();
                        }
                    } while (selection != "1" && selection != "2");

                }
                else if (selection == "4") //Withdraw funds
                {
                    do
                    {
                        main.AccountMenu();
                        selection = Console.ReadLine().Trim();
                        if (selection == "1") //Withdraw from checking
                        {
                            Console.WriteLine("Please enter the amount you'd like to withdraw.");
                            input = float.Parse(Console.ReadLine());
                            check.Withdraw(input);
                            Console.WriteLine("Your Checking Account balance is : $" + check.acctBalance);
                            Console.WriteLine("\nCan I do anything else for you, sir?\n");
                        }
                        else if (selection == "2") //Withdraw from savings
                        {
                            Console.WriteLine("Please enter the amount you'd like to withdraw.");
                            input = float.Parse(Console.ReadLine());
                            save.Withdraw(input);
                            Console.WriteLine("Your Savings Account balance is: $" + save.acctBalance);
                            Console.WriteLine("\nCan I do anything else for you, sir?\n");
                        }
                        else
                        {
                            main.ValidationMenu();
                        }

                    } while (selection != "1" && selection != "2");                   

                }

            } while (selection != "5");
            

            {
                Console.WriteLine("Pleasure doing business with you, Mr. Potter.");
                Environment.Exit(5);
            }
        }
    }
}

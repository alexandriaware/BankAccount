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
            }
        }
    }
}

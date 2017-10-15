using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings : Accounts
    {
        //field
        private float minimumBalance;

        //Property
        public float MinimumBalance { get; set; }

        //Constructors
        public Savings()
        {
            //default
            minimumBalance = 10.0f;
            acctType = "Savings Account";
            acctNum = 8775;
            acctBalance = 15000.0f;

        }

        //Method
        public override void Withdraw(float input)
        {
            if (input >= minimumBalance)
            {
                acctBalance = acctBalance - input;
            }
            else
            {
                Console.WriteLine("Insufficient funds, Mr. Potter.");
            }
        }
        
    }
}

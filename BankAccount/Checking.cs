﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Accounts
    {
        //I DON'T NEED NO FIELDS OR PROPERTIES cuz they are SHARED

        //Constructors
        public Checking()
        {
            acctBalance = 7887.5f;
            acctNum = 2308;
            acctType = "Checking Account";

        }

        //Method
        public override void Withdraw(float input)
        {
            if (input > acctBalance - input)
            {
                Console.WriteLine("Insufficient funds, Mr. Potter.");
            }
            else
            {
                acctBalance = acctBalance - input;
            }
        }
        public override void Deposit(float input)
        {
            base.Deposit(input);
        }
    }
}

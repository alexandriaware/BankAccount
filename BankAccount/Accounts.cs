using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Accounts
    {
        //fields
        protected string acctType;
        protected int acctNum;
        public float acctBalance;


        //Properties
        public string AcctType { get; set; }
        public float AcctBalance
        {
            get { return this.acctBalance; }
        }
        public int AcctNum
        {
            get { return this.acctNum; }
        }

        //Constructors
        public Accounts()
        {

        }
        public Accounts(string acctType, float acctBalance, int acctNum)
        {
            this.acctType = acctType;
            this.acctBalance = acctBalance;
            this.acctNum = acctNum;
        }

        //methods
        public abstract void Withdraw(float input);

        public virtual void Deposit(float input)
        {
            acctBalance = acctBalance + input;
        }
    }

        
}

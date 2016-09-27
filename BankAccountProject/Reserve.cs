using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Reserve : Account
    {
        // Field 
        double resStart = 1000.00;
        char acctType;



        // Properties
        public double ResStart
        {
            get { return this.ResStart; }
            set { ResStart = value; }
        }

        public char AcctType
        {
            get { return this.acctType; }
            set { acctType = value; }
        }

        // Constructor
        public Reserve(string accountNam, int accountNum) : base(accountNam, accountNum)
        {

        }

        // Methods
        public override void Display()
        {
            Console.WriteLine("Reserve!");
        }
        public void CurrentBalance()
        {
            Console.WriteLine("Starting Reserve account balance: {0:C}", resStart);
        }
    }
}

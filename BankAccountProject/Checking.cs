using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Checking : Account
    {
        // Field 
        double chkStart;
        char acctType;


        // Properties
        public double ChkStart
        {
            get { return this.chkStart; }
            set { chkStart = value; }
        }
        
        public char AcctType
        {
            get { return this.acctType; }
            set { acctType = value; }
        }

        // Constructor
        public Checking(string accountNam, int accountNum) : base(accountNam, accountNum)
        {
            
        }

        // Methods
        public override void Display()
        {
            Console.WriteLine("Checking!");
        }

    }
}


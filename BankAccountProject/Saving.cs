﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Savings : Account
    {
        // Field 
        double savStart = 1000.00;
        char acctType;
        


        // Properties
        public double SavStart
        {
            get { return this.savStart; }
            set { savStart = value; }
        }

        public char AcctType
        {
            get { return this.acctType; }
            set { acctType = value; }
        }

        // Constructor
        public Savings(string accountNam, int accountNum) : base(accountNam, accountNum)
        {

        }

        // Methods
        public override void Display()
        {
            Console.WriteLine("Savings!");
        }
        public void CurrentBalance()
        {
            Console.WriteLine("Starting Savings account balance: {0:C}", savStart);
        }
    }
}

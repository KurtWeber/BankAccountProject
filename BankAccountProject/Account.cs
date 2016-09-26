using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Account
    {
        // Fields
        char accountType;

        // Properties
        public char AccountType
        {
            get { return this.accountType; }
            set { accountType = value; }
        }
        // Method
        public virtual void Display()
        {
            Console.WriteLine("Account Type: {0}, Starting Balance: {1:C}", AccountType);
        }
    }
}

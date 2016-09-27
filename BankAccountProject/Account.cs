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
        int accountNum;
        string userName;
        

        // Properties
        public int AccountNum
        {
            get { return this.accountNum; }
            set { accountNum = value; }
        }
        public string UserName
        {
            get { return this.userName; }
            set { userName = value; }
        }
        // Contructor
        public Account(string userName, int accountNum)
        {
            UserName = userName;
            AccountNum = accountNum;
        }

        // Method
        public virtual void Display() 
        {
            // Virtual to override in other accounts
        }
    }
}

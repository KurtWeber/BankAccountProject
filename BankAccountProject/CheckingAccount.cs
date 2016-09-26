using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class CheckingAccount : Account
    {
        // Fields
        double chkStartBal;
        
        // Properties
        public double ChkStartBal
        {
            get { return this.ChkStartBal;}
            set { chkStartBal = value; }
        }      

        // Constructors
        public CheckingAccount()
        {
            chkStartBal = 1000.00;
            AccountType = 'C';
        }
        
        // Methods
    }
}

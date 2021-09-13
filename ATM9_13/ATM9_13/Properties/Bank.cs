using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM9_13.Properties
{
    class Bank
    {
        public CreditAccount UserAccount { get; private set; }

        public Bank()
        {
            
            UserAccount = new CreditAccount();
        }
        
        
    }
}

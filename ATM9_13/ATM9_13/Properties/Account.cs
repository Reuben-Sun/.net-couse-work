using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM9_13.Properties
{
    class Account
    {
        public int id;

        protected virtual void ShowDetail()
        {
            Console.WriteLine(id);
        }
    }
}

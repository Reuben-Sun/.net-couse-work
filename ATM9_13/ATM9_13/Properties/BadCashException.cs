using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM9_13.Properties
{
    class BadCashException : Exception
    {
        public string error;
        private Exception innerException;

        public BadCashException() { }
        public BadCashException(string msg) : base(msg)
        {
            this.error = msg;
        }
        public BadCashException(string msg, Exception innerException) : base(msg, innerException)
        {
            this.innerException = innerException;
            error = msg;
        }
        public string GetError()
        {
            return error;
        }

    }
}

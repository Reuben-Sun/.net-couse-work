using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM9_13.Properties
{
    class CreditAccount : Account
    {
        public int Money { private set; get; }
        protected override void ShowDetail()
        {
            base.ShowDetail();
        }
        public CreditAccount()
        {
            Money = 10000;
        }

        public void SaveMoney(int num)
        {
            Money += num;
        }

        public bool WithdrawMoney(int num)
        {
            
           
            try
            {
                Random r = new Random();
                if(r.Next(0,100) < 30)
                {
                    throw new BadCashException("我的错误", new Exception("这是Exception的错误"));
                }
                else
                {
                    if (Money >= num)
                    {
                        Money -= num;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

            }
            catch (BadCashException e)
            {

                Console.WriteLine(e.InnerException.Message);
                return false;
            }
        }
    }
}

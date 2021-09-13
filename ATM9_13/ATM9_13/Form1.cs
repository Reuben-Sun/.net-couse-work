using ATM9_13.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM9_13
{

    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
            
        }
        Bank bank = new Bank();
        private void button2_Click(object sender, EventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            inputDialog.Show();
            inputDialog.textHander = (str) => { 
                if(int.Parse(str) >= 10000)
                {
                    MessageBox.Show("本次交易金额较大，请确认操作信息");
                }
                if (!bank.UserAccount.WithdrawMoney(int.Parse(str)))
                {
                    MessageBox.Show("取款失败");
                }
            };
        }

        private void saveMoney_Click(object sender, EventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            inputDialog.Show();
            inputDialog.textHander = (str) => { bank.UserAccount.SaveMoney(int.Parse(str)); };

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moneyText.Text = bank.UserAccount.Money.ToString();
        }

    }
}

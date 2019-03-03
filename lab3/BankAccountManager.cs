using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class BankAccountManager : Form
    {
        decimal balance = 0m, conversion = 1.3m;
        string store;
        public BankAccountManager()
        {
            InitializeComponent();
        }

        private void BankAccountManager_Load(object sender, EventArgs e)
        {
            radioButtonCAD.Checked = true;
            labelCurrencyBal.Text = "CAD";
            store = balance.ToString();
            labelBalanceOut.Text = balance.ToString("C");
        }

        private void GetDeposit(BankAccount account)
        {
            decimal amtd;
            if (decimal.TryParse(textBoxAmtD.Text, out amtd) && amtd >= 0)
            {
                if (radioButtonCAD.Checked == true)
                {
                    account.depositFunds(amtd);
                }
                if (radioButtonUS.Checked == true)
                {
                    account.depositFunds(amtd*conversion);
                }
            }
            else
            {
                MessageBox.Show("Invalid Deposit Amount!");
            }
            textBoxAmtD.Text = "";
        }

        private void GetWithdraw(BankAccount account)
        {
            decimal amtw;
            if (decimal.TryParse(textBoxAmtW.Text, out amtw) && amtw >= 0)
            {
                if (radioButtonCAD.Checked == true)
                {
                    account.withdrawFunds = amtw;
                    if(account.withdrawFunds < 0)
                    {
                        MessageBox.Show("Insufficient Balance!");
                    }
                }
                if (radioButtonUS.Checked == true)
                {
                    account.withdrawFunds = amtw * conversion;
                    if (account.withdrawFunds < 0)
                    {
                        MessageBox.Show("Insufficient Balance!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Withdrawal Amount!");
            }
            textBoxAmtW.Text="";
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            decimal initBal;
            if (decimal.TryParse(store, out initBal))
            {
                BankAccount myAccount = new BankAccount(initBal);
                GetDeposit(myAccount);
                store = myAccount.Balance.ToString();
                labelBalanceOut.Text= "$" + store;
            }
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            decimal initBal;
            if (decimal.TryParse(store, out initBal))
            {
                BankAccount myAccount = new BankAccount(initBal);
                GetWithdraw(myAccount);
                if (myAccount.withdrawFunds >= 0)
                {
                    store = myAccount.withdrawFunds.ToString();
                    labelBalanceOut.Text = "$" + store;
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

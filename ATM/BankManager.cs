using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ATM
{
    public partial class BankManager : Form
    {
        private Account[] ac = new Account[4];
        public Boolean data = false;

        public BankManager()
        {
            InitializeComponent();
            ac[0] = new Account(300, 1111, 111111, new Semaphore(1, 1));
            ac[1] = new Account(750, 2222, 222222, new Semaphore(1, 1));
            ac[2] = new Account(3000, 3333, 333333, new Semaphore(1, 1));
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            SemaRadio.Checked = true;
        }
        /*
         * Create new thread
         */
        private void btnThread_Click(object sender, EventArgs e)
        {
            
            log("New ATM created.");
            //creates two threads both running the same form
            Thread ATM1 = new Thread(new ThreadStart(showThreadedAtm));

            //starts both threads
            ATM1.Start();

        }

        private void showThreadedAtm()
        {
            //function to create the form and run them, this is called when the thread button is clicked
            // Passes in Buttons accounts 
            Form1 f1 = new Form1(this);
            f1.ac = ac;
            f1.dataRace = dataRace;
            f1.MutexRadio = MutexRadio;
            f1.SemaRadio = SemaRadio;
            Application.Run(f1);
        }
        public void log(String message)
        {
            this.txtLog.Invoke((MethodInvoker)delegate
            {txtLog.Text += message + "\n";
            });
        }


        private void txtLog_TextChanged(object sender, EventArgs e)
        {

        }

        /*
         * 
         * If datarace is checked display the options or not
         */
        private void dataRace_CheckedChanged(object sender, EventArgs e)
        {

            //Hides options
            if (dataRace.Checked == true)
            {
                DataFix.Hide();
                SemaRadio.Checked = false;
                MutexRadio.Checked = false;
                data = true;
                log("Data Race Enabled.");
            }
            //displays options
            else
            {
                DataFix.Show();
                data = false;
                SemaRadio.Checked = true;
                log("Data Race Disabled.");
            }
        }

        private void SemaRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (SemaRadio.Checked == true)
            {
                log("Semaphore Selected");
            }
        }

        private void MutexRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (MutexRadio.Checked == true)
            {
                log("Mutex Selected");
            }
        }
    }
    public class Account
    {
        //the attributes for the account
        private int balance;
        private int pin;
        private int accountNum;
        private Semaphore transaction;

        // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
        public Account(int balance, int pin, int accountNum, Semaphore transaction)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
            this.transaction = transaction;
        }

        //getter and setter functions for balance
        public int getBalance()
        {
            return balance;
        }
        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }
        public Semaphore GetSemaphore()
        {
            return transaction;
        }


        /*
         *   This funciton allows us to decrement the balance of an account
         *   it perfomes a simple check to ensure the balance is greater tha
         *   the amount being debeted
         *   
         *   reurns:
         *   true if the transactions if possible
         *   false if there are insufficent funds in the account
         */


        public Boolean decrementBalance(int amount)
        {
            int currentBalance = this.balance;
            if (this.balance >= amount)
            {
                currentBalance -= amount;
                Thread.Sleep(3000);
                this.balance = currentBalance;
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         * This funciton check the account pin against the argument passed to it
         *
         * returns:
         * true if they match
         * false if they do not
         */
        public Boolean checkPin(int pinEntered)
        {
            if (pinEntered == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getAccountNum()
        {
            return accountNum;
        }

    }
}

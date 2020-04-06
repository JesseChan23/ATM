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
    public partial class Form1 : Form
    {
        private static Mutex mutex = new Mutex();
        BankManager atmManager;
        Panel activePanel;

        /*
        * This function initilises the 3 accounts 
        * and instanciates the ATM class passing a referance to the account information
        * Changes the default panel to the number pad
        */
        
        public Form1(BankManager manager)
        {

            InitializeComponent();
            this.atmManager = manager;

            activePanel = numberPanel;
       
            allignText();

            //Button formatting

        }




        /*
         * Changes the panel depending on what is getting passed through
         * 
         * panelName type of panel getting passed
         */
        private void changePanel(Panel panelName)
        {

            activePanel.Visible = false;
            activePanel = panelName;
            activePanel.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        /*
         * Depending on the stage it's on it will limit the amount of numbers it can display
         * 
         */
        private void numberValidation(int number)
        {
            // Only displays 3 numbers for withdraw stage
            if (DisplayInput.Text.Length < 3 && withdraw == true)
            {
                DisplayInput.Text += number;
            }
            // Only displays 4 numbers for Pin stage
            else if (DisplayInput.Text.Length < 4 && inputPin == true)
            {
                DisplayInput.Text += number;
            }

            // Only displays 3 numbers for account stage
            else if (DisplayInput.Text.Length < 6 && account == true)
            {
                DisplayInput.Text += number;
            }

        }
        /**
         * Button 0-9 Inputs
         * 
         */
        private void button1_Click(object sender, EventArgs e)
        {

            numberValidation(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numberValidation(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numberValidation(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numberValidation(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numberValidation(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numberValidation(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numberValidation(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numberValidation(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numberValidation(9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            numberValidation(0);
        }



        // Global variables for the main program
        private Account activeAccount = null;
        Boolean inputPin = false;
        int check = 3;
        Boolean withdraw = false;
        Boolean account = true;
        private void EnterButton_Click(object sender, EventArgs e)
        {
            // Checks if there is something in box when enter is pressed
            if (DisplayInput.Text.Length > 0)
            {
                // Withdraw stage
                if (withdraw == true)
                {
                    int input = Convert.ToInt32(DisplayInput.Text);
                    // Only allows certain input and if it's divisble by 5
                    if (input == 0 || input > 400 || input % 5 != 0)
                    {
                        MessageBox.Show("Please enter a valid withdrawal amount (must be divisible by 5)");
                        DisplayInput.Text = "";
                    }
                    else
                    {
                        withdrawInstructions(input);
                        changePanel(panelWithdraw);
                        DisplayInstruction.Text = "Please select a withdraw option";
                        allignText();
                        DisplayInput.Text = "";
                    }

                }
                //Account number stage
                else if (inputPin == false)
                {

                    int input = Convert.ToInt32(DisplayInput.Text);

                    DisplayInput.Text = "";
                    // Tries to find account
                    Boolean found = false;
                    for (int i = 0; i < this.ac.Length - 1; i++)
                    {
                        
                        if (ac[i].getAccountNum() == input)
                        {
                            activeAccount = ac[i];
                           // atmManager.log("Account successfully logged in.");
                            DisplayInstruction.Text = "Please enter your pin";
                            allignText();
                            inputPin = true;
                            found = true;
                            account = false;
                            
                            
                        }
                    }
                    if (found == false)
                    {
                        MessageBox.Show("Please write a valid account number");
                        
                    }


                }
                else
                {
                    // Pin input stage 
                    if (check >= 0)
                    {
                        int input = Convert.ToInt32(DisplayInput.Text);
                        DisplayInput.Text = "";

                        // If pin is correct 
                        if (activeAccount.checkPin(input) == true)
                        {
                            //Display the options and change panel
                            atmManager.log("Account number " + activeAccount.getAccountNum() + " successfully logged in.");
                            inputPin = false;
                            changePanel(accountPanel);
                            DisplayInstruction.Text = "Select an option you would like to do";
                            allignText();
                            check = 3;
                        }
                        else
                        {
                            // if pin is wrong
                            attempts();
                        }
                    }
                }
            }
            else
            {
                // if the user presses enter when it's blank dispaly certain error message
                if (inputPin == true)
                {
                    attempts();
                }
                else
                {
                    if (withdraw == true)
                    {
                        MessageBox.Show("Please Type a valid withdrawal amount");
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid account number");
                    }
                }
            }
        }
        /*
         * Keeps track on how many times the user tries to how enter the pin
         */

        public Account[] ac { get; set; }
        public CheckBox dataRace { get; set; }
        public RadioButton SemaRadio { get; set; }
        public RadioButton MutexRadio { get; set; }
        private void attempts()
        {
            check--;
            // if no attempts left
            if (check == 0)
            {
                account = true;
                MessageBox.Show("Too many attempts you have been kicked out");
                inputPin = false;
                DisplayInstruction.Text = "Please enter your account number";
                allignText();
                check = 3;
                DisplayInput.Text = "";
            }
            // displays how many attempts left
            else
            {
                MessageBox.Show("You have " + check + " attemps remaining");
            }

        }

        /*
         * realigns text and makes it look centred
         */
        private void allignText()
        {

            DisplayInstruction.SelectAll();
            DisplayInstruction.SelectionAlignment = HorizontalAlignment.Center;
            DisplayInput.SelectAll();
            DisplayInput.SelectionAlignment = HorizontalAlignment.Center;
            Title.SelectAll();
            Title.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayInput.Text = "";
        }

        /* Balance button
         * Checks the balance of the account
        */

        private void button10_Click(object sender, EventArgs e)
        {
            atmManager.log("Account balance is: £" + activeAccount.getBalance());
            DisplayInstruction.Text = "Your Current balance is £" + activeAccount.getBalance();
            allignText();
            activeAccount.getBalance();
        }

        /*
         * Changes to the withdraw panel
         */
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            DisplayInstruction.Text = "Please select a withdraw option";
            changePanel(panelWithdraw);
            allignText();
            
        }
        /*
         *returns to the account number stage when you press exit in the withdraw stage
         */
        private void exitButton_Click(object sender, EventArgs e)
        {
            atmManager.log("Account logged out.");
            changePanel(numberPanel);
            DisplayInstruction.Text = "Please enter your account number";
            allignText();
            account = true;
        }

        /*
         * When users presses an amount to withdraw 
         * Passes in the amount getting withdrawed
         */
        private void withdrawInstructions(int amount)
        {
           // if statement needed for the semaphore or Mutex
            int balance = activeAccount.getBalance();
            if (dataRace.Checked == false && SemaRadio.Checked == true)
            {
                Console.WriteLine("Sema");
                activeAccount.GetSemaphore().WaitOne();
            }
            else if(dataRace.Checked == false && MutexRadio.Checked == true)
            {
                Console.WriteLine("mutex");
                mutex.WaitOne();
            }
            
            if (activeAccount.decrementBalance(amount))
            {
                atmManager.log("Successfully withdrawn £" + amount + ".");
                MessageBox.Show("Thank you for withdrawing £" + amount + " \nPlease collect your money");
                withdraw = true;
                DisplayInput.Text = "";
            }
            else
            {
                atmManager.log("Insufficient balance to withdraw.");
                MessageBox.Show("Insufficent balance withdrawal thing please select another option");
            }

            if (dataRace.Checked == false && SemaRadio.Checked == true)
            {
                Console.WriteLine("Sema");
                activeAccount.GetSemaphore().Release();
            }

            else if (dataRace.Checked == false && MutexRadio.Checked == true)
            {
                Console.WriteLine("mutex");
                mutex.ReleaseMutex();
            }

        }
        /* 
         * Withdraws £10
         */
        private void Withdraw10_Click(object sender, EventArgs e)
        {

            withdrawInstructions(10);

        }
        /* 
         * Goes back to account
         */
        private void BackButton_Click(object sender, EventArgs e)
        {

            changePanel(accountPanel);
            DisplayInstruction.Text = "Select an option you would like to do";
            allignText();
            withdraw = false;
        }
        /* 
         * Withdraws £25
         */
        private void Withdraw25_Click(object sender, EventArgs e)
        {
            withdrawInstructions(25);
        }

        /* 
        * Withdraws £25
        */
        private void Withdraw50_Click(object sender, EventArgs e)
        {
            withdrawInstructions(50);
        }

        /* 
        * Withdraws a custom amount of money and displays number pad
        * Note Only deposits in 5 because of notes
        */
        private void WithdrawCustom_Click(object sender, EventArgs e)
        {
            changePanel(numberPanel);
            DisplayInstruction.Text = "Please enter your custom withdrawal amount";
            allignText();
            withdraw = true;
        }

        /* 
        * Gives user card back when inputs the correct pin and account number
        */
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DisplayInput.Text = "";
            // if it's in withdraw stage
            if (withdraw == true)
            {
                changePanel(numberPanel);
                withdraw = false;
                account = true;
                DisplayInstruction.Text = "Please enter your account number";
                MessageBox.Show("Remember to pick up your card");
                allignText();
            }
        }
    }

 
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BankingApplicationIteration2
{
    public partial class ManageAccountsForm : ParentForm
    {

        Customer a = new Customer();
        Controller control = new Controller();
        Account ac = new Account();

        double overallBal = 0;


        public ManageAccountsForm()
        {

            InitializeComponent();
            control.ReadTextFileAccounts();
            control.ReadTextFileCustomers();
            DisplayAccounts();
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttMenu_Click(object sender, EventArgs e)
        {
            MainMenuForm mm = new MainMenuForm();

            this.Hide();

            mm.Show();
        }

        private void buttAddAcc_Click(object sender, EventArgs e)
        {
            AddNewAccount na = new AddNewAccount();

            this.Hide();

            na.Show();
        }

        public void DisplayAccounts()
        {
            

            //clear list box
            listDispAcc.Items.Clear();

            foreach (Account h in control.AllAccounts)
            {
                listDispAcc.Items.Add(h);
            }

            listDispAcc.SelectedIndex = 0;

        }

        private void buttDisplayAcc_Click(object sender, EventArgs e)
        {
            //shows data of selected acc in display account box

            try
            {
                Account accnt = (Account)listDispAcc.SelectedItem;
                int accountOwner = accnt.ReturnAccountHolderIDNum();

                string customerName = "";

                foreach (Customer c in control.AllCustomers)
                {
                    if (c.AccountHolderID == accountOwner)
                    {
                        customerName= c.AccountHolderName;
                    }
                }

                labDispayAcc.Text = accnt.AllInfo() + " " + "Account Owner: " + customerName;
            }
            catch
            {
                throw new Exception();
            }

        }

        private void buttDeleteAcc_Click(object sender, EventArgs e)
        {
            //to deleted selected account from bin file and list

            Account accnt = (Account)listDispAcc.SelectedItem;
            
            try
            {
                int toDeleteID = accnt.ReturnAccountID();
                int accHoldID = accnt.ReturnAccountHolderIDNum();
                double deletedBal = accnt.ReturnBal();
                string accType = accnt.ReturnAccType();
                double odraftAmount = accnt.OverdraftReturnAmount();
                string toDelete = toDeleteID + "," + accHoldID + "," + deletedBal + "," + accType + "," + odraftAmount;

                control.DeleteAccount(toDelete);

                //refresh list
                RefreshAccounts();

            }
            catch
            {
                throw new Exception();
            }

            
        }

        public void RefreshAccounts()
        {

            //clears current list of all accounts
            control.AllAccounts.Clear();

            //clears listbox displau
            listDispAcc.Items.Clear();

            //reads updated txt file
            control.ReadTextFileAccounts();

            //readds all new items to the listbox display
            foreach (Account h in control.AllAccounts)
            {
                listDispAcc.Items.Add(h);
            }

        }

        private void listDispAcc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            //selected item from liztbox
            Account accnt = (Account)listDispAcc.SelectedItem;
            //finds bal of selected item in listbox
            double accBal = accnt.ReturnBal();
            //returns the account type for selected customer
            string accType = accnt.ReturnAccType();
            //returns selected users overdraft amount
            double odraftAmount = accnt.OverdraftReturnAmount();

            int userID = accnt.ReturnAccountID();
            int accHoldID = accnt.ReturnAccountHolderIDNum();
            double deletedBal = accnt.ReturnBal();
            string toDelete = userID + "," + accHoldID + "," + deletedBal + "," + accType + "," + odraftAmount;

            //finds customer details and checks if they are staff
            int accountOwner = accnt.ReturnAccountHolderIDNum();
            bool customerStaff = false;
            foreach (Customer c in control.AllCustomers)
            {
                if (c.AccountHolderID == accountOwner)
                {
                    customerStaff = c.IsStaff;
                }
            }

            if (string.IsNullOrWhiteSpace(txtDollaValue.Text))
            {
                //error popup saying please enter value
                MessageBox.Show("Please input value into text box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

             //takes value from box and parse to double
             double userVal = double.Parse(txtDollaValue.Text);

                //if the overdraft amount is 0
                if (odraftAmount == 0)
                {
                    //if the value entered to withdraw is more than the avaliable balance
                    if (userVal > accBal)
                    {
                        //if the customer is a memeber of staff
                        if (customerStaff == true)
                        {
                            MessageBox.Show("You do not have enough to complete this transaction, A failed transaction fee has been withdrawn from your account.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            double failedbal = accBal - 5;

                            //removes old account with outdated balance
                            control.DeleteAccount(toDelete);

                            //adds newly updated account wit new balance
                            //pass filepath and filename
                            StreamWriter sw = new StreamWriter("../../AllAccounts.txt", true);

                            //and new line to file
                            sw.WriteLine(userID + "," + accHoldID + "," + failedbal + "," + accType + "," + odraftAmount);

                            //clears the list 
                            listDispAcc.Items.Clear();

                            //close file
                            sw.Close();

                            //clears the list (THIS WORKS)
                            listDispAcc.Items.Clear();

                            control.AllAccounts.Clear();

                            control.ReadTextFileAccounts();
                            control.ReadTextFileCustomers();

                            //refreshes list disply
                            RefreshAccounts();
                        }
                        //if the customer is not a staff member they get charged the full $10 fee
                        else
                        {
                            MessageBox.Show("You do not have enough to complete this transaction, A failed transaction fee has been withdrawn from your account.",
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            double failedbal = accBal - 10;

                            //removes old account with outdated balance
                            control.DeleteAccount(toDelete);

                            //adds newly updated account wit new balance
                            //pass filepath and filename
                            StreamWriter sw = new StreamWriter("../../AllAccounts.txt", true);

                            //and new line to file
                            sw.WriteLine(userID + "," + accHoldID + "," + failedbal + "," + accType + "," + odraftAmount);

                            //clears the list 
                            listDispAcc.Items.Clear();

                            //close file
                            sw.Close();

                            //clears the list (THIS WORKS)
                            listDispAcc.Items.Clear();

                            control.AllAccounts.Clear();

                            control.ReadTextFileAccounts();
                            control.ReadTextFileCustomers();

                            //refreshes list disply
                            RefreshAccounts();
                        }
                    }
                    //if the user has the correct amount of money stored they can withdraw (aka an actual transaction)
                    else
                    {

                        //Account account = (Account)listBoxWithAccounts.SelectedItem;
                        //double oldbal = account.ReturnBal();
                        double trueTransaction = accBal - userVal;

                        //removes old account with outdated balance
                        control.DeleteAccount(toDelete);

                        //adds newly updated account wit new balance
                        //pass filepath and filename
                        StreamWriter sw = new StreamWriter("../../AllAccounts.txt", true);

                        //and new line to file
                        sw.WriteLine(userID + "," + accHoldID + "," + trueTransaction + "," + accType + "," + odraftAmount);

                        //clears the list 
                        listDispAcc.Items.Clear();

                        //close file
                        sw.Close();

                        //clears the list (THIS WORKS)
                        listDispAcc.Items.Clear();

                        control.AllAccounts.Clear();

                        control.ReadTextFileAccounts();
                        control.ReadTextFileCustomers();

                        //refreshes list disply
                        RefreshAccounts();
                    }
                }//the overdraft amount is not 0 (meaning they can overdraft that amount)
                else
                {
                    double balAndODraft = accBal + odraftAmount;

                    //if the value entered to withdraw is more than the avaliable balance and the overdraft
                    if (userVal > balAndODraft)
                    {
                        //if they are a staff member
                        if (customerStaff == true)
                        {
                            MessageBox.Show("You do not have enough to complete this transaction, A failed transaction fee has been withdrawn from your account.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            double failedbal = accBal - 5;

                            //removes old account with outdated balance
                            control.DeleteAccount(toDelete);

                            //adds newly updated account wit new balance
                            //pass filepath and filename
                            StreamWriter sw = new StreamWriter("../../AllAccounts.txt", true);

                            //and new line to file
                            sw.WriteLine(userID + "," + accHoldID + "," + failedbal + "," + accType + "," + odraftAmount);

                            //clears the list 
                            listDispAcc.Items.Clear();

                            //close file
                            sw.Close();

                            //clears the list (THIS WORKS)
                            listDispAcc.Items.Clear();

                            control.AllAccounts.Clear();

                            control.ReadTextFileAccounts();
                            control.ReadTextFileCustomers();

                            //refreshes list disply
                            RefreshAccounts();
                        }
                        //if they are not a staff member
                        else
                        {
                            MessageBox.Show("You do not have enough to complete this transaction, A failed transaction fee has been withdrawn from your account.",
                                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            double failedbal = accBal - 10;

                            //removes old account with outdated balance
                            control.DeleteAccount(toDelete);

                            //adds newly updated account wit new balance
                            //pass filepath and filename
                            StreamWriter sw = new StreamWriter("../../AllAccounts.txt", true);

                            //and new line to file
                            sw.WriteLine(userID + "," + accHoldID + "," + failedbal + "," + accType + "," + odraftAmount);

                            //clears the list 
                            listDispAcc.Items.Clear();

                            //close file
                            sw.Close();

                            //clears the list (THIS WORKS)
                            listDispAcc.Items.Clear();

                            control.AllAccounts.Clear();

                            control.ReadTextFileAccounts();
                            control.ReadTextFileCustomers();

                            //refreshes list disply
                            RefreshAccounts();
                        }
                    }
                    //if the user has the correct amount of money stored they can withdraw (aka an actual transaction)
                    else
                    {

                        double trueTransaction = balAndODraft - userVal;

                        //removes old account with outdated balance
                        control.DeleteAccount(toDelete);

                        //adds newly updated account wit new balance
                        //pass filepath and filename
                        StreamWriter sw = new StreamWriter("../../AllAccounts.txt", true);

                        //and new line to file
                        sw.WriteLine(userID + "," + accHoldID + "," + trueTransaction + "," + accType + "," + odraftAmount);

                        //clears the list 
                        listDispAcc.Items.Clear();

                        //close file
                        sw.Close();

                        //clears the list (THIS WORKS)
                        listDispAcc.Items.Clear();

                        control.AllAccounts.Clear();

                        control.ReadTextFileAccounts();
                        control.ReadTextFileCustomers();

                        //refreshes list disply
                        RefreshAccounts();
                    }

                }
                txtDollaValue.Clear();
            }
        }

        private void btnIntrest_Click(object sender, EventArgs e)
        {
            Account accnt = (Account)listDispAcc.SelectedItem;
            //returns balance of selected account
            double balance = accnt.ReturnBal();
            //returns account type of selected account 
            string type = accnt.ReturnAccType();
            //balance to return after calculations
            double calc2 = 0;

            if (type == "Omni")
            {
                if (balance > 1000)
                {
                    double calc1 = (balance * 4 * 1) / 100;
                    calc2 = balance + calc1;
                    //newBalanceOutput.Text = calc2.ToString();
                }
                else
                {
                    calc2 = balance;
                }
            }
            else if (type == "Invest")
            {
                double calc1 = (balance * 8 * 1) / 100;
                calc2 = balance + calc1;
                //newBalanceOutput.Text = calc2.ToString();
            }
            else
            {
                //double calc1 = (balance * 0 * 1) / 100;
                calc2 = balance;
                //newBalanceOutput.Text = calc2.ToString();
            }

            int userID = accnt.ReturnAccountID();
            int accHoldID = accnt.ReturnAccountHolderIDNum();
            double deletedBal = accnt.ReturnBal();
            string accType = accnt.ReturnAccType();
            double odraftAmount = accnt.OverdraftReturnAmount();
            string toDelete = userID + "," + accHoldID + "," + deletedBal + "," + accType + "," + odraftAmount;

            //removes old account with outdated balance
            control.DeleteAccount(toDelete);

            //adds newly updated account wit new balance
            //pass filepath and filename
            StreamWriter sw = new StreamWriter("../../AllAccounts.txt", true);

            //and new line to file
            sw.WriteLine(userID + "," + accHoldID + "," + calc2 + "," + accType + "," + odraftAmount);

            //clears the list 
            listDispAcc.Items.Clear();

            //close file
            sw.Close();

            //clears the list (THIS WORKS)
            listDispAcc.Items.Clear();

            control.AllAccounts.Clear();

            control.ReadTextFileAccounts();
            control.ReadTextFileCustomers();

            //refreshes list disply
            RefreshAccounts();

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //takes the value form the txt box and deposits into selected bank account
            if (string.IsNullOrWhiteSpace(txtDollaValue.Text))
            {
                //error popup saying please enter value
                MessageBox.Show("Please input value into text box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                double userVal = double.Parse(txtDollaValue.Text);

                Account accnt = (Account)listDispAcc.SelectedItem;
                //finds bal of selected item in listbox
                double accBal = accnt.ReturnBal();
                //takes entered in box and adds to balance in list
                double newbal = accBal + userVal;
                //updates value in list with newly added balance

                int userID = accnt.ReturnAccountID();
                int accHoldID = accnt.ReturnAccountHolderIDNum();
                double deletedBal = accnt.ReturnBal();
                string accType = accnt.ReturnAccType();
                double odraftAmount = accnt.OverdraftReturnAmount();
                string toDelete = userID + "," + accHoldID + "," + deletedBal + "," + accType + "," + odraftAmount;

                //removes old account with outdated balance
                control.DeleteAccount(toDelete);

                //adds newly updated account wit new balance
                //pass filepath and filename
                StreamWriter sw = new StreamWriter("../../AllAccounts.txt", true);

                //and new line to file
                sw.WriteLine(userID + ","  + accHoldID + "," + newbal + "," + accType + "," + odraftAmount);

                //clears the list 
                listDispAcc.Items.Clear();

                //close file
                sw.Close();

                //clears the list (THIS WORKS)
                listDispAcc.Items.Clear();

                control.AllAccounts.Clear();

                control.ReadTextFileAccounts();
                control.ReadTextFileCustomers();

                //refreshes list disply
                RefreshAccounts();

                
            }

            txtDollaValue.Clear();

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            //from account details
            int userFID = 0;
            int userFAID = 0;
            double balFrom = 0;
            string userFT = "";
            double uFO = 0;

            //to account details
            int userTID = 0;
            int userTAID = 0;
            double balTo = 0;
            string userTT = "";
            double uTO = 0;

            //txtbox for from account
            int fromAccount = int.Parse(txxFromAccount.Text);
            //txtbox for to account
            int toAccount = int.Parse(txtToAccount.Text);
            //txtbox dollar value
            double dollarAmount = double.Parse(txtDollaValue.Text);

            //get balance and details of account money is being taken from
            foreach (Account c in control.AllAccounts)
            {
                if (c.AccountID == fromAccount)
                {
                    userFID = c.accountID;
                    userFAID = c.accountHolderID;
                    balFrom = c.accountBalance;
                    userFT = c.accountType;
                    uFO = c.overdraftAmount;
                    
                }

            }

            //get balance and details from account money is being added to
            foreach (Account c in control.AllAccounts)
            {
                if (c.AccountID == toAccount)
                {
                    userTID = c.accountID;
                    userTAID = c.accountHolderID;
                    balTo = c.accountBalance;
                    userTT = c.accountType;
                    uTO = c.overdraftAmount;

                }

            }
            
           
            //updated balances from tansactions
            double updadtedBalFrom = balFrom - dollarAmount;
            double updadtedBalTo = balTo + dollarAmount;

            if (dollarAmount <= balFrom)
            {

                //adds newly updated account wit new balance
                //pass filepath and filename
                StreamWriter sw = new StreamWriter("../../AllAccounts.txt", true);

                //and new line to file
                sw.WriteLine(userFID + "," + userFAID + "," + updadtedBalFrom + "," + userFT + "," + uFO);
                sw.WriteLine(userTID + "," + userTAID + "," + updadtedBalTo + "," + userTT + "," + uTO);

                sw.Close();

                //string of old data to delete
                string toDeleteF = userFID + "," + userFAID + "," + balFrom + "," + userFT + "," + uFO;
                string toDeleteT = userTID + "," + userTAID + "," + balTo + "," + userTT + "," + uTO;

                //removes old account with outdated balance
                control.DeleteAccount(toDeleteT);
                control.DeleteAccount(toDeleteF);

                //clears the list 
                listDispAcc.Items.Clear();

                //close file
                sw.Close();

                //clears the list 
                listDispAcc.Items.Clear();

                control.AllAccounts.Clear();

                control.ReadTextFileAccounts();
                control.ReadTextFileCustomers();

                //refreshes list disply
                RefreshAccounts();


            }
            else if (dollarAmount > balFrom)
            {
                //do not transfer the money 
                MessageBox.Show("You do not have enough funds to complete this transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //blank or white space and error to throw
                //error popup saying please enter value
                MessageBox.Show("Please input value into the correct text boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

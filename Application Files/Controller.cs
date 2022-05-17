using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BankingApplicationIteration2
{
    /// <summary>
    /// controller class
    /// all the code that interacts with the forms
    /// </summary>
    public class Controller
    {
        
        /// <summary>
        /// creation of the lists needed to store and parse the data to the binary files
        /// </summary>
        public List<Customer> AllCustomers = new List<Customer>();
      
        public List<Account> AllAccounts = new List<Account>();

        /// <summary>
        /// code used to create a new customer for the application as long as the parameters are met
        /// </summary>
        /// <param name="accID">specific id assigned to the customer</param>
        /// <param name="name">customers first and last name</param>
        /// <param name="email">contact details</param>
        /// <param name="isStaff"> is the customer a member of staff</param>
        /// <param name="discountPercentage">if staff and what is their discount percentage(standard is 50 off fees)</param>
        public void CreateCustomer(int accID, string name, string email, bool isStaff, int discountPercentage)
        {
            // creates new customer to add to the list and stored data location
            try
            {
                AllCustomers.Add(new Customer(accID, name, email, isStaff, discountPercentage));
            }
            catch
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>
        /// code used to create a new account for the application as long as the parameters are met
        /// </summary>
        /// <param name="accountID"></param>
        /// <param name="accountHolderID"></param>
        /// <param name="accountBalance"></param>
        /// <param name="accountType"></param>
        /// <param name="overdraftAmount"></param>
        public void CreateAccount(int accountID, int accountHolderID, double accountBalance, string accountType, double overdraftAmount)
        {
            //creates new account for customers

            try
            {
                AllAccounts.Add(new Account(accountID, accountHolderID, accountBalance, accountType, overdraftAmount));
            }
            catch
            {
                throw new NullReferenceException();
            }

        }

        /// <summary>
        /// used to find the customers details so long as their ID num is parsed
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Customer FindCustomerByID(int id)
        {
            // allows finding customer by ID number
            foreach (Customer c in AllCustomers)
            {
                if (c.AccountHolderID == id) { return c; }
            }

            return null;
        }
       
        /// <summary>
        /// used to find the account details so long as the ID number is parsed
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Account FindAccountByID(int id)
        {
            //allows finding account via account number
            foreach (Account a in AllAccounts)
            {
                if (a.AccountID == id) { return a; } 
            }

            return null;
        }
        /// <summary>
        /// updates the customers details where needed
        /// </summary>
        /// <param name="accID"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="isStaff"></param>
        /// <param name="discount"></param>
        public void UpdateCustomer(int accID, string name, string email, bool isStaff, int discount)
        {
            //updates the customer data when applicable
            foreach (Customer a in AllCustomers)
            {
                if (a.accountHolderID == accID)
                {
                    AllCustomers.RemoveAll(x => x.accountHolderID == accID);
                    AllCustomers.Add(new Customer(accID, name, email, isStaff, discount));
                }
            }


        }
        /// <summary>
        /// allows for the update of account information
        /// </summary>
        /// <param name="accountID"></param>
        /// <param name="accountHolderID"></param>
        /// <param name="accountBalance"></param>
        /// <param name="accountType"></param>
        /// <param name="overdraftAmount"></param>
        public void UpdateAccount(int accountID, int accountHolderID, double accountBalance, string accountType, double overdraftAmount)
        {
            //updates the selected account when applicable

            foreach (Account a in AllAccounts)
            {
                if(a.AccountID == accountID)
                {
                    AllAccounts.RemoveAll(x => x.AccountID == accountID);
                    AllAccounts.Add(new Account(accountID, accountHolderID, accountBalance, accountType, overdraftAmount));
                }
            }
        }
        
        /// <summary>
        /// removes a customer where needed by deleting from the binary file
        /// </summary>
        /// <param name="deleteLine"></param>
        public void DeleteCustomer(string deleteLine)
        {
            //removes unneeded customer from list and from data source

            /*AllCustomers.RemoveAll(x => x.accountHolderID == accID);*/

            string line = null;

            string originalFile = "../../AllCustomers.txt";
            string fileToReplace = "../../Coutput.txt";
            string backupOfFileToReplace = "../../Coutput.txt.bac";

            using (StreamReader reader = new StreamReader(originalFile))
            {
                using (StreamWriter writer = new StreamWriter(fileToReplace))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(line, deleteLine) == 0)
                            continue;

                        writer.WriteLine(line);

                    }
                }

            }

            File.Replace(fileToReplace, originalFile, backupOfFileToReplace, false);
            //File.Move(fileToReplace, originalFile);
        }

        /// <summary>
        /// removes account details for the binary file
        /// </summary>
        /// <param name="deleteLine"></param>
        public void DeleteAccount(string deleteLine)
        {
            //removes unneeded accounts from the list and txt file

            string line = null;

            string originalFile = "../../AllAccounts.txt";
            string fileToReplace = "../../Aoutput.txt";
            string backupOfFileToReplace = "../../Aoutput.txt.bac";

            using (StreamReader reader = new StreamReader(originalFile))
            {
                using (StreamWriter writer = new StreamWriter(fileToReplace))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(line, deleteLine) == 0)
                            continue;

                        writer.WriteLine(line);

                    }
                }

            }

            File.Replace(fileToReplace, originalFile, backupOfFileToReplace, false);
            //File.Move(fileToReplace, originalFile);
        }

        /// <summary>
        /// reads the data currently stored on the customer file
        /// </summary>
        public void ReadTextFileCustomers()
        {
            AllCustomers.Clear();

            string[] strArray;

            //opens the txt file
            var myfile = new StreamReader("../../AllCustomers.txt");


            while (!myfile.EndOfStream)
            {
                //reads line and splits into substrings
                strArray = myfile.ReadLine().Split(',');
                //calls control and adds to list
                CreateCustomer(Convert.ToInt32(strArray[0]), strArray[1], strArray[2], Convert.ToBoolean(strArray[3]), Convert.ToInt32(strArray[4]));
            }

            myfile.Close();
        }

        /// <summary>
        /// reads the accounts file and parses to list
        /// </summary>
        public void ReadTextFileAccounts()
        {
            AllCustomers.Clear();

            string[] strArray;

            //opens the txt file
            var myfile = new StreamReader("../../AllAccounts.txt");


            while (!myfile.EndOfStream)
            {
                //reads line and splits into substrings
                strArray = myfile.ReadLine().Split(',');
                //calls control and adds to list
                CreateAccount(Convert.ToInt32(strArray[0]), Convert.ToInt32(strArray[1]), Convert.ToDouble(strArray[2]), strArray[3], Convert.ToDouble(strArray[4]));
            }

            myfile.Close();
        }


    }
}


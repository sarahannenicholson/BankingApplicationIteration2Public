using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BankingApplicationIteration2
{
    public partial class ManageCustomerForm : ParentForm
    {

        Customer a = new Customer();
        Controller control = new Controller();
        Account ac = new Account();

        public static string editCusID;

        public ManageCustomerForm()
        {
            InitializeComponent();
            control.ReadTextFileCustomers();
            DisplayCustomers();
        }



        private void buttMenu_Click(object sender, EventArgs e)
        {
            //returns to the first menu form
            MainMenuForm frmCust = new MainMenuForm();

            this.Hide();

            frmCust.Show();
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            //closes the application
            this.Close();
        }

        private void buttAddCust_Click(object sender, EventArgs e)
        {
            //moves to the add customer form
            AddCustomerForm addcust = new AddCustomerForm();

            this.Hide();

            addcust.Show();

        }


        /*private void ReadTextFile()
        {
            control.AllCustomers.Clear();

            string[] strArray;

            //opens the txt file
            var myfile = new StreamReader("../../AllCustomers.txt");


            while (!myfile.EndOfStream)
            {
                //reads line and splits into substrings
                strArray = myfile.ReadLine().Split(',');
                //calls control and adds to list
                control.CreateCustomer(Convert.ToInt32(strArray[0]), strArray[1], strArray[2], Convert.ToBoolean(strArray[3]), Convert.ToInt32(strArray[4]));
            }

            myfile.Close();
        }*/

        public void DisplayCustomers()
        {


            //clears the listbox
            listDispCust.Items.Clear();


            //add item to listbox
            foreach (Customer h in control.AllCustomers)
            {
                listDispCust.Items.Add(h);
            }

            listDispCust.SelectedIndex = 0;

        }

        private void buttDisplayCust_Click(object sender, EventArgs e)
        {
            //shows data in lable of the account highlighted in listbox

            try
            {
                Customer accnt = (Customer)listDispCust.SelectedItem;
                labCustOutput.Text = accnt.Info();
            }
            catch
            {
                throw new Exception();
            }


        }

        private void buttEditCust_Click(object sender, EventArgs e)
        {
            Customer accnt = (Customer)listDispCust.SelectedItem;
            int editCusID = accnt.HolderID();



            try
            {
                

                int toDeleteID = accnt.HolderID();
                string toDeleteName = accnt.ToString();
                string toDeleteEmail = accnt.HolderContact();
                bool toDeleStaff = accnt.IsCusStaff();
                int discPercent = accnt.DiscPercentStaff();
                string toDelete = toDeleteID + "," + toDeleteName + "," + toDeleteEmail + "," + toDeleStaff + "," + discPercent;

                control.DeleteCustomer(toDelete);

                listDispCust.Items.Clear();

                control.ReadTextFileCustomers();
                //to refresh the list after deleting customer
                RefreshCustomers();

            }
            catch
            {
                throw new Exception();
            }

            //moves to the manage customer form
            EditCustomerForm editcus = new EditCustomerForm();

            this.Hide();

            editcus.Show();

        }

        private void buttDeleteCust_Click(object sender, EventArgs e)
        {

            try
            {
                Customer accnt = (Customer)listDispCust.SelectedItem;

                int toDeleteID = accnt.HolderID();
                string toDeleteName = accnt.ToString();
                string toDeleteEmail = accnt.HolderContact();
                bool toDeleStaff = accnt.IsCusStaff();
                int discPercent = accnt.DiscPercentStaff();
                string toDelete = toDeleteID + "," + toDeleteName + "," + toDeleteEmail + "," + toDeleStaff + "," + discPercent;

                control.DeleteCustomer(toDelete);

                listDispCust.Items.Clear();

                //to refresh the list after deleting customer
                RefreshCustomers();
            }
            catch
            {
                throw new Exception();
            }
        }

        public void RefreshCustomers()
        {
            //clears list of all customers
            control.AllCustomers.Clear();

            //clears the listbox display
            listDispCust.Items.Clear();

            //reads updated txtfile
            control.ReadTextFileCustomers();

            //add item to listbox
            foreach (Customer h in control.AllCustomers)
            {
                listDispCust.Items.Add(h);
            }

        }

        private void btnEditCustAcc_Click(object sender, EventArgs e)
        {
            ManageAccountsForm mna = new ManageAccountsForm();

            this.Hide();

            mna.Show();

        }
    }
}

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
    public partial class AddCustomerForm : ParentForm
    {

        Customer a = new Customer();
        Controller control = new Controller();
        ManageCustomerForm m = new ManageCustomerForm();

        public AddCustomerForm()
        {
            InitializeComponent();
            

        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageCustomerForm frmA = new ManageCustomerForm();

            this.Hide();

            frmA.Show();


        }

        private void buttSave_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrWhiteSpace(txtIDNum.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                throw new Exception();
            }
            else
            {
                bool staff;
                int dPercent = 0;
                bool isChecked = radioYesStaff.Checked;

                if (isChecked)
                {
                    staff = true;
                    dPercent = 50;
                }
                else
                {
                    staff = false;
                    dPercent = 0;
                }

                //iterate through list of customers to find highest value ID#
                //and +1
                
                
                

                int newID = int.Parse(txtIDNum.Text);
                string fName = txtFirstName.Text;
                string lName = txtLastName.Text;
                string aName = fName + " " + lName;
                string email = txtEmailAdd.Text;

                
                //pass filepath and filename 
                StreamWriter sw = new StreamWriter("../../AllCustomers.txt", true);

                //add newly created user as a new line
                sw.WriteLine(newID + "," + " " + fName + " " + lName + "," + email + "," + staff + "," + dPercent);

                //close file
                sw.Close(); 

                control.CreateCustomer(newID, aName, email, staff, dPercent);

                //clear all txt boxes
                txtFirstName.Clear();
                txtIDNum.Clear();
                txtLastName.Clear();
                txtEmailAdd.Clear();

                string message = "New Customer Saved.";
                string title = "New Customer";

                MessageBox.Show(message, title);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}

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
    public partial class EditCustomerForm : ParentForm
    {
        //imports to access specificly needed classes
        Customer a = new Customer();
        Controller control = new Controller();
        Account ac = new Account();
        
        //int editedCustID = 0;

        //Customer accnt = (Customer)ManageCustomerForm.listDispCust.SelectedItem;

        public EditCustomerForm()
        {
            InitializeComponent();
            //txtFName.Text();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //moves to the add customer form
            ManageCustomerForm manageCus = new ManageCustomerForm();

            this.Hide();

            manageCus.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //int editedIDInt;

            if (string.IsNullOrWhiteSpace(txtFName.Text) || string.IsNullOrWhiteSpace(txtLName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                throw new Exception();
            }
            else
            {
                bool staff;
                int dPercent = 0;
                bool isChecked = radYStaff.Checked;
                

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

                int editedIDInt = int.Parse(txtIDNum.Text);
                string fName = txtFName.Text;
                string lName = txtLName.Text;
                string aName = fName + " " + lName;
                string email = txtEmail.Text;


                //pass filepath and filename 
                StreamWriter sw = new StreamWriter("../../AllCustomers.txt", true);

                //add newly created user as a new line
                sw.WriteLine(editedIDInt + "," + " " + fName + " " + lName + "," + email + "," + staff + "," + dPercent);

                //close file
                sw.Close();

                control.CreateCustomer(editedIDInt, aName, email, staff, dPercent);

                //clear all txt boxes
                txtIDNum.Clear();
                txtFName.Clear();
                txtLName.Clear();
                txtEmail.Clear();

                string message = "Customer Details Saved.";
                string title = "Customer Edited";

                MessageBox.Show(message, title);

            }
        }
    }

}



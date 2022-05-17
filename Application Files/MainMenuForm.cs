using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BankingApplicationIteration2
{
    public partial class MainMenuForm : ParentForm
    {
        Controller control = new Controller();
        Customer a = new Customer();

        public MainMenuForm()
        {
            InitializeComponent();

            control.AllCustomers.Clear();
            
            
        }

        private void buttManageCust_Click(object sender, EventArgs e)
        {
            ManageCustomerForm frmA = new ManageCustomerForm();

            this.Hide();

            frmA.Show();

            

        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //moves to the add customer form
            AddCustomerForm addcust = new AddCustomerForm();

            this.Hide();

            addcust.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //moves to add new account form
            AddNewAccount addAcc = new AddNewAccount();

            this.Hide();

            addAcc.Show();
        }

        private void btnManageAcc_Click(object sender, EventArgs e)
        {
            //moves to manage accounts form
            ManageAccountsForm manAcc = new ManageAccountsForm();

            this.Hide();

            manAcc.Show();
        }
    }
}

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
    public partial class AddNewAccount : ParentForm

    {

        public AddNewAccount()
        {
            InitializeComponent();
            InitiCombo();
        }

        private void InitiCombo()
        {
            string[] accountTypes = new string[] { "Everyday", "Invest", "Omni" };
            comboAccTyp.Items.AddRange(accountTypes);
            this.Controls.Add(this.comboAccTyp);
        }

        private void AddNewAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRerturn_Click(object sender, EventArgs e)
        {
            ManageAccountsForm mnf = new ManageAccountsForm();

            this.Hide();

            mnf.Show();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccHoldID.Text) || string.IsNullOrWhiteSpace(txtInitBal.Text) || string.IsNullOrWhiteSpace(txtAccHoldID.Text))
            {
                throw new Exception();
            }
            else
            {
                string selected = this.comboAccTyp.GetItemText(this.comboAccTyp.SelectedItem);
                int newID = int.Parse(txtAccId.Text);
                int accHolderID = int.Parse(txtAccHoldID.Text);
                double iniBal = double.Parse(txtInitBal.Text);
                

                if (selected == "Omni")
                {
                    double overdraft = double.Parse(txtOvDraftAmount.Text);

                    //pass filepath and filename
                    StreamWriter sw = new StreamWriter("../../AllAccounts.txt", true);

                    //and new line to file
                    sw.WriteLine(newID + "," + accHolderID + "," + iniBal + "," + selected + "," + overdraft);

                    //close file
                    sw.Close();

                    txtAccId.Clear();
                    txtAccHoldID.Clear();
                    txtInitBal.Clear();
                    txtOvDraftAmount.Clear();
                }
                else if (selected == "Everyday" || selected == "Invest")
                {

                    double overdraft = 0;

                    //pass filepath and filename
                    StreamWriter sw = new StreamWriter("../../AllAccounts.txt", true);

                    //and new line to file
                    sw.WriteLine(newID + "," + accHolderID + "," + iniBal + "," + selected + "," + overdraft);

                    //close file
                    sw.Close();

                    txtAccId.Clear();
                    txtAccHoldID.Clear();
                    txtInitBal.Clear();
                    txtOvDraftAmount.Clear();


                }
                else
                {
                    throw new Exception();
                }

                string message = "New Account Saved.";
                string title = "New Account";

                MessageBox.Show(message, title);

            }
        }
    }
}


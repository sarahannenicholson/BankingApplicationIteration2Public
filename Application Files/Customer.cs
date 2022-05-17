using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationIteration2
{
    

    public class Customer
    {
        

        static int nextAccountHolderID = 1;
        public int accountHolderID;
        public string accountHolderName;
        public string accountHolderContact;
        public int accountNumbers;
        public bool isStaff;
        public int discountPercent;



        public Customer()
        {
            //default constructor
            //sets ID and increases when next called
            accountHolderID = nextAccountHolderID;
            nextAccountHolderID++;
        }

        public Customer(int newAccountHolderID, string newAccountName, string newAccountContact, bool newCustomerStaff, int newDiscountPercentage)
        {
            //constructor with parameteres, ensures default is always called first
            accountHolderID = newAccountHolderID;
            accountHolderName = newAccountName;
            accountHolderContact = newAccountContact;
            isStaff = newCustomerStaff;
            discountPercent = newDiscountPercentage;
        }

        public string AccountContact
        {
            get { return accountHolderContact; }
            set { accountHolderContact = value; }
        }

        public int AccountHolderID
        {
            
            get { return accountHolderID; }
            set { accountHolderID = value; }
        }

        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }

        public int AccountNumbers
        {
            get { return accountNumbers; }
            set { accountNumbers = value; }
        }

        public bool IsStaff
        {
            get { return isStaff; }
            set { isStaff = value; }
        }

        public int DiscountPercentage
        {
            get { return discountPercent; }
            set { discountPercent = value; }
        }

        public override string ToString()
        {
            return accountHolderName;
        }

        public virtual string Info()
        {
            return "Holder ID: " + accountHolderID + "Account Holder Name: " + accountHolderName +  "\n" + "Account Holder Contact: " + accountHolderContact + "\n" + "Account Holder Account Numbers: " + accountNumbers + "\n" + "Account Holder is Staff?: " + isStaff + "\n" + "Account Holder Discount Percentage:  " + discountPercent;
        }

        public virtual string GetHolderName()
        {
            return accountHolderName;
        }

        public virtual int HolderID()
        {
            return accountHolderID;
        }

        public virtual string HolderContact()
        {
            return accountHolderContact;
        }

        public virtual bool IsCusStaff()
        {
            return isStaff;
        }

        public virtual int DiscPercentStaff()
        {
            return discountPercent;
        }

        public virtual string ToDelete()
        {
            return accountHolderID + "," + " " + accountHolderName + "," + accountHolderContact;
        }

       
    }

    public class AccountHolderTestClass : Customer { }


    

}


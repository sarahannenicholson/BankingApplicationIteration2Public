using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationIteration2
{

    public class Account
    {
        static int nextAccountID = 1;
        public int accountID;
        public int accountHolderID;
        public double accountBalance;
        public string accountType;
        public double overdraftAmount;

        public Account()
        {
            //default constructor
            //sets ID and increases when next called
            accountID = nextAccountID;
            nextAccountID++;
        }

        public Account(int newAccID, int newAccHolderID, double accBal, string accType, double odraftAmount) : this()
        {
            //contructor with parameters
            accountID = newAccID;
            accountHolderID = newAccHolderID;
            accountBalance = accBal;
            accountType = accType;
            overdraftAmount = odraftAmount;
            

        }
        public int AccountID
        {
            //read only as we dont want to be able to set this
            get { return accountID; }
            set { accountID = value; }
        }

        public double AccountBalance
        {
            // get and set for account balance so can be updated with deposits/interest etc
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        public double OverdraftAmount
        {
            get { return overdraftAmount; }
            set { overdraftAmount = value; }
        }

        public int AccountHolderID
        {
            //get only for account holder ID as should be linked to the accountholder class
            get { return accountHolderID; }
            set { accountHolderID = value; }
        }

        public string AccountType
        {
            //links to account types class so can set rates for account
            get { return accountType; }
            set { accountType = value; }
        }

        public virtual string AllInfo()
        {
            return "Account Number: " + accountID + ". Account Holder ID:  " + accountHolderID + ". Balance: " + accountBalance + ". Type: " + accountType;
        }

        public virtual string Info()
        {
            return accountType + " " + accountID + " " + accountBalance;
        }

        public virtual string GetInfo()
        {
            return accountID + accountHolderID +  accountBalance + accountType + overdraftAmount;
        }
        public virtual double ReturnBal()
        {
            return accountBalance;
        }

        public virtual string ReturnAccType()
        {
            return accountType;
        }

        public override string ToString()
        {
            return accountID + " " + accountType + " " + accountBalance;
        }

        public virtual int ReturnAccountID()
        {
            return accountID;
        }

        public virtual int ReturnAccountHolderIDNum()
        {
            return accountHolderID;

        }

        public virtual double OverdraftReturnAmount()
        {
            return overdraftAmount;
        }
    }

    public class AccountType : Account
    {
        private string typeOfAccount;
        private double intrest;
        private double fee;
        private bool overdraft;
        private double overdraftAccAmount;


        public string TypeOfAccount
        {
            get { return typeOfAccount; }
            set { typeOfAccount = value; }
        }
        public double Intrest
        {

            get { return intrest; }
            set { intrest = value; }
        }

        public double Fee
        {

            get { return fee; }
            set { fee = value; }
        }

        public bool Overdraft
        {

            get { return overdraft; }
            set { overdraft = value; }
        }

        public double OverdraftAmoount
        {
            get { return overdraftAccAmount; }
            set { overdraftAccAmount = value; }
        }

        public override string Info()
        {
            return base.Info() + " " + intrest + " Intrest Rate, " + fee + " Fee, " + overdraft + " Overdraft Avaliable" + OverdraftAmoount + " Overdraft Amount";
        }

      

    }

    public class Withdrawl : Account
    {
        private int withdrawlAmount;
        private int fromAccount;
        private int toAccount;
        private int accOriginalBal;
        private int accountAttemptBal;
        private int accNewBal;
        private bool transactionApproved;
        private int transactionNumber;
        private int transactionFeeCharge;
        static int nexttransactionNumber = 1;
        

        public Withdrawl()
        {
            //default constructor
            //sets ID and increases when next called
            transactionNumber = nexttransactionNumber;
            nexttransactionNumber++;
        }
        public int TransactionNumber
        {
            
            get { return transactionNumber; }
            set { transactionNumber = value; }
        }

        public int WithdrawlAmount
        {
            get { return withdrawlAmount; }
            set { withdrawlAmount = value; }
        }

        public int FromAccount
        {
            get { return fromAccount; }
            set { fromAccount = value; }
        }

        public int ToAccount
        {
            get { return toAccount; }
            set { toAccount = value; }
        }

        public int OriginalBal
        {
            get { return accOriginalBal; }
            set { accOriginalBal = value; }
        }

        public int AccountAttemptBalance
        {
            get { return accountAttemptBal; }
            set { accountAttemptBal = value; }
        }

        public int NewBal
        {
            get { return accNewBal; }
            set { accNewBal = value; }
        }

        public int TransactionCharge
        {
            get { return transactionFeeCharge; }
            set { transactionFeeCharge = value; }
        }

        public bool TransactionApproved
        {
            set { _ = transactionApproved; }
            get { return transactionApproved; }
        }

        public override string Info()
        {
            return base.Info() + " ";
        }

    }

    public class Deposit : Account
    {
        private int depositAmount;
        private int fromAccount;
        private int accOriginalBal;
        private int accNewBal;
        private int depositFee;
        private bool transAccepted;
        private int transactionNumber;
        static int nexttransactionNumber = 1;

        public Deposit()
        {
            //default constructor
            //sets ID and increases when next called
            transactionNumber = nexttransactionNumber;
            nexttransactionNumber++;
        }
        public int TransactionNumber
        {
            //read only so no set
            get { return transactionNumber; }
        }

        public int WithdrawlAmount
        {
            get { return depositAmount; }
            set { depositAmount = value; }
        }

        public int FromAccount
        {
            get { return fromAccount; }
            set { fromAccount = value; }
        }

        public int OriginalBal
        {
            get { return accOriginalBal; }
            set { accOriginalBal = value; }
        }

        public int NewBal
        {
            get { return accNewBal; }
            set { accNewBal = value; }
        }

        public int WithdrawlFee
        {
            get { return depositFee; }
            set { depositFee = value; }
        }

        public bool TransAccepted
        {
            set { _ = transAccepted; }
        }

        public override string Info()
        {
            return base.Info() + " ";
        }

    }

    public class WithdrawMoney : Account
    {
        public double accBal;
        public double userVal;

        public double AccBal
        {
            get { return accBal; }
            set { accBal = value; }
        }

        public double UserVal
        {
            get { return userVal; }
            set { userVal = value; }
        }

        public WithdrawMoney()
        {
            accBal = 1000;
            userVal = 50;

            try
            {
                if (accBal < userVal)
                {
                    double newval = accBal - userVal;
                }
                else
                {
                    userVal++;
                }
            }
            catch
            {
                throw new ExceptionClass(userVal, accBal);
            }

        }

    }
}

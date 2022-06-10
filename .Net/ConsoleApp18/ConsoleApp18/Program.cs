using System;

namespace AccountApp
{

    public class Account
    {
        private string name;
        private double balance;
        public Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }
        public double deposit(double depositAmount)
        {
            return balance + depositAmount;
        }
        public double getBalance()
        {
            return balance;
        }
        public string getName(string name)
        {
            return name;
        }
        public void setName(string name)
        {

        }
        // Code Here..

    }

    class Test
    {
        static void Main(string[] args)
        {
            Account ac = new Account("John", 250.00);
            ac.getBalance();
            //Code Here..
        }
    }

}
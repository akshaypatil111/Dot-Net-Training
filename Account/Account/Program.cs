using System;
namespace Account
{
    public class person
    {
        double balance;
        string name;
        person(double b, string s)
        {
            balance = b;
            name = s;
        }
        public double getBalance()
        {
            return balance;
        }
        public void setName()
        {

        }
        public string getName()
        {
            return name;
        }
    }
    class Test
    {
        static void Main()
        {
            Account account1 = new Account("Jane Austen", 250.00);
            account1.getBalance();
        }
    }
}
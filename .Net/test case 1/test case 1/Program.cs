public class Account
{


    private string name;
    private double balance;
    public Account(string name, double balance)
    {
        this.name = name;
        if (balance > 0.0)
        {

            this.balance = balance;
        }

    }
    public double deposit(double depositAmount)
    {
        if (depositAmount > 0.0)
        {

            balance = balance + depositAmount;
        }
        return balance;

    }
    public double getBalance()
    {
        return balance;

    }
    public void setName(String name)
    {
        this.name = name;
    }
    public String getName()
    {
        return name;
    }


}

class Test
{
    static void Main(string[] args)
    {

        Account account1 = new Account("Jane Austen", 250.00);
        account1.getBalance();
    }
}

}
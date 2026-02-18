abstract class BankAccount
{
    public int AccountNumber{get; set;}
    public string CustomerName{get; set;}
    public decimal Balance{get; set;}

    public BankAccount(int accountNumber, string name, decimal balance)
    {
        if(balance < 0)
        {
            throw new InvalidTransactionException("Opening balance cant bwe negative");
        }

        AccountNumber = accountNumber;
        if(name == null)
        {
            throw new ArgumentNullException("Name cannot be null");
        }
        CustomerName = name;
        Balance = balance;
    }

    public virtual void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidTransactionException("Deposit amount must be greater than 0");
    
        Balance += amount;
    }
    public virtual void Withdraw(decimal amount)
    {
        if(amount> Balance)
        {
            throw new InsufficientBalanceException("Insufficient Balance");
        }
        Balance-= amount;
    }
    public abstract decimal CalculateInterest();
}
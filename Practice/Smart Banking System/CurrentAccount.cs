class CurrentAccount : BankAccount
{
    decimal OverdraftLimit{get; set;} = 5000;
    public CurrentAccount(int accNo, string name, decimal balance) : base(accNo, name, balance){}
    public override decimal CalculateInterest()
    {
        return 0;
    }
    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidTransactionException("Invalid withdrawal amount");

        if (amount > Balance + OverdraftLimit)
            throw new InsufficientBalanceException("Overdraft limit exceeded");

        Balance -=amount;
    }
}
class SavingAccount : BankAccount
{
    private const decimal MIN_BALANCE = 1000;
    public SavingAccount(int accNo, string name, decimal balance)
        : base(accNo, name, balance) { }
    public override decimal CalculateInterest()
    {
        decimal simpleInterest = Balance * 0.04m;
        return simpleInterest;
    }
    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidTransactionException("Invalid withdrawal amount");

        if(Balance - amount < MIN_BALANCE) //1000 is minimum amount
        {
            throw new MinimumBalanceException("Minimum balance for savings account is 1000");
        }
        Balance -= amount;
    }
}

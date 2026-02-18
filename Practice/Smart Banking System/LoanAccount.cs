class LoanAccount : BankAccount
{
    public LoanAccount(int accNo, string name, decimal balance)
        : base(accNo, name, balance) { }

    public override decimal CalculateInterest()
    {
        decimal simpleInterest = Balance *0.12m;
        return simpleInterest;
    }
    public override void Deposit(decimal amount)
    {
        throw new InvalidTransactionException("Loan Account cant deposit");
    }
}

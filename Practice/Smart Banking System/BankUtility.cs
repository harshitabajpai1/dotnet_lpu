using System.Collections.Generic;
using System.Linq;
class BankUtility
{
    List<BankAccount> accountDetails = null;
    public BankUtility()
    {
        accountDetails = new List<BankAccount>();
    }

    public void AddAccount(BankAccount account)
    {
        accountDetails.Add(account);
    }

    //Get account with balance > 50000
    public List<BankAccount> AccountWithMoreBalance()
    {
        var accounts = accountDetails.Where(a => a.Balance > 50000).ToList();
        return accounts;
    }
    public decimal GetTotalBalance()
    {
        var total = accountDetails.Sum(a => a.Balance);
        return total;
    }
    public List<BankAccount> GetTop3HighestBalanceAccount()
    {
        var accounts = accountDetails.OrderByDescending(a => a.Balance).Take(3).ToList();
        return accounts;
    }

    public List<string> CustomerNameStartsWithR()
    {
        var customer =accountDetails.Where( c => c.CustomerName.StartsWith("R") || c.CustomerName.StartsWith("r")).Select(n => n.CustomerName).ToList();
        return customer;
    }
    // public var GroupByAccountType()
    // {
    //     return accountDetails.GroupBy(a => a.GetType().Name);
    // }
}
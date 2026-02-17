class RegularOrder : Order
{
    public RegularOrder(int id, string name, decimal amount) : base(id, name, amount)
    {
        
    }
    public override decimal CalculateFinalAmount()
    {
        return Amount;
    }
}
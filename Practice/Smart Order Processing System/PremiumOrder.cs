class PremiumOrder : Order
{
    public PremiumOrder(int id, string name, decimal amount):base(id,name,amount)
    {
        
    }
    public override decimal CalculateFinalAmount()
    {
        
        return Amount*1.10m;
    }
}
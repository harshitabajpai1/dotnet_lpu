namespace DigitalPettyCashLe
{
    public abstract class Transaction : IReportable
    {
        public int ID{get;set;}
        public DateTime Date{get;set;}
        public int Amount{get;set;}
        public string Description{get;set;}

        public abstract string GetSummary();
    }
}
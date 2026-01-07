namespace DigitalPettyCashLe
{
    public class IncomeTransaction : Transaction
    {
        public string Source{get;set;}    //eg--- Main Cash , Bank Transfer

        public override string GetSummary()
        {
            return $" INCOME \n Amount: {Amount}, \nSource: {Source}, \nDate: {Date}";
        }
    }
}




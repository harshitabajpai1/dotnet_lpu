namespace DigitalPettyCashLe
{
    public class ExpenseTransaction : Transaction
    {
        public string Category{get;set;}    //eg--office,travel,food
        public override string GetSummary()
        {
            return  $" EXPENSE \n Amount: {Amount}, \nCategory: {Category}, \nDate: {Date}";
        }
    }
}
namespace DigitalPettyCashLe
{
    class Ledger<T> where T: Transaction
    {
        List<T> history = new List<T>();
        //Add Entry
        public void AddEntry(T entry)
        {
            history.Add(entry);
        }
        public int CalculateTotal()
        {
            int total = 0;
            foreach(T entry in history)
            {
                total += entry.Amount;
            }

            return total;
        }

        //NOT USING IT ANYWHERE

        public List<T> GetTransactionsByDate(DateTime date)
        {
            List<T> filteredList = new List<T>();

            foreach (T entry in history)
            {
                if (entry.Date.Date == date.Date)
                {
                    filteredList.Add(entry);
                }
            }

            return filteredList;
            // return history;       //not correct need to change the code for filtered list
        } 
    }
}

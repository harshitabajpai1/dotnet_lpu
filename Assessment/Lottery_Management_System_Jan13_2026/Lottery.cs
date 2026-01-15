using System;
using System.Collections.Generic;


namespace LotteryManagementSystem
{
    public class Lottery
    {
        public event EventHandler<CustomEventArgs> LotteryEvent;
        private List<int> tickets = new List<int>();
        private Random random_lottery_ticket= new Random();

        //default constructor
        public Lottery()
        {
            
        }

        void GenerateTickets(Object Sender, CustomEventArgs eventArgs)
        {
            if(eventArgs.Quantity < 10)
            {
                throw new InvalidOperationException("minimum 10 tickets requireed");
            }

            while(tickets.Count <eventArgs.Quantity )
            {
                int ticketNumber = random_lottery_ticket.Next(100000000,999999999);

                //to make the number unique we will add it in the list and check is the number is present or not present in the list
                if (!tickets.Contains(ticketNumber))
                {
                    tickets.Add(ticketNumber);
                }
            }
        }

        public void StartLottery(int quantity)
        {
            CustomEventArgs args = new CustomEventArgs
            {
                Quantity = quantity

            };
        }

        public IList<int> LotteryWinners()
        {
            if(tickets.Count == 0)
            {
                
            }
        }
        
    }

    
}
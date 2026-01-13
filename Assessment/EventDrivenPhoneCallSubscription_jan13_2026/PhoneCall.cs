namespace PhoneCallSubscription
{
    public class PhoneCall
    {

        //calling a delegate
        public delegate void notify();  //Multicast delegate

        //event for phone call
        public event notify PhoneCallEvent;
        public string Message {get;private set;}

        private void OnSubscribe()
        {
            Message = "Subscribed to Phone Call";
        }

        private void OnUnSubscribe()
        {
            Message = "UnSubscribed to Phone Call";
        }

        public void MakeAPhoneCall(bool notify)
        {
            if(notify == true)
            {
                //now we will attach the onSubscribe event to the phone call event;
                PhoneCallEvent += OnSubscribe;
            }
            else
            {
                PhoneCallEvent += OnUnSubscribe;
            }


            PhoneCallEvent?.Invoke();   //will check is the event is not null and then invoke it.

        }


    }
}
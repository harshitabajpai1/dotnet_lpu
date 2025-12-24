using System;
namespace HasinaCabs
{
    public class CabDetails : Cab
    {
        // Cab cabObj = new Cab();
        public bool ValidateBookingId()
        {
            if(BookingID.Length != 6)
            {
                return false;
            }
            if (!BookingID.StartsWith("AC@"))
            {
                return false;
            }
            for(int i = 3;i<BookingID.Length; i++)
            {
                if (!char.IsDigit(BookingID[i]))
                {
                    return false;
                }
            }

            return true;

        }
        int HatchbackFare{get;} = 10;
        int SedanFare{get;} = 20;
        int SuvFare{get;} = 30;

        public double CalculateFareAmount()
        {
            double  fare = 0;
            double sqrt = Math.Sqrt(WaitingTimeInMinutes);
            double waitingCharge = Math.Floor(sqrt);
            if (CabType == "HatchBack")
            {
                fare = (double)DistanceInKm *HatchbackFare +waitingCharge;
            }
            else if (CabType == "Sedan")
            {
                fare = (double)DistanceInKm *SedanFare +waitingCharge;
            }
            else if (CabType == "Suv")
            {
                fare = (double)DistanceInKm *SuvFare +waitingCharge;
            }

            return fare;
        }
    }
}
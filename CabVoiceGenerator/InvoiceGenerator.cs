using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabVoiceGenerator
{
    public class InvoiceGenerator
    {
        public int pricePerKilometer;
        public int pricePerMinute;
        public int minimumFare;
        public double totalFare;
        public int numberOfRides;
        public double averagePerRide;
       
        public InvoiceGenerator()
        {
            this.pricePerKilometer = 10;
            this.pricePerMinute = 1;
            this.minimumFare = 5;
        }
        // UC1 - Method to calculate fare for single ride
        public double CalculateFare(Ride ride)
        { 
                if (ride.time <= 0)
                    throw new InvoiceGeneratorException(InvoiceGeneratorException.ExceptionType.INVALID_TIME, "Invalid Time");
                if (ride.distance <= 0)
                    throw new InvoiceGeneratorException(InvoiceGeneratorException.ExceptionType.INVALID_DISTANCE, "Invalid Distance");
                //Total fare for single ride
                totalFare = (ride.distance * pricePerKilometer) + (ride.time * pricePerMinute);
                //Comparing minimum fare and calculated fare to return the maximum fare
                return Math.Max(totalFare, minimumFare);
            }
    }
}

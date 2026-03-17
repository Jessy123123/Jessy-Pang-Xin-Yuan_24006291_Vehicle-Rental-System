using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    class Truck : Vehicle
    {
        private double payloadTons;

        public double PayloadTons
        {
            get { return payloadTons; }
            set { payloadTons = value; }
        }

        public Truck(string make, string model, int year, double dailyRate, double payloadTons) : base(make, model, year, dailyRate)
        {
            PayloadTons = payloadTons;
        }

        public override double CalculateRentalCost(int days)
        {
           return (DailyRate + 30 * PayloadTons) * days;
        }

        public override string GetDescription()
        {
            return ($"{Year} {Make} {Model} ({PayloadTons} tons) — RM {DailyRate:F2}/day");
        }
        
    }
}

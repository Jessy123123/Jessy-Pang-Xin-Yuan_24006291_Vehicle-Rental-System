using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    class Car: Vehicle
    {
        private int numPassengers;

        public int NumPassengers
        {
            get { return numPassengers; }
            set { numPassengers = value; }
        }

        public Car(string make, string model, int year, double dailyRate, int numPassengers) : base(make, model, year, dailyRate)
        {
            this.numPassengers = numPassengers;
        }

        public override double CalculateRentalCost(int days)
        {
            return ( DailyRate * days);
        }

        public override string GetDescription()
        {
            return ($"{Year} {Make} {Model} ({numPassengers} passengers) — RM {DailyRate:F2}/day");
        }
    }
}

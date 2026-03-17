using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    abstract class Vehicle
    {
        private string make = String.Empty;
        private string model = String.Empty;
        private int year;
        private double dailyRate;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double DailyRate
        {
            get { return dailyRate; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Daily rate must be greater than 0.");
                }
                dailyRate = value;
            }
        }

        public Vehicle(string make, string model, int year, double dailyRate)
        {
            Make = make; // goes through the property setter
            Model = model;
            Year = year;
            DailyRate = dailyRate;
        }

        public abstract double CalculateRentalCost(int days);

        public virtual string GetDescription()
        {
            return($"{Year} {Make} {Model} — RM {DailyRate:F2}/day");
        }
    }
}

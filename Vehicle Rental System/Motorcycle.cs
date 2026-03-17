using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    class Motorcycle : Vehicle 
    {
        private bool hasSidecar;

        public bool HasSidecar
        {
            get { return hasSidecar; } 
            set { hasSidecar = value; }
        }

        public Motorcycle(string make, string model, int year, double dailyRate, bool hasSidecar) : base(make, model, year, dailyRate)
        {
            HasSidecar= hasSidecar;
        }

        public override double CalculateRentalCost(int days)
        {
            if (HasSidecar == false)
            {
                return DailyRate * days * 0.90; // 10% discount without sidecar
            }
            else
            {
                return DailyRate * days; // full price with sidecar
            }
        }

        public override string GetDescription()
        {
            string sidecarInfo = HasSidecar ? "with sidecar" : "no sidecar";
            return $"{Year} {Make} {Model} ({sidecarInfo}) — RM {DailyRate:F2}/day";
        }
    }
}

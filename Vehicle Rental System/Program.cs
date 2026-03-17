using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int rentalDays = 5;

            List<Vehicle> fleet = new List<Vehicle>
        {
            new Car       ("Toyota", "Camry", 2022, 150.00, 5),
            new Motorcycle("Honda",  "CBR",   2021,  80.00, false),
            new Truck     ("Volvo",  "FH",    2020, 200.00, 8.5)
        };

            // Print description + 5-day cost for every vehicle
            foreach (Vehicle v in fleet)
            {
                double cost = v.CalculateRentalCost(rentalDays);
                Console.WriteLine(v.GetDescription());
                Console.WriteLine($"  {rentalDays}-day rental cost: RM {cost:N2}");
                Console.WriteLine();
            }

            // Find the most expensive vehicle for 5 days (LINQ)
            Vehicle mostExpensive = fleet.OrderByDescending(v => v.CalculateRentalCost(rentalDays))
                                         .First();

            Console.WriteLine($"Most expensive: {mostExpensive.Year} {mostExpensive.Make} " +
                              $"{mostExpensive.Model} — " +
                              $"RM {mostExpensive.CalculateRentalCost(rentalDays):N2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }
        public void Drive(int distance)
        {
            double difference = FuelAmount - distance * FuelConsumptionPerKilometer;
            if (difference < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                FuelAmount = difference;
                TravelledDistance += distance;
            }
        }
        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {TravelledDistance}";
        }
    }
}

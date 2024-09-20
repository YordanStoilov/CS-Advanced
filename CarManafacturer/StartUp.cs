using CarManufacturer;
using System.Text;
using System.Linq;
namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<string> tiresAsString = new();
            List<Tire[]> tires = new();
            List<Engine> engines = new();
            List<Car> cars = new();
            Tire[] currentPair = new Tire[4];

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "No more tires")
                {
                    break;
                }
                string[] lineSplit = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (string substring in lineSplit)
                {
                    tiresAsString.Add(substring);
                }
            }

            int tiresCount = 0;
            for (int i = 0; i < tiresAsString.Count; i += 2)
            {
                int year = int.Parse(tiresAsString[i]);
                double pressure = double.Parse(tiresAsString[i + 1]);
                currentPair[tiresCount] = new Tire(year, pressure);
                tiresCount++;

                if (tiresCount > 3)
                {
                    tiresCount = 0;
                    tires.Add(currentPair.ToArray());
                    currentPair = new Tire[4];
                }
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Engines done")
                {
                    break;
                }

                string[] lineSplit = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(lineSplit[0]);
                double cubicCapacity = double.Parse(lineSplit[1]);
                engines.Add(new Engine(horsePower, cubicCapacity));
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Show special")
                {
                    break;
                }

                string[] lineSplit = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = lineSplit[0], model = lineSplit[1];
                int year = int.Parse(lineSplit[2]);
                double fuelQuantity = double.Parse(lineSplit[3]);
                double fuelConsumption = double.Parse(lineSplit[4]);
                int engineIndex = int.Parse(lineSplit[5]);
                int tiresIndex = int.Parse(lineSplit[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, 
                    engines[engineIndex], tires[tiresIndex]));
            }

            foreach (Car car in cars)
            {
                StringBuilder builder = new();
                double sumOfTires = car.Tires.Select(tire => tire.Pressure).Sum();

                if (car.Year < 2017)
                {
                    continue;
                }
                if (car.Engine.HorsePower <= 330)
                {
                    continue;
                }
                if (sumOfTires < 9 || sumOfTires > 10)
                {
                    continue;
                }
                if (!car.CanBeDriven(20))
                {
                    continue;
                }
                car.Drive(20);

                builder.AppendLine($"Make: {car.Make}");
                builder.AppendLine($"Model: {car.Model}");
                builder.AppendLine($"Year: {car.Year}");
                builder.AppendLine($"HorsePowers: {car.Engine.HorsePower}");
                builder.AppendLine($"FuelQuantity: {car.FuelQuantity}");

                Console.WriteLine(builder.ToString());
            }

        }
    }
}
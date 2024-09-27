using System.Security.Cryptography;

namespace CarSalesman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Engine> engines = new();
            List<Car> cars = new();

            int enginesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < enginesCount; i++)
            {
                string[] line = Console.ReadLine().Split(" ", 
                    StringSplitOptions.RemoveEmptyEntries);

                int displacement;
                string efficiency;

                string model = line[0];
                int power = int.Parse(line[1]);
                Engine currentEngine = new Engine(model, power);

                if (line.Length > 2)
                {
                    if (int.TryParse(line[2], out _))
                    {
                        currentEngine.Displacement = int.Parse(line[2]);
                    }
                    else
                    {
                        currentEngine.Efficiency = line[2];
                    }
                }
                if (line.Length > 3)
                {
                    if (int.TryParse(line[3], out _))
                    {
                        currentEngine.Displacement = int.Parse(line[3]);
                    }
                    else
                    {
                        currentEngine.Efficiency = line[3];
                    }
                }
                engines.Add(currentEngine);
            }

            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] line = Console.ReadLine().Split(" ", 
                    StringSplitOptions.RemoveEmptyEntries);

                int weight;
                string color;

                string model = line[0];
                string engineName = line[1];
                Engine currentEngine = engines.
                    Where(engine => engine.Model == engineName)
                    .ToArray() [0];

                Car currentCar = new Car(model, currentEngine);

                if (line.Length > 2)
                {
                    if (int.TryParse(line[2], out _))
                    {
                        currentCar.Weight = int.Parse(line[2]);
                    }
                    else
                    {
                        currentCar.Color = line[2];
                    }
                }

                if (line.Length > 3)
                {
                    if (int.TryParse(line[3], out _))
                    {
                        currentCar.Weight = int.Parse(line[3]);
                    }
                    else
                    {
                        currentCar.Color = line[3];
                    }
                }
                cars.Add(currentCar);
            }
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
using SpeedRacing;

int n = int.Parse(Console.ReadLine());

List<Car> cars = new();

for (int i = 0; i < n; i++)
{
    string[] line = Console.ReadLine().Split();

    string carModel = line[0];
    int fuelAmount = int.Parse(line[1]);
    double consumption = double.Parse(line[2]);

    cars.Add(new Car(carModel, fuelAmount, consumption));
}

while (true)
{
    string command = Console.ReadLine();
    if (command == "End")
    {
        break;
    }

    string[] line = command.Split();
    string model = line[1];
    int distance = int.Parse(line[2]);

    Car currentCar = cars.Where(car => car.Model == model).ToArray()[0];

    currentCar.Drive(distance);
}
foreach (Car car in cars)
{
    Console.WriteLine(car);
}
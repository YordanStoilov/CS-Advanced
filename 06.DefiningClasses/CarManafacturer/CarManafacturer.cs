
namespace CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
        }
    }

}


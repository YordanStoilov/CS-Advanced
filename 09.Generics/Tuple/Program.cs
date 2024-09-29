
namespace Tuple;
class Program
{
    static void Main(string[] args)
    {
        string[] line1 = Console.ReadLine().Split();
        string fullName = line1[0] + " " + line1[1];
        string address = line1[2];

        string[] line2 = Console.ReadLine().Split();
        string name = line2[0];
        int beers = int.Parse(line2[1]);

        string[] line3 = Console.ReadLine().Split();
        int firstValue = int.Parse(line3[0]);
        double secondValue = double.Parse(line3[1]);

        CustomTuple<string, string> tuple1 = new CustomTuple<string, string>(fullName, address);
        CustomTuple<string, int> tuple2 = new CustomTuple<string, int>(name, beers);
        CustomTuple<int, double> tuple3 = new CustomTuple<int, double>(firstValue, secondValue);

        Console.WriteLine(tuple1);
        Console.WriteLine(tuple2);
        Console.WriteLine(tuple3);
    }
}
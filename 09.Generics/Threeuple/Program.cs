using System.Text;

namespace Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split();
            string firstName = line1[0] + ' ' + line1[1];
            string address = line1[2];
            string town;

            StringBuilder sb = new StringBuilder();
            for (int i = 3; i < line1.Length; i++)
            {
                sb.Append(line1[i]);
                sb.Append(" ");
            }

            town = sb.ToString().TrimEnd();

            string[] line2 = Console.ReadLine().Split();
            string secondName = line2[0];
            int beers = int.Parse(line2[1]);
            bool isDrunk;

            if (line2[2].ToLower() == "drunk")
            {
                isDrunk = true;
            }
            else
            {
                isDrunk = false;
            }

            string[] line3 = Console.ReadLine().Split();
            string thirdName = line3[0];
            double accountBalance = double.Parse(line3[1]);
            string bankName;

            sb = new StringBuilder();
            for (int i = 2; i < line3.Length; i++)
            {
                sb.Append(line3[i]);
                sb.Append(" ");
            }
            bankName = sb.ToString().TrimEnd();

            Threeuple<string, string, string> threeupleOne = 
                new Threeuple<string, string, string>(firstName, address, town);


            Threeuple<string, int, bool> threeupleTwo = 
                new Threeuple<string, int, bool>(secondName, beers, isDrunk);

            Threeuple<string, double, string> threeupleThree =
                new Threeuple<string, double, string>(thirdName, accountBalance, bankName);

            Console.WriteLine(threeupleOne);
            Console.WriteLine(threeupleTwo);
            Console.WriteLine(threeupleThree);
    }
    }
}
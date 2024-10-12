namespace ComparingObjects;
public class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new();

        while (true)
        {
            string line = Console.ReadLine();
            if (line == "END")
            {
                break;
            }

            string[] personData = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = personData[0], town = personData[2];
            int age = int.Parse(personData[1]);

            people.Add(new Person(name, age, town));
        }

        int n = int.Parse(Console.ReadLine());

        Person personToCompare = people[n - 1];

        int matches = 0;
        int nonEqual = 0;
        int totalPeople = people.Count;

        for (int i = 0; i < totalPeople; i++)
        {
            Person currentPerson = people[i];
            if (personToCompare.CompareTo(currentPerson) == 0)
            {
                matches++;
            }
            else
            {
                nonEqual++;
            }
        }

        if (matches <= 1)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{matches} {nonEqual} {totalPeople}");
        }
    }
}
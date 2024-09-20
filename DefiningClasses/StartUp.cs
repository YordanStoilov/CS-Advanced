namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = line[0];
                int age = int.Parse(line[1]);

                Person currentPersn = new Person(age, name);
                list.Add(currentPersn);
            }
            var sorted = list.Where(person => person.Age > 30).OrderBy(person => person.Name).ToList();

            foreach (Person person in sorted)
            {
                Console.WriteLine(person);
            }
        }
    }
}
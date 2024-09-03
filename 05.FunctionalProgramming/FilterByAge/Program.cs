
List<Person> people = new();
int n = int.Parse(Console.ReadLine());

bool CompareAges(string type, int baseline, int age)
{
    if (type == "older")
    {
        return age >= baseline;
    }
    else if (type == "younger")
    {
        return age < baseline;
    }
    return false;
}

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ");
    string name = input[0];
    int age = int.Parse(input[1]);

    people.Add(new Person(age, name));
}
string type = Console.ReadLine();
int baseline = int.Parse(Console.ReadLine());

List<Person> sorted = people
.Where(person => CompareAges(type, baseline, person.Age))
.ToList();

string outputType = Console.ReadLine();

Action<Person> PrintRequiredData(string type)
{
    if (type == "name age")
    {
        return p => Console.WriteLine($"{p.Name} - {p.Age}");
    }
    else if (type == "name")
    {
        return p => Console.WriteLine(p.Name);
    }
    else if (type == "age")
    {
        return p => Console.WriteLine(p.Age);
    }
    return null;
}

sorted.ForEach(PrintRequiredData(outputType));

class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
    public Person(int age, string name)
    {
        Age = age;
        Name = name;
    }
}